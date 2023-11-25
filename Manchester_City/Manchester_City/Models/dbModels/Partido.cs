using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Manchester_City.Models.dbModels
{
    [Table("Partido")]
    public partial class Partido
    {
        [Key]
        public int IdPartido { get; set; }
        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }
        public int IdEquipoLocal { get; set; }
        public int IdEquipoVisitante { get; set; }
        public int? ResultadoLocal { get; set; }
        public int? ResultadoVisitante { get; set; }
        [Column(TypeName = "date")]
        public DateTime FechaMod { get; set; }
        public int IdUsuario { get; set; }
        [StringLength(500)]
        public string? DatoImportante { get; set; }

        [ForeignKey("IdEquipoLocal")]
        [InverseProperty("PartidoIdEquipoLocalNavigations")]
        public virtual Equipo IdEquipoLocalNavigation { get; set; } = null!;
        [ForeignKey("IdEquipoVisitante")]
        [InverseProperty("PartidoIdEquipoVisitanteNavigations")]
        public virtual Equipo IdEquipoVisitanteNavigation { get; set; } = null!;
        [ForeignKey("IdUsuario")]
        [InverseProperty("Partidos")]
        public virtual ApplicationUser IdUsuarioNavigation { get; set; } = null!;
    }
}
