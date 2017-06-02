using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LiftRecorder.Models;

namespace LiftRecorder.ViewModels
{
    public class LiftLoggerViewModel
    {
        public AppUser AppUser { get; set; }

        //The following properties slip up the lift types into lists
        public IEnumerable<Lift> ChestLifts { get; set; }
        public IEnumerable<Lift> LegLifts { get; set; }
        public IEnumerable<Lift> BackLifts { get; set; }
        public IEnumerable<Lift> ShoulderLifts { get; set; }

        //UsersLifts holds a list of a single users lifts
        public IEnumerable<UsersLift> UsersLifts { get; set; }

        public IEnumerable<Lift> Lifts { get; set; }//May not need this because of the above lift properties.
    }
}