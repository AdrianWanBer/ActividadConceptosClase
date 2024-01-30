using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadConceptosClase.Sevicios
{
    internal interface OperativaInterfaz
    {
        public void agregarGanancia(List<int> ganancias);

        public void ordenarListaYImprimir(List<int> ganancias);
    }
}
