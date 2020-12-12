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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currSearch1
            // 
            this.currSearch1.Location = new System.Drawing.Point(12, 12);
            this.currSearch1.Name = "currSearch1";
            this.currSearch1.Size = new System.Drawing.Size(166, 22);
            this.currSearch1.TabIndex = 0;
            // 
            // currSearch2
            // 
            this.currSearch2.Location = new System.Drawing.Point(622, 12);
            this.currSearch2.Name = "currSearch2";
            this.currSearch2.Size = new System.Drawing.Size(166, 22);
            this.currSearch2.TabIndex = 1;
            // 
            // currList1
            // 
            this.currList1.FormattingEnabled = true;
            this.currList1.ItemHeight = 16;
            this.currList1.Location = new System.Drawing.Point(12, 40);
            this.currList1.Name = "currList1";
            this.currList1.Size = new System.Drawing.Size(166, 404);
            this.currList1.TabIndex = 2;
            // 
            // currList2
            // 
            this.currList2.FormattingEnabled = true;
            this.currList2.ItemHeight = 16;
            this.currList2.Location = new System.Drawing.Point(622, 40);
            this.currList2.Name = "currList2";
            this.currList2.Size = new System.Drawing.Size(166, 404);
            this.currList2.TabIndex = 3;
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 22);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.currInput);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.currList2);
            this.Controls.Add(this.currList1);
            this.Controls.Add(this.currSearch2);
            this.Controls.Add(this.currSearch1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox textBox1;
    }
}

