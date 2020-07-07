using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class FuncionalidadLog
    {
        public static void GuardarLog(string mensaje)
        {
            if(!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Logs"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Logs");
            }
           
                using (StreamWriter data = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Logs\Errores.txt", true)) //@"C:\Users\Fer\Desktop\Programacion 2 proyectos\GuardarEnArchivoDeTexto\GuardarEnArchivoDeTexto\Data2.txt",true))
                {
                    data.WriteLine(mensaje);
                                     
                }
                

        }

    }
}
