using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Manchester_City.Models.dbModels
{
    [Table("Posicion")]
    public partial class Posicion
    {
        public Posicion()
        {
            Jugadors = new HashSet<Jugador>();
        }

        [Key]
        public int IdPosicion { get; set; }
        [StringLength(20)]
        public string Descripcion { get; set; } = null!;

        [InverseProperty("IdPosicionNavigation")]
        public virtual ICollection<Jugador> Jugadors { get; set; }
    }
}
