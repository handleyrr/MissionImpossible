using MissionImpossible.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionImpossible.Controllers
{
    public class FormsController : Controller
    {
        private ApplicationDbContext _dbContext;

        public FormsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Forms
        public ActionResult Index()
        {
            var forms = _dbContext.Forms.ToList();

            return View(forms);
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Add(Form form)
        {
            _dbContext.Forms.Add(form);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var form = _dbContext.Forms.SingleOrDefault(m => m.Id == id);

            if (form == null)
                return HttpNotFound();

            return View(form);
        }

        [HttpPost]
public ActionResult Update(Form form)
        {
            var videoInDb = _dbContext.Forms.SingleOrDefault(m => m.Id == form.Id);

            if (videoInDb == null)
                return HttpNotFound();

            videoInDb.Form_name = form.Form_name;
            videoInDb.Description = form.Description;
            videoInDb.Type = form.Type;
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var form = _dbContext.Forms.SingleOrDefault(m => m.Id == id);

            if (form == null)
                return HttpNotFound();

            return View(form);
        }

        [HttpPost]
        public ActionResult DoDelete(int id)
        {
            var form = _dbContext.Forms.SingleOrDefault(m => m.Id == id);
            if (form == null)
                return HttpNotFound();
            _dbContext.Forms.Remove(form);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }

}