using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jardin
{
    public partial class FrmMostrarProximo : Form
    {
        

        Queue<Alumno> listaAlumnos;
        List<Docente> listaDocentes;

        

        FrmEvaluando eva;

        Thread hiloProximo;

        public delegate void DetenerHilosPrincipal();
        public delegate void CerrarForm();
        //public delegate void MostrarAlumno();
        public delegate void SinAlumnos();

       // public delegate void PasarAlumno();

        //public delegate void DetenerFormularios();
        public event DetenerHilosPrincipal MatarHiloTiempo;

        public event SinAlumnos NoHayAlumnos;

        //public event CerrarForm Cerrar;




        //public event PasarAlumno PasarAEvaluar;

        //public event MostrarAlumno AlumnoAMostrar;

        //public event DetenerFormularios MatarHilo;
        //public delegate void DetenerFormularios();

        public Queue<Alumno> Alumnos
        {
            get
            {
                return this.listaAlumnos;
            }
            set
            {
                this.listaAlumnos = value;
            }
        }

        public List<Docente> Docentes
        {
            get { return this.listaDocentes; }
            set { this.listaDocentes = value; }
        }


        

        //event MostrarProximo SiguienteAlumno; 
        public FrmMostrarProximo()
        {
            InitializeComponent();

            eva = new FrmEvaluando();

            NoHayAlumnos += MensajeNoHayAlumnos;
            eva.MatarHilo += DetenerHilo;
                                

            eva.Show();

            hiloProximo = new Thread(AlumnoAEvaluar);

            hiloProximo.Start();
         
        }

        

        private void AlumnoAEvaluar()
        {
            try
            {
                while (this.listaAlumnos.Count > 0)
                {

                    
                    bool listo = false;

                    
                    Alumno next = new Alumno();
                    Random rnd = new Random();
                    int indexDocente = rnd.Next(0, 9);
                    int indexAlumno = rnd.Next(0, listaAlumnos.Count);


                    if (listaAlumnos.Count == 1)
                    {
                        eva.Alumno = listaAlumnos.Peek();
                        eva.EvaluarAlumno();
                        listaAlumnos.Dequeue();
                        listo = true;
                    }
                    else
                    {
                        eva.Alumno = listaAlumnos.Dequeue();
                    }

                    
                    eva.Docente = listaDocentes[indexDocente];

                    if (listaAlumnos.Count > 0 && listo == false)
                    {
                        MostrarAlumnoProximo(listaAlumnos.Peek());
                        
                        eva.EvaluarAlumno();


                        //colaAlumnos.Dequeue(),listaDocentes[index]);

                    }


                }
                NoHayAlumnos();//Si no quedan alumnos invoco el evento
            }
            catch (Exception ex)
            {

                FuncionalidadLog.GuardarLog(ex.Message);
            }
           
        }
        

        public void MostrarAlumnoProximo(Alumno a)//, Docente d)
        {
            if (rtb_ProximoAEvaluar.InvokeRequired)
            {
                rtb_ProximoAEvaluar.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.rtb_ProximoAEvaluar.Text = a.ToString();
                });
            }
            else
            {
                this.rtb_ProximoAEvaluar.Text = a.ToString();
            }

           
        }

       

        public void MensajeNoHayAlumnos()
        {
            MessageBox.Show("Ya no quedan alumnos para evaluar");
            if (hiloProximo.IsAlive)
                hiloProximo.Abort();
            

        }

        public void DetenerHilo()
        {
            if (hiloProximo.IsAlive)
                hiloProximo.Abort();

            MatarHiloTiempo.Invoke();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            

            DetenerHilo();

            eva.Close();
           

        }
    }
}
