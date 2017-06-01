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
            var lifts = _context.Lifts.ToList();

            var viewModel = new LiftLoggerViewModel
            {
                AppUser = appUser,
                //UsersLifts = usersLifts,
                Lifts = lifts
            };

            return View(viewModel);
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
            //var customers = _context.Customers.Include(c => c.MembershipType).ToList();.Include(c => c.UserLifts)
            //----------
            //var appUser = _context.AppUsers.SingleOrDefault(u => u.AppUserId == id).UsersLifts;  //NOT WORKING
            //-----------
            //var appUser = from u in _context.AppUsers
            //where u.AppUserId == id
            //select new AppUser
            //{
            //    FirstName = u.FirstName,
            //    LastName = u.LastName,
            //    Email = u.Email,
            //    UsersLifts = u.UsersLifts
            //};
            //-------------
            //var appUser = (from u in _context.AppUsers
            //               where u.AppUserId == id
            //               select u);
            //-----------
            //var appUser = _context.AppUsers.SingleOrDefault(u => u.AppUserId == id);
            //------------
            var appUser = _context.UsersLifts.SingleOrDefault(u => u.AppUserId == id); //Does get the user's lifts via the id.
            return View(appUser);
        }

    }
}