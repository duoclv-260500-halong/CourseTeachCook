#pragma checksum "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d708f97a2e0c89608ca3971c1f2587d4964bc6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Contact\Index.cshtml"
using CourseTeachCook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d708f97a2e0c89608ca3971c1f2587d4964bc6a", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"973e770039118a62ffe1e7488ad63c162f9470bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/contacts.css?v=2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_LayoutCustomer";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d708f97a2e0c89608ca3971c1f2587d4964bc6a4231", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8d708f97a2e0c89608ca3971c1f2587d4964bc6a4493", async() => {
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
            WriteLiteral("\r\n\r\n<div class=\"main_child\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            \r\n");
#nullable restore
#line 14 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Contact\Index.cshtml"
             using (var connect = new CourseTeachCookContext())
            {
                String[] colors = { "#23afc8", "#21977d", "#f18c50", "#4dce8f", "#b02b25", "#699212" };
                Contactsinformation contactsinformation = new Contactsinformation();
                List<Contactsinformation> contact1 = contactsinformation.GetContactAll();
                int index = 0;
                foreach (Contactsinformation contact in contact1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-xs-12 col-sm-6 col-md-4\">\r\n                        <div class=\"box_contact\"");
            BeginWriteAttribute("style", " style=\"", 874, "\"", 908, 2);
            WriteAttributeValue("", 882, "background:", 882, 11, true);
#nullable restore
#line 23 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Contact\Index.cshtml"
WriteAttributeValue(" ", 893, colors[index], 894, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"top_bcontact clearfix\"> <a class=\"ic_bcontact\" rel=\"nofollow\"> <img");
            BeginWriteAttribute("src", "\r\n                                src=\"", 1019, "\"", 1104, 2);
            WriteAttributeValue("", 1058, "/Image/ImageDesign/ContactImage/", 1058, 32, true);
#nullable restore
#line 25 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1090, contact.Image, 1090, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </a>\r\n                                <div class=\"txt_bcontact\">\r\n                                    <h2>");
#nullable restore
#line 27 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Contact\Index.cshtml"
                                   Write(contact.JobPosition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                    <p><span><img src=\"/Image/ImageDesign/ContactImage/icon_hl.png\"></span><a>");
#nullable restore
#line 28 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Contact\Index.cshtml"
                                                                                                         Write(contact.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                                    <p><span><img src=\"/Image/ImageDesign/ContactImage/icon_hl1.png\"></span><a rel=\"nofollow\"");
            BeginWriteAttribute("href", "\r\n                                    href=\"", 1505, "\"", 1570, 2);
            WriteAttributeValue("", 1549, "mailto:", 1549, 7, true);
#nullable restore
#line 30 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1556, contact.Email, 1556, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration: none;\">");
#nullable restore
#line 30 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Contact\Index.cshtml"
                                                                                           Write(contact.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"bot_bcontact\">\r\n                                <div class=\"text\">\r\n                                    <p> ");
#nullable restore
#line 35 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Contact\Index.cshtml"
                                   Write(contact.Description1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p> ");
#nullable restore
#line 36 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Contact\Index.cshtml"
                                   Write(contact.Description2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p> ");
#nullable restore
#line 37 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Contact\Index.cshtml"
                                   Write(contact.Description3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 42 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Contact\Index.cshtml"
                    index = index + 1;
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"clearfix mt30\"></div>\r\n    </div>\r\n</div>");
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
