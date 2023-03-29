namespace PS001
{
    public partial class Form1 : Form
    {
        public static int Limit { get; set; }

        public Form1()
        {
            InitializeComponent();
            Limit = 100000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void normálToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void nyújtottToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void automatikusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void középreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void nagyítottToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Bitmap ujbmp = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    ujbmp.SetPixel(i, j, Color.FromArgb(bmp.GetPixel(i, j).A, 0, bmp.GetPixel(i, j).B, 0));
                }
            }
            pictureBox1.Image = ujbmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Form2 f2 = new Form2(new Bitmap(bmp, bmp.Width / 4, bmp.Height / 4), Limit);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = KonturSeged.Konturozott((Bitmap)pictureBox1.Image, Limit);
            }            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vízjelezéshez kérem válasszon színt:");
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                Color c = cd.Color;
                Bitmap b = (Bitmap)pictureBox1.Image;
                Graphics g = Graphics.FromImage(b);
                g.DrawString(textBox1.Text, new Font("Arail", 100), new SolidBrush(c), 1, 1);
                pictureBox1.Image = b;
            }            
        }
    }
}