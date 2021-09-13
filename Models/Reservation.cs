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
        public Guid ReservationId { get; set; }

        [Required]
        public DateTime ReservationDateTime { get; set; }

        [Required]
        public Client ReservationClient { get; set; }        
        [Required]        
        public Masseur ReservationМasseur { get; set; }
    }
}
