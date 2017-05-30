using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiftRecorder.Models
{
    public class Lift
    {
        public int LiftId { get; set; }        
        public string Name { get; set; }
        public string LiftType { get; set; }
        //public LiftType LiftType { get; set; }
        //public int LiftTypeId { get; set; }
        // Do we need a Nav property here?
        
    }
}