﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DawgInHim.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required] //title is required
        public string Title { get; set; } 

        public string Description { get; set; }

        [Required] //ISBN is required
        public string ISBN { get; set; }

        [Required] //Author name is Required.
        public string Author { get; set; }
        
        [Required]
        [Range(1,10000)]
        [Display(Name = "List Price")]
        public double ListPrice { get; set; }

        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 1-49")]
        public double Price { get; set; }


        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 50-99")]
        public double Price50 { get; set; }

        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 100+")]
        public double Price100 { get; set; }

        [ValidateNever]
        public string ImageUrl { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }


        [Required]
        [Display(Name ="Cover Type")]
        public int CoverTypeId { get; set; }
        [ValidateNever]

        public CoverType CoverType { get; set; }

    }
}
