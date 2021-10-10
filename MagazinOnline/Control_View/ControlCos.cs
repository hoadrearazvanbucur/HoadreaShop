using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MagazinOnline.Control_View
{
    public class ControlCos : Panel
    {
        public ControlCos()
        {
            layouts();
        }

        public void layouts()
        {
            layoutPanel();
        }

        public void layoutPanel()
        {
            this.Size = new Size(1175, 543);
            this.BackColor = SystemColors.ControlLightLight;
            this.BorderStyle = BorderStyle.None;
            this.AutoScroll = true;
        }



    }
}
