namespace GrafikaAlapok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Graphics gr = button1.CreateGraphics();
            // gr.DrawEllipse(Pens.Red, 1, 1, 100, 55);

        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(Pens.Red, 1, 1, 100, 55);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.DrawEllipse(Pens.Red, 1, 1, 100, 100);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Green, 10, 10, 110, 110);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(@"C:\temp\valami.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"C:\temp\valami2.jpg");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)Image.FromFile(@"C:\temp\valami.jpg");
            Graphics gr = Graphics.FromImage(bmp);
            Font f = new Font("Arial", 100);
            gr.DrawString("Tirol víztározó", f, Brushes.Yellow, 1, 1);
            pictureBox1.Image = bmp;
            pictureBox1.Image.Save(@"C:\temp\valami3.jpg");
            //bmp.GetPixel

        }
    }
}