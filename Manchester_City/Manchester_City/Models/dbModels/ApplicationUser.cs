using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Manchester_City.Models.dbModels
{
    public class ApplicationUser : IdentityUser<int>
    {
        public ApplicationUser()
        {
            FotoEquipos = new HashSet<FotoEquipo>();
            Jugadors = new HashSet<Jugador>();
            Noticia = new HashSet<Noticium>();
            Partidos = new HashSet<Partido>();
        }


        [Key]
        public int IdUsuario { get; set; }
        [StringLength(320)]
        public string Correo { get; set; } = null!;
        [StringLength(50)]
        public string Contraseña { get; set; } = null!;
        [StringLength(60)]
        public string Nombre { get; set; } = null!;
        public bool Notificaciones { get; set; }
        public DateTime FechaIngreso { get; set; }

        public virtual ICollection<FotoEquipo> FotoEquipos { get; set; }
        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Jugador> Jugadors { get; set; }
        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Noticium> Noticia { get; set; }
        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Partido> Partidos { get; set; }
    }
}
