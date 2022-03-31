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
    public partial class FromLenguaje : Form
    {
        public FromLenguaje()
        {

            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvAleato.Rows.Clear();
            Random random = new Random();
            int n;
            n = Convert.ToInt32(txtN.Text);
            
            for (int i = 0; i < n; i++)
            {
                dgvAleato.Rows.Add(i + 1, null , Math.Round(random.NextDouble(), 4));
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grafico g = new Grafico(dgvAleato);
            g.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Close();
            Menu m = new Menu();
            m.Show();
        }
    }
}
