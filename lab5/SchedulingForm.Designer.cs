using System.Drawing;
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelPriorities1 = new System.Windows.Forms.Label();
            this.labelQuantum1 = new System.Windows.Forms.Label();
            this.labelProcesses1 = new System.Windows.Forms.Label();
            this.buttonAdd1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonStop1 = new System.Windows.Forms.Button();
            this.cbAmountOfProcesses1 = new System.Windows.Forms.ComboBox();
            this.buttonStart1 = new System.Windows.Forms.Button();
            this.buttonLoad1 = new System.Windows.Forms.Button();
            this.cbPriotities = new System.Windows.Forms.ComboBox();
            this.cbQuantum1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.labelQuantum2 = new System.Windows.Forms.Label();
            this.labelProcesses2 = new System.Windows.Forms.Label();
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.buttonLoad2 = new System.Windows.Forms.Button();
            this.cbQuantum2 = new System.Windows.Forms.ComboBox();
            this.cbAmountOfProcesses2 = new System.Windows.Forms.ComboBox();
            this.buttonStop2 = new System.Windows.Forms.Button();
            this.buttonStart2 = new System.Windows.Forms.Button();
            this.progressBar2 = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Task1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullProcessTimeColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromiseTimeColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullTimeColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.labelPriorities1);
            this.splitContainer1.Panel1.Controls.Add(this.labelProcesses1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonStart1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonStop1);
            this.splitContainer1.Panel1.Controls.Add(this.labelQuantum1);
            this.splitContainer1.Panel1.Controls.Add(this.cbQuantum1);
            this.splitContainer1.Panel1.Controls.Add(this.cbPriotities);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonLoad1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAdd1);
            this.splitContainer1.Panel1.Controls.Add(this.cbAmountOfProcesses1);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.labelQuantum2);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar2);
            this.splitContainer1.Panel2.Controls.Add(this.labelProcesses2);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAdd2);
            this.splitContainer1.Panel2.Controls.Add(this.cbAmountOfProcesses2);
            this.splitContainer1.Panel2.Controls.Add(this.buttonLoad2);
            this.splitContainer1.Panel2.Controls.Add(this.buttonStop2);
            this.splitContainer1.Panel2.Controls.Add(this.cbQuantum2);
            this.splitContainer1.Panel2.Controls.Add(this.buttonStart2);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Size = new System.Drawing.Size(1053, 431);
            this.splitContainer1.SplitterDistance = 540;
            this.splitContainer1.TabIndex = 5;
            // 
            // labelPriorities1
            // 
            this.labelPriorities1.AutoSize = true;
            this.labelPriorities1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriorities1.Location = new System.Drawing.Point(13, 68);
            this.labelPriorities1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPriorities1.Name = "labelPriorities1";
            this.labelPriorities1.Size = new System.Drawing.Size(80, 22);
            this.labelPriorities1.TabIndex = 24;
            this.labelPriorities1.Text = "Priorities";
            // 
            // labelQuantum1
            // 
            this.labelQuantum1.AutoSize = true;
            this.labelQuantum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantum1.Location = new System.Drawing.Point(13, 125);
            this.labelQuantum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantum1.Name = "labelQuantum1";
            this.labelQuantum1.Size = new System.Drawing.Size(83, 22);
            this.labelQuantum1.TabIndex = 23;
            this.labelQuantum1.Text = "Quantum";
            // 
            // labelProcesses1
            // 
            this.labelProcesses1.AutoSize = true;
            this.labelProcesses1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcesses1.Location = new System.Drawing.Point(13, 12);
            this.labelProcesses1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProcesses1.Name = "labelProcesses1";
            this.labelProcesses1.Size = new System.Drawing.Size(94, 22);
            this.labelProcesses1.TabIndex = 20;
            this.labelProcesses1.Text = "Processes";
            // 
            // buttonAdd1
            // 
            this.buttonAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd1.Location = new System.Drawing.Point(8, 267);
            this.buttonAdd1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd1.Name = "buttonAdd1";
            this.buttonAdd1.Size = new System.Drawing.Size(92, 41);
            this.buttonAdd1.TabIndex = 19;
            this.buttonAdd1.Text = "Add";
            this.buttonAdd1.UseVisualStyleBackColor = true;
            this.buttonAdd1.Click += new System.EventHandler(this.buttonAdd1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task1,
            this.Time1,
            this.ProcessPriority,
            this.FullProcessTimeColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(115, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(387, 337);
            this.dataGridView1.TabIndex = 3;
            // 
            // buttonStop1
            // 
            this.buttonStop1.Enabled = false;
            this.buttonStop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop1.Location = new System.Drawing.Point(45, 374);
            this.buttonStop1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStop1.Name = "buttonStop1";
            this.buttonStop1.Size = new System.Drawing.Size(220, 44);
            this.buttonStop1.TabIndex = 8;
            this.buttonStop1.Text = "Stop";
            this.buttonStop1.UseVisualStyleBackColor = true;
            this.buttonStop1.Click += new System.EventHandler(this.buttonStop1_Click);
            // 
            // cbAmountOfProcesses1
            // 
            this.cbAmountOfProcesses1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmountOfProcesses1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAmountOfProcesses1.FormattingEnabled = true;
            this.cbAmountOfProcesses1.Location = new System.Drawing.Point(21, 36);
            this.cbAmountOfProcesses1.Margin = new System.Windows.Forms.Padding(4);
            this.cbAmountOfProcesses1.Name = "cbAmountOfProcesses1";
            this.cbAmountOfProcesses1.Size = new System.Drawing.Size(61, 28);
            this.cbAmountOfProcesses1.TabIndex = 0;
            // 
            // buttonStart1
            // 
            this.buttonStart1.Enabled = false;
            this.buttonStart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart1.Location = new System.Drawing.Point(282, 374);
            this.buttonStart1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart1.Name = "buttonStart1";
            this.buttonStart1.Size = new System.Drawing.Size(220, 44);
            this.buttonStart1.TabIndex = 6;
            this.buttonStart1.Text = "Start";
            this.buttonStart1.UseVisualStyleBackColor = true;
            this.buttonStart1.Click += new System.EventHandler(this.buttonStart1_Click);
            // 
            // buttonLoad1
            // 
            this.buttonLoad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad1.Location = new System.Drawing.Point(8, 200);
            this.buttonLoad1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoad1.Name = "buttonLoad1";
            this.buttonLoad1.Size = new System.Drawing.Size(92, 41);
            this.buttonLoad1.TabIndex = 5;
            this.buttonLoad1.Text = "Load";
            this.buttonLoad1.UseVisualStyleBackColor = true;
            this.buttonLoad1.Click += new System.EventHandler(this.buttonLoad1_Click);
            // 
            // cbPriotities
            // 
            this.cbPriotities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriotities.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPriotities.FormattingEnabled = true;
            this.cbPriotities.Location = new System.Drawing.Point(21, 93);
            this.cbPriotities.Margin = new System.Windows.Forms.Padding(4);
            this.cbPriotities.Name = "cbPriotities";
            this.cbPriotities.Size = new System.Drawing.Size(61, 28);
            this.cbPriotities.TabIndex = 1;
            // 
            // cbQuantum1
            // 
            this.cbQuantum1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbQuantum1.FormattingEnabled = true;
            this.cbQuantum1.Location = new System.Drawing.Point(21, 150);
            this.cbQuantum1.Margin = new System.Windows.Forms.Padding(4);
            this.cbQuantum1.Name = "cbQuantum1";
            this.cbQuantum1.Size = new System.Drawing.Size(61, 28);
            this.cbQuantum1.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.BarOffset = 1;
            this.progressBar1.Caption = "0";
            this.progressBar1.CaptionColor = System.Drawing.Color.DarkBlue;
            this.progressBar1.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.Custom;
            this.progressBar1.CaptionShadowColor = System.Drawing.Color.White;
            this.progressBar1.ChangeByMouse = false;
            this.progressBar1.DashSpace = 2;
            this.progressBar1.DashWidth = 5;
            this.progressBar1.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.None;
            this.progressBar1.EdgeColor = System.Drawing.Color.Gray;
            this.progressBar1.EdgeLightColor = System.Drawing.Color.LightGray;
            this.progressBar1.EdgeWidth = 1;
            this.progressBar1.FloodPercentage = 0.2F;
            this.progressBar1.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.progressBar1.Invert = false;
            this.progressBar1.Location = new System.Drawing.Point(418, 12);
            this.progressBar1.MainColor = System.Drawing.Color.Gold;
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Maximum = 100;
            this.progressBar1.Minimum = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Vertical;
            this.progressBar1.ProgressBackColor = System.Drawing.Color.AliceBlue;
            this.progressBar1.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Dashed;
            this.progressBar1.SecondColor = System.Drawing.Color.White;
            this.progressBar1.Shadow = true;
            this.progressBar1.ShadowOffset = 1;
            this.progressBar1.Size = new System.Drawing.Size(73, 330);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 25;
            this.progressBar1.TextAntialias = true;
            this.progressBar1.Value = 0;
            // 
            // labelQuantum2
            // 
            this.labelQuantum2.AutoSize = true;
            this.labelQuantum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantum2.Location = new System.Drawing.Point(397, 74);
            this.labelQuantum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantum2.Name = "labelQuantum2";
            this.labelQuantum2.Size = new System.Drawing.Size(83, 22);
            this.labelQuantum2.TabIndex = 22;
            this.labelQuantum2.Text = "Quantum";
            // 
            // labelProcesses2
            // 
            this.labelProcesses2.AutoSize = true;
            this.labelProcesses2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcesses2.Location = new System.Drawing.Point(396, 16);
            this.labelProcesses2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProcesses2.Name = "labelProcesses2";
            this.labelProcesses2.Size = new System.Drawing.Size(94, 22);
            this.labelProcesses2.TabIndex = 21;
            this.labelProcesses2.Text = "Processes";
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd2.Location = new System.Drawing.Point(397, 215);
            this.buttonAdd2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(98, 41);
            this.buttonAdd2.TabIndex = 18;
            this.buttonAdd2.Text = "Add";
            this.buttonAdd2.UseVisualStyleBackColor = true;
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // buttonLoad2
            // 
            this.buttonLoad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad2.Location = new System.Drawing.Point(397, 151);
            this.buttonLoad2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoad2.Name = "buttonLoad2";
            this.buttonLoad2.Size = new System.Drawing.Size(98, 39);
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
            this.cbQuantum2.Location = new System.Drawing.Point(410, 95);
            this.cbQuantum2.Margin = new System.Windows.Forms.Padding(4);
            this.cbQuantum2.Name = "cbQuantum2";
            this.cbQuantum2.Size = new System.Drawing.Size(71, 28);
            this.cbQuantum2.TabIndex = 16;
            // 
            // cbAmountOfProcesses2
            // 
            this.cbAmountOfProcesses2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmountOfProcesses2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAmountOfProcesses2.FormattingEnabled = true;
            this.cbAmountOfProcesses2.Location = new System.Drawing.Point(411, 39);
            this.cbAmountOfProcesses2.Margin = new System.Windows.Forms.Padding(4);
            this.cbAmountOfProcesses2.Name = "cbAmountOfProcesses2";
            this.cbAmountOfProcesses2.Size = new System.Drawing.Size(71, 28);
            this.cbAmountOfProcesses2.TabIndex = 14;
            // 
            // buttonStop2
            // 
            this.buttonStop2.Enabled = false;
            this.buttonStop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop2.Location = new System.Drawing.Point(7, 372);
            this.buttonStop2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStop2.Name = "buttonStop2";
            this.buttonStop2.Size = new System.Drawing.Size(220, 46);
            this.buttonStop2.TabIndex = 13;
            this.buttonStop2.Text = "Stop";
            this.buttonStop2.UseVisualStyleBackColor = true;
            this.buttonStop2.Click += new System.EventHandler(this.buttonStop2_Click);
            // 
            // buttonStart2
            // 
            this.buttonStart2.Enabled = false;
            this.buttonStart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart2.Location = new System.Drawing.Point(235, 372);
            this.buttonStart2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart2.Name = "buttonStart2";
            this.buttonStart2.Size = new System.Drawing.Size(220, 46);
            this.buttonStart2.TabIndex = 13;
            this.buttonStart2.Text = "Start";
            this.buttonStart2.UseVisualStyleBackColor = true;
            this.buttonStart2.Click += new System.EventHandler(this.buttonStart2_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.BarOffset = 1;
            this.progressBar2.Caption = "0";
            this.progressBar2.CaptionColor = System.Drawing.Color.DarkBlue;
            this.progressBar2.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.Custom;
            this.progressBar2.CaptionShadowColor = System.Drawing.Color.White;
            this.progressBar2.ChangeByMouse = false;
            this.progressBar2.DashSpace = 2;
            this.progressBar2.DashWidth = 5;
            this.progressBar2.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.None;
            this.progressBar2.EdgeColor = System.Drawing.Color.Gray;
            this.progressBar2.EdgeLightColor = System.Drawing.Color.LightGray;
            this.progressBar2.EdgeWidth = 1;
            this.progressBar2.FloodPercentage = 0.2F;
            this.progressBar2.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.progressBar2.Invert = false;
            this.progressBar2.Location = new System.Drawing.Point(292, 12);
            this.progressBar2.MainColor = System.Drawing.Color.Gold;
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar2.Maximum = 100;
            this.progressBar2.Minimum = 0;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Vertical;
            this.progressBar2.ProgressBackColor = System.Drawing.Color.AliceBlue;
            this.progressBar2.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Dashed;
            this.progressBar2.SecondColor = System.Drawing.Color.White;
            this.progressBar2.Shadow = true;
            this.progressBar2.ShadowOffset = 1;
            this.progressBar2.Size = new System.Drawing.Size(69, 333);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 13;
            this.progressBar2.TextAntialias = true;
            this.progressBar2.Value = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskColumn2,
            this.TimeColumn2,
            this.PromiseTimeColumn2,
            this.FullTimeColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(23, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 15;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(348, 345);
            this.dataGridView2.TabIndex = 3;
            // 
            // Task1
            // 
            this.Task1.HeaderText = "Task";
            this.Task1.Name = "Task1";
            this.Task1.ReadOnly = true;
            this.Task1.Width = 50;
            // 
            // Time1
            // 
            this.Time1.HeaderText = "Time";
            this.Time1.Name = "Time1";
            this.Time1.Width = 50;
            // 
            // ProcessPriority
            // 
            this.ProcessPriority.HeaderText = "Process Priority";
            this.ProcessPriority.Name = "ProcessPriority";
            this.ProcessPriority.Width = 70;
            // 
            // FullProcessTimeColumn1
            // 
            this.FullProcessTimeColumn1.HeaderText = "Full Time";
            this.FullProcessTimeColumn1.Name = "FullProcessTimeColumn1";
            this.FullProcessTimeColumn1.Visible = false;
            // 
            // TaskColumn2
            // 
            this.TaskColumn2.HeaderText = "Task";
            this.TaskColumn2.Name = "TaskColumn2";
            this.TaskColumn2.ReadOnly = true;
            this.TaskColumn2.Width = 50;
            // 
            // TimeColumn2
            // 
            this.TimeColumn2.HeaderText = "Time";
            this.TimeColumn2.Name = "TimeColumn2";
            this.TimeColumn2.Width = 50;
            // 
            // PromiseTimeColumn2
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.PromiseTimeColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.PromiseTimeColumn2.HeaderText = "PromiseTime";
            this.PromiseTimeColumn2.Name = "PromiseTimeColumn2";
            this.PromiseTimeColumn2.Width = 70;
            // 
            // FullTimeColumn2
            // 
            this.FullTimeColumn2.HeaderText = "Full";
            this.FullTimeColumn2.Name = "FullTimeColumn2";
            this.FullTimeColumn2.Visible = false;
            // 
            // SchedulingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 431);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SchedulingForm";
            this.Text = "Scheduling";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonLoad2;
        private System.Windows.Forms.ComboBox cbQuantum2;
        private System.Windows.Forms.ComboBox cbAmountOfProcesses2;
        private System.Windows.Forms.Button buttonStop2;
        private System.Windows.Forms.Button buttonStart2;
        private ExtendedDotNET.Controls.Progress.ProgressBar progressBar2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonAdd2;
        private System.Windows.Forms.Label labelQuantum2;
        private System.Windows.Forms.Label labelProcesses2;
        private System.Windows.Forms.Label labelPriorities1;
        private System.Windows.Forms.Label labelQuantum1;
        private System.Windows.Forms.Label labelProcesses1;
        private System.Windows.Forms.Button buttonAdd1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonStop1;
        private System.Windows.Forms.ComboBox cbAmountOfProcesses1;
        private System.Windows.Forms.Button buttonStart1;
        private System.Windows.Forms.Button buttonLoad1;
        private System.Windows.Forms.ComboBox cbPriotities;
        private System.Windows.Forms.ComboBox cbQuantum1;
        private ExtendedDotNET.Controls.Progress.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullProcessTimeColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromiseTimeColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullTimeColumn2;
    }
}

