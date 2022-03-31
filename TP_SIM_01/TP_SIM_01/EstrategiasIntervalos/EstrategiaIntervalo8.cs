using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SIM_01.EstrategiasIntervalos
{
    class EstrategiaIntervalo8 : IEstrategiaIntervalos
    {
        public override List<int> frecuenciaObservada(List<float> valoresAleatorios)
        {
            List<int> fo = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0};
            for (int i = 0; i < valoresAleatorios.Count; i++)
            {
                int posicion = (int)Math.Truncate((float)valoresAleatorios[i] / (float)0.125);
                fo[posicion] = fo[posicion] + 1;
            }

            return fo;
        }

        public override float[,] calcularIntervalos()
        {
            float[,] intervalos = new float[8, 2];
            for (int i = 0; i < 8; i++)
            {
                intervalos[i, 0] = (float)0.125 * i;
                intervalos[i, 1] = (float)(0.125 * i + 0.124);
            }
            return intervalos;
        }

        public override int cantInt()
        {
            return 8;
        }
    }
}
