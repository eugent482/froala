using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteProduct.Models
{
    public class ProductItemViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0.10, 100000, ErrorMessage = "Діапазон ціни від 0.10 до 10000.00")]
        public decimal Price { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Description { get; set; }
    }
    public class ProductAddViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0.10, 100000, ErrorMessage ="Діапазон ціни від 0.10 до 10000.00")]
        public decimal Price { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Description { get; set; }
        public string DescriptionImages { get; set; }
    }
}