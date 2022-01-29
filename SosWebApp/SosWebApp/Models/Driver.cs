using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SosWebApp.Models
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        [Display (Name="Nombre")]
        public string Name { get; set; }

        [StringLength(10)]
        [Display(Name = "DNI")]
        public string DNI { get; set; }

        

    }
}