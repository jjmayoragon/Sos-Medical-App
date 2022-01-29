using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SosWebApp.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Nro. de Incidente")]
        public string NroIncidente { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Hora")]
        public DateTime Hora { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Paciente")]
        public string Paciente { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Diagnóstico")]
        public string Dx { get; set; }

        [StringLength(255)]
        [Display(Name = "Observaciones")]
        public string Obs { get; set; }

        [Display(Name = "Código")]
        public int? TriageCodeId { get; set; }
        public TriageCode TriageCode { get; set; }

        [Display(Name = "Coseguro")]
        public double? Coseguro { get; set; }

        [Display(Name = "Horario nocturno")]
        public bool IsPlus { get; set; }

        [Display(Name = "Identificador guardia")]
        public int GuardId { get; set; }

        public Guard Guard { get; set; }

    }
}