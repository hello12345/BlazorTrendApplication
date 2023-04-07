using System;
using System.Collections.Generic;
using System.Text;
using BlazorTrendApplication.Web.CustomValidation;
using System.ComponentModel.DataAnnotations;

namespace BlazorTrendApplication.Infrastructure.Models
{
    public class TrendModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please choose a trend")]
        public string TrendType { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Introduction is required")]
        public string Introduction { get; set; }
        public string Summary { get; set; }
        public string FileName { get; set; }
        public string ImgFile { get; set; }
        public string TargetedViewer { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [IsNumericAttribute(ErrorMessage = "Must be numeric")]
        public long? Price { get; set; }
        public int? UserId { get; set; }
        public bool Active { get; set; }
        public bool ImgChanged { get; set; }
        public string Status { get; set; }
        public string ImgSrc { get; set; }

    }
}
