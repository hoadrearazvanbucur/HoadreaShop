using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Magazin_Online_v2;

namespace MagazinOnline.Control_View
{
    public class ControlCos : Panel
    {
        private ControlProducts controlProducts;

        public ControlCos()
        {
            this.controlProducts = new ControlProducts();
            layoutPanel();
            layouts();

            Label TEST = new Label();
            TEST.Location = new Point(10, 1000);
            this.Controls.Add(TEST);
        }

        public void layouts()
        {
            Label cosulMeu = new Label();
            layoutCosulMeu(cosulMeu);
            this.Controls.Add(cosulMeu);

            layoutOrders();
        }
        public void layoutOrders()
        {
            List<Product> lista = controlProducts.Products;
            int k1 = 40;
            foreach (Product produs in lista)
            {
                ControlComanda card = new ControlComanda(produs.Name, produs.Image, produs.Price, (produs as Telefon).NumeTelefon,produs.Stock);
                card.Location = new Point(75, 50 + k1);
                k1 += 200;
                this.Controls.Add(card);
            }
        }


        public void layoutCosulMeu(Label cosulMeu)
        {
            cosulMeu.AutoSize = false;
            cosulMeu.Location = new Point(15, 20);
            cosulMeu.Size = new Size(300, 30);
            cosulMeu.Font = new Font("Cambria", 18, FontStyle.Regular);
            cosulMeu.BackColor = SystemColors.ControlLightLight;
            cosulMeu.Text = "Cosul meu de cumparaturi:";
        }

        public void layoutPanel()
        {
            this.Size = new Size(1175, 543);
            this.BackColor = SystemColors.ControlLightLight;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.AutoScroll = true;
        }



    }
}
