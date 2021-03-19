using System;
using System.Collections.Generic;
using System.Text;

namespace ShopKz.Models
{
    public class SortViewModel
    {
        public SortState NameSort { get; private set; } 
        public SortState AgeSort { get; private set; } 
        public SortState ScoreSort { get; private set; }
        public SortState Current { get; private set; } 

        public SortViewModel(SortState sortOrder)
        {
            NameSort = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            AgeSort = sortOrder == SortState.AgeAsc ? SortState.AgeDesc : SortState.AgeAsc;
            ScoreSort = sortOrder == SortState.CompanyAsc ? SortState.CompanyDesc : SortState.ScoreAsc;
            Current = sortOrder;
        }
    }
}
