#pragma checksum "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Home/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad0b4d31b76c593edb9e39feb1a4cd352b60db69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/_ViewImports.cshtml"
using ContosoUniversity_HiramTodd;

#line default
#line hidden
#line 2 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/_ViewImports.cshtml"
using ContosoUniversity_HiramTodd.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad0b4d31b76c593edb9e39feb1a4cd352b60db69", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fdcf04b01be0807fc29523bf04626ae696ea4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContosoUniversity_HiramTodd.Models.SchoolViewModels.EnrollmentDateGroup>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(93, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Home/About.cshtml"
  
    ViewData["Title"] = "Student Body Statistics";

#line default
#line hidden
            BeginContext(154, 179, true);
            WriteLiteral("\r\n<h2>Student Body Statistics</h2>\r\n\r\n<table>\r\n    <tr>\r\n        <th>\r\n            Enrollment Date\r\n        </th>\r\n        <th>\r\n            Students\r\n        </th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 19 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Home/About.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(374, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(423, 49, false);
#line 23 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Home/About.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(472, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(528, 17, false);
#line 26 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Home/About.cshtml"
           Write(item.StudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(545, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 29 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Home/About.cshtml"
    }

#line default
#line hidden
            BeginContext(588, 8, true);
            WriteLiteral("</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContosoUniversity_HiramTodd.Models.SchoolViewModels.EnrollmentDateGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
