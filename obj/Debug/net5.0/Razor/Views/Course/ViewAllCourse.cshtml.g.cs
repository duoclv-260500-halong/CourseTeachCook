#pragma checksum "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e35db7df94813ac41f593f9cadfe5d2106f0aac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_ViewAllCourse), @"mvc.1.0.view", @"/Views/Course/ViewAllCourse.cshtml")]
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
#line 1 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\_ViewImports.cshtml"
using CourseTeachCook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
using CourseTeachCook.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e35db7df94813ac41f593f9cadfe5d2106f0aac", @"/Views/Course/ViewAllCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"973e770039118a62ffe1e7488ad63c162f9470bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_ViewAllCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/course.css?v=4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetCourseCus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img_boxli"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("/khoa-hoc/chuyen-nghiep"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-uppercase"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_LayoutCustomer";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e35db7df94813ac41f593f9cadfe5d2106f0aac6234", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3e35db7df94813ac41f593f9cadfe5d2106f0aac6496", async() => {
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
            WriteLiteral("\r\n\r\n<div class=\"main_child\">\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
     using (var connect = new CourseTeachCookContext())
    {
        List<Course> khoahoc = new List<Course>();

        Category danhmuc = new Category();

        khoahoc = ViewBag.ViewAllCourse;

        danhmuc = ViewBag.danhmuc;
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""container"">
            <div class=""select_course"">
                
                <ul class=""infor_select"">
                    <li class=""item_select item_select_course"">
                        <h1 style=""font-size: 18px; margin:0;""> ");
#nullable restore
#line 32 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
                                                           Write(danhmuc.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n");
            WriteLiteral("                    </li>\r\n                </ul>\r\n                \r\n            </div>\r\n\r\n            <div class=\"list_clnew list_clnew1 \" id=\"list_course_cat\">\r\n                <div class=\"row\">\r\n\r\n");
#nullable restore
#line 56 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
                     foreach (Course khoahocs in khoahoc)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-xs-12 col-sm-6 col-md-4 box\">\r\n                        <div class=\"box_liclnews\">\r\n                            <div class=\"img_boxliw\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e35db7df94813ac41f593f9cadfe5d2106f0aac10209", async() => {
                WriteLiteral(" <img\r\n                                    class=\"img-responsive\"");
                BeginWriteAttribute("src", " src=\"", 2544, "\"", 2603, 2);
                WriteAttributeValue("", 2550, "/Image/ImageDesign/CourseImage/", 2550, 31, true);
#nullable restore
#line 61 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
WriteAttributeValue("", 2581, khoahocs.FeatureImage, 2581, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2604, "\"", 2630, 1);
#nullable restore
#line 61 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
WriteAttributeValue("", 2610, khoahocs.CourseName, 2610, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
                                                                                                                WriteLiteral(khoahocs.CourseId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 60 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
AddHtmlAttributeValue("", 2439, khoahocs.CourseName, 2439, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"body_course\" style=\"padding-left: 0; padding-right: 0\">\r\n                                <p class=\"name_cat\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e35db7df94813ac41f593f9cadfe5d2106f0aac14333", async() => {
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 65 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
                                   Write(danhmuc.CategoryName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
                                                                                                                 WriteLiteral(khoahocs.CourseId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </p>\r\n                                <h4 class=\"title\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e35db7df94813ac41f593f9cadfe5d2106f0aac17283", async() => {
#nullable restore
#line 66 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
                                                                                                                                                                      Write(khoahocs.CourseName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
                                                                                                               WriteLiteral(khoahocs.CourseId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 66 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
AddHtmlAttributeValue("", 3194, khoahocs.CourseName, 3194, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </h4>\r\n                                <div class=\"info_sub\">\r\n                                    <label class=\"rate-1\">\r\n                                        <div");
            BeginWriteAttribute("class", " class=\"", 3408, "\"", 3456, 3);
            WriteAttributeValue("", 3416, "ratingStar", 3416, 10, true);
            WriteAttributeValue(" ", 3426, "ratingStar_", 3427, 12, true);
#nullable restore
#line 69 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
WriteAttributeValue("", 3438, khoahocs.CourseId, 3438, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("course_id", " course_id=\"", 3457, "\"", 3487, 1);
#nullable restore
#line 69 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
WriteAttributeValue("", 3469, khoahocs.CourseId, 3469, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("number_rate", " number_rate=\"", 3488, "\"", 3523, 1);
#nullable restore
#line 69 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
WriteAttributeValue("", 3502, khoahocs.CourseRates, 3502, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                        style=\"overflow: auto;\">\r\n");
#nullable restore
#line 71 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
                                             for (int i = 1; i <= khoahocs.CourseRates; i++)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <i class=\"fas fa-star\" style=\"color: yellow; font-size: 130%\"></i>\r\n");
#nullable restore
#line 74 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
                                                 for (int i = khoahocs.CourseRates+1; i <=5; i++)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <i class=\"fas fa-star\" style=\"color: #d0d0d0; font-size: 130%\"></i>\r\n");
#nullable restore
#line 78 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
                                                } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div> <span> (<span");
            BeginWriteAttribute("class", " class=\"", 4291, "\"", 4336, 3);
            WriteAttributeValue("", 4299, "rate_numb", 4299, 9, true);
            WriteAttributeValue(" ", 4308, "rate_num_", 4309, 10, true);
#nullable restore
#line 79 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
WriteAttributeValue("", 4318, khoahocs.CourseId, 4318, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 79 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
                                                                                                      Write(khoahocs.Views);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>)</span>\r\n                                    </label>\r\n                                    <span class=\"color_333 price\"> Giá: <span class=\"color_b22b25\" style=\"float: none\">\r\n                                            ");
#nullable restore
#line 82 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
                                       Write(string.Format(new CultureInfo("vi-VN"),"{0:c}",khoahocs.CoursePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n");
            WriteLiteral("                                            </span>\r\n                                    </span>\r\n                                </div>\r\n                                <div class=\"bot_boxli\" style=\"display: none\"> <a");
            BeginWriteAttribute("href", " href=\"", 4965, "\"", 4972, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""mr_boxli"">Chi tiết</a>
                                    <a href=""/dang-ky-khoa-hoc/my-bay-singapore-d52.html"" class=""rg_boxli""> Đăng ký học
                                        <img src=""https://daynauan.vn/isocms/templates/default/skin/images/icon/3.png"">
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 95 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    \r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"clearfix mt30\"></div>\r\n        </div>\r\n");
#nullable restore
#line 106 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Course\ViewAllCourse.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>");
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
