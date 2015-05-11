using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace lab4
{
    public partial class DiningPhilosophersForm : Form
    {
        public DiningPhilosophersForm()
        {
            InitializeComponent();
            _forks = new List<Label>(6);
            _philosophers = new List<Label>(6);
            for (int i = 0; i < 7; i++)
            {
                _forks.Add(null);
                _philosophers.Add(null);
            }
            _forks[1] = Fork1;
            _forks[2] = Fork2;
            _forks[3] = Fork3;
            _forks[4] = Fork4;
            _forks[5] = Fork5;

            _philosophers[1] = Philosopher1;
            _philosophers[2] = Philosopher2;
            _philosophers[3] = Philosopher3;
            _philosophers[4] = Philosopher4;
            _philosophers[5] = Philosopher5;
            for (var i = 0; i < 5; i++)
                fork.Add(new Fork());
            for (var i = 0; i < 5; i++)
                ph.Add(new Philosopher((i + 1).ToString(), i));

            threads.Add(new Thread(ph[0].Start));
            threads.Add(new Thread(ph[1].Start));
            threads.Add(new Thread(ph[2].Start));
            threads.Add(new Thread(ph[3].Start));
            threads.Add(new Thread(ph[4].Start));
            threads[0].Start(fork);
            threads[1].Start(fork);
            threads[2].Start(fork);
            threads[3].Start(fork);
            threads[4].Start(fork);
            CallBackMy.CallbackEatEventHandler = PhelosopherEating;
            CallBackMy.CallbackThinkEventHandler = PhelosopherThinking;
            CallBackMy.CallbackWeitingEventHandler = PhelosopherWaiting;
        }

        private List<Label> _forks;
        private List<Label> _philosophers;
        static List<Fork> fork = new List<Fork>();
        static List<Philosopher> ph = new List<Philosopher>();
        List<Thread> threads = new List<Thread>();

        public void PhelosopherEating(Data data)
        {

            Action chTxt = () =>
            {
                _philosophers[data.Philosopher].Text = "EATING";
                _philosophers[data.Philosopher].BackColor = Color.DarkMagenta;
                _forks[data.Fork1].Text = "Philosopher " + data.Philosopher;
                _forks[data.Fork1].BackColor = Color.DarkMagenta;
                _forks[data.Fork2].Text = "Philosopher " + data.Philosopher;
                _forks[data.Fork2].BackColor = Color.DarkMagenta;
            };

            if (InvokeRequired)
                BeginInvoke(chTxt);
            else chTxt();

        }

        public void PhelosopherWaiting(Data data)
        {
            Action chTxt = () =>
            {
                _philosophers[data.Philosopher].Text = "Waiting";
                _philosophers[data.Philosopher].BackColor = Color.DarkOrange;
            };

            if (InvokeRequired)
                BeginInvoke(chTxt);
            else chTxt();
            
        }

        public void PhelosopherThinking(Data data)
        {

            Action chTxt = () =>
            {
                _philosophers[data.Philosopher].Text = "Thinking";
                _philosophers[data.Philosopher].BackColor = Color.DarkGreen;
                _forks[data.Fork1].Text = "Free";
                _forks[data.Fork1].BackColor = Color.DarkGreen;
                _forks[data.Fork2].Text = "Free";
                _forks[data.Fork2].BackColor = Color.DarkGreen;
                ChangeCounters();
            };

            if (InvokeRequired)
                BeginInvoke(chTxt);
            else chTxt();

        }

        private void ChangeCounters()
        {
            label6.Text = ph[0].Count.ToString();
            label7.Text = ph[1].Count.ToString();
            label8.Text = ph[2].Count.ToString();
            label9.Text = ph[3].Count.ToString();
            label10.Text = ph[4].Count.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var VARIABLE in threads)
            {
                VARIABLE.Abort();
            }
        }
    }
}
