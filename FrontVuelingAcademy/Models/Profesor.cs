using System;
using System.Collections.Generic;

namespace FrontVuelingAcademy.Models
{
    public partial class Profesor
    {
        public Profesor()
        {
            Modulo = new HashSet<Modulo>();
            ModulosCursoAmedida = new HashSet<ModulosCursoAmedida>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public byte[] Imagen { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public ICollection<Modulo> Modulo { get; set; }
        public ICollection<ModulosCursoAmedida> ModulosCursoAmedida { get; set; }
    }
}
