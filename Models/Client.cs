using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MassageStudioWebApi.Models
{
    public class Client
    {
        [Key]
        [Required]
        public Guid ClientId { get; set; }

        [Required]
        public string ClientName { get; set; }

        [Required]
        public IList<Reservation> ClientReservations { get; set; }
    }
}
