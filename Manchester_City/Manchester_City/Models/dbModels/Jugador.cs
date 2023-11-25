using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Manchester_City.Models.dbModels
{
    [Table("Jugador")]
    public partial class Jugador
    {
        [Key]
        public int IdJugador { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; } = null!;
        public int IdUsuario { get; set; }
        [Column(TypeName = "date")]
        public DateTime FechaMod { get; set; }
        public int IdPosicion { get; set; }
        public int NumeroJugador { get; set; }
        public string FotoJugador { get; set; } = null!;

        [ForeignKey("IdPosicion")]
        [InverseProperty("Jugadors")]
        public virtual Posicion IdPosicionNavigation { get; set; } = null!;
        [ForeignKey("IdUsuario")]
        [InverseProperty("Jugadors")]
        public virtual ApplicationUser IdUsuarioNavigation { get; set; } = null!;
    }
}
