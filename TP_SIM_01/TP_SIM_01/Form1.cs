using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_SIM_01.Estrategias;

namespace TP_SIM_01
{
    public partial class Form1 : Form
    {
        double[] vectorXi = new double[2];
        double[] vectorXi1 = new double[2];
        int x0, g, a, c, k;
        double m;
        EstrategiaMixto estrategia = new EstrategiaMixto();


        private void btnGenerar_Click(object sender, EventArgs e)
        {
         
                if (txtXo.Text != string.Empty && txtK.Text != string.Empty && (txtG.Text != string.Empty) && txtN.Text != string.Empty && txtC.Text != string.Empty)
                {
                    
                    
                    dgvAleatoriosMixto.Rows.Clear();
                    x0 = Convert.ToInt32(txtXo.Text);
                    a = estrategia.calcularA(Convert.ToInt32(txtK.Text));
                    m = estrategia.calcularM(Convert.ToInt32(txtG.Text));
                    c = Convert.ToInt32(txtC.Text);
                    

                    vectorXi = estrategia.calcularSiguiente(x0, a, c, m);



                    dgvAleatoriosMixto.Rows.Add(1, vectorXi[1] , Math.Truncate( 10000  * vectorXi[0] ) / 10000);

                    int n = Convert.ToInt32(txtN.Text);
                    for (int i = 1; i < n; i++)
                    {
                        int xi = Convert.ToInt32(vectorXi[1]);
                        vectorXi1 = estrategia.calcularSiguiente(xi, a, c, m);
                        dgvAleatoriosMixto.Rows.Add(i + 1, vectorXi1[1] , Math.Truncate(10000 * vectorXi1[0]) / 10000);
                        vectorXi = vectorXi1;
                    }


                }
                else
                {
                    MessageBox.Show("¡Por favor complete los campos obligatorios!", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
          
        }

        private void txtC_Leave(object sender, EventArgs e)
        {
            if (!(txtC.Text == string.Empty))
            {
                if (!(int.TryParse(txtC.Text, out c) && c > 0))
                {
                    MessageBox.Show("Datos ingresados no válidos. La variable C debe ser un número entero positivo.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtC.Clear();
                    txtC.Focus();
                }
                else
                {
                    m = estrategia.calcularM(Convert.ToInt32(txtG.Text));
                    c = Convert.ToInt32(txtC.Text);
                    if (txtG.Text != string.Empty && !estrategia.verificarMyCPrimos(m, c))
                    {
                        MessageBox.Show("Se recomienda que las variables M y C sean coprimas.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        txtC.Clear();
                    }
                }
            }
        }

        private void txtK_Leave(object sender, EventArgs e)
        {
            if (!(txtK.Text == string.Empty))
            {
                if (!(int.TryParse(txtK.Text, out k) && estrategia.validarK(k)))
                {
                    MessageBox.Show(estrategia.stringVerk(), "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtK.Clear();
                    txtK.Focus();

                }
            }
        }

        private void txtG_Leave(object sender, EventArgs e)
        {
            if (!(txtG.Text == string.Empty))
            {
                if (!(int.TryParse(txtG.Text, out g) && g > 0))
                {
                    MessageBox.Show("Datos ingresados no válidos. La variable g debe ser un número entero positivo.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtG.Clear();
                    txtG.Focus();
                }
            }
        }

        private void txtXo_Leave(object sender, EventArgs e)
        {
            if (!(txtXo.Text == string.Empty))
            {
                if (!(int.TryParse(txtXo.Text, out x0) && x0 > 0))
                {
                    MessageBox.Show("Datos ingresados no válidos. La variable X0 debe ser un número entero positivo.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtXo.Clear();
                    txtXo.Focus();
                }
                else
                {
                    if (!estrategia.validarX0impar(x0) && !(txtXo.Text == string.Empty))
                        MessageBox.Show("Se aconseja que la variable x0 sea impar", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtXo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Close();
            Menu f = new Menu();
            f.Show();
        }

        private void txtN_Leave(object sender, EventArgs e)
        {
            if (!(txtN.Text == string.Empty))
            {
                int n;
                if (!(int.TryParse(txtN.Text, out n) && n > 0))
                {
                    MessageBox.Show("Datos ingresados no válidos. La variable n debe ser un número entero positivo.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtN.Clear();
                    txtN.Focus();
                }
            }
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            Grafico g = new Grafico(dgvAleatoriosMixto);
            g.Show();
        }

        private void dgvAleatoriosMixto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
 


        }

    }
}
