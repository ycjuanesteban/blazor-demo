using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Data.Vuelos
{
    public class Vuelo
    {
        public int Id { get; set; }
      
        [Required(ErrorMessage = "Ups! no se te olvide")]
        [StringLength(20, ErrorMessage = "Ups! se te fue la mano copiando")]
        public string Origen { get; set; }

        [Required(ErrorMessage = "Ups! no se te olvide")]
        [StringLength(20, ErrorMessage = "Ups! se te fue la mano copiando")]
        public string Destino { get; set; }

        [Required(ErrorMessage = "Ups! no se te olvide")]
        public DateTime HoraSalida { get; set; }

        [Required(ErrorMessage = "Ups! no se te olvide")]
        public DateTime HoraLlegada { get; set; }
    }
}
