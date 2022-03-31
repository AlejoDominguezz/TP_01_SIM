using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SIM_01.Estrategias
{
    class EstrategiaMixto
    {

        public bool validarK(int k)
        {
            return k > 0;
        }

        public  string stringVerk()
        {
            return "Datos ingresados no válidos. La variable K debe ser un número entero positivo.";
        }

        public  int calcularA(int k)
        {
            return 1 + 4 * k;
        }


        public bool sonPrimos(int a, int b)
        {
            int mayor = Math.Max(a, b);
            int menor = Math.Min(a, b);
            int res;
            do
            {
                res = menor;
                menor = mayor % menor;
                mayor = res;
            } while (menor != 0);

            if (res == 1)
                return true;

            return false;
        }

        public  bool verificarMyCPrimos(double m, int c)
        {
            return sonPrimos((int)m, c);
        }

        public  double[] calcularSiguiente(int xi, int a, int c, double m)
        {
            double[] vector = new double[2];
            vector[1] = (a * xi + c) % m;
            vector[0] = vector[1] / (m);
            return vector;

        }

        public double calcularM(int g)
        {
            return Math.Pow(2, g);
        }


        public bool validarX0impar(int x0)
        {
            return x0 % 2 != 0;
        }
    }
}
