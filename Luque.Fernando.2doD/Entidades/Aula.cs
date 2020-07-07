using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        private int id;
        private string salita;


        

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

        

        public string Salita
        {
            get 
            { 
                return this.salita; 
            }
            set 
            { 
                this.salita = value; 
            }
        }

        public Aula(int id, string salita)
        {
            this.Id = id;
            this.Salita = salita;
        }

    }
}
