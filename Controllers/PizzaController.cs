﻿using la_mia_pizzeria_static.DataBase;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        // GET: PizzasController
        public ActionResult Index()
        {
            using (PizzeriaContext context = new PizzeriaContext())
            {

                List<Pizza> listPizzas = context.Pizzas.ToList();

                return View(listPizzas);
            }

        }

        // GET: PizzasController/Details/5
        public ActionResult Details(int id)
        {
            using(PizzeriaContext context = new PizzeriaContext())
            {
                Pizza pizza = context.Pizzas.Where(pizza => pizza.Id == id).FirstOrDefault();

                return View(pizza);
            }
        }

        // GET: PizzasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            //if (!ModelState.IsValid)
            //{

            //}
            using (PizzeriaContext context = new PizzeriaContext())
            {
                try
                {
                    Pizza newPizza = new Pizza()
                    {
                        Name = collection["Name"],
                        Image = collection["Description"],
                        Description = collection["Description"],
                        Price = Decimal.Parse(collection["Price"])
                    };

                    context.Pizzas.Add(newPizza);
                    context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View("Create", collection);
                }

            }

        }

        // GET: PizzasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
