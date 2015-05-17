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
            borderedPictureBoxWaiting.BackColor = ColorWaiting;
            borderedPictureBoxEating.BackColor = ColorEating;
            borderedPictureBoxThinking.BackColor = ColorThinking;

            _forks = new List<BorderedPictureBox>(6);
            _philosophers = new List<BorderedPictureBox>(6);
            for (int i = 0; i < 7; i++)
            {
                _forks.Add(null);
                _philosophers.Add(null);
            }
            _forks[1] = borderedPictureBoxFork1;
            _forks[2] = borderedPictureBoxFork2;
            _forks[3] = borderedPictureBoxFork3;
            _forks[4] = borderedPictureBoxFork4;
            _forks[5] = borderedPictureBoxFork5;

            _philosophers[1] = borderedPictureBoxPlate1;
            _philosophers[2] = borderedPictureBoxPlate2;
            _philosophers[3] = borderedPictureBoxPlate3;
            _philosophers[4] = borderedPictureBoxPlate4;
            _philosophers[5] = borderedPictureBoxPlate5;
            for (var i = 0; i < 5; i++)
                Forks.Add(new Fork());
            for (var i = 0; i < 5; i++)
                Philosophers.Add(new Philosopher((i + 1).ToString(), i));

            _threads.Add(new Thread(Philosophers[0].Start));
            _threads.Add(new Thread(Philosophers[1].Start));
            _threads.Add(new Thread(Philosophers[2].Start));
            _threads.Add(new Thread(Philosophers[3].Start));
            _threads.Add(new Thread(Philosophers[4].Start));
            _threads[0].Start(Forks);
            _threads[1].Start(Forks);
            _threads[2].Start(Forks);
            _threads[3].Start(Forks);
            _threads[4].Start(Forks);
            CallBackMy.CallbackEatEventHandler = PhilosopherEating;
            CallBackMy.CallbackThinkEventHandler = PhilosopherThinking;
            CallBackMy.CallbackWaitingEventHandler = PhilosopherWaiting;
        }

        private readonly List<BorderedPictureBox> _forks;
        private readonly List<BorderedPictureBox> _philosophers;
        static readonly List<Fork> Forks = new List<Fork>();
        static readonly List<Philosopher> Philosophers = new List<Philosopher>();
        readonly List<Thread> _threads = new List<Thread>();

        private static readonly Color ColorEating = Color.Red;
        private static readonly Color ColorWaiting = Color.DarkSeaGreen;
        private static readonly Color ColorThinking = Color.SaddleBrown;

        private void PhilosopherEating(Data data)
        {

            Action chTxt = () =>
            {
                _philosophers[data.Philosopher].BackColor = ColorEating;
                _philosophers[data.Philosopher].BorderColor = ColorEating;
                _forks[data.Fork1].BackColor = ColorEating;
                _forks[data.Fork2].BackColor = ColorEating;
     
            };

            if (InvokeRequired)
                BeginInvoke(chTxt);
            else chTxt();

        }

        private void PhilosopherWaiting(Data data)
        {
            Action chTxt = () =>
            {
                _philosophers[data.Philosopher].BackColor = ColorWaiting;
                _philosophers[data.Philosopher].BorderColor = ColorWaiting;
            };

            if (InvokeRequired)
                BeginInvoke(chTxt);
            else chTxt();
            
        }

        private void PhilosopherThinking(Data data)
        {

            Action chTxt = () =>
            {
                _philosophers[data.Philosopher].BackColor = ColorThinking;
                _philosophers[data.Philosopher].BorderColor = ColorThinking;
                _forks[data.Fork1].BackColor = ColorThinking;
                _forks[data.Fork2].BackColor = ColorThinking;
                ChangeCounters();
            };

            if (InvokeRequired)
                BeginInvoke(chTxt);
            else chTxt();

        }

        private void ChangeCounters()
        {
            label6.Text = Philosophers[0].Count.ToString();
            label7.Text = Philosophers[1].Count.ToString();
            label8.Text = Philosophers[2].Count.ToString();
            label9.Text = Philosophers[3].Count.ToString();
            label10.Text = Philosophers[4].Count.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var variable in _threads)
            {
                variable.Abort();
            }
        }
    }
}
