using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiftRecorder.Models
{
    public class UsersLift
    {
        public int UsersLiftId { get; set; }
        public DateTime LiftDateTime { get; set; }
        public int Weight { get; set; }
        public int Reps { get; set; }

        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
        public Lift Lift { get; set; }
        public int LiftId { get; set; }
    }
}