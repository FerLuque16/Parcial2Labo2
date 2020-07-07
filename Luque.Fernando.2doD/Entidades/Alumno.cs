using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	[Serializable]
    public class Alumno : Persona,IMostrar<Alumno>
    {
		private int id;
        private int idResponsable;


		

		public int Id
		{
			get 
			{ return this.id; 
			}
			set 
			{ 
				this.id = value; 
			}
		}

		public int IdResponsable
		{
			get 
			{ 
				return this.idResponsable; 
			}
			set 
			{ 
				this.idResponsable = value; 
			}
		}

		public Alumno()
		{

		}

		public Alumno(int id, string nombre, string apellido, int dni, int edad, string direccion) : base(nombre, apellido, dni, edad, direccion)
		{
			this.Id = id;

		}

		

		public override string ToString()
		{


			return MostrarDatos(this);
		}

		public string MostrarDatos(IMostrar<Alumno> elemento)
		{
			return string.Format("Nombre: {0}  Apellido: {1} \n", ((Alumno)elemento).Nombre, ((Alumno)elemento).Apellido);
		}
	}
}
