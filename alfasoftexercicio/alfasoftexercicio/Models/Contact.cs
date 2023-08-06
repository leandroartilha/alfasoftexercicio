using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace alfasoftexercicio.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [MaxLength(9)]
        [DisplayName("Contact")]
        public string? ContactNumber { get; set; }

        [MinLength(50)]
        [DisplayName("Email")]
        public string? Email { get; set; }
    }
}

