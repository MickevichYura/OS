using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace lab5
{
    public partial class SchedulingForm : Form
    {
        public SchedulingForm()
        {
            InitializeComponent();
            cbAmountOfProcesses1.DataSource = new[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            cbAmountOfProcesses2.DataSource = new[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            cbPriotities.DataSource = new[] { 3, 4, 5, 6, 7, 8, 9, 10 };
            cbQuantum1.DataSource = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            cbQuantum2.DataSource = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }

        private readonly static Color InProgressColor = Color.Gold;
        private readonly static Color WasInProgressColor = Color.LemonChiffon;
        private readonly static Color DefaultColor = Color.White;

        private const int SleepTime = 1000;

        private int _amount1;
        private int _quantum1;

        private int _amount2;
        private int _quantum2;
        private readonly List<double> _times = new List<double>();
        private int _totalWorkingTime;

        private static readonly Random GetRandom = new Random(DateTime.Now.Millisecond);
        private static readonly object SyncLock = new object();

        private static int GetRandomNumber(int min, int max)
        {
            lock (SyncLock)
            {
                try
                {
                    return GetRandom.Next(min, max);
                }
                catch (ArgumentOutOfRangeException)
                {
                    return 0;
                }
            }
        }

        private void buttonLoad1_Click(object sender, EventArgs e)
        {
            _amount1 = 0;
            _quantum1 = int.Parse(cbQuantum1.Text);
            dataGridView1.Rows.Clear();
            AddProcesses1(int.Parse(cbAmountOfProcesses1.Text), int.Parse(cbPriotities.Text));
            buttonStart1.Enabled = true;
            buttonStop1.Enabled = true;
        }

        private void buttonStart1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[2].ReadOnly = true;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            timer1.Enabled = true;
            dataGridView1.Sort(ProcessPriority, ListSortDirection.Descending);
        }


        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            AddProcesses1(int.Parse(cbAmountOfProcesses1.Text), int.Parse(cbPriotities.Text));
        }

        private void AddProcesses1(int amount, int priorities)
        {
            for (int i = 0; i < amount; i++)
            {
                var a = GetRandomNumber(0, priorities);
                dataGridView1.Rows.Add("Task " + (i + _amount1), 0, a, GetRandomNumber(_quantum1, _quantum1 * 30).ToString());
            }
            _amount1 += amount;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            Thread.Sleep(SleepTime);
            dataGridView1.Rows[0].Cells[1].Value = int.Parse(dataGridView1.Rows[0].Cells[1].Value.ToString()) + _quantum1;

            if (dataGridView1.RowCount > 1)
            {
                int i = 0;
                while (i < dataGridView1.RowCount - 1 && (int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) ==
                    int.Parse(dataGridView1.Rows[i + 1].Cells[2].Value.ToString())))
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        object swap0 = dataGridView1.Rows[i].Cells[j].Value;
                        object swap1 = dataGridView1.Rows[i + 1].Cells[j].Value;
                        dataGridView1.Rows[i].Cells[j].Value = swap1;
                        dataGridView1.Rows[i + 1].Cells[j].Value = swap0;
                    }
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = DefaultColor;
                    i++;

                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = WasInProgressColor;
                }
                
            }
            dataGridView1.Rows[0].DefaultCellStyle.BackColor = InProgressColor;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = int.Parse(dataGridView1.Rows[0].Cells[3].Value.ToString());
            progressBar1.Value = int.Parse(dataGridView1.Rows[0].Cells[1].Value.ToString());
            progressBar1.Caption = string.Format("{0} - {1}%", dataGridView1.Rows[0].Cells[0].Value, progressBar1.Value * 100 / progressBar1.Maximum);
            timer1.Enabled = true;
            Check();
        }

        private void Check()
        {
            if (int.Parse(dataGridView1.Rows[0].Cells[3].Value.ToString()) - int.Parse(dataGridView1.Rows[0].Cells[1].Value.ToString()) <= 0 && _amount1 > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
                _amount1--;
            }
            if (_amount1 == 0)
            {
                timer1.Enabled = false;
                progressBar1.Value = 0;
                progressBar1.Caption = @"0";
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
            timer2.Enabled = true;
        }

        private void buttonLoad2_Click(object sender, EventArgs e)
        {
            _amount2 = 0;
            _quantum2 = int.Parse(cbQuantum2.Text);
            dataGridView2.Rows.Clear();

            AddProcesses2(int.Parse(cbAmountOfProcesses2.Text));

            buttonStart2.Enabled = true;
            buttonStop2.Enabled = true;
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            AddProcesses2(int.Parse(cbAmountOfProcesses2.Text));
        }

        private void AddProcesses2(int amount)
        {
            _totalWorkingTime = 0;
            for (int i = 0; i < amount; i++)
            {
                int processTime = GetRandomNumber(_quantum2, _quantum2 * 30);
                dataGridView2.Rows.Add("Task " + (i + _amount2), 0, 0, processTime.ToString());
            }
            _amount2 += amount;
        }

        private void buttonStop2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _times.Clear();
            timer2.Enabled = false;

            Thread.Sleep(SleepTime);
            dataGridView2.Rows[0].Cells["TimeColumn2"].Value = int.Parse(dataGridView2.Rows[0].Cells["TimeColumn2"].Value.ToString()) + _quantum2;
            _totalWorkingTime += _quantum2;

            dataGridView2.Rows[0].Cells["PromiseTimeColumn2"].Value =
                (double.Parse(dataGridView2.Rows[0].Cells["PromiseTimeColumn2"].Value.ToString()));

            progressBar2.Minimum = 0;
            progressBar2.Maximum = int.Parse(dataGridView2.Rows[0].Cells["FullTimeColumn2"].Value.ToString());
            progressBar2.Value = int.Parse(dataGridView2.Rows[0].Cells["TimeColumn2"].Value.ToString());
            progressBar2.Caption = string.Format("{0} - {1}%", dataGridView2.Rows[0].Cells["TaskColumn2"].Value, progressBar2.Value * 100 / progressBar2.Maximum);
            timer2.Enabled = true;
            Check2();

            double minValue = double.MaxValue;
            int minValueIndex = 0;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                int processWorkingTime = int.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());

                double d = (processWorkingTime / (double)(_totalWorkingTime * _amount2));
                //double d = processWorkingTime / double.Parse(dataGridView2.Rows[i].Cells["LeftTimeColumn"].Value.ToString());
                //double d = processWorkingTime / double.Parse(dataGridView2.Rows[i].Cells["ColumnFullTime"].Value.ToString());
                dataGridView2.Rows[i].Cells["PromiseTimeColumn2"].Value = string.Format("{0:0.000}", d);

                _times.Add(double.Parse(dataGridView2.Rows[i].Cells["PromiseTimeColumn2"].Value.ToString()));
                if (minValue > _times[i])
                {
                    minValue = _times[i];
                    minValueIndex = i;
                }
            }

            if (dataGridView2.RowCount != 0)
            {
                for (int i = 0; i < dataGridView2.ColumnCount; i++)
                {
                    object swap0 = dataGridView2.Rows[0].Cells[i].Value;
                    object swap1 = dataGridView2.Rows[minValueIndex].Cells[i].Value;
                    dataGridView2.Rows[0].Cells[i].Value = swap1;
                    dataGridView2.Rows[minValueIndex].Cells[i].Value = swap0;
                }
            }

            //if (dataGridView1.RowCount > 1)
            //{
            //    int i = 0;
            //    while (i < dataGridView2.RowCount && (int.Parse(dataGridView2.Rows[i].Cells["PromiseTimeColumn2"].Value.ToString()) ==
            //        int.Parse(dataGridView2.Rows[i + 1].Cells["PromiseTimeColumn2"].Value.ToString())))
            //    {
            //        for (int j = 0; j < dataGridView2.ColumnCount; j++)
            //        {
            //            object swap0 = dataGridView2.Rows[i].Cells[j].Value;
            //            object swap1 = dataGridView2.Rows[i + 1].Cells[j].Value;
            //            dataGridView2.Rows[i].Cells[j].Value = swap1;
            //            dataGridView2.Rows[i + 1].Cells[j].Value = swap0;
            //        }
            //        i++;
            //    }
            //}
        }

        private void Check2()
        {
            if (int.Parse(dataGridView2.Rows[0].Cells["FullTimeColumn2"].Value.ToString()) - int.Parse(dataGridView2.Rows[0].Cells["TimeColumn2"].Value.ToString()) <= 0 && _amount2 > 0)
            {
                dataGridView2.Rows.RemoveAt(0);
                _amount2--;
            }
            if (_amount2 == 0)
            {
                timer2.Enabled = false;
                progressBar2.Value = 0;
                progressBar2.Caption = @"0";
                dataGridView2.Columns[2].ReadOnly = false;
                buttonStart2.Enabled = false;
                buttonStop2.Enabled = true;
            }
        }
    }
}
