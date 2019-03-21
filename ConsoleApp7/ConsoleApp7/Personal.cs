using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Personal
    {
        private int id;
        private string Nombre;
        private string Apellidos;

        public int ID { get { return id; } set { id = value; } }
        public string NOMBRE { get { return Nombre; } set { Nombre = value; } }
        public string APELLIDO { get { return Apellidos; } set { Apellidos = value; } }



        public Personal(int pid, string pNombre, string pApellido)
        {
            id = pid;
            Nombre = pNombre;
                    Apellidos = pApellido;
        }
    

    }
}
