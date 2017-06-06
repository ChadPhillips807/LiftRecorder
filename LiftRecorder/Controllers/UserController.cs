using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiftRecorder.Models;
using LiftRecorder.ViewModels;

namespace LiftRecorder.Controllers
{
    public class UserController : Controller
    {
        // Need DbContext to access the database
        private ApplicationDbContext _context;

        public UserController()
        {
            // DbContext needs to be initialized in the constructor
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult LogUpdate(int id)
        {
            // Get user's data
            var appUser = _context.AppUsers.SingleOrDefault(u => u.AppUserId == id);

            // Get user's list of past lifts performed and add it to AppUser's UsersLifts object
            appUser.UsersLifts = _context.UsersLifts.ToList();

            // Get the list of lifts
            var lifts = _context.Lifts.ToList();

            // Create a ViewModel object and fill it's properties with the above values
            var viewModel = new LiftLoggerViewModel
            {
                AppUser = appUser,
                Lifts = lifts
            };

            return View(viewModel);// Pass the ViewModel object to the view
        }

        /// <summary>
        /// AddLift will add a newly added users lift to a UsersLift object
        /// and then to the logged in user's UsersLifts object.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddLift(LiftLoggerViewModel viewModel)
        {
            //Add the lift to the List<UsersLifts> object
            viewModel.UsersLifts.Add(viewModel.UserLift);

            //Should I make the viewModel.UsersLift = null now?

            return View(viewModel); // Return the updated viewModel Object to the view
        }

        public ActionResult SaveLift()
        {
            return View();
        }

        // GET: User
        public ViewResult Index()
        {
            //TODO: Finish this portion!! Gotta sleep.
            //Problem here is we are getting a list of users and we only want one, the user that is logged in
            var appUsers = _context.AppUsers;
            return View(appUsers);
        }


        public ViewResult Details(int id)
        {
            var appUser = _context.UsersLifts.SingleOrDefault(u => u.AppUserId == id); //gets the user's lifts via the id.
            return View(appUser);
        }

    }
}