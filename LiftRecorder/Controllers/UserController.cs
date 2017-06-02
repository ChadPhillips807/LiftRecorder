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
            var appUser = _context.AppUsers.SingleOrDefault(u => u.AppUserId == id);
            //var usersLifts = _context.UsersLifts.Include("UsersLifts");
            appUser.UsersLifts = _context.UsersLifts.ToList();
            IEnumerable<Lift> chestLifts = _context.Lifts.Where(c => c.LiftType == "Chest");
            IEnumerable<Lift> backLifts = _context.Lifts.Where(c => c.LiftType == "Back");
            IEnumerable<Lift> legLifts = _context.Lifts.Where(c => c.LiftType == "Legs");
            IEnumerable<Lift> shoulderLifts = _context.Lifts.Where(c => c.LiftType == "Shoulders");

            var lifts = _context.Lifts.ToList();

            var viewModel = new LiftLoggerViewModel
            {
                AppUser = appUser,
                ChestLifts = chestLifts,
                BackLifts = backLifts,
                LegLifts = legLifts,
                ShoulderLifts = shoulderLifts,
                Lifts = lifts
            };

            return View(viewModel);
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