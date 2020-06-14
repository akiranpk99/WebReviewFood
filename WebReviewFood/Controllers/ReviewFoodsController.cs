using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebReviewFood.Models;

namespace WebReviewFood.Controllers
{
    public class ReviewFoodsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ReviewFoods
        public async Task<ActionResult> Index()
        {
            return View(await db.ReviewFoods.ToListAsync());
        }

        // GET: ReviewFoods/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewFood reviewFood = await db.ReviewFoods.FindAsync(id);
            if (reviewFood == null)
            {
                return HttpNotFound();
            }
            return View(reviewFood);
        }

        // GET: ReviewFoods/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReviewFoods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,TenBaiReview,ThongtinFood,DanhGiaFood,ImageCover,IdCategory")] ReviewFood reviewFood)
        {
            if (ModelState.IsValid)
            {
                db.ReviewFoods.Add(reviewFood);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(reviewFood);
        }

        // GET: ReviewFoods/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewFood reviewFood = await db.ReviewFoods.FindAsync(id);
            if (reviewFood == null)
            {
                return HttpNotFound();
            }
            return View(reviewFood);
        }

        // POST: ReviewFoods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,TenBaiReview,ThongtinFood,DanhGiaFood,ImageCover,IdCategory")] ReviewFood reviewFood)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reviewFood).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(reviewFood);
        }

        // GET: ReviewFoods/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewFood reviewFood = await db.ReviewFoods.FindAsync(id);
            if (reviewFood == null)
            {
                return HttpNotFound();
            }
            return View(reviewFood);
        }

        // POST: ReviewFoods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ReviewFood reviewFood = await db.ReviewFoods.FindAsync(id);
            db.ReviewFoods.Remove(reviewFood);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
