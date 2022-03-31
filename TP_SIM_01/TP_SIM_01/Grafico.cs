using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TP_SIM_01.EstrategiasIntervalos;
using MathNet.Numerics.Distributions;



namespace TP_SIM_01
{
    public partial class Grafico : Form
    {
        Series Series2 = new Series();
        Series Series3 = new Series();
        private DataGridView numeros;
        private IEstrategiaIntervalos estrategia;

        public Grafico(DataGridView numeros)

        {
  
            InitializeComponent();
            this.numeros = numeros;
            chrtDistribucion.Series.Add(Series2);
            chrtChi.Series.Add(Series3);
        }

        private void Grafico_Load(object sender, EventArgs e)
        {

        }

        private void checkInt5_CheckedChanged(object sender, EventArgs e)
        {
            estrategia = new EstrategiaIntervalo5();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dgvChi.Rows.Clear();
            

            List<float> numerosAleatorios = new List<float>();
            for (int i = 0; i < numeros.Rows.Count; i++)
            {

                numerosAleatorios.Add((float)(Convert.ToDouble(numeros.Rows[i].Cells[2].Value)));

            }

            List<int> frecuenciaObservada = estrategia.frecuenciaObservada(numerosAleatorios);
            float[,] intervalos = estrategia.calcularIntervalos();

            for (int i = 0; i < frecuenciaObservada.Count; i++)
            {
                float marcaClase = (float)(intervalos[i, 0] + intervalos[i, 1]) / 2;
                float probabilidad = calcularProbabilidad(intervalos[i, 0], intervalos[i, 1]);

                dataGridView1.Rows.Add(Math.Truncate(10000 * intervalos[i, 0]) / 10000, Math.Truncate(10000 * intervalos[i, 1]) / 10000, marcaClase, frecuenciaObservada[i], probabilidad, calcularFrecuenciaEsperada(probabilidad, numerosAleatorios.Count));
            }

            generarGrafico(intervalos, frecuenciaObservada);
            string[,] intervalosChi = chiCuadrado();
            generarGraficoChi(intervalosChi);
            lblCalculado.Text = getAcumulado().ToString();
            lblCalculado.Visible = true;
            lblTabla.Text = tablaChiCuadrado().ToString();
            conclusion();
            
            

        }



        public float calcularProbabilidad(float desde, float hasta)
        {
            float prob = (1 / (float)estrategia.cantInt());
            return prob;
        }

        public float calcularFrecuenciaEsperada(float prob, int n)
        {
            return prob * n;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            estrategia = new EstrategiaIntervalo10();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            estrategia = new EstrategiaIntervalo8();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            estrategia = new EstrategiaIntervalo12();
        }



        public void generarGrafico(float[,] intervalos, List<int> frecuencia)
        {
            chrtDistribucion.Series["Series1"].Points.Clear();
            chrtDistribucion.Series["Series2"].Points.Clear();
            chrtDistribucion.Series["Series1"].LegendText = "Frecuencia observada";
            chrtDistribucion.Series["Series2"].LegendText = "Frecuencia esperada";

            Dictionary<string, int> dic = new Dictionary<string, int>();
            Dictionary<string, float> dic2 = new Dictionary<string, float>();

            for (int i = 0; i < frecuencia.Count; i++)
            {
                dic.Add(intervalos[i, 0] + " - " + intervalos[i, 1], frecuencia[i]);
                dic2.Add(intervalos[i, 0] + " - " + intervalos[i, 1], calcularFrecuenciaEsperada(calcularProbabilidad(intervalos[i, 0], intervalos[i, 1]), numeros.Rows.Count));
            }

            foreach (KeyValuePair<string, int> d in dic)
            {
                chrtDistribucion.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }

            foreach (KeyValuePair<string, float> d in dic2)
            {
                chrtDistribucion.Series["Series2"].Points.AddXY(d.Key, d.Value);
            }

        }

        public string[,] chiCuadrado()
        {
            float cAcum = 0;
            String[,] intervalos = new String[dataGridView1.Rows.Count, 4];
            int j = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string desde = dataGridView1.Rows[i].Cells["Desde"].Value.ToString();
                string hasta = dataGridView1.Rows[i].Cells["Hasta"].Value.ToString();
                float sumaEsperada = (float)Convert.ToDouble(dataGridView1.Rows[i].Cells["FrecuenciaEsperada"].Value);
                int sumaObservada = Convert.ToInt32(dataGridView1.Rows[i].Cells["FrecuenciaObservada"].Value);

                while (sumaEsperada < 5 || verificarProximos(i))
                {
                    if (i == dataGridView1.Rows.Count - 1)
                        break;
                    i++;
                    sumaEsperada += (float)Convert.ToDouble(dataGridView1.Rows[i].Cells["FrecuenciaEsperada"].Value);
                    sumaObservada += Convert.ToInt32(dataGridView1.Rows[i].Cells["FrecuenciaObservada"].Value);
                    hasta = dataGridView1.Rows[i].Cells["Hasta"].Value.ToString();

                }
                float c = (float)Math.Pow(((float)sumaEsperada - (float)sumaObservada), 2) / sumaEsperada;
                cAcum += c;
                dgvChi.Rows.Add(desde, hasta, sumaObservada, sumaEsperada, Math.Truncate(10000 * c) / 10000, Math.Truncate(10000 * cAcum) / 10000);
                intervalos[j, 0] = desde;
                intervalos[j, 1] = hasta;
                intervalos[j, 2] = sumaObservada.ToString();
                intervalos[j, 3] = sumaEsperada.ToString();
                j++;
            }

            return intervalos;

        }

        public bool verificarProximos(int i)
        {
            int suma = 0;
            for (int j = i + 1; j < dataGridView1.Rows.Count; j++)
            {
                suma += Convert.ToInt32(dataGridView1.Rows[j].Cells["FrecuenciaEsperada"].Value);
            }
            return suma < 5;
        }




        public void generarGraficoChi(string[,] intervalos)
        {
            chrtChi.Series["Series1"].Points.Clear();
            chrtChi.Series["Series2"].Points.Clear();
            chrtChi.Series["Series1"].LegendText = "Frecuencia observada";
            chrtChi.Series["Series2"].LegendText = "Frecuencia esperada";

            Dictionary<string, int> dic3 = new Dictionary<string, int>();
            Dictionary<string, float> dic4 = new Dictionary<string, float>();

            int i = 0;
            while (i < intervalos.GetLength(0) && !(intervalos[i, 0] == null))
            {
                dic3.Add(intervalos[i, 0] + " - " + intervalos[i, 1], Convert.ToInt32(intervalos[i, 2]));
                dic4.Add(intervalos[i, 0] + " - " + intervalos[i, 1], (float)Convert.ToDouble(intervalos[i, 3]));
                i++;
            }

            foreach (KeyValuePair<string, int> d in dic3)
            {
                chrtChi.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }

            foreach (KeyValuePair<string, float> d in dic4)
            {
                chrtChi.Series["Series2"].Points.AddXY(d.Key, d.Value);
            }

        }


        public float getAcumulado()
        {
            return (float)Convert.ToDouble(dgvChi.Rows[dgvChi.Rows.Count - 1].Cells["Css"].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        public float tablaChiCuadrado()
        {
            return (float)Math.Round(ChiSquared.InvCDF(dgvChi.Rows.Count - 1, 0.95), 4);
        }

        public void conclusion()
        {
            string txt;
            if (getAcumulado() < tablaChiCuadrado())
                txt = "Conclusión: La hipótesis se acepta, los datos se aproximan a una distribución uniforme.";
            else
                txt = "Conclusión: La hipótesis no se acepta, los datos no se aproximan a una distribución uniforme.";

            lblconclusion.Text = txt;
        }

        



    }
}
