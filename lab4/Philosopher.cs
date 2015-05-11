using System;
using System.Collections.Generic;
using System.Threading;
using Timer = System.Timers.Timer;

namespace lab4
{
    class Philosopher
    {
        bool _isHunger;
        readonly string _philosopherName;
        readonly int _number;
        public int Count;

        public Philosopher(string name, int number)
        {
            _philosopherName = name;
            _number = number;
        }

        void GetFork(IReadOnlyList<Fork> fork)
        {
            var timer = new Timer {Interval = 10000};
            var tmp = new Data(int.Parse(_philosopherName), 0, 0);
            CallBackMy.CallbackWeitingEventHandler(tmp);

            timer.Start();
            if (!Monitor.TryEnter(fork))
            {
                return;
            }
            try
            {
                var first = _number-1;
                if (first == -1) first = 4;
                
                var second=_number;
                if (fork[first].IsUsing || fork[second].IsUsing) return;
                timer.Stop();
                timer.Dispose();
                fork[first].IsUsing = true;
                fork[second].IsUsing = true;
                Monitor.Enter(fork[first]);
                Monitor.Enter(fork[second]);
                Monitor.Exit(fork);
                CallBackMy.CallbackEatEventHandler(new Data(int.Parse(_philosopherName), first+1,second+1));

                Thread.Sleep(2500);
                fork[first].IsUsing = false;
                fork[second].IsUsing = false;
                CallBackMy.CallbackThinkEventHandler(new Data(_number+1,first+1,second+1));
                _isHunger = false;
                Monitor.Exit(fork[first]);
                Monitor.Exit(fork[second]);
                ++Count;
            }
            finally
            {
                if(Monitor.IsEntered(fork))
                Monitor.Exit(fork);
            }
            
        }

        public void Start(object obj)
        {
            while (true)
            {
                if (_isHunger)
                    GetFork((List<Fork>)obj);
                if (!_isHunger)
                {
                    var random = new Random(DateTime.Now.Millisecond);
                    Thread.Sleep(random.Next(1000, 5000));
                }
                else
                {
                    Thread.Sleep(50);
                }

                if(!_isHunger) _isHunger = true;
            }
        }
    }
    public static class CallBackMy
    {
        public delegate void CallbackEatEvent(Data data);
        public static CallbackEatEvent CallbackEatEventHandler;
        public delegate void CallbackThinkEvent(Data data);
        public static CallbackThinkEvent CallbackThinkEventHandler;
        public delegate void CallbackWeitingEvent(Data data);
        public static CallbackWeitingEvent CallbackWeitingEventHandler;
    }
}
