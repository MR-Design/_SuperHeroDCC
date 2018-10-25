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
        private ApplicationDbContext db;

        public SuperHeroController()
        {
            db = new ApplicationDbContext();
        }
     
        // HttpGet
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(People people)
        {
            try
            {
                db.peoples.Add(people);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Index()
        {
           var GettingSuperHeros= db.peoples.ToList();
            return View(GettingSuperHeros);
        }

        public ActionResult Details(int id)
        {
            var superhero = db.peoples.Where(p => p.ID == id);
            return View(superhero);

        }


        public ActionResult Edit(int id)
        {
            var edditing = db.peoples.Where(e => e.ID == id).Select(e => e).SingleOrDefault();
            return View(edditing);
        }


        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {

            var edditing = db.peoples.Where(e => e.ID ==id).Select(e => e).SingleOrDefault();


            edditing.Name = collection["Name"];
            edditing.Age = Int32.Parse(collection["Age"]);
            edditing.alterEgo = collection["alterEgo"];
            edditing.primeryAbility = collection["primeryAbility"];
            edditing.secondaryAbility = collection["secondaryAbility"];
            edditing.catchphrase = collection["catchphrase"];

            
            db.SaveChanges();
            return RedirectToAction("Index");
         
        }

        public ActionResult Delete(int id)
        {
                var Deletting = db.peoples.Where(d => d.ID == id).Select(d => d).SingleOrDefault();
                db.peoples.Remove(Deletting);
                db.SaveChanges();
                return RedirectToAction("Index");            
    }   }
}