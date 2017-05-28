using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiftRecorder.Models;

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

        // GET: User
        public ActionResult Index()
        {
            //TODO: Finish this portion!! Gotta sleep.
            var appUsers = _context.AppUsers;
            return View(appUsers);
        }

        
    }
}