using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MassageStudioWebApi.Models
{
    public class Reservation
    {
        public Reservation()
        {
            ReservationId = new Guid();
        }
        [Key]
        [Required]
        public Guid ReservationId { get; set; }

        [Required]
        public DateTime ReservationDateTime { get; set; }

        [Required]
        public Guid ClientId { get; set; }

        //[Required]
        //public Client Client { get; set; }

        [Required]
        public Guid МasseurId { get; set; }

        //[Required]
        //public Masseur Мasseur { get; set; }
    }
}
