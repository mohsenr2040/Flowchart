using Chart_in_Core.Models;
using System.Collections.Generic;

namespace Satistic.Models
{
    public interface IReportService
    {
        List<MoadiShenaseDto> lookup(string ncode, string sal, string source, string dore);
        List<MoadiDetailsDto> GetDetails(string Sh_ezharname);
    }
}
