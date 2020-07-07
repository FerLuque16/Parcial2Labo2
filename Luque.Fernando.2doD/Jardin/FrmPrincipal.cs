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

        int contador = 0;

        FrmMostrarProximo frmMostrar;
        
        Queue<Alumno> colaAlumnos;
        List<Docente> listaDocentes;
               
        Thread hiloEstadoJardin;
        
        public delegate void CambiarEstadoJardin();
        
        public event CambiarEstadoJardin EventoEstado;

       


        #region Propiedades
        public Queue<Alumno> Alumnos
        {
            get 
            {
                return this.colaAlumnos;
            }
            set 
            { 
                this.colaAlumnos = value; 
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
            
            EventoEstado += Recreo;

            
        }

        

        private void btn_IniciarJornada_Click(object sender, EventArgs e)
        {

            try
            {
               
                btn_IniciarJornada.Click -= btn_IniciarJornada_Click;
                
                timer_Evaluando.Start();

                
                frmMostrar = new FrmMostrarProximo();

                frmMostrar.Alumnos = this.colaAlumnos;
                frmMostrar.Docentes = this.listaDocentes;
               
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

        private void cargarEntidades()
        {
            this.colaAlumnos = FuncionalidadSql.CargarAlumnos();
            this.listaDocentes = FuncionalidadXML.DeserlizarDocentes();

            foreach (Alumno item in colaAlumnos)
            {

                rtb_Alumnos.AppendText(item.ToString() + "\n");
            }

            foreach (Docente item in listaDocentes)
            {

                rtb_Docentes.AppendText(item.ToString() + "\n");

            }

            foreach (Docente item in listaDocentes)
            {
                FuncionalidadSql.InsertarDocente(item);
            }
        }

        public void DetenerHilos()
        {
            if (hiloEstadoJardin.IsAlive)
                    hiloEstadoJardin.Abort();

            if (timer_Evaluando.Enabled==true)
                    timer_Evaluando.Stop();
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
            lbl_Tiempo.Text = "Segundos desde que se inicio a evaluar: " + contador.ToString(); 

        }

        private void JardinUtn_FormClosing(object sender, FormClosingEventArgs e)
        {


            if (!(hiloEstadoJardin is null) && hiloEstadoJardin.IsAlive)
                hiloEstadoJardin.Abort();

            if (!(frmMostrar is null))
                frmMostrar.Close();


        }
    }
}
