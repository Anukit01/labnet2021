using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabajoPractico.MVC.Models
{
    public class CategoriesView
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Category name must be provided.")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Must be at least 4 characters long.")]
        public string CategoryName { get; set; }
        public string Description { get; set; }       
    }
}