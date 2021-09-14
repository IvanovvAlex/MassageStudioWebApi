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
            MasseurReservations = new HashSet<Reservation>();
        }
        [Key]
        [Required]
        public int MasseurId { get; set; }

        [Required]
        public string MasseurName { get; set; }

        
        public ICollection<Reservation> MasseurReservations { get; set; }
    }
}
