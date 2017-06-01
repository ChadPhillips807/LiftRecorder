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
        public IEnumerable<UsersLift> UsersLifts { get; set; }
        public IEnumerable<Lift> Lifts { get; set; }
    }
}