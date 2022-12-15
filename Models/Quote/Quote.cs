using System.ComponentModel.DataAnnotations;

namespace TestWebsite.Models.Quote
{
    public class Quote
    {
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Total Size (m2)")]
        public double TotalSize { get; set; }

        [Display(Name = "Total Rebuild Cost (£)")]
        public decimal TotalRebuildCost { get; set; }

        [Display(Name = "Flat Roof Cover needed?")]
        public bool IsFlatRoofCover { get; set; }

        [Display(Name = "Flat Roof Cover")]
        public int FlatRoofCover { get; set; }
    }
}
