#pragma checksum "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\Introduce.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3bf00755802907681bd0ddbf724aae77b4c82b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Introduce), @"mvc.1.0.view", @"/Views/Customer/Introduce.cshtml")]
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
#line 1 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\Introduce.cshtml"
using CourseTeachCook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3bf00755802907681bd0ddbf724aae77b4c82b7", @"/Views/Customer/Introduce.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"973e770039118a62ffe1e7488ad63c162f9470bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Introduce : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Introduce.css?v=3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\Introduce.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_LayoutCustomer";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3bf00755802907681bd0ddbf724aae77b4c82b74267", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c3bf00755802907681bd0ddbf724aae77b4c82b74529", async() => {
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
                WriteLiteral("    <script src=\"js/site.js?v=2\"></script>\r\n");
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
            WriteLiteral("\r\n\r\n<div class=\"bg_contact\">\r\n\r\n    <img src=\"/Image/ImageDesign/IntroductImage/Slide_gioi-thieu.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 391, "\"", 397, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img_gt"">

</div>

<div class=""box_ab1"" id=""view1"">
    <div class=""container"">
        <div class=""row"">
            <div class=""top_ab1 clearfix"">
                <div class=""col-md-4 col-xs-12"">
                    <div class=""col1_ab"">
                        <h2 class=""tlt_ab1"">CHÚNG TÔI LÀ AI?</h2>
                        <div class=""formatTextStandard"">
                            <p style=""text-align: justify;"">EZcooking là trung tâm đào tạo nấu ăn được thành lập từ năm
                                2006, với trên 10 năm hoạt động, đào tạo hơn 3000 lượt học viên hàng năm.</p>
                            <p style=""text-align: justify;"">Chương trình đào tạo của EZcooking được xây dựng, giảng dạy
                                theo tiêu chuẩn, toàn diện và đầy thách thức sáng tạo kích thích học viên học hỏi, giao
                                lưu, chia sẻ nghệ thuật ẩm thực.</p>
                            <p style=""text-align: justify;"">Dựa trên tiêu chí đem lại kiến thức, k");
            WriteLiteral(@"ỹ năng và truyền cảm
                                hứng cho học viên thông qua sự chuyên nghiệp của giáo viên và cơ sở vật chất tốt nhất,
                                EZcooking mang đến cho sự tự tin trong nhà bếp và niềm vui trong nấu ăn trong gia đình
                                cũng nhưng định hướng nghề nghiệp trở thành đầu bếp chuyên nghiệp.</p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4 col-xs-12"">
                    <div class=""col1_ab"">
                        <h2 class=""tlt_ab1"">Tầm nhìn, sử mệnh của ezcooking</h2>
                        <div class=""formatTextStandard"">
                            <p style=""text-align: justify;""><strong>Tầm nhìn</strong></p>
                            <p style=""text-align: justify;"">Trở thành trung tâm đào tạo nấu ăn hàng đầu Việt Nam, trở
                                thành một nơi mà bất cứ ai cũng có thể đến học hỏi, giao lưu, chia sẻ hiểu biết về phong
         ");
            WriteLiteral(@"                       cách ẩm thực.</p>
                            <p style=""text-align: justify;""><strong>Sứ mệnh</strong></p>
                            <p style=""text-align: justify;"">Đem lại kiến thức, kỹ năng, và truyền cảm hứng cho mỗi học
                                viên thông qua chương trình giảng dạy tiêu chuẩn, toàn diện và đầy thách thức sáng tạo.
                                Với đội ngũ giáo viên và quy trình đào tạo chuyên nghiệp, cơ sở vật chất đầy đủ, chúng
                                tôi tin rằng EZ sẽ giúp cho học viên sự tự tin trong nhà bếp, niềm vui nấu ăn trong gia
                                đình cũng như định hướng phát triển trong sự nghiệp trở thành đầu bếp chuyên nghiệp.</p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4 col-xs-12"">
                    <div class=""logo_ab""><img src=""/Image/ImageDesign/LogoImage/Logo---1000.png""></div>
                </div>
            </div>
     ");
            WriteLiteral(@"   </div>
    </div>
    <div class=""cs_boxab1"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-4 col-xs-6"">
                    <div class=""cs_boxab_w cs_boxab_gr"">
                        <h2>01</h2>
                        <p>Cơ sở</p> <span><img
                                src=""/Image/ImageDesign/IntroductImage/icab.png""></span>
                    </div>
                </div>
                <div class=""col-md-2 col-xs-6"">
                    <div class=""cs_boxab_w cs_boxab_gr"">
                        <h2>40<span>%</span></h2>
                        <p>Tăng trưởng hàng năm</p> <span><img
                                src=""/Image/ImageDesign/IntroductImage/icab1.png""></span>
                    </div>
                </div>
                <div class=""col-md-3 col-xs-6"">
                    <div class=""cs_boxab_w cs_boxab_gr"">
                        <h2>15</h2>
                        <p>Bếp trưởng giảng dạy</p> <span><img
");
            WriteLiteral(@"                                src=""/Image/ImageDesign/IntroductImage/icab2.png""></span>
                    </div>
                </div>
                <div class=""col-md-3 col-xs-6"">
                    <div class=""cs_boxab_w cs_boxab_gr"">
                        <h2>3000</h2>
                        <p>Học viên / năm</p> <span><img
                                src=""/Image/ImageDesign/IntroductImage/icab3.png""></span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""cs_boxab2"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12 col-md-6""> <img src=""/Image/ImageDesign/IntroductImage/img_ab.jpg"" class=""img-responsive""> </div>
                <div class=""col-xs-12 col-md-6"">
                    <div class=""cs_boxab_2"">
                        <h3>CÁC KHÓA HỌC NẤU ĂN ĐÚNG NHU CẦU CỦA HỌC VIÊN</h3>
                        <p style=""text-align: justify;""><em>""Tôi vẫn thường nhận");
            WriteLiteral(@" được câu hỏi từ nhiều người, về một nơi
                                dạy nấu ăn chất lượng tốt. Nhưng phần lớn những địa chỉ khi đó không đáp ứng được mong
                                muốn của họ. Với xã hội đã có nhiều chuyển biến, đời sống ẩm thực phong phú, giao thoa
                                nhiều nền văn hóa ẩm thực quốc tế, tôi cảm nhận thật rõ, các cô gái muốn gì.</em><em>Là
                                biên tập viên một chương trình ẩm thực trên truyền hình, tôi ao ước có một phòng studio
                                riêng với đầy đủ dụng cụ, không gian và đặc biệt là có thể chủ động về mặt thời gian.
                                Vậy là EZcooking Class ra đời.</em>&nbsp;<em>Nhiều người vẫn đọc chữ E và chữ Z tách
                                rời, nhưng thực ra phải là easy – đúng thế - easy cooking – nấu ăn dễ dàng. Đó chẳng
                                phải là mong muốn của mọi người yêu nấu nướng hay sao?</em></p>
                        <p style=""text-align: ri");
            WriteLiteral(@"ght;""><em>- Giám đốc trẻ tại EZcooking tâm sự -</em></p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""box_tcez-index "" >
    <div class=""container"">
        <div class=""row"">
            <div class=""list_tcez1 text-center""> 
                <a");
            BeginWriteAttribute("href", " href=\"", 6867, "\"", 6874, 0);
            EndWriteAttribute();
            WriteLiteral(@"> 
                    <span>
                        <img class=""middle"" src=""https://daynauan.vn/isocms/templates/default/skin/images/icon/4.png"">
                    </span> 
                </a>
                <h2>
                    <a href=""/giao-vien.html"" style=""font-size: 28px;"">Giáo viên ezcooking</a>
                </h2>
                <p>
                    Giáo viên tại EZcooking với nhiều năm đào tạo dạy nấu ăn đem lại cảm hứng cho hơn 3000 học viên/năm.
                </p>
                <p>
                    Với mong muốn đem lại những trải nghiệm lý thú nhất cho học viên lớp nghề chuyên nghiệp, trung tâm
                    dạy nấu ăn EZcooking luôn tìm kiếm các cơ hội để học viên có cơ hội giao lưu, học hỏi và nâng cao
                    tay nghề.
                </p>
            </div>
        </div>

        <div class=""row"">
            <div class=""box_carousel_teacher"" style=""overflow: hidden;"">
                <div class=""jcarousel-box owl-carousel owl-the");
            WriteLiteral("me owl-responsive-1200 owl-loaded\" id=\"carousel_teacher\">\r\n                    <div class=\"owl-stage-outer\">\r\n                        <div class=\"owl-stage\" style=\"width: 2850px;\">\r\n\r\n");
#nullable restore
#line 148 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\Introduce.cshtml"
                             using (var connect = new CourseTeachingCookContext())
                            {
                                List<Teacher> list = new List<Teacher>();
                                list = @ViewBag.danhsachgiangvien;

                                int count = 1;

                                foreach (Teacher giangvien in list)
                                {
                                    if (count >= 13)
                                    {
                                        break;
                                    }
                                    count = count + 1;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""owl-item"" style=""width: 270px; margin-right: 30px;"">
                                        <div class=""w_cmnttcez"">
                                            <div class=""box_img_teacher text-center"">
                                                <a");
            BeginWriteAttribute("href", " href=\"", 9072, "\"", 9109, 2);
            WriteAttributeValue("", 9079, "#", 9079, 1, true);
#nullable restore
#line 166 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\Introduce.cshtml"
WriteAttributeValue("", 9080, giangvien.TeacherDescription, 9080, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" class=\"img_cmttcez\"> \r\n                                                    <img class=\"owl-lazy\" data-src=\"\"");
            BeginWriteAttribute("src", " src=\"", 9239, "\"", 9300, 2);
            WriteAttributeValue("", 9245, "/Image/ImageDesign/TeacherImage/", 9245, 32, true);
#nullable restore
#line 167 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\Introduce.cshtml"
WriteAttributeValue("", 9277, giangvien.TeacherImage, 9277, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 9301, "\"", 9307, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""opacity: 1; margin:auto"">
                                                
                                                </a> 
                                            </div>

                                            <div class=""txt_cmttcez text-center"" style=""margin-top: 35px;"">
                                                <h3>");
#nullable restore
#line 173 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\Introduce.cshtml"
                                               Write(giangvien.TeacherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                                <p>");
#nullable restore
#line 174 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\Introduce.cshtml"
                                              Write(giangvien.TeacherDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 178 "C:\Users\Administrator\OneDrive\Tài liệu\ProjectSEM2\CourseTeachCook\Views\Customer\Introduce.cshtml"
                                }
                            
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                    </div>


                </div>

            </div>


        </div>

    </div>
</div>

<div class=""csvc_box"" id=""view4"">
    <div class=""container"">
        <div class=""csvc_box1 clearfix"">
            <div class=""csvc_col1 mt30"">
                <div id=""carouselControls"" class=""carousel slide"" data-ride=""carousel"">
                    <div class=""carousel-inner"">
                        <div class=""carousel-item active"">
                            <img class=""d-block w-100"" src=""/Image/ImageDesign/IntroductImage/A1.jpg"" alt=""First slide"">
                        </div>
                        <div class=""carousel-item"">
                            <img class=""d-block w-100"" src=""/Image/ImageDesign/IntroductImage/A2.jpg"" alt=""Second slide"">
                        </div>
                        <div class=""carousel-item"">
                            <img class=""d-block w-100"" src=""/Image/ImageDesign/IntroductImage/A3.jpg"" al");
            WriteLiteral(@"t=""Third slide"">
                        </div>
                    </div>
                    <a class=""carousel-control-prev"" href=""#carouselControls"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#carouselControls"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
            </div>
            <div class=""csvc_col2"">
                <div class=""csvc_col2_top"">
                    <div class=""csvc_col2_top""> <img
                            src=""https://daynauan.vn/isocms/templates/default/skin/images/icon_txtab.jpg""> </div>
                </div>
                <div class=""csvc_col2_txt"">");
            WriteLiteral(@"
                    <h3><a>CƠ SỞ VẬT CHẤT HIỆN ĐẠI, ĐÚNG TIÊU CHUẨN CHÂU ÂU</a></h3>
                    <div class=""formatTextStandard"">
                        <p style=""text-align: justify;"">""Tôi hình dung đến một không gian nơi những dụng cụ không chỉ
                            đầy đủ, mà còn phải tiêu chuẩn sạch sẽ. Nơi những giáo viên giỏi nghề, đạo đức, thân thiện
                            và cởi mở sẽ giúp cho những ai đến với EZcooking - Easy Cooking thêm phần tự tin trong cuộc
                            sống, và một ý nghĩa khác nữa – họ có thể cảm thấy thư giãn, tìm thấy niềm vui từ việc nấu
                            ăn, làm ra những món ăn của mình, không chỉ để phục vụ người khác"".</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
