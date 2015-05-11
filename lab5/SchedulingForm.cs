using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            cbTickets.DataSource = new[] { 13, 14, 15, 16, 17, 18, 19, 20 };
            cbQuantum1.DataSource = cbQuantum2.DataSource = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }


        private int sumTime, quantumPerProcess, promiseTime;


        private int Amount, counters;
        private int Priorites, ticket;
        private int QStep;
        private int Qstep2;
        private Dictionary<string, int> Copy = new Dictionary<string, int>();
        private Dictionary<string, int> Copy1 = new Dictionary<string, int>();
        private static readonly Random getrandom = new Random();
        List<bool> ticketsa = new List<bool>();
        private static readonly object syncLock = new object();
        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                try
                {
                    return getrandom.Next(min, max);
                }
                catch (ArgumentOutOfRangeException)
                {
                    return 0;

                }

            }
        }

        private void B_Load_Click(object sender, EventArgs e)
        {
            Amount = int.Parse(cbAmountOfProcesses1.Text);
            Priorites = int.Parse(cbPriotities.Text);
            QStep = int.Parse(cbQuantum1.Text);
            dataGridView1.Rows.Clear();
            var aRandom = new Random(DateTime.Today.Millisecond);
            for (int i = 0; i < Amount; i++)
            {
                var a = GetRandomNumber(0, Priorites);
                dataGridView1.Rows.Add("Task " + i, aRandom.Next(QStep, QStep*50).ToString(), a, a);
            }
            B_start.Enabled = true;
            B_STOP.Enabled = true;
        }

        private void B_start_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[2].ReadOnly = true;
            Copy.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                Copy.Add(dataGridView1.Rows[i].Cells[0].Value.ToString(), int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
            
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
                progressBar1.Value = Copy[dataGridView1.Rows[0].Cells[0].Value.ToString()] - int.Parse(dataGridView1.Rows[0].Cells[1].Value.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
            }

            dataGridView1.Rows[0].Cells[1].Value = int.Parse(dataGridView1.Rows[0].Cells[1].Value.ToString()) - QStep;
            if(int.Parse(dataGridView1.Rows[0].Cells[3].Value.ToString()) > 0)
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

            //if (progressBar1.Value.Equals(progressBar1.Maximum) && Amount > 0)
            if (int.Parse(dataGridView1.Rows[0].Cells[1].Value.ToString()) <= 0 && Amount > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
                Amount--;
                progressBar1.Value = 0;
            }
            if (Amount == 0)
            {
                timer1.Enabled = false;
                progressBar1.Value = 0;
                label1.Text = "0";
                MessageBox.Show(@"Success");
                dataGridView1.Columns[2].ReadOnly = false;
                B_start.Enabled = false;
                B_STOP.Enabled = true;
            }

        }

        private void B_STOP_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Copy1.Clear();
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                Copy1.Add(dataGridView2.Rows[i].Cells[0].Value.ToString(), int.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString()));

                //dataGridView2.Rows[i].Cells[2].Value = int.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());
            }
            timer2.Enabled = true;
        }

        private int GetNumber(int a, int b)
        {
            return (int)Math.Ceiling(a / (double)b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sumTime = 0;
            counters = int.Parse(cbAmountOfProcesses2.Text);
            ticket = int.Parse(cbTickets.Text);
            Qstep2 = int.Parse(cbQuantum2.Text);
            dataGridView2.Rows.Clear();
            ticketsa.Clear();
            for (int i = 0; i < ticket; i++)
            {
                ticketsa.Add(false);
            }

            for (int i = 0; i < counters; i++)
            {
                int ticn;
                while (true)
                {
                    ticn = GetRandomNumber(0, ticket - 1);
                    if (!ticketsa[ticn])
                    {
                        ticketsa[ticn] = true;
                        break;
                    }
                }

                int processTime = GetRandomNumber(Qstep2, Qstep2 * 50);
                dataGridView2.Rows.Add("Task " + i, processTime.ToString(), GetNumber(processTime, Qstep2), processTime/(double)promiseTime);
                sumTime += processTime;
            }
            sumTime = GetNumber(sumTime, Qstep2);
            quantumPerProcess = GetNumber(sumTime, counters);

            MessageBox.Show(string.Format("{0} - {1}", sumTime, quantumPerProcess));

            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            var numb = GetRandomNumber(0, ticket - 1);
            int rown = 0;
            var flag = true;
            while (flag)
            {
                for (int i = 0; i<counters; i++)
                {

                        string[] bils = dataGridView2.Rows[i].Cells[2].Value.ToString().Split(',');
                        if (bils.Contains(numb.ToString()))
                        {
                            rown = i;
                            flag = false;
                            label5.Text = numb.ToString();
                            break;
                        }
                    }
            }

            Thread.Sleep(100);
            progressBar22.Minimum = 0;
            try
            {
                progressBar22.Maximum = int.Parse(dataGridView2.Rows[rown].Cells[1].Value.ToString());
            }
            catch (Exception)
            {
                progressBar1.Maximum = 100;
            }
            try
            {
                progressBar22.Value = Copy1[dataGridView2.Rows[rown].Cells[0].Value.ToString()] - int.Parse(dataGridView2.Rows[rown].Cells[1].Value.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
            }

            dataGridView2.Rows[rown].Cells[1].Value = int.Parse(dataGridView2.Rows[rown].Cells[1].Value.ToString()) - Qstep2;
            label3.Text = progressBar22.Value.ToString();
            label4.Text = dataGridView2.Rows[rown].Cells[0].Value.ToString();


            //-------------
            if (int.Parse(dataGridView2.Rows[rown].Cells[1].Value.ToString()) <= 0 && counters > 0)
            {
                var s = dataGridView2.Rows[rown].Cells[2].Value.ToString().Split(',');
                foreach (string aa in s)
                    ticketsa[int.Parse(aa)] = false;
                
                dataGridView2.Rows.RemoveAt(rown);
                counters--;
                for (int i = 0; i < ticketsa.Count; i++)
                {
                    if (ticketsa[i]) continue;
                    dataGridView2.Rows[GetRandomNumber(0, counters - 1)].Cells[2].Value += string.Format(",{0}", i);
                    ticketsa[i] = true;
                }
            }
            if (counters <= 0)
            {
                timer2.Enabled = false;
                progressBar22.Value = 0;
                label3.Text = "0";
                MessageBox.Show(@"Success1");
                dataGridView2.Columns[2].ReadOnly = false;
                button1.Enabled = false;
                button2.Enabled = false;
                dataGridView2.Rows.Clear();
            }
            else
            //-------------
            timer2.Enabled = true;
            //Check();
        }
    }

}
