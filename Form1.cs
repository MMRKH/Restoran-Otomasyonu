using System.Windows.Forms;

namespace Restoran_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            if (false == null)
            {
                f = new Form2();
                f.Show();
            }
            else
            {
                f.Show();
                
            }
           
            

        }
    }
}