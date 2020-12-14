namespace IRF_Project
{
    partial class Form1
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
            this.currSearch1 = new System.Windows.Forms.TextBox();
            this.currSearch2 = new System.Windows.Forms.TextBox();
            this.currList1 = new System.Windows.Forms.ListBox();
            this.currList2 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.currInput = new System.Windows.Forms.TextBox();
            this.currOutput = new System.Windows.Forms.TextBox();
            this.btnSavePastWeek = new System.Windows.Forms.Button();
            this.btnSavePastMonth = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnSavePastYear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currSearch1
            // 
            this.currSearch1.Location = new System.Drawing.Point(12, 12);
            this.currSearch1.MaxLength = 3;
            this.currSearch1.Name = "currSearch1";
            this.currSearch1.Size = new System.Drawing.Size(166, 22);
            this.currSearch1.TabIndex = 0;
            this.currSearch1.TextChanged += new System.EventHandler(this.currSearch1_TextChanged);
            // 
            // currSearch2
            // 
            this.currSearch2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currSearch2.Location = new System.Drawing.Point(622, 12);
            this.currSearch2.MaxLength = 3;
            this.currSearch2.Name = "currSearch2";
            this.currSearch2.Size = new System.Drawing.Size(166, 22);
            this.currSearch2.TabIndex = 1;
            this.currSearch2.TextChanged += new System.EventHandler(this.currSearch2_TextChanged);
            // 
            // currList1
            // 
            this.currList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.currList1.FormattingEnabled = true;
            this.currList1.ItemHeight = 16;
            this.currList1.Location = new System.Drawing.Point(12, 40);
            this.currList1.Name = "currList1";
            this.currList1.Size = new System.Drawing.Size(166, 404);
            this.currList1.TabIndex = 2;
            this.currList1.SelectedIndexChanged += new System.EventHandler(this.currList1_SelectedIndexChanged);
            // 
            // currList2
            // 
            this.currList2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currList2.FormattingEnabled = true;
            this.currList2.ItemHeight = 16;
            this.currList2.Location = new System.Drawing.Point(622, 40);
            this.currList2.Name = "currList2";
            this.currList2.Size = new System.Drawing.Size(166, 404);
            this.currList2.TabIndex = 3;
            this.currList2.SelectedIndexChanged += new System.EventHandler(this.currList2_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(273, 264);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // currInput
            // 
            this.currInput.Location = new System.Drawing.Point(281, 157);
            this.currInput.Name = "currInput";
            this.currInput.Size = new System.Drawing.Size(215, 22);
            this.currInput.TabIndex = 5;
            this.currInput.Text = "0";
            this.currInput.TextChanged += new System.EventHandler(this.currInput_TextChanged);
            // 
            // currOutput
            // 
            this.currOutput.Enabled = false;
            this.currOutput.Location = new System.Drawing.Point(285, 236);
            this.currOutput.Name = "currOutput";
            this.currOutput.Size = new System.Drawing.Size(211, 22);
            this.currOutput.TabIndex = 6;
            this.currOutput.Text = "0";
            this.currOutput.TextChanged += new System.EventHandler(this.currOutput_TextChanged);
            // 
            // btnSavePastWeek
            // 
            this.btnSavePastWeek.Location = new System.Drawing.Point(448, 370);
            this.btnSavePastWeek.Name = "btnSavePastWeek";
            this.btnSavePastWeek.Size = new System.Drawing.Size(124, 36);
            this.btnSavePastWeek.TabIndex = 8;
            this.btnSavePastWeek.Text = "Save Past Week";
            this.btnSavePastWeek.UseVisualStyleBackColor = true;
            this.btnSavePastWeek.Click += new System.EventHandler(this.btnSavePastWeek_Click);
            // 
            // btnSavePastMonth
            // 
            this.btnSavePastMonth.Location = new System.Drawing.Point(234, 355);
            this.btnSavePastMonth.Name = "btnSavePastMonth";
            this.btnSavePastMonth.Size = new System.Drawing.Size(135, 51);
            this.btnSavePastMonth.TabIndex = 7;
            this.btnSavePastMonth.Text = "btnSavePastMonth";
            this.btnSavePastMonth.UseVisualStyleBackColor = true;
            this.btnSavePastMonth.Click += new System.EventHandler(this.btnSavePastMonth_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(373, 307);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 9;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(527, 162);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(89, 21);
            this.lblInput.TabIndex = 10;
            this.lblInput.Text = "currency1";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(527, 236);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(89, 21);
            this.lblOutput.TabIndex = 11;
            this.lblOutput.Text = "currency2";
            // 
            // btnSavePastYear
            // 
            this.btnSavePastYear.Location = new System.Drawing.Point(345, 89);
            this.btnSavePastYear.Name = "btnSavePastYear";
            this.btnSavePastYear.Size = new System.Drawing.Size(75, 23);
            this.btnSavePastYear.TabIndex = 12;
            this.btnSavePastYear.Text = "button1";
            this.btnSavePastYear.UseVisualStyleBackColor = true;
            this.btnSavePastYear.Click += new System.EventHandler(this.btnSavePastYear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSavePastYear);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnSavePastWeek);
            this.Controls.Add(this.btnSavePastMonth);
            this.Controls.Add(this.currOutput);
            this.Controls.Add(this.currInput);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.currList2);
            this.Controls.Add(this.currList1);
            this.Controls.Add(this.currSearch2);
            this.Controls.Add(this.currSearch1);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currSearch1;
        private System.Windows.Forms.TextBox currSearch2;
        private System.Windows.Forms.ListBox currList1;
        private System.Windows.Forms.ListBox currList2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox currInput;
        private System.Windows.Forms.TextBox currOutput;
        private System.Windows.Forms.Button btnSavePastWeek;
        private System.Windows.Forms.Button btnSavePastMonth;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnSavePastYear;
    }
}

