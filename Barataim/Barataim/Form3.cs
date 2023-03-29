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
    public partial class Form3 : Form
    {
        Baratok locBaratok;
        public Form3(Baratok bk)
        {
            InitializeComponent();
            locBaratok = bk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Barat b in locBaratok.BaratLista)
            {
                if (b.ToString().Contains(textBox1.Text))
                {
                    MessageBox.Show(b.ToString());
                }
            }
        }
    }
}
