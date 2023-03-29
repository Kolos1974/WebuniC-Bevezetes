using System.Xml.Serialization;

namespace Valasztasok
{
    public partial class Form1 : Form
    {
        Valasztok nevsor;

        public Form1()
        {
            InitializeComponent();
            nevsor = new Valasztok();
        }

        private void btnUJ_Click(object sender, EventArgs e)
        {
            Valaszto v = new Valaszto();
            v.Nev = tbNev.Text;
            v.Varos = tbVaros.Text;
            v.Noe = checkBox1.Checked;
            v.Szev = (int)numericUpDown1.Value;
            nevsor.ValasztoLista.Add(v);
            Frissit();
        }

        private void Frissit()
        {
            listBox1.Items.Clear();
            foreach (Valaszto va in nevsor.ValasztoLista)
            {
                listBox1.Items.Add(va);
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("adatok.xml"))
            {
                XmlSerializer xser = new XmlSerializer(typeof(Valasztok));
                xser.Serialize(sw, nevsor);
            }
        }

        private void btnBetoltes_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("adatok.xml"))
            {
                XmlSerializer xser = new XmlSerializer(typeof(Valasztok));
                nevsor = (Valasztok)xser.Deserialize(sr);
            }
            Frissit();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            Valaszto v = (Valaszto)((ListBox)sender).SelectedItem;
            tbNev.Text = v.Nev;
            tbVaros.Text = v.Varos;
            numericUpDown1.Value = v.Szev;
            checkBox1.Checked = v.Noe;
        }
    }
}