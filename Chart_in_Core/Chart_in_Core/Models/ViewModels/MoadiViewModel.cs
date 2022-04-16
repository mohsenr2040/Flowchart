using Chart_in_Core.Models;
using Chart_in_Core.Models.ChartModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Satistic.Models.ViewModels
{
    public class MoadiViewModel
    {
        public List<MoadiShenaseDto>? MoadiShenases { get; set; }
        [Required(ErrorMessage ="*")]
        public string? CodMelli { get; set; }
        [Required(ErrorMessage = "*")]
        public int ddl_sourceId { get; set; }
        [Required(ErrorMessage = "*")]
        public string Sal { get; set; }
        [Required(ErrorMessage = "*")]
        public int ddl_DoreId { get; set; }

        public List<MoadiDetailsDto> Lst_MoadiDetails { get; set; }

        public List<ChartViewModel> ChartViewModels { get; set; }
    }
}
