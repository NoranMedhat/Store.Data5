﻿using System.ComponentModel.DataAnnotations;

namespace Store.Repository.Basket.Models
{
    public class BasketItemDto
    {
        [Required]
        [Range(0, int.MaxValue)]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        [Range(0.1,double.MaxValue, ErrorMessage ="Price Must be Greater than Zero")]
        public decimal Price { get; set; }
        [Required]
        [Range(1,10, ErrorMessage = "Quantity Must Between 1 And 10 Pieces ")]
        public int Quantity { get; set; }
        [Required]
        public string PictureUrl { get; set; }
        [Required]
        public string BrandName { get; set; }
        [Required]
        public string TypeName { get; set; }
    }
}