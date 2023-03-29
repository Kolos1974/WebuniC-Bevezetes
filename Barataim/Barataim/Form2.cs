using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barataim
{
    public partial class Form2 : Form
    {
        public Form2(Baratok bk)
        {
            InitializeComponent();
            Kiir(bk);
        }

        private void Kiir(Baratok bk)
        {
            int poz = 20;
            foreach (Barat b in bk.BaratLista)
            {
                Label l = new Label();
                l.Top = poz;
                l.Left = 40;
                l.Width = 500;
                l.Text = b.ToString();
                Controls.Add(l);
                poz += 40;
            }
        }
    }
}
