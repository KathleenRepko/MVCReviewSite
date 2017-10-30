using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Category
    {
        //Web application administrator should establish a list of property types (Hotel, Restaurant, Attraction, etc.)
        [Key]
        public int CategoryID { get; set; }
        [Display(Name ="Property Category")]
        public string CategoryName { get; set; }

        public virtual ICollection<Review> Review { get; set; }
    }
}