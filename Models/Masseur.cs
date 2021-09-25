using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MassageStudioWebApi.Models
{
    public class Masseur
    {        
        [Key]
        [Required]        
        public Guid MasseurId { get; set; }

        [Required]
        public string MasseurName { get; set; }
    }
}
