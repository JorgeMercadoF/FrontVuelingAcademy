using System;
using System.Collections.Generic;

namespace FrontVuelingAcademy.Models
{
    public partial class Modulo
    {
        public Modulo()
        {
            Lección = new HashSet<Lección>();
            ModulosCursoAmedida = new HashSet<ModulosCursoAmedida>();
            ModulosCursoCerrado = new HashSet<ModulosCursoCerrado>();
        }

        public int Id { get; set; }
        public string Modulo1 { get; set; }
        public string ComentarioHtml { get; set; }
        public int? Curso { get; set; }
        public int? DuracionEnMinutos { get; set; }
        public bool? HayEjercicios { get; set; }
        public int? Pos { get; set; }
        public int? IdProfesor { get; set; }

        public Curso CursoNavigation { get; set; }
        public Profesor IdProfesorNavigation { get; set; }
        public ICollection<Lección> Lección { get; set; }
        public ICollection<ModulosCursoAmedida> ModulosCursoAmedida { get; set; }
        public ICollection<ModulosCursoCerrado> ModulosCursoCerrado { get; set; }
    }
}
