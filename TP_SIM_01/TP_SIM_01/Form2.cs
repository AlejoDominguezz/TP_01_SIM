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
    public partial class Form2 : Form
    {
        double[] vectorXi = new double[2];
        double[] vectorXi1 = new double[2];
        int x0, g, a, c, k;
        double m;
        EstrategiaMultiplicativo estrategia = new EstrategiaMultiplicativo();

        public Form2()
        {
            InitializeComponent();
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

        private void txtX0_Leave(object sender, EventArgs e)
        {
            if (!(txtX0.Text == string.Empty))
            {
                if (!(int.TryParse(txtX0.Text, out x0) && x0 > 0))
                {
                    MessageBox.Show("Datos ingresados no válidos. La variable X0 debe ser un número entero positivo.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtX0.Clear();
                    txtX0.Focus();
                }
                else
                {
                    if (!estrategia.validarX0impar(x0) && !(txtX0.Text == string.Empty))
                        MessageBox.Show("Se aconseja que la variable x0 sea impar", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtN.Clear();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Grafico g = new Grafico(dgvMultiplicativo);
            g.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtX0.Text != string.Empty && txtK.Text != string.Empty && (txtG.Text != string.Empty) && txtN.Text != string.Empty)
            {
                dgvMultiplicativo.Rows.Clear();
                x0 = Convert.ToInt32(txtX0.Text);
                a = estrategia.calcularA(Convert.ToInt32(txtK.Text));
                c = 0;
                m = estrategia.calcularM(Convert.ToInt32(txtG.Text));

                vectorXi = estrategia.calcularSiguiente(x0, a, c, m);



                dgvMultiplicativo.Rows.Add(1, vectorXi[1], vectorXi[0]);

                int n = Convert.ToInt32(txtN.Text);
                for (int i = 1; i < n; i++)
                {
                    int xi = Convert.ToInt32(vectorXi[1]);
                    vectorXi1 = estrategia.calcularSiguiente(xi, a, c, m);
                    dgvMultiplicativo.Rows.Add(i + 1, vectorXi1[1], vectorXi1[0]);
                    vectorXi = vectorXi1;
                }
                /*
                btnProximo.Enabled = true;
                deshabilitarCampos();
                btnGenerarGrafico.Enabled = true;
                */

            }
            else
            {
                MessageBox.Show("¡Por favor complete los campos obligatorios!", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos()
        {
            if (estrategia.validarX0impar(Convert.ToInt32(txtX0.Text)))
            {
                return true;
            }
            return false;
        }

    }
}
