
using Abp.Web.Mvc.Models;
using Chart_in_Core.Models;
using Chart_in_Core.Models.ChartModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Satistic.Models;
using Satistic.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Chart_in_Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IReportService _service;

        public HomeController(ILogger<HomeController> logger, IReportService service)
        {
            _service = service;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { });
        }

        //[HttpGet]
        //public IActionResult Lookup()
        //{
        //    return View(new SellerProductsViewModel());
        //}
       

        [HttpGet]
        public IActionResult Lookup(MoadiViewModel model, string CodMelli,int? ddl_sourceId, string sal, int ddl_DoreId)
        {
            if (ModelState.ErrorCount >= 1)
            {
                ViewData["ddl_items"] = new SelectList(ddl_Source.Select, "Value", "Text");
                return View(model);
            }
            string source=null;
            if (ddl_sourceId == null)
            {
                ViewData["ddl_items"] = new SelectList(ddl_Source.Select, "Value", "Text");
            }
            else
            {
                ViewData["ddl_items"] = new SelectList(ddl_Source.Select, "Value", "Text", ddl_sourceId);

                source = ddl_Source.Select.FirstOrDefault(d => d.Value == ddl_sourceId.ToString()).Text;
            }

            if (CodMelli!=null)
            {
                List<MoadiShenaseDto> lst_msdto=  _service.lookup(CodMelli,  sal,  source, ddl_DoreId.ToString());

               
                model = new MoadiViewModel
                {
                    MoadiShenases = lst_msdto,
                    ddl_sourceId = ddl_Source.Id,
                   // SimpleReports = lstModel,
                    //CodMelli= CodMelli
                };

            }
            //if(ProductId != null)
            //{
            //    model.productDetailsDtos = _service.GetDetails(ProductId);
            //}
           
            return  View(model);
        }

        [HttpGet]
        public IActionResult Details(MoadiViewModel model,string Sh_ezharname)
        {
            List<MoadiDetailsDto>  Lst_Details = _service.GetDetails(Sh_ezharname);
            model.Lst_MoadiDetails = _service.GetDetails(Sh_ezharname);

            var Lst_chart = new List<ChartViewModel>();

            foreach (var item in Lst_Details)
            {
                if (item.Field_Name == "r_DaramadEbrazi" || item.Field_Name == "t_DaramadTashkhis" ||
                    item.Field_Name == "e_DaramadEteraz" || item.Field_Name == "b_DaramadBadvi" || item.Field_Name == "gh_DaramadGhatee")
                    Lst_chart.Add(new ChartViewModel
                {
                    
                    Step = item.Field_Name,
                    Value = item.Field_Value,
                });
            }
            ViewBag.Chart = Newtonsoft.Json.JsonConvert.SerializeObject( Lst_chart);
            return Json(Lst_Details);
        }

       

         Ddl_Source ddl_Source = new Ddl_Source()
        {
            Select = new List<SelectListItem>
            {
                new SelectListItem {Text = "مالیات بر درآمد مشاغل", Value = "1"},
                new SelectListItem {Text = "مالیات بر درآمد شرکت ها", Value = "2"},
                new SelectListItem {Text = "مالیات بر ارزش افزوده", Value = "3"},
            }
        };
    }
}
