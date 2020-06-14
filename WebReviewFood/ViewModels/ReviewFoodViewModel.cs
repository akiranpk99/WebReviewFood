using WebReviewFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebReviewFood.ViewModels
{
    public class ReviewFoodViewModel
    {
        [Required]
        public string TenBaiReview { get; set; }
        [Required]
        public string ThongtinFood { get; set; }
        [Required]
        public string DanhGiaFood { get; set; }
        [Required]
        public string ImageCover { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}