using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


using Magazin_Online_v2;
using Magazin_Online_v2.Clasa;

namespace MagazinOnline.Control_View
{
    public class ControlHome : Form
    {

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ControlHome
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "ControlHome";
            this.ResumeLayout(false);

        }

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
            this.Name = "form";
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

            ControlOptionBar bar = new ControlOptionBar();
            bar.Location = new Point(0, 109);
            this.Controls.Add(bar);

            ControlMain main = new ControlMain();
            main.Location = new Point(13, 145);
            this.Controls.Add(main);
        }
    
    }
}
