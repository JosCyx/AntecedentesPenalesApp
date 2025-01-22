using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntecedentesPenalesApp.Models
{
    internal class Persona
    {
        public int PersonaID { get; set; }
        public string Cedula { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int ProvinciaID { get; set; }
    }
}
