using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Review
    {
        //Model holds the pertinent review data, and relates to Category and Rating models.
        [Key]
        public int ReviewID { get; set; }
        [MaxLength(40), Display(Name ="Review Title")]
        public string Title { get; set; }
        [Display(Name ="Property Name")]
        public string PropertyName { get; set; }
        [Display(Name ="Property Location")]
        public string PropertyLocation { get; set; }
        [Display(Name ="Reviewer Name")]
        public string Reviewer { get; set; }
        [Display(Name ="Date Reviewed")]
        public DateTime Date { get; set; }
        [MaxLength(500), Display(Name ="Write Review:")]
        public string Content { get; set; }

        [ForeignKey("Category"), Display(Name ="Property Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}