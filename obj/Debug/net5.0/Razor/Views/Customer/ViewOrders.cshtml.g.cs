#pragma checksum "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "452305b63f04dba54cc02c631b347582619a33c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ViewOrders), @"mvc.1.0.view", @"/Views/Customer/ViewOrders.cshtml")]
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
#line 1 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\_ViewImports.cshtml"
using CourseTeachCook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
using CourseTeachCook.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"452305b63f04dba54cc02c631b347582619a33c4", @"/Views/Customer/ViewOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"973e770039118a62ffe1e7488ad63c162f9470bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ViewOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Infor.css?v=1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Infor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewOrderDetailsCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: #0084ff;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_LayoutCustomer";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "452305b63f04dba54cc02c631b347582619a33c47478", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "452305b63f04dba54cc02c631b347582619a33c47740", async() => {
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
                WriteLiteral("\r\n\r\n");
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
#nullable restore
#line 11 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
 using (var connect = new CourseTeachCookContext())
{
    Customer customer = ViewBag.customer;

List<Order> orders = connect.Orders.Where(o=>o.CustomerId == customer.CustomerId).ToList();

    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""main_child"">

        <div class=""container"">

            <div class=""row"">

                <div id=""ctl00_divCenter"" class=""full-width col-sm-12"">

                    <div class=""row"">
                        <div class=""col-md-3 col-sm-4"">
                            <section class=""user-sidebar clearfix"">
                                <div class=""userinfo clearfix"">
                                    <figure>
                                        <img");
            BeginWriteAttribute("alt", " alt=\"", 911, "\"", 917, 0);
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 918, "\"", 968, 2);
            WriteAttributeValue("", 924, "/Image/ImageDesign/UserImage/", 924, 29, true);
#nullable restore
#line 31 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
WriteAttributeValue("", 953, customer.Image, 953, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""avatar user-img"">
                                        <figcaption>
                                            <div class=""title"">Tài khoản của</div>
                                            <div class=""user-name"">
                                                ");
#nullable restore
#line 35 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                           Write(customer.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </figcaption>\r\n                                    </figure>\r\n                                </div>\r\n");
            WriteLiteral(@"                            </section>
                            <nav class=""user-sidelink clearfix"">
                                <ul>

                                    <li class=""hvr-sweep-to-right active"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "452305b63f04dba54cc02c631b347582619a33c412222", async() => {
                WriteLiteral("<i class=\"fa fa-info-circle\"></i> Thông tin tài khoản");
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
#line 46 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                                                          WriteLiteral(customer.CustomerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </li>\r\n                                    <li class=\"hvr-sweep-to-right\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "452305b63f04dba54cc02c631b347582619a33c414915", async() => {
                WriteLiteral("\r\n                                            <i class=\"fa fa-lock\"></i> Đổi mật khẩu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                                                                                              WriteLiteral(customer.CustomerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                    \r\n                                    <li class=\"hvr-sweep-to-right\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "452305b63f04dba54cc02c631b347582619a33c417674", async() => {
                WriteLiteral("\r\n                                            <i class=\"fa fa-list-alt\"></i> Quản lý đơn hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                                                                                          WriteLiteral(customer.CustomerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                    <li class=\"hvr-sweep-to-right\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "452305b63f04dba54cc02c631b347582619a33c420441", async() => {
                WriteLiteral("<i class=\"fa fa-sign-out\"></i>\r\n                                            Thoát");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                                    
                                </ul>
                            </nav>
                        </div>

                        <div class=""col-md-9 col-sm-8"">
                            <div id=""ctl00_mainContent_pnlUser"" class=""user-page clearfix"">

                                <h1 class=""postname""> Khóa học của tôi </h1>



                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <table class=""table"" style=""background: #f2f2f2;"">
                                            <thead>
                                                <tr>
                                                    <th scope=""col"">Mã đơn hàng</th>
                                                    <th scope=""col"">Ngày mua</th>
                                                    <th scope=""col"">Khóa học</th>
                                                    <th scope=""col"">Tổn");
            WriteLiteral(@"g tiền</th>
                                                    <th scope=""col"">Trạng thái đơn hàng</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 81 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                 foreach (Order order in orders)

                                                {
                                                    int total = 0;
                                                    List<Orderdetail> orderdetails = connect.Orderdetails.Where(o => o.OrderId == order.OrderId).ToList();
                                                    foreach (Orderdetail orderdetail in orderdetails)
                                                    {
                                                        total = (orderdetail.CoursePrice+ orderdetail.MaterialPrice)*orderdetail.Quantity;

                                                    }
                                                    
                                                    Course course = new Course();

                                                    course = course.GetCourseDetails(orderdetails[0].CourseId);


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td scope=\"row\"  >");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "452305b63f04dba54cc02c631b347582619a33c424550", async() => {
#nullable restore
#line 97 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                                                                                                                                                                                                Write(order.OrderId);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                                                                                                            WriteLiteral(order.OrderId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                                                                                                                                           WriteLiteral(customer.CustomerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id1"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id1", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id1"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 98 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                       Write(order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 99 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                       Write(course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 100 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                       Write(string.Format(new CultureInfo("vi-VN"),"{0:c}",@total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        \r\n");
#nullable restore
#line 103 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                             if (order.OrderStatus == -1)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <td>\r\n                                                                    Đang chờ chấp nhận\r\n                                                                </td>\r\n");
#nullable restore
#line 108 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                            }
                                                            else if (order.OrderStatus == 0)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <td>\r\n                                                                    Đang chờ thanh toán\r\n                                                                </td>\r\n");
#nullable restore
#line 114 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                            }
                                                            else if (order.OrderStatus == 1)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <td>\r\n                                                                    Đã thanh toán\r\n                                                                </td>\r\n");
#nullable restore
#line 120 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                            }
                                                            else if (order.OrderStatus == -2)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <td>\r\n                                                                    Đã hủy\r\n                                                                </td>\r\n");
#nullable restore
#line 126 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                            }
                                                            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                 <td>\r\n                                                                    ");
#nullable restore
#line 129 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                               Write(order.OrderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                </td>\r\n");
#nullable restore
#line 131 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        \r\n                                                    </tr>\r\n");
#nullable restore
#line 134 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"

                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                                            </tbody>
                                        </table>

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
#nullable restore
#line 163 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\ViewOrders.cshtml"
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
