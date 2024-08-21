using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombres = "Cabito";
            persona.Apellidos = "Sanabria";
            persona.AsignarNombresCompletos();

            Console.WriteLine(persona.NombresCompletos);

            Persona persona2 = new Persona
            {
                Nombres = "Gabriel",
                Apellidos = "Reyes",
                Edad = 21,
            };

            Triangle aea = new Triangle();
            aea.Base = 5;
            aea.Altura = 10;
            Console.WriteLine(aea.CalcularArea());

            Console.Read();
        }
    }
}
