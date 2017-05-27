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
        private ApplicationDbContext _context;

        public UserController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        // GET: User
        public ActionResult Index()
        {
            //TODO: Finish this portion!! Gotta sleep.
            return View();
        }
    }
}