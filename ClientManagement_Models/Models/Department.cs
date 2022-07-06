using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement_Models.Models
{
    public class Department
    {
        // Using DepartmentId naming to demonstrate the need to specify it as a key.
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        // Navigation property indicating that this is a foreign key.
        [ForeignKey("Client")]
        public int Client_Id { get; set; }
        public Client Client { get; set; }
    }
}
