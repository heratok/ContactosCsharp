using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresarial:Persona
    {
        public int Nit { get; set; }
        public string RazonSocial { get; set; }
        public string Correo { get; set; }
    }
}
 