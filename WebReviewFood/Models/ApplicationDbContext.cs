using WebReviewFood.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace WebReviewFood.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ReviewFood> ReviewFoods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}