using System;
using System.Collections.Generic;

namespace FrontVuelingAcademy.Models
{
    public partial class CursoAmedida
    {
        public CursoAmedida()
        {
            ModulosCursoAmedida = new HashSet<ModulosCursoAmedida>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaCreación { get; set; }

        public ICollection<ModulosCursoAmedida> ModulosCursoAmedida { get; set; }
    }
}
