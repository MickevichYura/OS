namespace lab2
{
    partial class FormMutualExclusion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMutualExclusion));
            this.buttonStartP0 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.buttonFinishP0 = new System.Windows.Forms.Button();
            this.rbStrictAlternation = new System.Windows.Forms.RadioButton();
            this.rbPetersonAlgorithm = new System.Windows.Forms.RadioButton();
            this.buttonStartP1 = new System.Windows.Forms.Button();
            this.buttonFinishP1 = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelAlgorithm = new System.Windows.Forms.Label();
            this.tbOutput0 = new System.Windows.Forms.RichTextBox();
            this.tbOutput1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonStartP0
            // 
            this.buttonStartP0.Enabled = false;
            this.buttonStartP0.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartP0.Location = new System.Drawing.Point(241, 67);
            this.buttonStartP0.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonStartP0.Name = "buttonStartP0";
            this.buttonStartP0.Size = new System.Drawing.Size(104, 50);
            this.buttonStartP0.TabIndex = 2;
            this.buttonStartP0.Text = "Start P0";
            this.buttonStartP0.UseVisualStyleBackColor = true;
            this.buttonStartP0.Click += new System.EventHandler(this.StartP0button_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(480, 75);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(117, 97);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.Clear);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.Location = new System.Drawing.Point(357, 23);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(94, 30);
            this.InputTextBox.TabIndex = 8;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // buttonFinishP0
            // 
            this.buttonFinishP0.Enabled = false;
            this.buttonFinishP0.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFinishP0.Location = new System.Drawing.Point(241, 129);
            this.buttonFinishP0.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonFinishP0.Name = "buttonFinishP0";
            this.buttonFinishP0.Size = new System.Drawing.Size(104, 50);
            this.buttonFinishP0.TabIndex = 9;
            this.buttonFinishP0.Text = "Finish P0";
            this.buttonFinishP0.UseVisualStyleBackColor = true;
            this.buttonFinishP0.Click += new System.EventHandler(this.FinishP0button_Click);
            // 
            // rbStrictAlternation
            // 
            this.rbStrictAlternation.AutoSize = true;
            this.rbStrictAlternation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbStrictAlternation.Location = new System.Drawing.Point(13, 69);
            this.rbStrictAlternation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rbStrictAlternation.Name = "rbStrictAlternation";
            this.rbStrictAlternation.Size = new System.Drawing.Size(175, 27);
            this.rbStrictAlternation.TabIndex = 10;
            this.rbStrictAlternation.TabStop = true;
            this.rbStrictAlternation.Text = "Strict Alternation";
            this.rbStrictAlternation.UseVisualStyleBackColor = true;
            this.rbStrictAlternation.CheckedChanged += new System.EventHandler(this.ChooseAlgorithm);
            // 
            // rbPetersonAlgorithm
            // 
            this.rbPetersonAlgorithm.AutoSize = true;
            this.rbPetersonAlgorithm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbPetersonAlgorithm.Location = new System.Drawing.Point(13, 109);
            this.rbPetersonAlgorithm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rbPetersonAlgorithm.Name = "rbPetersonAlgorithm";
            this.rbPetersonAlgorithm.Size = new System.Drawing.Size(216, 27);
            this.rbPetersonAlgorithm.TabIndex = 11;
            this.rbPetersonAlgorithm.TabStop = true;
            this.rbPetersonAlgorithm.Text = "Peterson’s algorithm ";
            this.rbPetersonAlgorithm.UseVisualStyleBackColor = true;
            this.rbPetersonAlgorithm.CheckedChanged += new System.EventHandler(this.ChooseAlgorithm);
            // 
            // buttonStartP1
            // 
            this.buttonStartP1.Enabled = false;
            this.buttonStartP1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartP1.Location = new System.Drawing.Point(353, 67);
            this.buttonStartP1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonStartP1.Name = "buttonStartP1";
            this.buttonStartP1.Size = new System.Drawing.Size(104, 48);
            this.buttonStartP1.TabIndex = 12;
            this.buttonStartP1.Text = "Start P1";
            this.buttonStartP1.UseVisualStyleBackColor = true;
            this.buttonStartP1.Click += new System.EventHandler(this.StartP1button_Click);
            // 
            // buttonFinishP1
            // 
            this.buttonFinishP1.Enabled = false;
            this.buttonFinishP1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFinishP1.Location = new System.Drawing.Point(353, 129);
            this.buttonFinishP1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonFinishP1.Name = "buttonFinishP1";
            this.buttonFinishP1.Size = new System.Drawing.Size(104, 50);
            this.buttonFinishP1.TabIndex = 13;
            this.buttonFinishP1.Text = "Finish P1";
            this.buttonFinishP1.UseVisualStyleBackColor = true;
            this.buttonFinishP1.Click += new System.EventHandler(this.FinishP1button_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInput.Location = new System.Drawing.Point(220, 23);
            this.labelInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(127, 23);
            this.labelInput.TabIndex = 14;
            this.labelInput.Text = "Input symbol:";
            // 
            // labelAlgorithm
            // 
            this.labelAlgorithm.AutoSize = true;
            this.labelAlgorithm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlgorithm.Location = new System.Drawing.Point(13, 31);
            this.labelAlgorithm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlgorithm.Name = "labelAlgorithm";
            this.labelAlgorithm.Size = new System.Drawing.Size(169, 23);
            this.labelAlgorithm.TabIndex = 15;
            this.labelAlgorithm.Text = "Choose algorithm:";
            // 
            // tbOutput0
            // 
            this.tbOutput0.BackColor = System.Drawing.SystemColors.Menu;
            this.tbOutput0.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutput0.ForeColor = System.Drawing.Color.Black;
            this.tbOutput0.Location = new System.Drawing.Point(13, 199);
            this.tbOutput0.Name = "tbOutput0";
            this.tbOutput0.ReadOnly = true;
            this.tbOutput0.Size = new System.Drawing.Size(359, 282);
            this.tbOutput0.TabIndex = 17;
            this.tbOutput0.Text = "";
            // 
            // tbOutput1
            // 
            this.tbOutput1.BackColor = System.Drawing.SystemColors.Menu;
            this.tbOutput1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutput1.ForeColor = System.Drawing.Color.Black;
            this.tbOutput1.Location = new System.Drawing.Point(394, 199);
            this.tbOutput1.Name = "tbOutput1";
            this.tbOutput1.ReadOnly = true;
            this.tbOutput1.Size = new System.Drawing.Size(330, 282);
            this.tbOutput1.TabIndex = 18;
            this.tbOutput1.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 491);
            this.Controls.Add(this.tbOutput1);
            this.Controls.Add(this.tbOutput0);
            this.Controls.Add(this.labelAlgorithm);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.buttonFinishP1);
            this.Controls.Add(this.buttonStartP1);
            this.Controls.Add(this.rbPetersonAlgorithm);
            this.Controls.Add(this.rbStrictAlternation);
            this.Controls.Add(this.buttonFinishP0);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonStartP0);
            this.Font = new System.Drawing.Font("Segoe Print", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mutual Exclusion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartP0;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button buttonFinishP0;
        private System.Windows.Forms.RadioButton rbStrictAlternation;
        private System.Windows.Forms.RadioButton rbPetersonAlgorithm;
        private System.Windows.Forms.Button buttonStartP1;
        private System.Windows.Forms.Button buttonFinishP1;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelAlgorithm;
        private System.Windows.Forms.RichTextBox tbOutput0;
        private System.Windows.Forms.RichTextBox tbOutput1;
    }
}

