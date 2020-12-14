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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
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
            this.currSearch2.Location = new System.Drawing.Point(622, 12);
            this.currSearch2.MaxLength = 3;
            this.currSearch2.Name = "currSearch2";
            this.currSearch2.Size = new System.Drawing.Size(166, 22);
            this.currSearch2.TabIndex = 1;
            this.currSearch2.TextChanged += new System.EventHandler(this.currSearch2_TextChanged);
            // 
            // currList1
            // 
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
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(373, 408);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 9;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currOutput);
            this.Controls.Add(this.currInput);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.currList2);
            this.Controls.Add(this.currList1);
            this.Controls.Add(this.currSearch2);
            this.Controls.Add(this.currSearch1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReverse;
    }
}

