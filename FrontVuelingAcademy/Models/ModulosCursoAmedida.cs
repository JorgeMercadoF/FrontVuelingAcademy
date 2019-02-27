using System;
using System.Collections.Generic;

namespace FrontVuelingAcademy.Models
{
    public partial class ModulosCursoAmedida
    {
        public int Id { get; set; }
        public int? IdCursoAmedida { get; set; }
        public int? IdModuloAmedida { get; set; }
        public int? IdProfesor { get; set; }

        public CursoAmedida IdCursoAmedidaNavigation { get; set; }
        public Modulo IdModuloAmedidaNavigation { get; set; }
        public Profesor IdProfesorNavigation { get; set; }
    }
}
