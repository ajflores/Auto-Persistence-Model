using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control.Acceso.Data.Entity
{
    public class Usuario
    {
        public virtual int Id { get; set; }
        public virtual String Legajo { get; set; }
        public virtual String Nombre { get; set; }
        public virtual String Apellido { get; set; }
        public virtual String Documento { get; set; }
        public virtual String Telefono { get; set; }
        public virtual String Correo { get; set; }
        public virtual String Clave { get; set; }

        public override string ToString()
        {
            return Legajo + " " + Nombre + " " + Apellido;
        }
    }
}
