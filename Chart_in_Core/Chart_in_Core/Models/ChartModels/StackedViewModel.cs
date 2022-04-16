using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart_in_Core.Models.ChartModels
{
    public class StackedViewModel
    {
        public string Stacked_Tax_Step { get; set; }
        public List<ChartViewModel> LstData { get; set; }
    }
}
