#pragma checksum "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCookAdmin\Views\Customer\Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e140fde24b2b29a804e8e48a757c3f3b2d9c6fbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Confirmation), @"mvc.1.0.view", @"/Views/Customer/Confirmation.cshtml")]
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
#line 1 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCookAdmin\Views\_ViewImports.cshtml"
using CourseTeachCook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCookAdmin\Views\Customer\Confirmation.cshtml"
using CourseTeachCook.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCookAdmin\Views\Customer\Confirmation.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e140fde24b2b29a804e8e48a757c3f3b2d9c6fbb", @"/Views/Customer/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"973e770039118a62ffe1e7488ad63c162f9470bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/confir.css?v=0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCookAdmin\Views\Customer\Confirmation.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_LayoutCustomer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e140fde24b2b29a804e8e48a757c3f3b2d9c6fbb4560", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e140fde24b2b29a804e8e48a757c3f3b2d9c6fbb4822", async() => {
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
#nullable restore
#line 12 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCookAdmin\Views\Customer\Confirmation.cshtml"
 using (var connect = new CourseTeachingCookContext())
{
    Contactsinformation contact = ViewBag.contact;

    Customer customer = ViewBag.customer;
    Course course = ViewBag.course;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""main_child main_success mb50"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-9 bore-right bg_fff "">
                    <h1 class=""title""> Đăng ký thành công </h1>
                    <div class=""formatTextStandard"">
                        <p><strong>Thông báo đăng ký thành công!</strong></p>
                        <p>Chúc mừng ");
#nullable restore
#line 25 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCookAdmin\Views\Customer\Confirmation.cshtml"
                                Write(customer.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 25 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCookAdmin\Views\Customer\Confirmation.cshtml"
                                                        Write(customer.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(") đã đăng ký khóa học thành công </p>\r\n                        <p>Khoá học: ");
#nullable restore
#line 26 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCookAdmin\Views\Customer\Confirmation.cshtml"
                                Write(course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        <p>Số người đăng kí: ");
#nullable restore
#line 27 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCookAdmin\Views\Customer\Confirmation.cshtml"
                                        Write(ViewBag.quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        <p>Giá khóa học: ");
#nullable restore
#line 28 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCookAdmin\Views\Customer\Confirmation.cshtml"
                                    Write(string.Format(new CultureInfo("vi-VN"),"{0:c}",course.CoursePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        <p>Giá nguyên liệu: ");
#nullable restore
#line 29 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCookAdmin\Views\Customer\Confirmation.cshtml"
                                       Write(string.Format(new CultureInfo("vi-VN"),"{0:c}",course.MaterialPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n                        <p><strong>Tổng thanh toán: ");
#nullable restore
#line 30 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCookAdmin\Views\Customer\Confirmation.cshtml"
                                               Write(string.Format(new CultureInfo("vi-VN"),"{0:c}",(course.CoursePrice + course.MaterialPrice)*ViewBag.quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </strong></p>
                        
                        <p>Chúng tôi đã nhận được yêu cầu của bạn. Chúng tôi sẽ kiểm tra thông tin đăng ký và sẽ phản hồi
                            tới bạn trong vòng 24h.</p>
                        <p> Vui lòng liên hệ nếu bạn cần hỗ trợ và giải đáp thắc mắc.</p>
                        <p>Hotline: ");
#nullable restore
#line 35 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCookAdmin\Views\Customer\Confirmation.cshtml"
                               Write(contact.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        <p>Email: <a");
            BeginWriteAttribute("href", " href=\"", 1841, "\"", 1848, 0);
            EndWriteAttribute();
            WriteLiteral(" > info@ezcooking.vn</a></p>\r\n                        <p>Trân trọng cảm ơn.</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 43 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCookAdmin\Views\Customer\Confirmation.cshtml"
}

#line default
#line hidden
#nullable disable
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
