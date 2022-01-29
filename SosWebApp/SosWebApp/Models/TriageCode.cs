using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SosWebApp.Models
{
    public class TriageCode 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [StringLength(250)]
        [Display(Name = "Denominación legal")]
        public string LegalName { get; set; }

        [Display(Name = "Tarifa Regular")]
        public double TarifaRegular { get; set; }

        


    }
}