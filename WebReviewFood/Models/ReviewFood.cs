using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WebReviewFood.Models
{
    public class ReviewFood
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string TenBaiReview { get; set; }
        [Required]
        public string ThongtinFood { get; set; }
        [Required]
        public string DanhGiaFood { get; set; }
        [Required]
        public string ImageCover { get; set; }
        [Required]
        public byte IdCategory { get; set; }
    }
}