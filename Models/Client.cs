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
            ClientId = new Guid();
            //ClientReservations = new HashSet<Reservation>();
        }
        [Key]
        [Required]
        public Guid ClientId { get; set; }

        [Required]
        public string ClientName { get; set; }

        //[Required]
        //public ICollection<Reservation> ClientReservations { get; set; }
    }
}
