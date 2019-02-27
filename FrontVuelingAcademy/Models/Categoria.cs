using System;
using System.Collections.Generic;

namespace FrontVuelingAcademy.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            SubCategoria = new HashSet<SubCategoria>();
        }

        public int Id { get; set; }
        public string Categoria1 { get; set; }
        public string ComentarioHtml { get; set; }
        public byte[] Imagen_Miniatura { get; set; }
        public byte[] Imagen_Grande { get; set; }
        public string Color { get; set; }

        public ICollection<SubCategoria> SubCategoria { get; set; }
    }
}
