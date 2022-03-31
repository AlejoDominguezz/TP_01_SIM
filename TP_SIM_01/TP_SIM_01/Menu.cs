using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_SIM_01
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMixto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnMultiplicativo_Click(object sender, EventArgs e)
        {
            
            Form2 f = new Form2();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromLenguaje f = new FromLenguaje();
            f.Show();
        }
    }
}
