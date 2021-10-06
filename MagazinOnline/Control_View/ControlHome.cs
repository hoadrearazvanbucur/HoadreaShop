using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


using Magazin_Online_v2;

namespace MagazinOnline.Control_View
{
    public class ControlHome : Form
    {
        public ControlHome()
        {
            layouts();         
        }

        public void layouts()
        {
            layoutForm();
            layoutPanels();
        }

        public void layoutForm()
        {
            this.Size = new Size(1200, 700);
            this.MaximumSize = new Size(1200, 700);
            this.MinimumSize = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = SystemColors.ControlLightLight;
        }

        public void layoutPanels()
        {
            ControlHeader header = new ControlHeader();
            header.Location = new Point(13, 13);
            this.Controls.Add(header);
        }

    }
}
