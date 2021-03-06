﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class ReviewsController : Controller
    {
        // GET: Reviews
        public ActionResult Index()
        {
            var model =
                from r in _reviews
                orderby r.Country
                select r;

            return View(model);
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
        [HttpPost]
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

        // GET: Reviews/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _reviews.SingleOrDefault(r => r.Id == id);
            return View(model);
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = _reviews.SingleOrDefault(r => r.Id == id);
            if (TryUpdateModel(review))
            {
                return RedirectToAction("Index");
            }
            return View(review);
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviews/Delete/5
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

        static List<RestaurantReview> _reviews = new List<RestaurantReview>
        {
            new RestaurantReview()
            {
                City = "Upland",
                Country = "USA",
                Id = 1,
                Name = "Bob's Joint",
                Rating = 10
            },

            new RestaurantReview()
            {
                City = "Rancho",
                Country = "USA",
                Id = 2,
                Name = "Cougar's",
                Rating = 3
            }
        };
    }
}
