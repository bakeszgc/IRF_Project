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
            this.currList1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currSearch1
            // 
            this.currSearch1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currSearch1.Location = new System.Drawing.Point(11, 11);
            this.currSearch1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currSearch1.MaxLength = 3;
            this.currSearch1.Name = "currSearch1";
            this.currSearch1.Size = new System.Drawing.Size(120, 21);
            this.currSearch1.TabIndex = 0;
            this.currSearch1.TextChanged += new System.EventHandler(this.currSearch1_TextChanged);
            // 
            // currSearch2
            // 
            this.currSearch2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currSearch2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currSearch2.Location = new System.Drawing.Point(736, 11);
            this.currSearch2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currSearch2.MaxLength = 3;
            this.currSearch2.Name = "currSearch2";
            this.currSearch2.Size = new System.Drawing.Size(120, 21);
            this.currSearch2.TabIndex = 1;
            this.currSearch2.TextChanged += new System.EventHandler(this.currSearch2_TextChanged);
            // 
            // currList2
            // 
            this.currList2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currList2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currList2.FormattingEnabled = true;
            this.currList2.ItemHeight = 16;
            this.currList2.Location = new System.Drawing.Point(736, 42);
            this.currList2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currList2.Name = "currList2";
            this.currList2.Size = new System.Drawing.Size(120, 372);
            this.currList2.TabIndex = 3;
            this.currList2.SelectedIndexChanged += new System.EventHandler(this.currList2_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 251);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // currInput
            // 
            this.currInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currInput.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currInput.Location = new System.Drawing.Point(201, 42);
            this.currInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currInput.Name = "currInput";
            this.currInput.Size = new System.Drawing.Size(314, 86);
            this.currInput.TabIndex = 5;
            this.currInput.Text = "0";
            this.currInput.TextChanged += new System.EventHandler(this.currInput_TextChanged);
            // 
            // currOutput
            // 
            this.currOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currOutput.Enabled = false;
            this.currOutput.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currOutput.Location = new System.Drawing.Point(201, 137);
            this.currOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currOutput.Name = "currOutput";
            this.currOutput.Size = new System.Drawing.Size(314, 86);
            this.currOutput.TabIndex = 6;
            this.currOutput.Text = "0";
            this.currOutput.TextChanged += new System.EventHandler(this.currOutput_TextChanged);
            // 
            // btnSavePastWeek
            // 
            this.btnSavePastWeek.FlatAppearance.BorderSize = 0;
            this.btnSavePastWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePastWeek.ForeColor = System.Drawing.Color.White;
            this.btnSavePastWeek.Location = new System.Drawing.Point(213, 349);
            this.btnSavePastWeek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSavePastWeek.Name = "btnSavePastWeek";
            this.btnSavePastWeek.Size = new System.Drawing.Size(123, 54);
            this.btnSavePastWeek.TabIndex = 8;
            this.btnSavePastWeek.Text = "Save Past Week";
            this.btnSavePastWeek.UseVisualStyleBackColor = true;
            this.btnSavePastWeek.Click += new System.EventHandler(this.btnSavePastWeek_Click);
            this.btnSavePastWeek.MouseEnter += new System.EventHandler(this.btnSavePastWeek_MouseEnter);
            this.btnSavePastWeek.MouseLeave += new System.EventHandler(this.btnSavePastWeek_MouseLeave);
            // 
            // btnSavePastMonth
            // 
            this.btnSavePastMonth.FlatAppearance.BorderSize = 0;
            this.btnSavePastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePastMonth.ForeColor = System.Drawing.Color.White;
            this.btnSavePastMonth.Location = new System.Drawing.Point(352, 340);
            this.btnSavePastMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSavePastMonth.Name = "btnSavePastMonth";
            this.btnSavePastMonth.Size = new System.Drawing.Size(119, 58);
            this.btnSavePastMonth.TabIndex = 7;
            this.btnSavePastMonth.Text = "btnSavePastMonth";
            this.btnSavePastMonth.UseVisualStyleBackColor = true;
            this.btnSavePastMonth.Click += new System.EventHandler(this.btnSavePastMonth_Click);
            this.btnSavePastMonth.MouseEnter += new System.EventHandler(this.btnSavePastMonth_MouseEnter);
            this.btnSavePastMonth.MouseLeave += new System.EventHandler(this.btnSavePastMonth_MouseLeave);
            // 
            // btnReverse
            // 
            this.btnReverse.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnReverse.Location = new System.Drawing.Point(441, 268);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(74, 48);
            this.btnReverse.TabIndex = 9;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // lblInput
            // 
            this.lblInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInput.ForeColor = System.Drawing.Color.White;
            this.lblInput.Location = new System.Drawing.Point(531, 46);
            this.lblInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(149, 78);
            this.lblInput.TabIndex = 10;
            this.lblInput.Text = "HUF";
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(531, 141);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(147, 78);
            this.lblOutput.TabIndex = 11;
            this.lblOutput.Text = "EUR";
            // 
            // btnSavePastYear
            // 
            this.btnSavePastYear.FlatAppearance.BorderSize = 0;
            this.btnSavePastYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePastYear.ForeColor = System.Drawing.Color.White;
            this.btnSavePastYear.Location = new System.Drawing.Point(518, 349);
            this.btnSavePastYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSavePastYear.Name = "btnSavePastYear";
            this.btnSavePastYear.Size = new System.Drawing.Size(110, 40);
            this.btnSavePastYear.TabIndex = 12;
            this.btnSavePastYear.Text = "btnSavePastYear";
            this.btnSavePastYear.UseVisualStyleBackColor = true;
            this.btnSavePastYear.Click += new System.EventHandler(this.btnSavePastYear_Click);
            this.btnSavePastYear.MouseEnter += new System.EventHandler(this.btnSavePastYear_MouseEnter);
            this.btnSavePastYear.MouseLeave += new System.EventHandler(this.btnSavePastYear_MouseLeave);
            // 
            // currList1
            // 
            this.currList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.currList1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currList1.FormattingEnabled = true;
            this.currList1.ItemHeight = 16;
            this.currList1.Location = new System.Drawing.Point(11, 42);
            this.currList1.Name = "currList1";
            this.currList1.Size = new System.Drawing.Size(120, 372);
            this.currList1.TabIndex = 13;
            this.currList1.SelectedIndexChanged += new System.EventHandler(this.currList1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(107, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(832, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(867, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currList1);
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
            this.Controls.Add(this.currSearch2);
            this.Controls.Add(this.currSearch1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(620, 420);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currSearch1;
        private System.Windows.Forms.TextBox currSearch2;
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
        private System.Windows.Forms.ListBox currList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

