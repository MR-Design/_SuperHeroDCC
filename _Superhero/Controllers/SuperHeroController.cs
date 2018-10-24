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

            public ActionResult Detail()
        {
            var superheroList = "Top Super Heroes";
     

            List<string> superHeros = new List<string>();
            superHeros.Add("Batman");
            superHeros.Add("Superman");
            superHeros.Add("SpiderMan");


            return View();
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