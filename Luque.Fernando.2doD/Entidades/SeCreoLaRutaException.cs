using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SeCreoLaRutaException : Exception
    {

        public SeCreoLaRutaException(string message):base(message)
        {
                
        }

        public SeCreoLaRutaException(string message, Exception inner):base(message,inner)
        {

        }
    }
}
