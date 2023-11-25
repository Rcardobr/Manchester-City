using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Manchester_City.Models.dbModels
{
    public partial class Noticium
    {
        [Key]
        public int IdNoticia { get; set; }
        [StringLength(100)]
        public string Titulo { get; set; } = null!;
        public int IdUsuario { get; set; }
        [StringLength(2000)]
        public string Contenido { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime FechaMod { get; set; }
        public string? ImagenNoticia { get; set; }

        [ForeignKey("IdUsuario")]
        [InverseProperty("Noticia")]
        public virtual ApplicationUser IdUsuarioNavigation { get; set; } = null!;
    }
}
