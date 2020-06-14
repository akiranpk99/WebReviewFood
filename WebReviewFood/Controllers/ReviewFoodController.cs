using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Mvc;
using WebReviewFood.Models;
using WebReviewFood.ViewModels;

namespace WebReviewFood.Controllers
{
    public class ReviewFoodController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public ReviewFoodController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Food
        public ActionResult IndexListFood()
        {
            return View();
        }

        // GET: Food/Details/5
        public ActionResult FoodDetails(int id)
        {
            return View();
        }

        // GET: Food/Create
        public ActionResult CreateFood()
        {
            var viewModel = new ReviewFoodViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }

        // POST: Food/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateFood(ReviewFoodViewModel viewModel)
        {
                if (!ModelState.IsValid)
                {
                    viewModel.Categories = _dbContext.Categories.ToList();
                    return View("CreateFood", viewModel);
                }
                var reviewFood = new ReviewFood
                {
                    TenBaiReview = viewModel.TenBaiReview,
                    ThongtinFood = viewModel.ThongtinFood,
                    DanhGiaFood = viewModel.DanhGiaFood,
                    IdCategory = viewModel.Category,
                    ImageCover = viewModel.ImageCover
                };
                // TODO: Add insert logic here
                _dbContext.ReviewFoods.Add(reviewFood);
                _dbContext.SaveChanges();
                return RedirectToAction("IndexListFood");
        }

        // GET: Food/Edit/5
        public ActionResult EditFood(int id)
        {
            return View();
        }

        // POST: Food/Edit/5
        [HttpPost]
        public ActionResult EditFood(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("IndexListFood");
            }
            catch
            {
                return View();
            }
        }

        // GET: Food/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Food/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("IndexListFood");
            }
            catch
            {
                return View();
            }
        }
    }
}
