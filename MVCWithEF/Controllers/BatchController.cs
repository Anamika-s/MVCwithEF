using MVCWithEF.Context;
using MVCWithEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithEF.Controllers
{
    public class BatchController : Controller
    {
        AppDbContext db = new AppDbContext();
        // GET: Batch
        public ActionResult Index()
        {
            var list = db.Batches.ToList();
            if (list.Count == 0)
            {
                ViewBag.msg = "There are  no batches";
                return View();
            }
            else
                return View(list);
        }

        Batch Search (int? id)
        {
            var batch = db.Batches.FirstOrDefault(x => x.Id == id);
            return batch;
        }
        public ActionResult Details(int? id)
        {
            if(!id.HasValue)
            {
                ViewBag.msg = "Please provide ID";
                return View();

            }
            var batch = Search(id);
            if(batch==null)
            {
                ViewBag.msg = "There is no batch with this ID";
                return View();
            }
            else
            return View(batch);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Batch batch)
        {
            db.Batches.Add(batch);
            db.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult Edit(int? id)
        {
            var batch = Search(id);
            if (batch == null)
            {
                ViewBag.msg = "There is no batch with this ID";
                return View();
            }
            else
                return View(batch);
          
        }



        [HttpPost]
        public ActionResult Edit(int id,  Batch batch)
        {
            var obj = Search(id);
            if(obj!=null)

            {
                 foreach(Batch temp in db.Batches)
                {
                    if(temp.Id == id)
                    {
                        temp.BatchName = batch.BatchName;
                        temp.StartDate = batch.StartDate;
                        temp.Trainer = batch.Trainer;
                        break;
                    }
                }
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            var batch = Search(id);
            if (batch == null)
            {
                ViewBag.msg = "There is no batch with this ID";
                return View();
            }
            else
                return View(batch);

        }



        [HttpPost]
        public ActionResult Delete(int id, Batch batch)
        {
            var obj = Search(id); if (obj != null)
            {
                db.Batches.Remove(obj);
                 db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}