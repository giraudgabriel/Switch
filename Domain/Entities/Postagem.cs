﻿using System;

namespace Switch.Domain.Entities
{
    public class Postagem
    {
        public int Id { get; set; }
        public DateTime DataPublicacao { get; set; } = DateTime.Now;
        public string Texto { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int GrupoId { get; set; }
        public virtual Grupo Grupo { get; set; }
    }
}
