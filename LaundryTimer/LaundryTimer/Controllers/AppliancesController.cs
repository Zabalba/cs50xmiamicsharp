using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LaundryTimer;

namespace LaundryTimer.Controllers
{
    public class AppliancesController : Controller
    {
        private LT_Model db = new LT_Model();

        // GET: Appliances
        public ActionResult Index()
        {
            return View(db.Appliances.ToList());
        }

        // GET: Appliances/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appliance appliance = db.Appliances.Find(id);
            if (appliance == null)
            {
                return HttpNotFound();
            }
            return View(appliance);
        }

        // GET: Appliances/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Appliances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,UserID,ApplianceTypeID,ApplianceName,ApplianceUserNote,ApplianceCycleLength,ApplianceActive,ApplianceCycleActive,ApplianceCycleEnd,NotifyOnCompletion")] Appliance appliance)
        {
            if (ModelState.IsValid)
            {
                db.Appliances.Add(appliance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(appliance);
        }

        // GET: Appliances/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appliance appliance = db.Appliances.Find(id);
            if (appliance == null)
            {
                return HttpNotFound();
            }
            return View(appliance);
        }

        // POST: Appliances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,UserID,ApplianceTypeID,ApplianceName,ApplianceUserNote,ApplianceCycleLength,ApplianceActive,ApplianceCycleActive,ApplianceCycleEnd,NotifyOnCompletion")] Appliance appliance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appliance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appliance);
        }

        // GET: Appliances/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appliance appliance = db.Appliances.Find(id);
            if (appliance == null)
            {
                return HttpNotFound();
            }
            return View(appliance);
        }

        // POST: Appliances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Appliance appliance = db.Appliances.Find(id);
            db.Appliances.Remove(appliance);
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
