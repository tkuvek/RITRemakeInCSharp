#pragma checksum "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37a66ff29785e6b7e508d27a0529001dd9d74936"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Degrees), @"mvc.1.0.view", @"/Views/Home/Degrees.cshtml")]
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
#line 1 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\_ViewImports.cshtml"
using RITRemake;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\_ViewImports.cshtml"
using RITRemake.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37a66ff29785e6b7e508d27a0529001dd9d74936", @"/Views/Home/Degrees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"054dabf44b16584603ce0d8ed8c3110c7bd1273e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Degrees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DegreesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
  
    ViewData["Title"] = "Degrees page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"accordionDegrees\">\r\n    <h3>Undergraduate degrees</h3>\r\n    <div id=\"accordD1\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 12 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                 foreach (var undergraduate in Model.undergraduate)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n\r\n                    <h2>");
#nullable restore
#line 16 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                   Write(undergraduate.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 17 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                  Write(undergraduate.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                     foreach (var conc in undergraduate.concentrations)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        - ");
#nullable restore
#line 23 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                     Write(conc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n");
#nullable restore
#line 25 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 27 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <h3>Graduate degrees</h3>\r\n    <div id=\"accordD2\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 36 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                 foreach (var graduate in Model.graduate)
                {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                 if (graduate.degreeName == "graduate advanced certificates")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-12 text-center\">\r\n                    <h2>\r\n                        ");
#nullable restore
#line 42 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                   Write(graduate.degreeName.Substring(0, 1).ToUpper());

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                                                                 Write(graduate.degreeName.Substring(1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h2>\r\n                    <p>");
#nullable restore
#line 44 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                  Write(graduate.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul class=\"list-group list-group-flush\">\r\n\r\n");
#nullable restore
#line 47 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                         foreach (var cert in graduate.availableCertificates)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">\r\n                            <p>");
#nullable restore
#line 50 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                          Write(cert);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </li>\r\n");
#nullable restore
#line 52 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n");
#nullable restore
#line 55 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                 if (graduate.degreeName != "graduate advanced certificates")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    <h2>");
#nullable restore
#line 59 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                   Write(graduate.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 59 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                                    Write(graduate.degreeName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 60 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                  Write(graduate.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 61 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                     foreach (var conc in graduate.concentrations)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 63 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                  Write(conc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 64 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 66 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Kuvek\source\repos\Kuvek_P3\Kuvek_Project3\Views\Home\Degrees.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>

<script>
    $(function () {
        $(""#accordionDegrees"").accordion({
            collapsible: true,
            autoHeight: true,
            heightStyle: ""content""
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DegreesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591