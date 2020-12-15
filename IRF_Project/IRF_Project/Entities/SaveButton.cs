using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project.Entities
{
    class SaveButton : Button
    {
        public SaveButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 181, 2);
            BackColor = Color.FromArgb(22, 47, 57);
            Height = 98;
            Width = 260;
            ForeColor = Color.White;
            Anchor = AnchorStyles.Bottom;

            MouseEnter += SaveButton_MouseEnter;
            MouseLeave += SaveButton_MouseLeave;
        }

        private void SaveButton_MouseLeave(object sender, EventArgs e)
        {
            ForeColor = Color.White;
        }

        private void SaveButton_MouseEnter(object sender, EventArgs e)
        {
            ForeColor = Color.FromArgb(15, 32, 40);
        }
    }
}
