using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace ShopKz.Models
{
    public class FilterViewModel
    {
        public FilterViewModel(List<Score> scores, int? score, string name)
        {
            scores.Insert(0, new Score { Name = "ShopKz", Id = 0 });
            Scores = new SelectList(scores, "Id", "Name", score);
            SelectedScore = score;
            SelectedName = name;
        }
        public SelectList Scores { get; private set; }
        public int? SelectedScore { get; private set; }
        public string SelectedName { get; private set; }     
    }
}
