using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadConceptosClase.Sevicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void agregarGanancia(List<int> ganancias)
        {
            Console.WriteLine("Cuanto dinero a ganado: ");
            int ganancia = Convert.ToInt32(Console.ReadLine());
            ganancias.Add(ganancia);
        }


        public void ordenarListaYImprimir(List<int> ganancias)
        {
            for(int i = 0; i < (ganancias.Count - 1); i++)
            {
                for(int j = i + 1; j < ganancias.Count; j++)
                {
                    if (ganancias[i] < ganancias[j])
                    {
                        int temp = ganancias[j];
                        ganancias[j] = ganancias[i];
                        ganancias[i] = temp;
                    }
                }

            }
            Console.WriteLine("Ganancias ordenadas");
            Console.WriteLine("-------------------");
            foreach (int recorrido in ganancias)
            {
                
                Console.Write(" | " + recorrido);
                

            }
            Console.WriteLine(" | ");
            Console.WriteLine("-------------------");


        }
    }
}
