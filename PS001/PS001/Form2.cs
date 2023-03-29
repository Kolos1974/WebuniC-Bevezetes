using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS001
{
    public partial class Form2 : Form
    {
        int localLimit;
        Bitmap localBmp;
        public Form2(Bitmap bmp, int limet)
        {
            InitializeComponent();
            localLimit = limet;
            localBmp = bmp;
            pictureBox1.Image = bmp;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.EndScroll)
            {
                localLimit = hScrollBar1.Value;
                pictureBox1.Image = KonturSeged.Konturozott(localBmp, localLimit);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Limit = localLimit;
        }
    }
}
