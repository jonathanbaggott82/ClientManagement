using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement_Models.Models
{
    public class Client
    {
        // With this naming convention {Id}, Entity Framework knows that this is an identifier and will auto increment by 1 per new record.
        // If the property was called ClientId, we would have to use Data Annotations such as [Key] to explicitly specify this is an identifier.
        public int Id { get; set; }

        [Display(Name = "Client Name")]
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Headquarters { get; set; } = string.Empty;

        [Display(Name = "Date Founded")]
        [Required]
        public DateTime Founded { get; set; }

        [Display(Name = "Number of Locations")]
        [Required]
        public int NumLocations { get; set; } = 1;

        [Required]
        public string Industry { get; set; } = string.Empty;


    }
}
