using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EVisionTask.Models
{
    public class ProductModel
    {
        [Required]
        public string Name { get; set; }
        public string PhotoPath { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public float Price { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
    }
}