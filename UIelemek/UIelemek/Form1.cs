namespace UIelemek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Peti");
            comboBox1.Items.Add("Kati");
            comboBox1.Items.Add("Laci");
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                button2.BackColor = cd.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            DialogResult res = form2.ShowDialog();

            if (res == DialogResult.OK)
            {
                MessageBox.Show("OK-ot nyomtak");
            }
            else if (res == DialogResult.No)
            {
                MessageBox.Show("oh no");
            }
            else
            {
                MessageBox.Show("ez meg mi lehet?");
            }

            
           // form2.Show();
        }
    }
}