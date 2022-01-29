using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SosWebApp.Models
{
    public class Guard 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Identificador de Guardia")]
        public string Name { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Inicio")]
        public DateTime? Start { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Final")]
        public DateTime? Finish { get; set; }

        [Display(Name = "Doctor")]
        public int? DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        [Display(Name = "Conductor")]
        public int? DriverId { get; set; }

        [Display(Name = "Conductor")]
        public Driver Driver { get; set; }

        [Display(Name = "Móvil")]
        public int? AmbulanceId { get; set; }

        [Display(Name = "Unidad Móvil")]
        public Ambulance Ambulance { get; set; }

        public ICollection<Service> Services { get; set; }

    }
}