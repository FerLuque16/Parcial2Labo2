using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Jardin
{
    public partial class FrmPrincipal : Form
    {
        FrmMostrarProximo frmMostrar;
        //FrmEvaluando frmEvalua;

        //Queue<Alumno> listaAlumnos;

        Queue<Alumno> listaAlumnos;
        List<Docente> listaDocentes;
        int contador = 0;

        //Thread hiloTiempo;
        //Thread hiloEvaluacion;
        Thread hiloEstadoJardin;

        //Thread hiloProximo;

        //public delegate void Evaluar(Alumno a, Docente d);
        //public delegate void SinAlumnos();
        public delegate void CambiarEstadoJardin();
        //public delegate void PasarAlumno(Alumno a, Docente d);

        //public delegate void DetenerConteo();

        //public event DetenerConteo PararTiempo;

        public event CambiarEstadoJardin EventoEstado;

        //public event PasarAlumno alumnoPasado;

        //public event Evaluar evaluarAlumno;

        //public event SinAlumnos NoQuedanAlumnos;


        #region Propiedades
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
            get 
            { 
                return this.listaDocentes; 
            }
            set 
            { 
                this.listaDocentes = value; 
            }
        }

        #endregion
        public FrmPrincipal()
        {
            InitializeComponent();
            this.cargarEntidades();
            //hiloTiempo = new Thread(new ParameterizedThreadStart(MostrarTiempo));
            EventoEstado += Recreo;

            
        }

        private void cargarEntidades()
        {
            this.listaAlumnos = FuncionalidadSql.CargarAlumnos();
            this.listaDocentes = FuncionalidadXML.DeserlizarDocentes();

            foreach (Alumno item in listaAlumnos)
            {
               
                rtb_Alumnos.AppendText(item.ToString()+"\n");
            }

            foreach (Docente item in listaDocentes)
            {

                rtb_Docentes.AppendText(item.ToString()+"\n");
                
            }

            foreach (Docente item in listaDocentes)
            {
                FuncionalidadSql.InsertarDocente(item);
            }
        }

        private void btn_IniciarJornada_Click(object sender, EventArgs e)
        {

            try
            {
               
                btn_IniciarJornada.Click -= btn_IniciarJornada_Click;
                
                timer_Evaluando.Start();

                
                frmMostrar = new FrmMostrarProximo();
                frmMostrar.Alumnos = this.listaAlumnos;
                frmMostrar.Docentes = this.listaDocentes;

                // frmMostrar.MatarHiloTiempo += DetenerHilos;
                frmMostrar.MatarHiloTiempo += DetenerHilos;

                frmMostrar.Show();

                hiloEstadoJardin = new Thread(AClases);

                hiloEstadoJardin.Start();

                
            }
            catch (Exception ex)
            {
                FuncionalidadLog.GuardarLog(ex.Message);
                
            }
           

        }

        public void DetenerHilos()
        {
            if (hiloEstadoJardin.IsAlive)
                    hiloEstadoJardin.Abort();

            if (timer_Evaluando.Enabled==true)
                    timer_Evaluando.Stop();
        }
             
       

        public void MostrarTiempo(object utcObj)
        {
            int utc=-3;
            Label lblTiempo = (Label)utcObj;

            while (true)
            {
                if (this.lbl_Tiempo.InvokeRequired)
                {
                    this.lbl_Tiempo.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lbl_Tiempo.Text = DateTime.UtcNow.AddHours(utc).ToString("hh:mm:ss");
                    });
                }
                else
                {
                    this.lbl_Tiempo.Text = DateTime.UtcNow.AddHours(utc).ToString("hh:mm:ss");
                }

                Thread.Sleep(1000);
            }
        }

        private void JardinUtn_FormClosing(object sender, FormClosingEventArgs e)
        {
           // if (!(hiloTiempo is null) && hiloTiempo.IsAlive)
             //   hiloTiempo.Abort();

           // if (hiloEvaluacion.IsAlive)
             //   hiloEvaluacion.Abort();

            if (!(hiloEstadoJardin is null) && hiloEstadoJardin.IsAlive)
                    hiloEstadoJardin.Abort();

            if(!(frmMostrar is null))
                frmMostrar.Close();

          /*  if (hiloProximo.IsAlive)
                hiloProximo.Abort();*/
        }
        public void Recreo()
        {
            CambiarLabel("Recreo");
            MessageBox.Show("Los alumnos ya evaluados estan en recreo");
            Thread.Sleep(5000);
            MessageBox.Show("Los alumnos ya han vuelto a las aulas");
            AClases();
        }

        public void AClases()
        {
            CambiarLabel("Hora de clases");           
            Thread.Sleep(20000);
            EventoEstado();
        }

        public void CambiarLabel(string msj)
        {
            if(lbl_Estado.InvokeRequired)
            {
                lbl_Estado.BeginInvoke((MethodInvoker)delegate ()
                {
                    lbl_Estado.Text = msj;
                }
                );
            }
            else
            {
                lbl_Estado.Text = msj;
            }

        }

        

        private void timer_Evaluando_Tick(object sender, EventArgs e)
        {
            contador++;
            lbl_Tiempo.Text = "Segundo desde que se inicio a evaluar: " + contador.ToString(); 



        }
    }
}
