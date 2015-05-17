using ExtendedDotNET.Controls;
namespace lab5
{
    partial class SchedulingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbAmountOfProcesses1 = new System.Windows.Forms.ComboBox();
            this.cbPriotities = new System.Windows.Forms.ComboBox();
            this.cbQuantum1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStop1 = new System.Windows.Forms.Button();
            this.buttonStart1 = new System.Windows.Forms.Button();
            this.buttonLoad1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLoad2 = new System.Windows.Forms.Button();
            this.cbQuantum2 = new System.Windows.Forms.ComboBox();
            this.cbAmountOfProcesses2 = new System.Windows.Forms.ComboBox();
            this.buttonStop2 = new System.Windows.Forms.Button();
            this.buttonStart2 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromiseTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAmountOfProcesses1
            // 
            this.cbAmountOfProcesses1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmountOfProcesses1.FormattingEnabled = true;
            this.cbAmountOfProcesses1.Location = new System.Drawing.Point(29, 39);
            this.cbAmountOfProcesses1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAmountOfProcesses1.Name = "cbAmountOfProcesses1";
            this.cbAmountOfProcesses1.Size = new System.Drawing.Size(61, 24);
            this.cbAmountOfProcesses1.TabIndex = 0;
            // 
            // cbPriotities
            // 
            this.cbPriotities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriotities.FormattingEnabled = true;
            this.cbPriotities.Location = new System.Drawing.Point(29, 96);
            this.cbPriotities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPriotities.Name = "cbPriotities";
            this.cbPriotities.Size = new System.Drawing.Size(61, 24);
            this.cbPriotities.TabIndex = 1;
            // 
            // cbQuantum1
            // 
            this.cbQuantum1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantum1.FormattingEnabled = true;
            this.cbQuantum1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbQuantum1.Location = new System.Drawing.Point(29, 153);
            this.cbQuantum1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbQuantum1.Name = "cbQuantum1";
            this.cbQuantum1.Size = new System.Drawing.Size(61, 24);
            this.cbQuantum1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.Time,
            this.ProcPriority,
            this.Priority});
            this.dataGridView1.Location = new System.Drawing.Point(128, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(341, 345);
            this.dataGridView1.TabIndex = 3;
            // 
            // Task
            // 
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // ProcPriority
            // 
            this.ProcPriority.HeaderText = "ProcPriority";
            this.ProcPriority.Name = "ProcPriority";
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonStop1);
            this.panel1.Controls.Add(this.cbAmountOfProcesses1);
            this.panel1.Controls.Add(this.buttonStart1);
            this.panel1.Controls.Add(this.buttonLoad1);
            this.panel1.Controls.Add(this.cbPriotities);
            this.panel1.Controls.Add(this.cbQuantum1);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 469);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 384);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 379);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // buttonStop1
            // 
            this.buttonStop1.Enabled = false;
            this.buttonStop1.Location = new System.Drawing.Point(133, 410);
            this.buttonStop1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStop1.Name = "buttonStop1";
            this.buttonStop1.Size = new System.Drawing.Size(220, 30);
            this.buttonStop1.TabIndex = 8;
            this.buttonStop1.Text = "STOP";
            this.buttonStop1.UseVisualStyleBackColor = true;
            this.buttonStop1.Click += new System.EventHandler(this.buttonStop1_Click);
            // 
            // buttonStart1
            // 
            this.buttonStart1.Enabled = false;
            this.buttonStart1.Location = new System.Drawing.Point(367, 410);
            this.buttonStart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStart1.Name = "buttonStart1";
            this.buttonStart1.Size = new System.Drawing.Size(220, 30);
            this.buttonStart1.TabIndex = 6;
            this.buttonStart1.Text = "Start!";
            this.buttonStart1.UseVisualStyleBackColor = true;
            this.buttonStart1.Click += new System.EventHandler(this.buttonStart1_Click);
            // 
            // buttonLoad1
            // 
            this.buttonLoad1.Location = new System.Drawing.Point(28, 217);
            this.buttonLoad1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoad1.Name = "buttonLoad1";
            this.buttonLoad1.Size = new System.Drawing.Size(63, 28);
            this.buttonLoad1.TabIndex = 5;
            this.buttonLoad1.Text = "Create";
            this.buttonLoad1.UseVisualStyleBackColor = true;
            this.buttonLoad1.Click += new System.EventHandler(this.buttonLoad1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(133, 373);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(453, 28);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 469);
            this.splitContainer1.SplitterDistance = 594;
            this.splitContainer1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonLoad2);
            this.panel2.Controls.Add(this.cbQuantum2);
            this.panel2.Controls.Add(this.cbAmountOfProcesses2);
            this.panel2.Controls.Add(this.buttonStop2);
            this.panel2.Controls.Add(this.buttonStart2);
            this.panel2.Controls.Add(this.progressBar2);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 469);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 378);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 378);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "0";
            // 
            // buttonLoad2
            // 
            this.buttonLoad2.Location = new System.Drawing.Point(480, 149);
            this.buttonLoad2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoad2.Name = "buttonLoad2";
            this.buttonLoad2.Size = new System.Drawing.Size(63, 28);
            this.buttonLoad2.TabIndex = 17;
            this.buttonLoad2.Text = "Create";
            this.buttonLoad2.UseVisualStyleBackColor = true;
            this.buttonLoad2.Click += new System.EventHandler(this.buttonLoad2_Click);
            // 
            // cbQuantum2
            // 
            this.cbQuantum2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantum2.FormattingEnabled = true;
            this.cbQuantum2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbQuantum2.Location = new System.Drawing.Point(480, 96);
            this.cbQuantum2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbQuantum2.Name = "cbQuantum2";
            this.cbQuantum2.Size = new System.Drawing.Size(61, 24);
            this.cbQuantum2.TabIndex = 16;
            // 
            // cbAmountOfProcesses2
            // 
            this.cbAmountOfProcesses2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmountOfProcesses2.FormattingEnabled = true;
            this.cbAmountOfProcesses2.Location = new System.Drawing.Point(480, 39);
            this.cbAmountOfProcesses2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAmountOfProcesses2.Name = "cbAmountOfProcesses2";
            this.cbAmountOfProcesses2.Size = new System.Drawing.Size(61, 24);
            this.cbAmountOfProcesses2.TabIndex = 14;
            // 
            // buttonStop2
            // 
            this.buttonStop2.Enabled = false;
            this.buttonStop2.Location = new System.Drawing.Point(13, 409);
            this.buttonStop2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStop2.Name = "buttonStop2";
            this.buttonStop2.Size = new System.Drawing.Size(220, 30);
            this.buttonStop2.TabIndex = 13;
            this.buttonStop2.Text = "STOP";
            this.buttonStop2.UseVisualStyleBackColor = true;
            this.buttonStop2.Click += new System.EventHandler(this.buttonStop2_Click);
            // 
            // buttonStart2
            // 
            this.buttonStart2.Enabled = false;
            this.buttonStart2.Location = new System.Drawing.Point(235, 409);
            this.buttonStart2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStart2.Name = "buttonStart2";
            this.buttonStart2.Size = new System.Drawing.Size(220, 30);
            this.buttonStart2.TabIndex = 13;
            this.buttonStart2.Text = "Start!";
            this.buttonStart2.UseVisualStyleBackColor = true;
            this.buttonStart2.Click += new System.EventHandler(this.buttonStart2_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(13, 373);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(443, 28);
            this.progressBar2.TabIndex = 13;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.LeftTimeColumn,
            this.PromiseTimeColumn});
            this.dataGridView2.Location = new System.Drawing.Point(13, 9);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(443, 345);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Task";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Time";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // LeftTimeColumn
            // 
            this.LeftTimeColumn.HeaderText = "LeftTime";
            this.LeftTimeColumn.Name = "LeftTimeColumn";
            // 
            // PromiseTimeColumn
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.PromiseTimeColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.PromiseTimeColumn.HeaderText = "PromiseTime";
            this.PromiseTimeColumn.Name = "PromiseTimeColumn";
            // 
            // SchedulingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 469);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SchedulingForm";
            this.Text = "Scheduling";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAmountOfProcesses1;
        private System.Windows.Forms.ComboBox cbPriotities;
        private System.Windows.Forms.ComboBox cbQuantum1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLoad1;
        private System.Windows.Forms.Button buttonStart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStop1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLoad2;
        private System.Windows.Forms.ComboBox cbQuantum2;
        private System.Windows.Forms.ComboBox cbAmountOfProcesses2;
        private System.Windows.Forms.Button buttonStop2;
        private System.Windows.Forms.Button buttonStart2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromiseTimeColumn;

    }
}

