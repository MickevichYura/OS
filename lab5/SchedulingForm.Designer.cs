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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd1 = new System.Windows.Forms.Button();
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
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLoad2 = new System.Windows.Forms.Button();
            this.cbQuantum2 = new System.Windows.Forms.ComboBox();
            this.cbAmountOfProcesses2 = new System.Windows.Forms.ComboBox();
            this.buttonStop2 = new System.Windows.Forms.Button();
            this.buttonStart2 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Task2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromiseTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFullTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelProcesses1 = new System.Windows.Forms.Label();
            this.labelProcesses2 = new System.Windows.Forms.Label();
            this.labelQuantum2 = new System.Windows.Forms.Label();
            this.labelQuantum1 = new System.Windows.Forms.Label();
            this.labelPriorities1 = new System.Windows.Forms.Label();
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
            this.cbAmountOfProcesses1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAmountOfProcesses1.FormattingEnabled = true;
            this.cbAmountOfProcesses1.Location = new System.Drawing.Point(22, 32);
            this.cbAmountOfProcesses1.Name = "cbAmountOfProcesses1";
            this.cbAmountOfProcesses1.Size = new System.Drawing.Size(47, 25);
            this.cbAmountOfProcesses1.TabIndex = 0;
            // 
            // cbPriotities
            // 
            this.cbPriotities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriotities.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPriotities.FormattingEnabled = true;
            this.cbPriotities.Location = new System.Drawing.Point(22, 78);
            this.cbPriotities.Name = "cbPriotities";
            this.cbPriotities.Size = new System.Drawing.Size(47, 25);
            this.cbPriotities.TabIndex = 1;
            // 
            // cbQuantum1
            // 
            this.cbQuantum1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.cbQuantum1.Location = new System.Drawing.Point(22, 124);
            this.cbQuantum1.Name = "cbQuantum1";
            this.cbQuantum1.Size = new System.Drawing.Size(47, 25);
            this.cbQuantum1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task1,
            this.Time1,
            this.ProcPriority,
            this.Priority});
            this.dataGridView1.Location = new System.Drawing.Point(96, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(334, 280);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPriorities1);
            this.panel1.Controls.Add(this.labelQuantum1);
            this.panel1.Controls.Add(this.labelProcesses1);
            this.panel1.Controls.Add(this.buttonAdd1);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 381);
            this.panel1.TabIndex = 4;
            // 
            // buttonAdd1
            // 
            this.buttonAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd1.Location = new System.Drawing.Point(12, 219);
            this.buttonAdd1.Name = "buttonAdd1";
            this.buttonAdd1.Size = new System.Drawing.Size(69, 33);
            this.buttonAdd1.TabIndex = 19;
            this.buttonAdd1.Text = "Add";
            this.buttonAdd1.UseVisualStyleBackColor = true;
            this.buttonAdd1.Click += new System.EventHandler(this.buttonAdd1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // buttonStop1
            // 
            this.buttonStop1.Enabled = false;
            this.buttonStop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop1.Location = new System.Drawing.Point(100, 333);
            this.buttonStop1.Name = "buttonStop1";
            this.buttonStop1.Size = new System.Drawing.Size(165, 36);
            this.buttonStop1.TabIndex = 8;
            this.buttonStop1.Text = "Stop";
            this.buttonStop1.UseVisualStyleBackColor = true;
            this.buttonStop1.Click += new System.EventHandler(this.buttonStop1_Click);
            // 
            // buttonStart1
            // 
            this.buttonStart1.Enabled = false;
            this.buttonStart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart1.Location = new System.Drawing.Point(275, 333);
            this.buttonStart1.Name = "buttonStart1";
            this.buttonStart1.Size = new System.Drawing.Size(165, 36);
            this.buttonStart1.TabIndex = 6;
            this.buttonStart1.Text = "Start";
            this.buttonStart1.UseVisualStyleBackColor = true;
            this.buttonStart1.Click += new System.EventHandler(this.buttonStart1_Click);
            // 
            // buttonLoad1
            // 
            this.buttonLoad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad1.Location = new System.Drawing.Point(12, 165);
            this.buttonLoad1.Name = "buttonLoad1";
            this.buttonLoad1.Size = new System.Drawing.Size(69, 33);
            this.buttonLoad1.TabIndex = 5;
            this.buttonLoad1.Text = "Load";
            this.buttonLoad1.UseVisualStyleBackColor = true;
            this.buttonLoad1.Click += new System.EventHandler(this.buttonLoad1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(100, 303);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(340, 23);
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(972, 381);
            this.splitContainer1.SplitterDistance = 487;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelQuantum2);
            this.panel2.Controls.Add(this.labelProcesses2);
            this.panel2.Controls.Add(this.buttonAdd2);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 381);
            this.panel2.TabIndex = 12;
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd2.Location = new System.Drawing.Point(404, 176);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(66, 33);
            this.buttonAdd2.TabIndex = 18;
            this.buttonAdd2.Text = "Add";
            this.buttonAdd2.UseVisualStyleBackColor = true;
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "0";
            // 
            // buttonLoad2
            // 
            this.buttonLoad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad2.Location = new System.Drawing.Point(404, 124);
            this.buttonLoad2.Name = "buttonLoad2";
            this.buttonLoad2.Size = new System.Drawing.Size(66, 32);
            this.buttonLoad2.TabIndex = 17;
            this.buttonLoad2.Text = "Load";
            this.buttonLoad2.UseVisualStyleBackColor = true;
            this.buttonLoad2.Click += new System.EventHandler(this.buttonLoad2_Click);
            // 
            // cbQuantum2
            // 
            this.cbQuantum2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.cbQuantum2.Location = new System.Drawing.Point(414, 79);
            this.cbQuantum2.Name = "cbQuantum2";
            this.cbQuantum2.Size = new System.Drawing.Size(47, 25);
            this.cbQuantum2.TabIndex = 16;
            // 
            // cbAmountOfProcesses2
            // 
            this.cbAmountOfProcesses2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmountOfProcesses2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAmountOfProcesses2.FormattingEnabled = true;
            this.cbAmountOfProcesses2.Location = new System.Drawing.Point(415, 33);
            this.cbAmountOfProcesses2.Name = "cbAmountOfProcesses2";
            this.cbAmountOfProcesses2.Size = new System.Drawing.Size(47, 25);
            this.cbAmountOfProcesses2.TabIndex = 14;
            // 
            // buttonStop2
            // 
            this.buttonStop2.Enabled = false;
            this.buttonStop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop2.Location = new System.Drawing.Point(27, 332);
            this.buttonStop2.Name = "buttonStop2";
            this.buttonStop2.Size = new System.Drawing.Size(165, 37);
            this.buttonStop2.TabIndex = 13;
            this.buttonStop2.Text = "Stop";
            this.buttonStop2.UseVisualStyleBackColor = true;
            this.buttonStop2.Click += new System.EventHandler(this.buttonStop2_Click);
            // 
            // buttonStart2
            // 
            this.buttonStart2.Enabled = false;
            this.buttonStart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart2.Location = new System.Drawing.Point(193, 332);
            this.buttonStart2.Name = "buttonStart2";
            this.buttonStart2.Size = new System.Drawing.Size(165, 37);
            this.buttonStart2.TabIndex = 13;
            this.buttonStart2.Text = "Start";
            this.buttonStart2.UseVisualStyleBackColor = true;
            this.buttonStart2.Click += new System.EventHandler(this.buttonStart2_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(27, 303);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(332, 23);
            this.progressBar2.TabIndex = 13;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task2,
            this.Time2,
            this.LeftTimeColumn,
            this.PromiseTimeColumn,
            this.ColumnFullTime});
            this.dataGridView2.Location = new System.Drawing.Point(27, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(362, 280);
            this.dataGridView2.TabIndex = 3;
            // 
            // Task2
            // 
            this.Task2.HeaderText = "Task";
            this.Task2.Name = "Task2";
            this.Task2.ReadOnly = true;
            this.Task2.Width = 70;
            // 
            // Time2
            // 
            this.Time2.HeaderText = "Time";
            this.Time2.Name = "Time2";
            this.Time2.Width = 50;
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
            // ColumnFullTime
            // 
            this.ColumnFullTime.HeaderText = "Full";
            this.ColumnFullTime.Name = "ColumnFullTime";
            this.ColumnFullTime.Visible = false;
            // 
            // Task1
            // 
            this.Task1.HeaderText = "Task";
            this.Task1.Name = "Task1";
            this.Task1.ReadOnly = true;
            // 
            // Time1
            // 
            this.Time1.HeaderText = "Time";
            this.Time1.Name = "Time1";
            this.Time1.Width = 70;
            // 
            // ProcPriority
            // 
            this.ProcPriority.HeaderText = "Process Priority";
            this.ProcPriority.Name = "ProcPriority";
            this.ProcPriority.Width = 120;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            this.Priority.Visible = false;
            // 
            // labelProcesses1
            // 
            this.labelProcesses1.AutoSize = true;
            this.labelProcesses1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcesses1.Location = new System.Drawing.Point(16, 12);
            this.labelProcesses1.Name = "labelProcesses1";
            this.labelProcesses1.Size = new System.Drawing.Size(74, 17);
            this.labelProcesses1.TabIndex = 20;
            this.labelProcesses1.Text = "Processes";
            // 
            // labelProcesses2
            // 
            this.labelProcesses2.AutoSize = true;
            this.labelProcesses2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcesses2.Location = new System.Drawing.Point(401, 12);
            this.labelProcesses2.Name = "labelProcesses2";
            this.labelProcesses2.Size = new System.Drawing.Size(74, 17);
            this.labelProcesses2.TabIndex = 21;
            this.labelProcesses2.Text = "Processes";
            // 
            // labelQuantum2
            // 
            this.labelQuantum2.AutoSize = true;
            this.labelQuantum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantum2.Location = new System.Drawing.Point(402, 59);
            this.labelQuantum2.Name = "labelQuantum2";
            this.labelQuantum2.Size = new System.Drawing.Size(66, 17);
            this.labelQuantum2.TabIndex = 22;
            this.labelQuantum2.Text = "Quantum";
            // 
            // labelQuantum1
            // 
            this.labelQuantum1.AutoSize = true;
            this.labelQuantum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantum1.Location = new System.Drawing.Point(16, 104);
            this.labelQuantum1.Name = "labelQuantum1";
            this.labelQuantum1.Size = new System.Drawing.Size(66, 17);
            this.labelQuantum1.TabIndex = 23;
            this.labelQuantum1.Text = "Quantum";
            // 
            // labelPriorities1
            // 
            this.labelPriorities1.AutoSize = true;
            this.labelPriorities1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriorities1.Location = new System.Drawing.Point(16, 58);
            this.labelPriorities1.Name = "labelPriorities1";
            this.labelPriorities1.Size = new System.Drawing.Size(63, 17);
            this.labelPriorities1.TabIndex = 24;
            this.labelPriorities1.Text = "Priorities";
            // 
            // SchedulingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 381);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Button buttonAdd2;
        private System.Windows.Forms.Button buttonAdd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromiseTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFullTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.Label labelPriorities1;
        private System.Windows.Forms.Label labelQuantum1;
        private System.Windows.Forms.Label labelProcesses1;
        private System.Windows.Forms.Label labelQuantum2;
        private System.Windows.Forms.Label labelProcesses2;

    }
}

