using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Familia:Persona
    {
        public DateTime FechaNaci { get; set; } 

        public int calcularEdad()
        {
            return 0;
        }
    }
}
