#pragma checksum "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6067ff027b98e899932cbd745933e12c55a80587"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructors_Index), @"mvc.1.0.view", @"/Views/Instructors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Instructors/Index.cshtml", typeof(AspNetCore.Views_Instructors_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6067ff027b98e899932cbd745933e12c55a80587", @"/Views/Instructors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fdcf04b01be0807fc29523bf04626ae696ea4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContosoUniversity_HiramTodd.Models.SchoolViewModels.InstructorIndexData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
  
    ViewData["Title"] = "Instructors";

#line default
#line hidden
            BeginContext(129, 35, true);
            WriteLiteral("\r\n<h2>Instructors</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(164, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6067ff027b98e899932cbd745933e12c55a805875320", async() => {
                BeginContext(187, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(201, 279, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>Last Name</th>
            <th>First Name</th>
            <th>Hire Date</th>
            <th>Office</th>
            <th>Courses</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 24 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
         foreach (var item in Model.Instructors)
        {
            string selectedRow = "";
            if (item.ID == (int?)ViewData["InstructorID"])
            {
                selectedRow = "success";
            }

#line default
#line hidden
            BeginContext(711, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 726, "\"", 746, 1);
#line 31 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
WriteAttributeValue("", 734, selectedRow, 734, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(747, 45, true);
            WriteLiteral(">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(793, 43, false);
#line 33 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(836, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(904, 47, false);
#line 36 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(951, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1019, 43, false);
#line 39 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 42 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
                     if (item.OfficeAssignment != null)
                    {
                        

#line default
#line hidden
            BeginContext(1214, 30, false);
#line 44 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
                   Write(item.OfficeAssignment.Location);

#line default
#line hidden
            EndContext();
#line 44 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
                                                       
                    }

#line default
#line hidden
            BeginContext(1269, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 48 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
                      
                        foreach (var course in item.CourseAssignments)
                        {
                            

#line default
#line hidden
            BeginContext(1466, 22, false);
#line 51 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
                       Write(course.Course.CourseID);

#line default
#line hidden
            EndContext();
            BeginContext(1488, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1491, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(1494, 19, false);
#line 51 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
                                                   Write(course.Course.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1513, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
#line 52 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1572, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1637, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6067ff027b98e899932cbd745933e12c55a8058712167", async() => {
                BeginContext(1683, 6, true);
                WriteLiteral("Select");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
                                            WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1693, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1717, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6067ff027b98e899932cbd745933e12c55a8058714558", async() => {
                BeginContext(1762, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
                                           WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1770, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1794, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6067ff027b98e899932cbd745933e12c55a8058716946", async() => {
                BeginContext(1842, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
                                              WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1853, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1877, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6067ff027b98e899932cbd745933e12c55a8058719340", async() => {
                BeginContext(1924, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
                                             WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1934, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 62 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1989, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
#line 66 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
 if (Model.Courses != null)
{

#line default
#line hidden
            BeginContext(2047, 223, true);
            WriteLiteral("    <h3>Courses Taught by Selected Instructor</h3>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th></th>\r\n            <th>Number</th>\r\n            <th>Title</th>\r\n            <th>Department</th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 77 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
         foreach (var item in Model.Courses)
        {
            string selectedRow = "";
            if (item.CourseID == (int?)ViewData["CourseID"])
            {
                selectedRow = "success";
            }

#line default
#line hidden
            BeginContext(2499, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2514, "\"", 2534, 1);
#line 84 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
WriteAttributeValue("", 2522, selectedRow, 2522, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2535, 45, true);
            WriteLiteral(">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2581, 68, false);
#line 86 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
               Write(Html.ActionLink("Select", "Index", new { courseID = item.CourseID }));

#line default
#line hidden
            EndContext();
            BeginContext(2649, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2717, 13, false);
#line 89 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
               Write(item.CourseID);

#line default
#line hidden
            EndContext();
            BeginContext(2730, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2798, 10, false);
#line 92 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2808, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2876, 20, false);
#line 95 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
               Write(item.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2896, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 98 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2951, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
            EndContext();
#line 101 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
}

#line default
#line hidden
            BeginContext(2970, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 103 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
 if (Model.Enrollments != null)
{

#line default
#line hidden
            BeginContext(3008, 178, true);
            WriteLiteral("    <h3>\r\n        Students Enrolled in Selected Course\r\n    </h3>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Grade</th>\r\n        </tr>\r\n");
            EndContext();
#line 113 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
         foreach (var item in Model.Enrollments)
        {

#line default
#line hidden
            BeginContext(3247, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3308, 21, false);
#line 117 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
               Write(item.Student.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(3329, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3397, 40, false);
#line 120 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(3437, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 123 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3492, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 125 "/Users/hiramtodd/Documents/GitHub/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/ContosoUniversity_HiramTodd/Views/Instructors/Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversity_HiramTodd.Models.SchoolViewModels.InstructorIndexData> Html { get; private set; }
    }
}
#pragma warning restore 1591