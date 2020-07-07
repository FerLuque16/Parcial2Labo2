using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jardin;
using Entidades;
using System.IO;
using System.Collections.Generic;

namespace TesteosJardin
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SerializarAlumnos()
        {
            Alumno alumno = new Alumno(5, "Nombre", "Apellido", 12345, 19, "Avenida de Mayo");
           // Evaluacion evaluacion = new Evaluacion(5, 3, 3, 7, 7, 7, "Bien");


            Assert.IsTrue(FuncionalidadXML.SerializarAlumno(alumno, 7));
        }

        [TestMethod]
        public void DeserializarAlumnos()
        {

            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Serializaciones\APROBADOS\Apellido_Nombre_7_7_2020.xml";
            Assert.IsNotNull(FuncionalidadXML.DeserializarAlumno(ruta));

        }


        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void SerializarAlumnoBinario()
        {
            Alumno alumno = new Alumno(2, "NombreBinario", "ApellidoBinario", 1254, 20, "9 de Julio");

            FuncionalidadBinnary.SerializarAlumnoBinario(alumno);

            Assert.IsTrue(File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Serializaciones\APROBADOS\ApellidoBinario_NombreBinario_7_7_2020.dat"));
            

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void DeserializarAlumnoBinario()
        {

            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Serializaciones\APROBADOS\ApellidoBinario_NombreBinario_7_7_2020.dat";

            Assert.IsNotNull(FuncionalidadBinnary.DeserializarAlumnoBinario(ruta));

        }

        [TestMethod]
        public void DeserializarDocentes()
        {

            List<Docente> listaDocentes;

            
           listaDocentes = FuncionalidadXML.DeserlizarDocentes();

            Assert.IsTrue(listaDocentes.Count==10);
            

        }

    }
}
