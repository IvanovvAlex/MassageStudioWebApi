using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MassageStudioWebApi.Models
{
    public class Masseur
    {
        public Masseur()
        {
            MasseurId = new Guid();
            MasseurReservations = new HashSet<Reservation>();
        }
        [Key]
        [Required]
        public Guid MasseurId { get; set; }

        [Required]
        public string MasseurName { get; set; }

        [Required]
        public ICollection<Reservation> MasseurReservations { get; set; }
    }
}
