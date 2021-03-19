using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopKz.Models
{
    public class Score
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }
        public Score()
        {
            Products = new List<Product>();
        }
    }
}
