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

        
        public Client ReservationClient { get; set; }

        
        public Мasseur ReservationМasseur { get; set; }
    }
}
