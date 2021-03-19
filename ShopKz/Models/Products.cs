using ShopKz.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopKz
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ScoreId { get; set; }
        public Score Score { get; set; }
    }
}
