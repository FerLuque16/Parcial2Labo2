using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jardin
{
    public partial class FrmEvaluando : Form
    {
        
        Alumno alumno;
        Docente docente;
       

        List<Aula> aulas;

        List<string> listaObservaciones;
       
        public delegate void DetenerFormularios();


        public event DetenerFormularios MatarHilo;

        public Alumno Alumno
        {
            get
            {
                return this.alumno;
            }
            set
            {
                this.alumno = value;
            }
        }

        public Docente Docente
        {
            get
            {
                return this.docente;
            }
            set
            {
                this.docente = value;
            }
        }

        public FrmEvaluando()
        {
            InitializeComponent();

            aulas = FuncionalidadSql.CargarAulas();
            listaObservaciones = CargarObservaciones();
            
        }


        public void EvaluarAlumno()
        {
            

            try
            {
                ActualizarRTBAlumno(this.alumno);
                ActualizarRTBProfesor(this.docente);


                Random rnd = new Random();
                int nota1 = rnd.Next(0, 10);
                int nota2 = rnd.Next(0, 10);
                float notaFinal = (nota1 + nota2) / 2;
                int idAula = rnd.Next(1, 6);


                Evaluacion ev = new Evaluacion(this.alumno.Id, this.docente.Id, idAula, nota1, nota2, notaFinal, notaFinal.Observacion(listaObservaciones));// "Bien");

                FuncionalidadXML.SerializarAlumno(this.alumno, notaFinal);
                FuncionalidadSql.InsertarEvaluacion(ev);

                Thread.Sleep(8000);
                
                ActualizarListaRecreo(this.alumno);
            }
            catch (Exception ex)
            {

                FuncionalidadLog.GuardarLog(ex.Message);
            }           
        }


        public void ActualizarListaRecreo(Alumno a)
        {
            if (this.rtb_AlumnosAlRecreo.InvokeRequired)
            {
                this.rtb_AlumnosAlRecreo.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.rtb_AlumnosAlRecreo.AppendText(a.ToString());
                });
            }
            else
            {
                this.rtb_AlumnosAlRecreo.AppendText(a.ToString());
            }
        }     
        public void ActualizarRTBAlumno(Alumno a)
        {
            if (this.rtb_AlumnoEvaluado.InvokeRequired)
            {
                this.rtb_AlumnoEvaluado.BeginInvoke((MethodInvoker)delegate ()
               {
                   this.rtb_AlumnoEvaluado.Text = a.ToString();
               });
            }
            else
            {
                this.rtb_AlumnoEvaluado.Text = a.ToString();
            }

        }

        public void ActualizarRTBProfesor(Docente d)
        {
            if (this.rtb_ProfesorEvaluando.InvokeRequired)
            {
                this.rtb_ProfesorEvaluando.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.rtb_ProfesorEvaluando.Text = d.ToString();
                });
            }
            else
            {
                this.rtb_ProfesorEvaluando.Text = d.ToString();
            }

        }

        

        public static List<string> CargarObservaciones()
        {
            List<string> observaciones = new List<string>();
            observaciones.Add("Muy mal");
            observaciones.Add("Mal");
            observaciones.Add("Bien");
            observaciones.Add("Excelente");

            return observaciones;

        }
        

        private void FrmEvaluando_FormClosing(object sender, FormClosingEventArgs e)
        {

            MatarHilo.Invoke();
           
        }

        
    }
}
