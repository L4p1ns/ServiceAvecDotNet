using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
//using ConsService.ServiceChambre;
//using ConsService.ServiceChambre;
using WcfService.Model;


namespace ConsService.Controllers
{
    public class ChambresController : Controller
    {
        ServiceChambre.Service1Client sw = new ServiceChambre.Service1Client();

        //private bdFadiouEntities db = new bdFadiouEntities();

        // GET: Chambres
        public ActionResult Index()
        {
            return View(sw.ListerChambres());
        }

        // GET: Chambres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var chambres = sw.ListerChambres().Where(a => a.idCh == id).FirstOrDefault();
            if (chambres == null)
            {
                return HttpNotFound();
            }
            return View(chambres);
        }

        // GET: Chambres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chambres/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCh,codeCh,libelle")] Chambres chambres)
        {
            if (ModelState.IsValid)
            {
                sw.AjouterChambre(chambres);
                //db.Chambres.Add(chambres);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chambres);
        }

        // GET: Chambres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chambres chambres = sw.ListerChambres().Where(a => a.idCh == id).FirstOrDefault();

                //sw.db.Chambres.Find(id);
            if (chambres == null)
            {
                return HttpNotFound();
            }
            return View(chambres);
        }

        // POST: Chambres/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCh,codeCh,libelle")] Chambres chambres)
        {
            if (ModelState.IsValid)
            {
                sw.EditerChambre(chambres);

                //db.Entry(chambres).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chambres);
        }

        // GET: Chambres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var chambres = sw.ListerChambres().Where(a => a.idCh == id).FirstOrDefault();



            if (chambres == null)
            {
                return HttpNotFound();
            }
            return View(chambres);
        }

        // POST: Chambres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            sw.SupprimerChambre(id);

            //Chambres chambres = db.Chambres.Find(id);
            //db.Chambres.Remove(chambres);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
