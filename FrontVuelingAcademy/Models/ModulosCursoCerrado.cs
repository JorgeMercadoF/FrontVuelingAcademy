using System;
using System.Collections.Generic;

namespace FrontVuelingAcademy.Models
{
    public partial class ModulosCursoCerrado
    {
        public int Id { get; set; }
        public int? IdCursoCerrado { get; set; }
        public int? IdModuloCerrado { get; set; }
        public int? IdProfesor { get; set; }

        public Curso IdCursoCerradoNavigation { get; set; }
        public Modulo IdModuloCerradoNavigation { get; set; }
    }
}
