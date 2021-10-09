﻿using System;
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
        private int timer;
        private PictureBox reclame;


        public ControlMain()
        {
            control = new ControlProducts();
            this.timer = 0;
            this.reclame = new PictureBox();
            timerCreate();
            layoutPanel();
            layouts();
            layoutProduse();



            Label TEST = new Label();
            TEST.Location = new Point(10, 2000);
            this.Controls.Add(TEST);
        }

        public void timerCreate()
        {
            Timer t = new Timer();
            t.Interval = 3000;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
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
            reclameP.Controls.Add(reclame);

            layoutReclame();          

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
                ControlCard card = new ControlCard(produs.Id,produs.Name, produs.Image, produs.Price, produs.Stock, (produs as Telefon).NumeTelefon);
                Panel panel = card;
                if(k2>900){
                    k2 = 0;
                    k1 += 450;
                }
                panel.Location = new Point(75+k2, 420+k1);


                Button b = null;

                foreach(Control controale in panel.Controls)
                {

                    if (controale is Button)
                    {

                        Button cos = controale as Button;
                        if (cos.Name.Contains("cos") == true)
                        {
                            b = cos;
                        }
                    }
                }

                b.Click += addCos_Click;



                k2 += 267;
                this.Controls.Add(panel);
            }
        }

        public void addCos_Click(object sender, EventArgs e)
        {

            Button button = sender as Button;

            int id = int.Parse(button.Name.Split(",")[1]);
            MessageBox.Show(id.ToString());
        }


        public void layoutReclame()
        {
            this.reclame.Location = new Point(0, 0);
            this.reclame.Size = new Size(1000, 250);
            Image im = null;
            if (this.timer == 0) im = Image.FromFile(Application.StartupPath + @"\images\reclamaTEST.png");
            if (this.timer == 1) im = Image.FromFile(Application.StartupPath + @"\images\close.png");
            if (this.timer == 2) im = Image.FromFile(Application.StartupPath + @"\images\logo.png");
            this.reclame.BackgroundImage = im;
            this.reclame.BackgroundImageLayout = ImageLayout.Stretch;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (this.timer == 2)
                this.timer = 0;
            else
                this.timer++;
            layoutReclame();
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
