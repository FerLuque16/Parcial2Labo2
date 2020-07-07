using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Entidades
{
    public static class FuncionalidadBinnary
    {
        static BinaryFormatter formatter;
        static Stream stream;


        public static bool SerializarAlumnoBinario(Alumno a)
        {
            bool retorno = true;
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Serializaciones\APROBADOS\ApellidoBinario_NombreBinario_7_7_2020.dat";

                stream = new FileStream(ruta, FileMode.Create);
                
                formatter = new BinaryFormatter();

                formatter.Serialize(stream, a);

                
            }
            catch (Exception ex)
            {

                FuncionalidadLog.GuardarLog(ex.Message);
                retorno = false;
            }
            finally
            {
                stream.Close();
            }
    

            return retorno;
        }

        public static Alumno DeserializarAlumnoBinario(string ruta)
        {
            Alumno alumno=null;

            try
            {
                using(stream = new FileStream(ruta, FileMode.Open))
                {
                    formatter = new BinaryFormatter();

                    alumno = (Alumno)formatter.Deserialize(stream);
                }

               
            }
            catch (Exception ex)
            {

                FuncionalidadLog.GuardarLog(ex.Message);
            }

           
            return alumno;
        }

    }
}
