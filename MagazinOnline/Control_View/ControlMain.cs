using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Magazin_Online_v2;

namespace MagazinOnline.Control_View
{
    public class ControlMain : Panel
    {
        public ControlProducts control;

        public ControlMain()
        {
            control = new ControlProducts();
            layoutPanel();
            layouts();
            layoutProduse();



            Label TEST = new Label();
            TEST.Location = new Point(10, 2000);
            this.Controls.Add(TEST);
        }

        public void layoutPanel()
        {
            this.Size = new Size(1175, 543);
            this.BackColor = SystemColors.ControlLightLight;
            this.BorderStyle = BorderStyle.None;
            this.AutoScroll = true;
        }

        public void layouts()
        {
            Panel reclameP = new Panel();
            layoutReclameP(reclameP);
            this.Controls.Add(reclameP);

            PictureBox reclame = new PictureBox();
            layoutReclame(reclame);
            reclameP.Controls.Add(reclame);

            Label oferte = new Label();
            layoutOferte(oferte);
            this.Controls.Add(oferte);
        }

        public void layoutProduse()
        {
            List<Product> lista = control.Products;
            int k1 = 1,k2=0;
            foreach(Product produs in lista)
            {
                ControlCard card = new ControlCard(produs.Name, produs.Image, produs.Price, produs.Stock, (produs as Telefon).NumeTelefon);
                Panel panel = card;
                if(k2>900){
                    k2 = 0;
                    k1 += 430;
                }
                panel.Location = new Point(75+k2, 350+k1);
                k2 += 267;
                this.Controls.Add(panel);
            }
        }


        public void layoutReclame(PictureBox reclame)
        {
            reclame.Location = new Point(0, 0);
            reclame.Size = new Size(1000, 250);
            Image im = Image.FromFile(Application.StartupPath + @"\images\reclamaTEST.png");
            reclame.BackgroundImage = im;
            reclame.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void layoutReclameP(Panel reclameP)
        {
            reclameP.Location = new Point(77, 0);
            reclameP.Size = new Size(1000, 250);
            reclameP.BackColor = SystemColors.ControlLightLight;
            reclameP.BorderStyle = BorderStyle.FixedSingle;
        }


        public void layoutOferte(Label oferte)
        {
            oferte.AutoSize = false;
            oferte.Location = new Point(15, 288);
            oferte.Size = new Size(150, 30);
            oferte.Font = new Font("Cambria", 16, FontStyle.Regular);
            oferte.BackColor = SystemColors.ControlLightLight;
            oferte.Text = "Ofertele zilei:";
        }

    }
}
