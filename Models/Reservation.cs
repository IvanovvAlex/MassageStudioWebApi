using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MassageStudioWebApi.Models
{
    public class Reservation
    {
        [Key]
        [Required]
        public int ReservationId { get; set; }

        [Required]
        public DateTime ReservationDateTime { get; set; }

        [Required]
        public int ClientId { get; set; }
        [Required]
        public Client Client { get; set; }

        [Required]
        public int МasseurId { get; set; }
        [Required]
        public Masseur Мasseur { get; set; }
    }
}
