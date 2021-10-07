using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MagazinOnline.Control_View
{
    public class ControlCard : Panel
    {
        private string name;
        private string image;
        private double price;
        private int stock;
        private string numeTelefon;

        public ControlCard(string name,string image,double price,int stock,string numeTelefon)
        {
            this.name = name;
            this.image = image;
            this.price = price;
            this.stock = stock;
            this.numeTelefon = numeTelefon;
            layoutPanel();
            layouts();
        }

        public void layoutPanel()
        {
            this.Size = new Size(200, 330);
            this.BackColor = SystemColors.ControlLightLight;
            this.BorderStyle = BorderStyle.None;
        }

        public void layouts()
        {
            Label test = new Label();
            test.Text = name;
            
            this.Controls.Add(test);
        }

    }
}
