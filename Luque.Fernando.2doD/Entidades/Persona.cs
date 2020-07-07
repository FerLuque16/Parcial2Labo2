using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private int dni;
        private int edad;
        private string direccion;       
        

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }


        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
      

        public int Edad
        {
            get 
            { 
                return this.edad; 
            }
            set 
            { this.edad= value; 
            }
        }



        public string Direccion
        {
            get 
            { 
                return this.direccion; 
            }
            set 
            { 
               this.direccion = value; 
            }
        }

        public Persona()
        {
                
        }
        protected Persona(string nombre, string apellido, int dni, int edad, string direccion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.direccion = direccion;
        }

       

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido: " + this.Apellido);
            sb.AppendLine("Dni: " + this.Dni);
            sb.AppendLine("Direccion: " + this.Direccion);
            


            return sb.ToString();
        }
    }
}
