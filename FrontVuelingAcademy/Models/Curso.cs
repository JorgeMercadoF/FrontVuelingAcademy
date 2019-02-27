using System;
using System.Collections.Generic;

namespace FrontVuelingAcademy.Models
{
    public partial class Curso
    {
        public Curso()
        {
            CursoImpartido = new HashSet<CursoImpartido>();
            Modulo = new HashSet<Modulo>();
            ModulosCursoCerrado = new HashSet<ModulosCursoCerrado>();
        }

        public int Id { get; set; }
        public string Curso1 { get; set; }
        public string Comentario_HTML { get; set; }
        public byte[] Imagen_Miniatura { get; set; }
        public byte[] Imagen_Grande { get; set; }
        public int? SubCategoria { get; set; }

        public SubCategoria SubCategoriaNavigation { get; set; }
        public ICollection<CursoImpartido> CursoImpartido { get; set; }
        public ICollection<Modulo> Modulo { get; set; }
        public ICollection<ModulosCursoCerrado> ModulosCursoCerrado { get; set; }
    }
}
