using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Manchester_City.Models.dbModels
{
    [Table("Equipo")]
    public partial class Equipo
    {
        public Equipo()
        {
            PartidoIdEquipoLocalNavigations = new HashSet<Partido>();
            PartidoIdEquipoVisitanteNavigations = new HashSet<Partido>();
        }

        [Key]
        public int IdEquipo { get; set; }
        [StringLength(20)]
        public string NombreEquipo { get; set; } = null!;
        public string LogoEquipo { get; set; } = null!;

        [InverseProperty("IdEquipoLocalNavigation")]
        public virtual ICollection<Partido> PartidoIdEquipoLocalNavigations { get; set; }
        [InverseProperty("IdEquipoVisitanteNavigation")]
        public virtual ICollection<Partido> PartidoIdEquipoVisitanteNavigations { get; set; }
    }
}
