using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using data_tables.Models;

namespace data_tables.Controllers
{
    public class datatabController : Controller
    {

        public ActionResult list()
        {
            return View();
        }


        // GET: datatab
        public ActionResult orderslist()
        {
            using (miniprojectsEntities datamod = new miniprojectsEntities())
            {
                var dataval = datamod.orders.ToList<order>();
                return Json(new { data = dataval }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult billspage()
        {
            return View();
        }
        public ActionResult billslist()
        {
            using (miniprojectsEntities billsmod = new miniprojectsEntities())
            {
                var billsval = billsmod.bills.ToList<bill>();
                return Json(new { data = billsval }, JsonRequestBehavior.AllowGet);
            }


            // eakhanath singh


        }
        public ActionResult salespage()
        {
            return View();
        }
        public ActionResult saleslist()
        {
            using (miniprojectsEntities salaesmod = new miniprojectsEntities())
            {
                var salesval = salaesmod.sales.ToList<sale>();
                return Json(new { data = salesval }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}