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

        [DataType(DataType.DateTime)]
        public DateTime? Start { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? Finish { get; set; }

        public int? DoctorId { get; set; }

        public Doctor Doctor { get; set; }

        public int? DriverId { get; set; }

        public Driver Driver { get; set; }

        public int? AmbulanceId { get; set; }

        public Ambulance Ambulance { get; set; }


    }
}