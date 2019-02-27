using System;
using System.Collections.Generic;

namespace FrontVuelingAcademy.Models
{
    public partial class SubCategoria
    {
        public SubCategoria()
        {
            Curso = new HashSet<Curso>();
        }

        public int Id { get; set; }
        public string Sub_Categoria { get; set; }
        public int? Categoria { get; set; }
        public string ComentarioHtml { get; set; }
        public byte[] Imagen_Miniatura { get; set; }
        public byte[] Imagen_Grande { get; set; }

        public Categoria CategoriaNavigation { get; set; }
        public ICollection<Curso> Curso { get; set; }
    }
}
