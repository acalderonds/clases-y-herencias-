using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {


        static void Main(string[] args)
        {
            Profesor profesor = new Profesor(1, "Emanuel", "Medina");
            Personal personal = new Personal(2, "Fulanito", "Fulanito");

            Console.WriteLine("Clase", profesor);
            Console.WriteLine("Id : {0}", profesor);
            Console.WriteLine("Nombre : {0}", profesor);
            Console.WriteLine(" Apellido : {0}", profesor);
            Console.ReadKey();
           

        }
    }
}

