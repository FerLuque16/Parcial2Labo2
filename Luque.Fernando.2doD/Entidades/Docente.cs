using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Persona,IMostrar<Docente>
    {

        private string sexo;
        private string email;
        private int id;

      
        public string Sexo
        {
            get 
            { 
                return this.sexo; 
            }
            set 
            { 
                this.sexo = value; 
            }
        }

        public string Email
        {
            get 
            { 
                return this.email; 
            }
            set 
            { 
                this.email = value; 
            }
        }

       

        public int Id
        {
            get 
            { 
                return this.id; 
            }
            set 
            { 
                this.id = value; 
            }
        }


        public Docente()
        {

        }
       
        public Docente(string nombre, string apellido, int dni, int edad, string direccion, string sexo, string email) : base(nombre, apellido, dni, edad, direccion)
        {
            this.Sexo = sexo;
            this.Email = email;
        }

        public override string ToString()
        {
            

            return MostrarDatos(this);
        }

        public string MostrarDatos(IMostrar<Docente> elemento)
        {
            return string.Format("Nombre: {0}  Apellido: {1} \n", ((Docente)elemento).Nombre, ((Docente)elemento).Apellido);
        }
    }
}
