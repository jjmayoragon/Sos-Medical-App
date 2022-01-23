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

    }
}