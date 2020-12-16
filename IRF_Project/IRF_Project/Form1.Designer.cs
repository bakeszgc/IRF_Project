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
            this.components = new System.ComponentModel.Container();
            this.currSearch1 = new System.Windows.Forms.TextBox();
            this.currSearch2 = new System.Windows.Forms.TextBox();
            this.currList2 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.currInput = new System.Windows.Forms.TextBox();
            this.currOutput = new System.Windows.Forms.TextBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.currList1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tWeekUp = new System.Windows.Forms.Timer(this.components);
            this.tWeekDown = new System.Windows.Forms.Timer(this.components);
            this.tMonthUp = new System.Windows.Forms.Timer(this.components);
            this.tMonthDown = new System.Windows.Forms.Timer(this.components);
            this.tYearUp = new System.Windows.Forms.Timer(this.components);
            this.tYearDown = new System.Windows.Forms.Timer(this.components);
            this.btnSavePastMonth = new IRF_Project.Entities.SaveButton();
            this.btnSavePastWeek = new IRF_Project.Entities.SaveButton();
            this.btnSavePastYear = new IRF_Project.Entities.SaveButton();
            this.SuspendLayout();
            // 
            // currSearch1
            // 
            this.currSearch1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currSearch1.Location = new System.Drawing.Point(15, 14);
            this.currSearch1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currSearch1.MaxLength = 3;
            this.currSearch1.Name = "currSearch1";
            this.currSearch1.Size = new System.Drawing.Size(159, 24);
            this.currSearch1.TabIndex = 0;
            this.currSearch1.TextChanged += new System.EventHandler(this.currSearch1_TextChanged);
            // 
            // currSearch2
            // 
            this.currSearch2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currSearch2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currSearch2.Location = new System.Drawing.Point(981, 14);
            this.currSearch2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currSearch2.MaxLength = 3;
            this.currSearch2.Name = "currSearch2";
            this.currSearch2.Size = new System.Drawing.Size(159, 24);
            this.currSearch2.TabIndex = 1;
            this.currSearch2.TextChanged += new System.EventHandler(this.currSearch2_TextChanged);
            // 
            // currList2
            // 
            this.currList2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currList2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currList2.FormattingEnabled = true;
            this.currList2.ItemHeight = 19;
            this.currList2.Location = new System.Drawing.Point(981, 52);
            this.currList2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currList2.Name = "currList2";
            this.currList2.Size = new System.Drawing.Size(159, 441);
            this.currList2.TabIndex = 3;
            this.currList2.SelectedIndexChanged += new System.EventHandler(this.currList2_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 308);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(635, 44);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // currInput
            // 
            this.currInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currInput.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currInput.Location = new System.Drawing.Point(268, 57);
            this.currInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currInput.Name = "currInput";
            this.currInput.Size = new System.Drawing.Size(417, 106);
            this.currInput.TabIndex = 5;
            this.currInput.Text = "0";
            this.currInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.currInput.TextChanged += new System.EventHandler(this.currInput_TextChanged);
            // 
            // currOutput
            // 
            this.currOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currOutput.Enabled = false;
            this.currOutput.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currOutput.Location = new System.Drawing.Point(268, 174);
            this.currOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currOutput.Name = "currOutput";
            this.currOutput.Size = new System.Drawing.Size(417, 106);
            this.currOutput.TabIndex = 6;
            this.currOutput.Text = "0";
            this.currOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.currOutput.TextChanged += new System.EventHandler(this.currOutput_TextChanged);
            // 
            // btnReverse
            // 
            this.btnReverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnReverse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReverse.FlatAppearance.BorderSize = 0;
            this.btnReverse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(181)))), ((int)(((byte)(2)))));
            this.btnReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReverse.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnReverse.ForeColor = System.Drawing.Color.White;
            this.btnReverse.Location = new System.Drawing.Point(199, 145);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(59, 41);
            this.btnReverse.TabIndex = 9;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // lblInput
            // 
            this.lblInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInput.ForeColor = System.Drawing.Color.White;
            this.lblInput.Location = new System.Drawing.Point(708, 62);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(233, 96);
            this.lblInput.TabIndex = 10;
            this.lblInput.Text = "curr1";
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(708, 178);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(233, 96);
            this.lblOutput.TabIndex = 11;
            this.lblOutput.Text = "curr2";
            // 
            // currList1
            // 
            this.currList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.currList1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currList1.FormattingEnabled = true;
            this.currList1.ItemHeight = 19;
            this.currList1.Location = new System.Drawing.Point(15, 52);
            this.currList1.Margin = new System.Windows.Forms.Padding(4);
            this.currList1.Name = "currList1";
            this.currList1.Size = new System.Drawing.Size(159, 441);
            this.currList1.TabIndex = 13;
            this.currList1.SelectedIndexChanged += new System.EventHandler(this.currList1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(143, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
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
            this.label2.Location = new System.Drawing.Point(1109, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(134)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 519);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(134)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(967, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 519);
            this.panel2.TabIndex = 17;
            // 
            // tWeekUp
            // 
            this.tWeekUp.Interval = 10;
            this.tWeekUp.Tick += new System.EventHandler(this.tWeekUp_Tick);
            // 
            // tWeekDown
            // 
            this.tWeekDown.Interval = 10;
            this.tWeekDown.Tick += new System.EventHandler(this.tWeekDown_Tick);
            // 
            // tMonthUp
            // 
            this.tMonthUp.Interval = 10;
            this.tMonthUp.Tick += new System.EventHandler(this.tMonthUp_Tick);
            // 
            // tMonthDown
            // 
            this.tMonthDown.Interval = 10;
            this.tMonthDown.Tick += new System.EventHandler(this.tMonthDown_Tick);
            // 
            // tYearUp
            // 
            this.tYearUp.Interval = 10;
            this.tYearUp.Tick += new System.EventHandler(this.tYearUp_Tick);
            // 
            // tYearDown
            // 
            this.tYearDown.Interval = 10;
            this.tYearDown.Tick += new System.EventHandler(this.tYearDown_Tick);
            // 
            // btnSavePastMonth
            // 
            this.btnSavePastMonth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSavePastMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnSavePastMonth.FlatAppearance.BorderSize = 0;
            this.btnSavePastMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(181)))), ((int)(((byte)(2)))));
            this.btnSavePastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePastMonth.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSavePastMonth.ForeColor = System.Drawing.Color.White;
            this.btnSavePastMonth.Location = new System.Drawing.Point(449, 421);
            this.btnSavePastMonth.Name = "btnSavePastMonth";
            this.btnSavePastMonth.Size = new System.Drawing.Size(260, 98);
            this.btnSavePastMonth.TabIndex = 19;
            this.btnSavePastMonth.Text = "Save Past Month";
            this.btnSavePastMonth.UseVisualStyleBackColor = false;
            this.btnSavePastMonth.Click += new System.EventHandler(this.btnSavePastMonth_Click);
            this.btnSavePastMonth.MouseEnter += new System.EventHandler(this.btnSavePastMonth_MouseEnter);
            this.btnSavePastMonth.MouseLeave += new System.EventHandler(this.btnSavePastMonth_MouseLeave);
            // 
            // btnSavePastWeek
            // 
            this.btnSavePastWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSavePastWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnSavePastWeek.FlatAppearance.BorderSize = 0;
            this.btnSavePastWeek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(181)))), ((int)(((byte)(2)))));
            this.btnSavePastWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePastWeek.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSavePastWeek.ForeColor = System.Drawing.Color.White;
            this.btnSavePastWeek.Location = new System.Drawing.Point(189, 421);
            this.btnSavePastWeek.Name = "btnSavePastWeek";
            this.btnSavePastWeek.Size = new System.Drawing.Size(260, 98);
            this.btnSavePastWeek.TabIndex = 18;
            this.btnSavePastWeek.Text = "Save Past Week";
            this.btnSavePastWeek.UseVisualStyleBackColor = false;
            this.btnSavePastWeek.Click += new System.EventHandler(this.btnSavePastWeek_Click);
            this.btnSavePastWeek.MouseEnter += new System.EventHandler(this.btnSavePastWeek_MouseEnter);
            this.btnSavePastWeek.MouseLeave += new System.EventHandler(this.btnSavePastWeek_MouseLeave);
            // 
            // btnSavePastYear
            // 
            this.btnSavePastYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePastYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnSavePastYear.FlatAppearance.BorderSize = 0;
            this.btnSavePastYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(181)))), ((int)(((byte)(2)))));
            this.btnSavePastYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePastYear.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSavePastYear.ForeColor = System.Drawing.Color.White;
            this.btnSavePastYear.Location = new System.Drawing.Point(709, 421);
            this.btnSavePastYear.Name = "btnSavePastYear";
            this.btnSavePastYear.Size = new System.Drawing.Size(260, 98);
            this.btnSavePastYear.TabIndex = 20;
            this.btnSavePastYear.Text = "Save Past Year";
            this.btnSavePastYear.UseVisualStyleBackColor = false;
            this.btnSavePastYear.Click += new System.EventHandler(this.btnSavePastYear_Click);
            this.btnSavePastYear.MouseEnter += new System.EventHandler(this.btnSavePastYear_MouseEnter);
            this.btnSavePastYear.MouseLeave += new System.EventHandler(this.btnSavePastYear_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1156, 519);
            this.Controls.Add(this.btnSavePastMonth);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currList1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.currOutput);
            this.Controls.Add(this.currInput);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.currList2);
            this.Controls.Add(this.currSearch2);
            this.Controls.Add(this.currSearch1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSavePastWeek);
            this.Controls.Add(this.btnSavePastYear);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
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
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.ListBox currList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer tWeekUp;
        private System.Windows.Forms.Timer tWeekDown;
        private System.Windows.Forms.Timer tMonthUp;
        private System.Windows.Forms.Timer tMonthDown;
        private System.Windows.Forms.Timer tYearUp;
        private System.Windows.Forms.Timer tYearDown;
        private Entities.SaveButton btnSavePastWeek;
        private Entities.SaveButton btnSavePastMonth;
        private Entities.SaveButton btnSavePastYear;
    }
}

