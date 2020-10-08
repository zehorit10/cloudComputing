using BL;
using BL.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zehorit.Models;

namespace Zehorit.Controllers
{
    public class MedicationController : Controller
    {
        // GET: Medication
        public ActionResult Index()
        {
            MedicinesModel model = new MedicinesModel();
            return View(model.Medicines);
        }

        // GET: Medication/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Medication/Create
        public ActionResult Create()
        {
            Medication m = new Medication() { };
            return View();
        }

        // POST: Medication/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                MedicationAdminLogic bl = new MedicationAdminLogic();
                bl.AddMedication(collection["Name"], collection["Maker"], collection["GenericName"], collection["ActiveIngredients"], collection["Properties"], collection["ImageUrl"]);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Medication/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Medication/Edit/5
        [HttpPost]
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

        // GET: Medication/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Medication/Delete/5
        [HttpPost]
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
