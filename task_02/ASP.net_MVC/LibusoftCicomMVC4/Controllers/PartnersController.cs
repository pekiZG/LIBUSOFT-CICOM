using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using LibusoftCicomMVC4.Entities;
using LibusoftCicomMVC4.Models;

namespace LibusoftCicomMVC4.Controllers
{   
    public class PartnersController : Controller
    {
        private LibusoftCicomMVC4Context context = new LibusoftCicomMVC4Context();
        
        //
        // GET: /Partners/

        public ViewResult Index()
        {
            return View(context.Partners.ToList());
        }

        //
        // GET: /Partners/Details/5

        public ViewResult Details(int id)
        {
            Partner partner = context.Partners.Single(x => x.PartnerId == id);
            return View(partner);
        }

        //
        // GET: /Partners/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Partners/Create

        [System.Web.Mvc.HttpPost]
        public ActionResult Create(Partner partner)
        {
            if (ModelState.IsValid)
            {
                context.Partners.Add(partner);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(partner);
        }
        
        //
        // GET: /Partners/Edit/5
 
        public ActionResult Edit(int id)
        {
            Partner partner = context.Partners.Single(x => x.PartnerId == id);
            return View(partner);
        }

        //
        // POST: /Partners/Edit/5

        [System.Web.Mvc.HttpPost]
        public ActionResult Edit(Partner partner)
        {
            if (ModelState.IsValid)
            {
                context.Entry(partner).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(partner);
        }

        //
        // GET: /Partners/Delete/5
 
        public ActionResult Delete(int id)
        {
            Partner partner = context.Partners.Single(x => x.PartnerId == id);
            return View(partner);
        }

        //
        // POST: /Partners/Delete/5

        [System.Web.Mvc.HttpPost, System.Web.Mvc.ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Partner partner = context.Partners.Single(x => x.PartnerId == id);
            context.Partners.Remove(partner);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }

    public class PartnersXmlController : ApiController
    {
        private LibusoftCicomMVC4Context context = new LibusoftCicomMVC4Context();

        // GET api/partnersXml
        public List<Partner> Get()
        {
            List<Partner> partners = context.Partners.ToList();
            return partners;
        }
    }

}