#pragma checksum "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2cd618072275e2f38c3cd64ab929d396496c3cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ChangeCategoryCourse), @"mvc.1.0.view", @"/Views/Admin/ChangeCategoryCourse.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\_ViewImports.cshtml"
using CourseTeachCook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
using CourseTeachCook.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2cd618072275e2f38c3cd64ab929d396496c3cd", @"/Views/Admin/ChangeCategoryCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"973e770039118a62ffe1e7488ad63c162f9470bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ChangeCategoryCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/layout.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/changeCourse.css?v=2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeCategoryCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
  
  ViewData["Title"] = "Thông tin cá nhân";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2cd618072275e2f38c3cd64ab929d396496c3cd6942", async() => {
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2cd618072275e2f38c3cd64ab929d396496c3cd7202", async() => {
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
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2cd618072275e2f38c3cd64ab929d396496c3cd8378", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n  <div class=\"right-body col-lg-10\">\r\n    <div class=\"content-body\">\r\n      <h4>Cập nhật danh mục</h4>\r\n");
#nullable restore
#line 18 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
       using (var system = new CourseTeachCookContext())
      {
          List<Category> categories = ViewBag.listCategories;
          Course course = new Course();
          course = ViewBag.course;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\" id=\"head\">\r\n          \r\n          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2cd618072275e2f38c3cd64ab929d396496c3cd10910", async() => {
                WriteLiteral("\r\n            <div id=\"content\">\r\n              <div class=\"row content\" id=\"email\">\r\n                <p class=\"col-lg-2\">Khóa học</p>\r\n                <p class=\"col-lg-4 detail\">");
#nullable restore
#line 30 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
                                      Write(course.CourseName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
              </div>
              <div class=""row content"" id=""email"">
                <p class=""col-lg-2"">Danh mục mới</p>
                <select class=""col-lg-5"" name=""categoryID"" id=""categoryID"" style=""background-color: #101010; color: white; border:none; width: 40.5%; outline: none;"">
");
#nullable restore
#line 35 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
                         foreach (Category category in categories)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2cd618072275e2f38c3cd64ab929d396496c3cd12321", async() => {
#nullable restore
#line 37 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
                                                            Write(category.CategoryName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
                               WriteLiteral(category.CategoryId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
                        }                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </select>\r\n              </div>\r\n");
#nullable restore
#line 41 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
               if (ViewBag.result != null)
              {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
                 if (ViewBag.result.Equals(true))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                  <div class=\"row content\">\r\n                    <p class=\"col-lg-2\"></p>\r\n                    <button class=\"result col-lg-3 btn btn-success\">Đổi danh mục thành công</button>\r\n                  </div>\r\n");
#nullable restore
#line 49 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                  <div class=\"row content\">\r\n                    <p class=\"col-lg-2\"></p>\r\n                    <button class=\"result col-lg-3 btn btn-danger\">Đổi danh mục thất bại</button>\r\n                  </div>\r\n");
#nullable restore
#line 56 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
                 
              }

#line default
#line hidden
#nullable disable
                WriteLiteral("              <div class=\"submitForm\">\r\n                <input type=\"submit\" value=\"Lưu thông tin\">\r\n              </div>\r\n");
#nullable restore
#line 61 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
                 if(ViewBag.result != null){
                    ViewBag.result = null;
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"
                                                                           WriteLiteral(course.CourseId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 67 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Admin\ChangeCategoryCourse.cshtml"

      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n  </div>\r\n");
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
