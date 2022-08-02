using displayModal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Web.Http;

namespace displayModal.Controllers
{
   

    public class CustomerReqController : Controller
    {

      readonly ICustomerReq customerReq;


       
            public CustomerReqController()
        {
            this.customerReq = customerReq;
        }





        //Get a Single record by id 
        [System.Web.Http.HttpGet]
        
        public ActionResult GetCRDataById(string id)
        {
            IList<CSRData> students = null;
            #region test
             
            var data = crRecord.Data.crRecord.FirstOrDefault(n => n.Id == id);
           
            
           

            return View(data);







            #endregion



        }



        // GET: CustomerReq
        public System.Web.Mvc.ActionResult Index()
        {
            return View();
        }

        // GET: CustomerReq/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerReq/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerReq/Create
        [System.Web.Http.HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerReq/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerReq/Edit/5
        [System.Web.Http.HttpPost]
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

        // GET: CustomerReq/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerReq/Delete/5
        [System.Web.Http.HttpPost]
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
        }
    }
}
