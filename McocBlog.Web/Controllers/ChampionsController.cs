using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using McocBlog.Data;
using McocBlog.Models.EntityModels;

namespace McocBlog.Web.Controllers
{
    [RoutePrefix("Champions")]
    public class ChampionsController : Controller
    {
        private McocBlogContext db = new McocBlogContext();
        [Route]
        public ActionResult Index()
        {
            return View(db.Champions.ToList());
        }

        [Route("Details/{id}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Champion champions = db.Champions.Find(id);
            if (champions == null)
            {
                return HttpNotFound();
            }
            return View(champions);
        }
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Champions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Route("Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Attack,Class,ReleaseDate")] Champion champions)
        {
            if (ModelState.IsValid)
            {
                db.Champions.Add(champions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(champions);
        }        
        [Route("Edit/{Id}")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Champion champions = db.Champions.Find(id);
            if (champions == null)
            {
                return HttpNotFound();
            }
            return View(champions);
        }

        // POST: Champions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Route("Edit/{Id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Attack,Class,ReleaseDate")] Champion champions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(champions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(champions);
        }

        [Route("Delete/{Id}")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Champion champions = db.Champions.Find(id);
            if (champions == null)
            {
                return HttpNotFound();
            }
            return View(champions);
        }

        [Route("Delete/{Id}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Champion champions = db.Champions.Find(id);
            db.Champions.Remove(champions);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
