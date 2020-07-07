using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodoExtendidoFloat
    {

        public static string Observacion(this float nota,List<string> listaObservaciones)
        {
            string observacion=String.Empty;

            if (nota < 4)
                observacion = listaObservaciones[0];

            else if (nota >= 4 && nota <= 6)
                observacion = listaObservaciones[1];

            else if (nota >= 7 && nota < 10)
                observacion = listaObservaciones[2];

            else
                observacion = listaObservaciones[3];

            return observacion;
        }
    }
}
