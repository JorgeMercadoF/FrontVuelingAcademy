using System;
using System.Collections.Generic;

namespace FrontVuelingAcademy.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            CursoImpartido = new HashSet<CursoImpartido>();
        }

        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string PosicionGeodesica { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public ICollection<CursoImpartido> CursoImpartido { get; set; }
    }
}
