using System;
using System.Collections.Generic;
using System.Text;

namespace ShopKz.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Score> Scores { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
        public SortViewModel SortViewModel { get; set; }
    }
}
