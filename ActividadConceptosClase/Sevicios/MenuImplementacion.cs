using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadConceptosClase.Sevicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuYSeleccion() {
            int seleccion;
            Console.WriteLine("Que desea hacer: ");
            Console.WriteLine("----------------------");
            Console.WriteLine("1.Ingresar ganancia");
            Console.WriteLine("2. Finalizar dia");
            Console.WriteLine("----------------------");
            seleccion = Convert.ToInt32(Console.ReadLine());
            return seleccion;
        }
    }
}
