using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vidly;

namespace Vidly.Controllers
{
    public class VideoTablaController : Controller
    {
        private VideosDBEntities db = new VideosDBEntities();

        // GET: VideoTabla
        public ActionResult Index()
        {
            return View(db.VideoTabla.ToList());
        }

        // GET: VideoTabla/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoTabla videoTabla = db.VideoTabla.Find(id);
            if (videoTabla == null)
            {
                return HttpNotFound();
            }
            return View(videoTabla);
        }

        // GET: VideoTabla/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VideoTabla/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VideoId,Titulo,Descripcion,Path")] VideoTabla videoTabla)
        {
            if (ModelState.IsValid)
            {
                db.VideoTabla.Add(videoTabla);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(videoTabla);
        }

        // GET: VideoTabla/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoTabla videoTabla = db.VideoTabla.Find(id);
            if (videoTabla == null)
            {
                return HttpNotFound();
            }
            return View(videoTabla);
        }

        // POST: VideoTabla/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VideoId,Titulo,Descripcion,Path")] VideoTabla videoTabla)
        {
            if (ModelState.IsValid)
            {
                db.Entry(videoTabla).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(videoTabla);
        }

        // GET: VideoTabla/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoTabla videoTabla = db.VideoTabla.Find(id);
            if (videoTabla == null)
            {
                return HttpNotFound();
            }
            return View(videoTabla);
        }

        // POST: VideoTabla/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VideoTabla videoTabla = db.VideoTabla.Find(id);
            db.VideoTabla.Remove(videoTabla);
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
