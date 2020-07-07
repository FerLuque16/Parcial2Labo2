using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public static class FuncionalidadXML 
    {
        static XmlTextReader reader;
        static XmlSerializer ser;

        public static List<Docente> DeserlizarDocentes()
        {
            List<Docente> listaDocentes = new List<Docente>();
            try
            {
                reader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Docentes\Docentes.xml");

                ser = new XmlSerializer(typeof(List<Docente>));

                listaDocentes = ((List<Docente>)ser.Deserialize(reader));
            }
            catch (Exception ex)
            {
                FuncionalidadLog.GuardarLog(ex.Message);
                
            }
            finally
            {
                reader.Close();
            }

            return listaDocentes;
        }


        public static bool SerializarAlumno(Alumno alumno, float notaFinal)
        {
            DateTime fecha = DateTime.UtcNow;

            string rutaAprobados= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Serializaciones\APROBADOS\";
            string rutaDesaprobados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Serializaciones\DESAPROBADOS\";


            bool retorno = false;

            try
            {

                if(!Directory.Exists(rutaAprobados) || !Directory.Exists(rutaDesaprobados))
                {
                    Directory.CreateDirectory(rutaAprobados);
                    Directory.CreateDirectory(rutaDesaprobados);

                    throw new SeCreoLaRutaException("La ruta no existia, asi que tuve que crearlo");
                    //Lanzar evento
                }
                /*else if()
                {
                    
                    //Lanzar evento
                }*/

                if (notaFinal >= 7)
                {

                    //using (XmlTextWriter xwr = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Serializaciones\APROBADOS\" + alumno.Apellido + "_" + alumno.Nombre + "_" + fecha.Day + "_" + fecha.Month + "_" + fecha.Year + ".xml", Encoding.UTF8))
                    using (XmlTextWriter xwr = new XmlTextWriter(rutaAprobados +@"\"+ alumno.Apellido + "_" + alumno.Nombre + "_" + fecha.Day + "_" + fecha.Month + "_" + fecha.Year + ".xml", Encoding.UTF8))
                    {
                        XmlSerializer xsr = new XmlSerializer(typeof(Alumno));
                        xsr.Serialize(xwr, alumno);
                        retorno = true;

                    }
                }
                else
                {
                    //using (XmlTextWriter xwr = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Serializaciones\DESAPROBADOS\" + alumno.Apellido + "_" + alumno.Nombre + "_" + fecha.Day + "_" + fecha.Month + "_" + fecha.Year + ".xml", Encoding.UTF8))
                    using (XmlTextWriter xwr = new XmlTextWriter(rutaDesaprobados +@"\"+ alumno.Apellido + "_" + alumno.Nombre + "_" + fecha.Day + "_" + fecha.Month + "_" + fecha.Year + ".xml", Encoding.UTF8))
                    {
                        XmlSerializer xsr = new XmlSerializer(typeof(Alumno));
                        xsr.Serialize(xwr, alumno);
                        retorno = true;

                    }
                }
                
            }
            catch (SeCreoLaRutaException ex)
            {

                FuncionalidadLog.GuardarLog(ex.Message);

            }

            
                
            
           

            return retorno;
        }

        public static Alumno DeserializarAlumno(string ruta)
        {
            // List<Docente> listaDocentes = new List<Docente>();
            Alumno alumno=null;
            try
            {
                reader = new XmlTextReader(ruta);

                ser = new XmlSerializer(typeof(Alumno));

                alumno = ((Alumno)ser.Deserialize(reader));
            }
            catch (Exception ex)
            {
                FuncionalidadLog.GuardarLog(ex.Message);

            }
            finally
            {
                reader.Close();
            }

            return alumno;
        }


    }

    
}
