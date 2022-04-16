using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Satistic.Models
{
    public class Ddl_Source
    {
        public int Id { get; set; }
        //    public string item_Value { get; set; }
        public List<SelectListItem>? Select { set; get; }
    }

}
