using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Code_First_with_Repository_Pattern.Models
{
    /*[Table("")]*/
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public double CategoryNumber { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}