using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MassageStudioWebApi.Models
{
    public class Мasseur
    {
        [Key]
        [Required]
        public Guid MasseurId { get; set; }

        [Required]
        public string MasseurName { get; set; }

        [Required]
        public IList<Reservation> MasseurReservations { get; set; }
    }
}
