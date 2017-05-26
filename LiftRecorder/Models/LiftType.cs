using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LiftRecorder.Models
{
    public class LiftType
    {
        public int LiftTypeId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}