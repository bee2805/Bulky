﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bulky.Models
{
	public class Product
	{
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        public required string Description { get; set; }

        [Required]
        public required string ISBN { get; set; }

        [Required]
        public required string Author { get; set; }

        [Required]
        [DisplayName("List Price")]
        [Range(1, 1000)]
        public required double ListPrice { get; set; }

        [Required]
        [DisplayName("Price for 1-10")]
        [Range(1, 1000)]
        public required double Price { get; set; }

        [Required]
        [DisplayName("Price for 50+")]
        [Range(1, 1000)]
        public required double Price50 { get; set; }

        [Required]
        [DisplayName("Price for 100+")]
        [Range(1, 1000)]
        public required double Price100 { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public string ImageUrl { get; set; }
    }
}

