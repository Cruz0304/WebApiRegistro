using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiRegistro.Models
{
    public class RegistroEntity
    {

        public int Id { get; set; }
        public string NombreCompania { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public string Correo { get; set; }
        public string telefono { get; set; }
    }
}