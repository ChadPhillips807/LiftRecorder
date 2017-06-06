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

        //UserLift will hold a single UserLift entry that will be entered into
        //the UsersLifts list when "add lift" button is pushed
        public UsersLift UserLift { get; set; }

        //UsersLifts holds a list of a single users lifts
        //Needs to be a list for adding UsersLift objects
        public List<UsersLift> UsersLifts { get; set; }

        public IEnumerable<Lift> Lifts { get; set; }//May not need this because of the above lift properties.
    }
}