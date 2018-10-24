using _Superhero.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _Superhero.Controllers
{
    public class SuperHeroController : Controller
    {
        // GET: SuperHero
        public ApplicationDbContext db;

        public SuperHeroController()
        {
            db = new ApplicationDbContext();
        }



        public ActionResult Index()
        {
            return View();
            
        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Read()
        {
            return View();
        }
    }
}