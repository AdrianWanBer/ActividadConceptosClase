using ActividadConceptosClase.Sevicios;
using System.Collections;

namespace ActividadConceptosClase.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            List<int> ganancias = new List<int>();
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            bool finDia = false;
            //Console.WriteLine(ganancias.Count);
            while (!finDia)
            {
                //Console.WriteLine(ganancias.Count);
                int seleccion = mi.menuYSeleccion();
                switch(seleccion) 
                {
                    case 1: // Agregar ganancia
                        oi.agregarGanancia(ganancias);

                        break;
                    case 2: // Finaliza el dia (Mostrar lista ordenada y cerrar aplicacion)
                        oi.ordenarListaYImprimir(ganancias);
                        finDia = true;
                        break;

                    default: //No elige ninguna de las opciones validas
                        Console.WriteLine("No se ha recibido una respuesta valida, repita porfavor");
                        break;
                }
            }



        }
    }
}
