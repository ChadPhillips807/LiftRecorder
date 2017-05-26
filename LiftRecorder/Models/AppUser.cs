using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LiftRecorder.Models
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        [Required]
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // May need this Navigation Property
        // This should link AppUser to the lifts they have performed
        //public ICollection<UsersLift> UsersLifts { get; set; }

    }
}