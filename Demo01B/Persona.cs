using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    internal class Persona
    {
        public String Nombres { get; set; }

        public String  Apellidos { get; set; }

        public int Edad { get; set; }
        public String NombresCompletos { get; set; }

        public String MayordeEdad()
        {
            string mensaje = "Es menor de edad";
            if (Edad > 18)
                mensaje = "Es mayor de edad";

            return mensaje;
        }
        public void AsignarNombresCompletos()
        {
            NombresCompletos = Nombres + " " + Apellidos;
        }
    }
}
