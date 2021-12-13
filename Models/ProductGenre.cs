using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace netCore.Models
{
    public class ProductGenre
    {
        // public List<Product> Products { get; set; }
        // public SelectList CategoryID { get; set; }
        // public string Productgenre { get; set; }
        // public string SearchString { get; set; }

        public List<Product> Products { get; set; }
        public SelectList CategoryID { get; set; }
        public string Productgenre { get; set; }
        public string SearchString { get; set; }
    }
}