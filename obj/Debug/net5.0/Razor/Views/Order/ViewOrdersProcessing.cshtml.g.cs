#pragma checksum "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe0b75a6139dff0bf3226f42565783d0cac4d6cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_ViewOrdersProcessing), @"mvc.1.0.view", @"/Views/Order/ViewOrdersProcessing.cshtml")]
namespace AspNetCore
{
    #line hidden
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
#line 9 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
using CourseTeachCook.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
using CourseTeachCook.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe0b75a6139dff0bf3226f42565783d0cac4d6cb", @"/Views/Order/ViewOrdersProcessing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"973e770039118a62ffe1e7488ad63c162f9470bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_ViewOrdersProcessing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index1.css?v=11"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/viewOrdersHistory.css?v=3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Vị trí", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Staff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchStaffs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-lg-7"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: flex; height: 30px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewOrderDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewOrdersProcessing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
  
    ViewData["Title"] = "Quản lí nhân viên";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe0b75a6139dff0bf3226f42565783d0cac4d6cb10751", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fe0b75a6139dff0bf3226f42565783d0cac4d6cb11014", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fe0b75a6139dff0bf3226f42565783d0cac4d6cb12193", async() => {
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
            WriteLiteral(@"
<style>
    #manage-staff tr:nth-child(even) {
        background-color: #314359;
    }

    #manage-staff tr {
        height: 40px;
    }

    #manage-staff tr:nth-child(odd) {
        background-color: #203143;
    }

    #manage-staff th {
        background-color: black;
        height: 40px;
    }

    .page-item a {
        color: black;
    }
</style>
");
#nullable restore
#line 40 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
 using (var system = new CourseTeachCookContext())
{
    Order order1 = new Order();
    List<Order> orders = ViewBag.orders;
    double sum = Math.Ceiling(system.Orders.Where(o => (o.OrderStatus == -1) || (o.OrderStatus == 0)).ToList().Count()/(double)ViewBag.pageSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""right-body col-lg-10"">
        <div class=""title-body"">
            <div class=""row"">
                <h4 class=""col-lg-12"" style=""color: white;margin-left: 10px"">Hóa đơn đang chờ xử lí</h4>
            </div><br>

            <div class=""row"">
                <div class=""col-lg-5"">
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe0b75a6139dff0bf3226f42565783d0cac4d6cb15343", async() => {
                WriteLiteral("\r\n                    <label class=\"col-lg-5\" for=\"cars\" style=\"color: white\"></label>\r\n                    <select name=\"type\" class=\"col-lg-2\" id=\"staff\" style=\"outline: none; margin-left: -12px\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe0b75a6139dff0bf3226f42565783d0cac4d6cb15842", async() => {
                    WriteLiteral("ID");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe0b75a6139dff0bf3226f42565783d0cac4d6cb17086", async() => {
                    WriteLiteral("Ngày tạo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                    <div class=""col-lg-6 search"" style=""display: flex; border-radius: 10px"">
                        <input type=""text"" placeholder=""   Tìm kiếm..."" name=""key""
                        style=""border: none; border-radius: 5px 0px 0px 5px; outline:none"">
                        <input type=""submit"" id=""submit"" value=""Tìm kiếm"">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"content-body\">\r\n                <h4 style=\"color: white; margin-bottom: 35px\">Có: ");
#nullable restore
#line 71 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                                                             Write(system.Orders.Where(o => o.OrderStatus == -1 || o.OrderStatus == 0).ToList().Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@" hóa đơn
                </h4>
            <table id=""manage-staff"" style=""color: white; width: 100%"">
                <tr style=""font-family: ;"">
                    <th class=""col-lg-2"">KHÁCH HÀNG</th>
                    <th class=""col-lg-2"">EMAIL</th>
                    <th class=""col-lg-2"">NGÀY TẠO</th>
                    <th class=""col-lg-2"">TỔNG TIỀN</th>
                    <th class=""col-lg-2"">TRẠNG THÁI</th>
                    <th class=""col-lg-2"">TÁC VỤ</th>
                </tr>


");
#nullable restore
#line 84 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                 foreach (Order order in orders)
                {
                    Customer customer = system.Customers.Find(order.CustomerId);
                    List<Orderdetail> orderdetails = system.Orderdetails.Where(o => o.OrderId == order.OrderId).ToList();
                    long total = 0;
                    foreach (Orderdetail orderdetail in orderdetails)
                    {
                        total += (orderdetail.CoursePrice + orderdetail.MaterialPrice) * orderdetail.Quantity;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n\r\n                        <td class=\"col-lg-2\">");
#nullable restore
#line 95 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                                        Write(customer.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"col-lg-2\">");
#nullable restore
#line 96 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                                        Write(customer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"col-lg-2\">");
#nullable restore
#line 97 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                                        Write(order.OrderDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"col-lg-2\">");
#nullable restore
#line 98 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                                        Write(string.Format(new CultureInfo("vi-VN"),"{0:c}", total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 99 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                         if (@order.OrderStatus == -1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"col-lg-2\">Chờ chấp nhận</td>\r\n");
#nullable restore
#line 102 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                        }
                        else if (@order.OrderStatus == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"col-lg-2\">Chờ thanh toán</td>\r\n");
#nullable restore
#line 106 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"col-lg-2\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe0b75a6139dff0bf3226f42565783d0cac4d6cb24841", async() => {
                WriteLiteral("<i class=\"fas fa-eye\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                          WriteLiteral(order.OrderId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 110 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </table>
            <div class=""row"" style=""margin-top: 20px;"">

                <div class=""col-lg-3"">
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination"" style=""margin-left: 15px"">
                            
");
#nullable restore
#line 120 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                             for (int i = 0; i < sum; i++)
                            {
                                if (i == ViewBag.index)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item active\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe0b75a6139dff0bf3226f42565783d0cac4d6cb28348", async() => {
#nullable restore
#line 125 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                                                                                   Write(i+1);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-index", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 125 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                                                                       WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["index"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-index", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["index"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 126 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe0b75a6139dff0bf3226f42565783d0cac4d6cb31465", async() => {
#nullable restore
#line 130 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                                                 Write(i+1);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-index", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 130 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                                     WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["index"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-index", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["index"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 131 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </nav>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 139 "C:\Users\Administrator\OneDrive\Máy tính\CourseTeachCook\Views\Order\ViewOrdersProcessing.cshtml"
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
