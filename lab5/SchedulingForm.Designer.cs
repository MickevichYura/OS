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
            this.cbAmountOfProcesses1 = new System.Windows.Forms.ComboBox();
            this.cbPriotities = new System.Windows.Forms.ComboBox();
            this.cbQuantum1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_Load = new System.Windows.Forms.Button();
            this.B_start = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.B_STOP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cbQuantum2 = new System.Windows.Forms.ComboBox();
            this.cbTickets = new System.Windows.Forms.ComboBox();
            this.cbAmountOfProcesses2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar22 = new System.Windows.Forms.ProgressBar();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAmountOfProcesses1
            // 
            this.cbAmountOfProcesses1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmountOfProcesses1.FormattingEnabled = true;
            this.cbAmountOfProcesses1.Location = new System.Drawing.Point(16, 42);
            this.cbAmountOfProcesses1.Margin = new System.Windows.Forms.Padding(4);
            this.cbAmountOfProcesses1.Name = "cbAmountOfProcesses1";
            this.cbAmountOfProcesses1.Size = new System.Drawing.Size(61, 24);
            this.cbAmountOfProcesses1.TabIndex = 0;
            // 
            // cbPriotities
            // 
            this.cbPriotities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriotities.FormattingEnabled = true;
            this.cbPriotities.Location = new System.Drawing.Point(16, 103);
            this.cbPriotities.Margin = new System.Windows.Forms.Padding(4);
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
            this.cbQuantum1.Location = new System.Drawing.Point(16, 160);
            this.cbQuantum1.Margin = new System.Windows.Forms.Padding(4);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(344, 364);
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
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(109, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 458);
            this.panel1.TabIndex = 4;
            // 
            // B_Load
            // 
            this.B_Load.Location = new System.Drawing.Point(16, 214);
            this.B_Load.Margin = new System.Windows.Forms.Padding(4);
            this.B_Load.Name = "B_Load";
            this.B_Load.Size = new System.Drawing.Size(63, 28);
            this.B_Load.TabIndex = 5;
            this.B_Load.Text = "Create";
            this.B_Load.UseVisualStyleBackColor = true;
            this.B_Load.Click += new System.EventHandler(this.B_Load_Click);
            // 
            // B_start
            // 
            this.B_start.Enabled = false;
            this.B_start.Location = new System.Drawing.Point(343, 427);
            this.B_start.Margin = new System.Windows.Forms.Padding(4);
            this.B_start.Name = "B_start";
            this.B_start.Size = new System.Drawing.Size(220, 28);
            this.B_start.TabIndex = 6;
            this.B_start.Text = "Start!";
            this.B_start.UseVisualStyleBackColor = true;
            this.B_start.Click += new System.EventHandler(this.B_start_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(109, 390);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(453, 28);
            this.progressBar1.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // B_STOP
            // 
            this.B_STOP.Enabled = false;
            this.B_STOP.Location = new System.Drawing.Point(109, 427);
            this.B_STOP.Margin = new System.Windows.Forms.Padding(4);
            this.B_STOP.Name = "B_STOP";
            this.B_STOP.Size = new System.Drawing.Size(220, 28);
            this.B_STOP.TabIndex = 8;
            this.B_STOP.Text = "STOP";
            this.B_STOP.UseVisualStyleBackColor = true;
            this.B_STOP.Click += new System.EventHandler(this.B_STOP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.cbQuantum2);
            this.panel2.Controls.Add(this.cbTickets);
            this.panel2.Controls.Add(this.cbAmountOfProcesses2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.progressBar22);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(731, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 454);
            this.panel2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(620, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.MaximumSize = new System.Drawing.Size(267, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 48);
            this.label5.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 383);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 384);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(627, 196);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 28);
            this.button3.TabIndex = 17;
            this.button3.Text = "Create";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.cbQuantum2.Location = new System.Drawing.Point(627, 142);
            this.cbQuantum2.Margin = new System.Windows.Forms.Padding(4);
            this.cbQuantum2.Name = "cbQuantum2";
            this.cbQuantum2.Size = new System.Drawing.Size(61, 24);
            this.cbQuantum2.TabIndex = 16;
            // 
            // cbTickets
            // 
            this.cbTickets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTickets.FormattingEnabled = true;
            this.cbTickets.Location = new System.Drawing.Point(627, 85);
            this.cbTickets.Margin = new System.Windows.Forms.Padding(4);
            this.cbTickets.Name = "cbTickets";
            this.cbTickets.Size = new System.Drawing.Size(61, 24);
            this.cbTickets.TabIndex = 15;
            // 
            // cbAmountOfProcesses2
            // 
            this.cbAmountOfProcesses2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmountOfProcesses2.FormattingEnabled = true;
            this.cbAmountOfProcesses2.Location = new System.Drawing.Point(627, 23);
            this.cbAmountOfProcesses2.Margin = new System.Windows.Forms.Padding(4);
            this.cbAmountOfProcesses2.Name = "cbAmountOfProcesses2";
            this.cbAmountOfProcesses2.Size = new System.Drawing.Size(61, 24);
            this.cbAmountOfProcesses2.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(3, 409);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "STOP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(235, 409);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Start!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar22
            // 
            this.progressBar22.Location = new System.Drawing.Point(4, 378);
            this.progressBar22.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar22.Name = "progressBar22";
            this.progressBar22.Size = new System.Drawing.Size(449, 28);
            this.progressBar22.TabIndex = 13;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.promise});
            this.dataGridView2.Location = new System.Drawing.Point(0, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(619, 364);
            this.dataGridView2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 396);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 12;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Priority";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // promise
            // 
            this.promise.HeaderText = "promise";
            this.promise.Name = "promise";
            // 
            // SchedulingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 469);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_STOP);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.B_start);
            this.Controls.Add(this.B_Load);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbQuantum1);
            this.Controls.Add(this.cbPriotities);
            this.Controls.Add(this.cbAmountOfProcesses1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SchedulingForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAmountOfProcesses1;
        private System.Windows.Forms.ComboBox cbPriotities;
        private System.Windows.Forms.ComboBox cbQuantum1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B_Load;
        private System.Windows.Forms.Button B_start;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button B_STOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar22;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbQuantum2;
        private System.Windows.Forms.ComboBox cbTickets;
        private System.Windows.Forms.ComboBox cbAmountOfProcesses2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn promise;

    }
}

