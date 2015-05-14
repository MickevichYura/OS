using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace lab5
{
    public partial class SchedulingForm : Form
    {
        public SchedulingForm()
        {
            InitializeComponent();
            cbAmountOfProcesses1.DataSource = cbAmountOfProcesses2.DataSource = new[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            cbPriotities.DataSource = new[] { 3, 4, 5, 6, 7, 8, 9, 10 };
            cbQuantum1.DataSource = cbQuantum2.DataSource = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }


        private int sumTime, quantumPerProcess, promiseTime, leftTime;


        private int Amount, counters;
        private int Priorities;
        private int QStep;
        private int Qstep2;
        private Dictionary<string, int> Copy1 = new Dictionary<string, int>();
        private Dictionary<string, int> Copy2 = new Dictionary<string, int>();
        private static readonly Random getRandom = new Random(DateTime.Now.Millisecond);
        private static readonly object syncLock = new object();

        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            {
                // synchronize
                try
                {
                    return getRandom.Next(min, max);
                }
                catch (ArgumentOutOfRangeException)
                {
                    return 0;
                }
            }
        }

        private void buttonLoad1_Click(object sender, EventArgs e)
        {
            Amount = int.Parse(cbAmountOfProcesses1.Text);
            Priorities = int.Parse(cbPriotities.Text);
            QStep = int.Parse(cbQuantum1.Text);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Amount; i++)
            {
                var a = GetRandomNumber(0, Priorities);
                dataGridView1.Rows.Add("Task " + i, GetRandomNumber(QStep, QStep * 30).ToString(), a, a);
            }
            buttonStart1.Enabled = true;
            buttonStop1.Enabled = true;
        }

        private void buttonStart1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[2].ReadOnly = true;
            Copy1.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Copy1.Add(dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));

                dataGridView1.Rows[i].Cells[2].Value = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                dataGridView1.Rows[i].Cells[3].Value = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }
            timer1.Enabled = true;
            dataGridView1.Sort(Priority, ListSortDirection.Descending);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            Thread.Sleep(100);
            progressBar1.Minimum = 0;
            try
            {
                progressBar1.Maximum = int.Parse(dataGridView1.Rows[0].Cells[1].Value.ToString());
            }
            catch (Exception)
            {
                progressBar1.Maximum = 100;
            }
            try
            {
                progressBar1.Value = Copy1[dataGridView1.Rows[0].Cells[0].Value.ToString()] -
                                     int.Parse(dataGridView1.Rows[0].Cells[1].Value.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
            }

            dataGridView1.Rows[0].Cells[1].Value = int.Parse(dataGridView1.Rows[0].Cells[1].Value.ToString()) - QStep;
            if (int.Parse(dataGridView1.Rows[0].Cells[3].Value.ToString()) > 0)
                dataGridView1.Rows[0].Cells[2].Value = int.Parse(dataGridView1.Rows[0].Cells[2].Value.ToString()) - 1;
            dataGridView1.Rows[0].Cells[3].Value = int.Parse(dataGridView1.Rows[0].Cells[3].Value.ToString()) - 1;
            label1.Text = progressBar1.Value.ToString();
            label2.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            timer1.Enabled = true;
            Check();
            dataGridView1.Sort(Priority, ListSortDirection.Descending);
        }

        private void Check()
        {
            if (int.Parse(dataGridView1.Rows[0].Cells[1].Value.ToString()) <= 0 && Amount > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
                Amount--;
                //progressBar1.Value = 0;
            }
            if (Amount == 0)
            {
                timer1.Enabled = false;
                progressBar1.Value = 0;
                label1.Text = "0";
                MessageBox.Show(@"Success");
                dataGridView1.Columns[2].ReadOnly = false;
                buttonStart1.Enabled = false;
                buttonStop1.Enabled = true;
            }

        }

        private void buttonStop1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void buttonStart2_Click(object sender, EventArgs e)
        {
            Copy2.Clear();
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                Copy2.Add(dataGridView2.Rows[i].Cells[0].Value.ToString(),
                    int.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString()));
            }
            timer2.Enabled = true;
        }

        private void buttonLoad2_Click(object sender, EventArgs e)
        {
            leftTime = 0;
            sumTime = 0;
            counters = int.Parse(cbAmountOfProcesses2.Text);
            Qstep2 = int.Parse(cbQuantum2.Text);
            dataGridView2.Rows.Clear();

            for (int i = 0; i < counters; i++)
            {
                int processTime = GetRandomNumber(Qstep2, Qstep2 * 30);
                dataGridView2.Rows.Add("Task " + i, processTime.ToString(), 0, 0);
                sumTime += processTime;
            }

            buttonStart2.Enabled = true;
            buttonStop2.Enabled = true;
        }

        private void buttonStop2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;

            Thread.Sleep(100);
            progressBar2.Minimum = 0;
            try
            {
                progressBar2.Maximum = int.Parse(dataGridView2.Rows[0].Cells[1].Value.ToString());
            }
            catch (Exception)
            {
                progressBar2.Maximum = 100;
            }
            try
            {
                progressBar2.Value = Copy2[dataGridView2.Rows[0].Cells[0].Value.ToString()] -
                                     int.Parse(dataGridView2.Rows[0].Cells[1].Value.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
            }

            dataGridView2.Rows[0].Cells[1].Value = int.Parse(dataGridView2.Rows[0].Cells[1].Value.ToString()) - Qstep2;
            dataGridView2.Rows[0].Cells[2].Value = int.Parse(dataGridView2.Rows[0].Cells[2].Value.ToString()) + Qstep2;
            leftTime += Qstep2;

            dataGridView2.Rows[0].Cells[3].Value =
                (double.Parse(dataGridView2.Rows[0].Cells[3].Value.ToString()));
            label3.Text = progressBar1.Value.ToString();
            label4.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
            timer2.Enabled = true;
            Check2();
            dataGridView2.Sort(LeftTimeColumn, ListSortDirection.Descending);
        }

        private void Check2()
        {
            if (int.Parse(dataGridView2.Rows[0].Cells[1].Value.ToString()) <= 0 && counters > 0)
            {
                dataGridView2.Rows.RemoveAt(0);
                counters--;
                progressBar2.Value = 0;
            }
            if (counters == 0)
            {
                timer1.Enabled = false;
                progressBar2.Value = 0;
                label3.Text = "0";
                MessageBox.Show(@"Success");
                dataGridView2.Columns[2].ReadOnly = false;
                buttonStart2.Enabled = false;
                buttonStop2.Enabled = true;
            }

        }
    }
}
