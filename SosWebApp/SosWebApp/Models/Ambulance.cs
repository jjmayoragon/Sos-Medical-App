using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SosWebApp.Models
{
    public class Ambulance
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Unidad")]
        public string Name { get; set; }

        [StringLength(10)]
        [Display(Name = "Patente")]
        public string Patente { get; set; }

        [StringLength(100)]
        [Display(Name = "Tipo de ambulancia")]
        public string AmbulanceCategory { get; set; }

        [StringLength(250)]
        [Display(Name = "Marca y modelo")]
        public string Description { get; set; }

        

    }
}