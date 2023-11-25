using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Manchester_City.Models.dbModels
{
    [Table("FotoEquipo")]
    public partial class FotoEquipo
    {
        [Key]
        public int IdFotoEquipo { get; set; }
        [Column("FotoEquipo")]
        public string FotoEquipo1 { get; set; } = null!;
        [StringLength(50)]
        public string Nombre { get; set; } = null!;
        public int IdUsuario { get; set; }
        [Column(TypeName = "date")]
        public DateTime FechaMod { get; set; }

        [ForeignKey("IdUsuario")]
        [InverseProperty("FotoEquipos")]
        public virtual ApplicationUser IdUsuarioNavigation { get; set; } = null!;
    }
}
