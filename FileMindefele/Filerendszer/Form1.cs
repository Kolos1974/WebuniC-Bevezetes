namespace Filerendszer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DriveInfo d in DriveInfo.GetDrives())
            {
                listBox1.Items.Add(d);
                //listBox1.Items.Add(d.Name);
                //listBox1.Items.Add(d.AvailableFreeSpace);
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(((ListBox)sender).SelectedItem.ToString());
            listBox2.Items.Clear();
            foreach (DirectoryInfo item in di.GetDirectories())
            {
                listBox2.Items.Add(item);
            }
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(((ListBox)sender).SelectedItem.ToString());
            foreach (FileInfo fi in di.GetFiles())
            {
                listBox3.Items.Add(fi);
            }

            listBox1_Click(sender, e);
        }

    }
}