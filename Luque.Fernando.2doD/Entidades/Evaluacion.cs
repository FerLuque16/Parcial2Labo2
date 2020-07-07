using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Evaluacion
    {
        private int idEvaluacion;
        private int idAlumno;
        private int idDocente;
        private int idAula;
        private int nota1;
        private int nota2;
        private float notaFinal;
        private string observaciones;


        public int IdEvaluacion
        {
            get
            {
                return this.idEvaluacion;
            }
            set
            {
                this.idEvaluacion = value;
            }
        }

        public int IdAlumno
        {
            get 
            { 
                return this.idAlumno; 
            }
            set 
            {
                this.idAlumno = value; 
            }
        }

        public int IdDocente
        {
            get
            {
                return this.idDocente;
            }
            set
            {
               this.idDocente = value;
            }
        }

        public int IdAula
        {
            get
            {
                return this.idAula;
            }
            set
            {
                this.idAula = value;
            }
        }

        public int Nota1
        {
            get
            {
                return this.nota1;
            }
            set
            {
                this.nota1 = value;
            }
        }

        public int Nota2
        {
            get
            {
                return this.nota2;
            }
            set
            {
                this.nota2 = value;
            }
        }

        public float NotaFinal
        {
            get
            {
                return this.notaFinal;
            }
            set
            {
                this.notaFinal = value;
            }
        }

        

        public string Observaciones
        {
            get 
            { 
                return this.observaciones; 
            }
            set 
            { 
                this.observaciones = value; 
            }
        }


        public Evaluacion(int idAlumno, int idDocente, int idAula, int nota1, int nota2, float notaFinal, string observaciones)
        {
            this.IdAlumno = idAlumno;
            this.IdDocente = idDocente;
            this.IdAula = idAula;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.NotaFinal = notaFinal;
            this.Observaciones = observaciones;

        }                 
                          
                          
    }                    
}                        
