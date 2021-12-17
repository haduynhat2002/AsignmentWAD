using AssignmentWAP.Data;
using AssignmentWAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentWAP.Controllers
{
    public class HomeController : Controller
    {
        private AssignmentWAPContext db = new AssignmentWAPContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            

            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,MaSinhVien,HinhThucNopPhat,TienNopPhat,ChongDay")] Student student)
        {         
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}