#pragma checksum "E:\Projects\Office\new\Satistic-Chart\Chart_in_Core\Chart_in_Core\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd44c7aabac4f5df839571a18b468995503211f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Projects\Office\new\Satistic-Chart\Chart_in_Core\Chart_in_Core\Views\_ViewImports.cshtml"
using Chart_in_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\Office\new\Satistic-Chart\Chart_in_Core\Chart_in_Core\Views\_ViewImports.cshtml"
using Chart_in_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd44c7aabac4f5df839571a18b468995503211f3", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88de316f60de9071d03dabcb51b94601bdf06e34", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/SiteTemplate/assets/css/Flowchart.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family:B Roya;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Projects\Office\new\Satistic-Chart\Chart_in_Core\Chart_in_Core\Views\Home\Privacy.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"fa\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd44c7aabac4f5df839571a18b468995503211f34741", async() => {
                WriteLiteral(@"
    
<style>
.modall {
   display: none; /* Hidden by default */
  position: fixed; /* Stay in place */
  z-index: 1; /* Sit on top */
  padding-top: 100px; /* Location of the box */
  left: 0;
  top: 0;
  width: 100%; /* Full width */
  height: 100%; /* Full height */
  overflow: auto; /* Enable scroll if needed */
  background-color: rgb(0,0,0); /* Fallback color */
  background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
}

/* Modal Content */
.modal-content {
  background-color: #fefefe;
  margin: auto;
  padding: 20px;
  border: 1px solid #888;
  width: 80%;
}

/* The Close Button */
.close {
  color: #aaaaaa;
  float: right;
  font-size: 28px;
  font-weight: bold;
}

.close:hover,
.close:focus {
  color: #000;
  text-decoration: none;
  cursor: pointer;
}

</style>

<script>
    
var modal = document.getElementById(""myModal"");

var btn = document.getElementById(""myBtn"");

// Get the <span> element that closes the modal
var span = document.getElements");
                WriteLiteral(@"ByClassName(""close"")[0];

// When the user clicks the button, open the modal 
btn.onclick = function() {
  modal.style.display = ""block"";
}

// When the user clicks on <span> (x), close the modal
span.onclick = function() {
  modal.style.display = ""none"";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
  if (event.target == modal) {
    modal.style.display = ""none"";
  }
}

</script>
  <title>CSS Tabs</title>
  <meta charset=utf-8>
   ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dd44c7aabac4f5df839571a18b468995503211f36582", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd44c7aabac4f5df839571a18b468995503211f38469", async() => {
                WriteLiteral(@"
  <div class=""tabbed"">
    <input type=""radio"" name=""tabs"" id=""tab-nav-1"" checked>
    <label for=""tab-nav-1"">نمودار وضعیت</label>
    <input type=""radio"" name=""tabs"" id=""tab-nav-2"">
    <label for=""tab-nav-2"">فلوچارت</label>
    <div class=""tabs"">
      <div>
        <h2>نمودار وضعیت</h2>
        
        
    </div>
      <div>
        <h2>فلوچارت</h2>
     
    </div>
     
    </div>
  </div>

<button id=""myBtn"">Open Modal</button>

<!-- The Modal -->
<div id=""myModal"" class=""modall"">

  <!-- Modal content -->
  <div class=""modal-content"" >
    <div class=""modal-header"">
        <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
        <h4 class=""modal-title"">Modal Header</h4>
      </div>
        <div class=""flowbody"" style=""overflow-x:scroll ;"">
          <div id=""wrapper"" >
              <span style=""background-color: green;"" class=""label"">
                  <div class=""tooltip""><span class=""tooltiptext"">
                    <table >  
      ");
                WriteLiteral(@"                  <tbody>  <tr><td>r_MoadiName: </td> <td>محمود معصوم زاده جوزداني </td> </tr> 
                            <tr><td>r_MoadiTIN: </td> <td>18167174280001 </td> </tr> 
                            <tr><td>r_CodeRahgiriSabtenam: </td> <td>1186386639 </td> </tr> 
                            <tr><td>r_ShenaseEzharnameh: </td> <td>100019 </td> </tr> 
                            <tr><td>r_Manba: </td> <td>مالیات بر درآمد مشاغل </td> </tr> 
                            <tr><td>r_Sal: </td> <td>1392 </td> </tr>
                            <tr><td>r_Dore: </td> <td>1 </td> </tr> 
                            <tr><td>r_MoadiType: </td> <td>حقیقی </td> </tr> 
                            <tr><td>r_DaramadEbrazi: </td> <td>136863000 </td> </tr>
                            <tr><td>r_MaliatEbrazi: </td> <td>27715750 </td> </tr> 
                            <tr><td>r_ManbaVoroodEzharname: </td> <td> </td> </tr> 
                            <tr><td>r_RiskEzharname: </td> <td> </td> </tr> 
             ");
                WriteLiteral(@"               <tr><td>r_SalMaliStartDate: </td> <td>1392/01/01 </td> 
                                </tr> <tr><td>r_SalMaliEndDate: </td> <td>1392/12/29 </td>
                                    </tr> <tr><td>r_MianSali: </td> <td>خیر </td> </tr> </tbody> </table>
                      </span>ارائه اظهارنامه</div>
              </span>
              <div class=""branch "">
                  <div class=""entry sole"">
                      <span style=""background-color: green;"" class=""label"">
                          درخواست اسناد و مدارک
                      </span>
                      <div class=""branch "">
                          <div class=""entry sole"">
                              <span style=""background-color: green;"" class=""label"">
                                  <div class=""tooltip""><span class=""tooltiptext"">
                                      <table dir=""rtl"">
                                          <tr>
                                              <td style=""width:100px;""");
                WriteLiteral(@"> تاریخ صدور :</td>
                                              <td>1400/03/18</td>
                                          </tr>
                                          <tr>
                                              <td style=""width:100px;""> شماره برگ تشخیص:</td>
                                              <td>140654198618</td>
                                          </tr>
                                      </table>
                                  </span>صدور برگ تشخیص</div>
                                  </span>
                              <div class=""branch lv1"">
                                  <div class=""entry"">
                                      <span style=""background-color: green;"" class=""label"">اعتراض</span>
                                      <div class=""branch lv2"">
                                          <div class=""entry"">
                                              <span class=""label"">Entry-1-1</span>
                                            ");
                WriteLiteral(@"  <div class=""branch lv3"">
                                                  <div class=""entry sole"">
                                                      <span class=""label"">Entry-1-1-1</span>
              
                                                      <div class=""branch "">
                                                          <div class=""entry "">
                                                              <span class=""label"">Entry-1-1-1-1</span>
              
                                                              <div class=""branch"">
                                                                  <div class=""entry sole"">
                                                                      <span class=""label"">Entry-1-1-1-1-1</span>
                                                                      <div class=""branch"">
                                                                          <div class=""entry sole"">
                                                   ");
                WriteLiteral(@"                           <span class=""label"">Entry-1-1-1-1-1-1</span>
              
                                                                          </div>
                                                                      </div>
                                                                  </div>
                                                              </div>
                                                          </div>
                                                          <div class=""entry "">
                                                              <span class=""label"">Entry-1-1-1-2</span>
              
                                                          </div>
                                                      </div>
              
                                                  </div>
                                              </div>
                                          </div>
                                          <div class=""entry");
                WriteLiteral(@""">
                                              <span class=""label"">Entry-1-2</span>
                                              <div class=""branch lv3"">
                                                  <div class=""entry sole""><span class=""label"">Entry-1-2-1</span></div>
                                              </div>
                                          </div>
                                          <div class=""entry"">
                                              <span class=""label"">Entry-1-3</span>
                                              <div class=""branch lv3"">
                                                  <div class=""entry sole"">
                                                      <span class=""label"">Entry-1-3-1</span>
              
                                                  </div>
                                              </div>
                                          </div>
                                      </div>
                           ");
                WriteLiteral(@"       </div>
                                  <div class=""entry"">
                                      <span style=""background-color: gray;"" class=""label"">تمکین</span>
                                      <div class=""branch lv3"">
                                          <div class=""entry sole""><span style=""background-color: gray;"" class=""label"">صدور برگ
                                                  قطعی</span></div>
                                      </div>
                                  </div>
                              </div>
                          </div>
                      </div>
                  </div>
              </div>
            </div>

     </div>
  </div>
  
</div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
