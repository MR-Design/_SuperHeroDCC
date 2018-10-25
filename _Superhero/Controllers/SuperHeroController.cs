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
        //protected override void Dispose (bool disposing)
        //{
        //    db.Dispose();
        //}
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
                // TODO: Add insert logic here
                db.peoples.Add(people);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //[HttpPost]
        //public ActionResult Create(int id)
        //{
        //   //  List <People> Peoples = new List<People>();
        //   //db.peoples.Add(people);
        //    //peoples.Add()

        //    var newPeople = db.peoples.Where(n => !n.ID.Equals(id)).SingleOrDefault();

        //   // db.SubmitChanges(newPeople);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
        ///
        public ActionResult Index()
        {
           var GettingSuperHeros= db.peoples.ToList();
            return View(GettingSuperHeros);
        }

        // GET: Test/Details/5
        public ActionResult Details(int id)
        {
            var editing = db.peoples.Where(e => e.ID == id).SingleOrDefault();
            if (editing == null)
                return HttpNotFound(); // this should be a class
            return View(editing);
        }

        // GET: Test/Create
       
       

        // GET: Test/Edit/5
        public ActionResult Edit(int id)
        {
          
            return View();
        }

        // POST: Test/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Test/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Test/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
    }   }
}