using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MassageStudioWebApi.Models
{
    public class Client
    {
        public Client()
        {
            ClientReservations = new HashSet<Reservation>();
        }
        [Key]
        [Required]
        public int ClientId { get; set; }

        [Required]
        public string ClientName { get; set; }

        
        public ICollection<Reservation> ClientReservations { get; set; }
    }
}
