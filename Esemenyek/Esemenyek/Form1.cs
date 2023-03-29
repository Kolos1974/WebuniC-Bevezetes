namespace Esemenyek
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int pontszam = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter > 10)
            {
                timer1.Enabled = false;
                MessageBox.Show($"Game over! Pontszámod:{pontszam}");
            }

            Random r = new Random();

            Button b = new Button();
            b.Width = 100;
            b.Height = 25;
            b.Top = r.Next(600);
            b.Left = r.Next(1000);
            b.Click += Leszed;


            Controls.Add(b);
            counter++;
        }


        private void Leszed(object sender, EventArgs e)
        {
            Controls.Remove((Button)sender);
            counter--;
            pontszam++;
        }
    }
}