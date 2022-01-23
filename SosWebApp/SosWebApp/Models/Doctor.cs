using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SosWebApp.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name="Nombre")]
        public string Name { get; set; }

        [StringLength(10)]
        [Display(Name = "DNI")]
        public string DNI { get; set; }

        [StringLength(10)]
        [Display(Name = "Matrícula")]
        public string MAT { get; set; }

        public Guard Guard { get; set; }

    }
}