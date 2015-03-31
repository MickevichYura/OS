using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class FormMutualExclusion : Form
    {
        public FormMutualExclusion()
        {
            InitializeComponent();
            rbStrictAlternation.Checked = true;
            InputTextBox.Select();
        }

        private int _turn;
        private readonly int[] _interested = { 0, 0 };
        private bool _isTrue = true;

        private void NoncriticalRegion(int process)
        {
            InputTextBox.Enabled = true; //Critical point
            if (rbPetersonAlgorithm.Checked && _interested[process] != 0)
            {
                _interested[process] = 0;
            }

            if (process == 0)
                tbOutput0.AppendText(String.Format("Noncritical Region\n" + "The Process #{0} is finished:\n\n", process));
            else
                tbOutput1.AppendText(String.Format("Noncritical Region\n" + "The Process #{0} is finished:\n\n", process));
        }

        private void CriticalRegion(int process)
        {

            char criticalValue = InputTextBox.Text[0]; //Critical point
            InputTextBox.Enabled = false; //Critical point

            if (process == 0)
            {
                tbOutput0.AppendText(String.Format("The Process #{0} is started:\n", process));
                tbOutput0.AppendText(String.Format("Critical Region: {0}\nASCII Code: {1}\n",
                    criticalValue, (int)criticalValue));
            }
            else
            {
                tbOutput1.AppendText(String.Format("The Process #{0} is started:\n", process));
                tbOutput1.AppendText(String.Format("Critical Region: {0}\nASCII Code: {1}\n",
                    criticalValue, (int)criticalValue));
            }
        }

        private void StartP0button_Click(object sender, EventArgs e)
        {
            _isTrue = true;
            while (_isTrue)
            {
                if (rbStrictAlternation.Checked)
                {
                    if (_turn != 0)
                    {
                        MessageBox.Show(@"The Process #0 must be finished");
                        return;
                    }
                    CriticalRegion(0);
                    _turn = 1;
                }
                else if (rbPetersonAlgorithm.Checked)
                {
                    if (_interested[1] == 1 && _turn == 1)
                    {
                        MessageBox.Show(@"The Process #1 must be finished");
                        return;
                    }
                    _interested[0] = 1;
                    _turn = 1;
                    CriticalRegion(0);
                }

                _isTrue = false;
            }
        }

        private void FinishP0button_Click(object sender, EventArgs e)
        {
            _isTrue = true;
            while (_isTrue)
            {
                if (rbStrictAlternation.Checked)
                {
                    if (_interested[0] != 1 && _turn != 1)
                    {
                        MessageBox.Show(@"The Process #0 must be started");
                        return;
                    }
                    NoncriticalRegion(0);
                    CriticalRegion(1);
                    _turn = 0;
                    FinishProcess1StrictAlt();
                }
                else if (rbPetersonAlgorithm.Checked)
                {
                    if (_interested[0] != 1)
                    {
                        MessageBox.Show(@"The Process #0 must be started");
                        return;
                    }
                    NoncriticalRegion(0);
                    _turn = 0;
                }

                _isTrue = false;
            }

        }

        private void StartP1button_Click(object sender, EventArgs e)
        {

            _isTrue = true;
            while (_isTrue)
            {
                if (rbPetersonAlgorithm.Checked)
                {
                    if (_interested[0] == 1 && _turn == 1)
                    {
                        MessageBox.Show(@"The Process #0 must be finished");
                        return;
                    }
                    CriticalRegion(1);
                    _interested[1] = 1;
                    _turn = 1;
                }
                _isTrue = false;
            }
        }

        private void FinishP1button_Click(object sender, EventArgs e)
        {
            if (_interested[1] != 1)
            {
                MessageBox.Show(@"The process P1 must be started");
                return;
            }
            NoncriticalRegion(1);
            _turn = 0;
        }

        private void FinishProcess1StrictAlt()
        {
            if (_turn != 0)
            {
                MessageBox.Show(@"The Process #1 waits for the termination of the Process #0");
                return;
            }
            NoncriticalRegion(1);
            InputTextBox.Select();
        }

        private void ChooseAlgorithm(object sender, EventArgs e)
        {
            if (rbStrictAlternation.Checked)
            {
                buttonFinishP1.Hide();
                buttonStartP1.Hide();
            }
            if (rbPetersonAlgorithm.Checked)
            {
                buttonFinishP1.Show();
                buttonStartP1.Show();
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            tbOutput0.Clear();
            tbOutput1.Clear();
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (InputTextBox.Text.Trim() == "")
            {
                buttonStartP0.Enabled = false;
                buttonStartP1.Enabled = false;
                buttonFinishP0.Enabled = false;
                buttonFinishP1.Enabled = false;
            }
            else
            {
                buttonStartP0.Enabled = true;
                buttonStartP1.Enabled = true;
                buttonFinishP0.Enabled = true;
                buttonFinishP1.Enabled = true;
            }
        }
    }
}
