#pragma checksum "C:\Users\maqam\Downloads\Vipexfinal99\Vipexfinal\Views\Xeberler\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec2b05fa6ca88e472b13f689ff9e2c8e48c62977"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Xeberler_Detail), @"mvc.1.0.view", @"/Views/Xeberler/Detail.cshtml")]
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
#line 1 "C:\Users\maqam\Downloads\Vipexfinal99\Vipexfinal\Views\_ViewImports.cshtml"
using Vipexfinal.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maqam\Downloads\Vipexfinal99\Vipexfinal\Views\_ViewImports.cshtml"
using Vipexfinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec2b05fa6ca88e472b13f689ff9e2c8e48c62977", @"/Views/Xeberler/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d949eea040bc70675f7caae4c80adda91bf9a36", @"/Views/_ViewImports.cshtml")]
    public class Views_Xeberler_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Xeber>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/xeberler2.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\maqam\Downloads\Vipexfinal99\Vipexfinal\Views\Xeberler\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec2b05fa6ca88e472b13f689ff9e2c8e48c629774334", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Vipex.az - Ən son kampaniya və xəbərlər</title>
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ec2b05fa6ca88e472b13f689ff9e2c8e48c629774938", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec2b05fa6ca88e472b13f689ff9e2c8e48c629776825", async() => {
                WriteLiteral(@"

    
    <section>
        <div class=""container"">
            <div class=""news-section_header"">
                <div class=""container"">
                    <div class=""news-section_title"">
                        Xəbərlər
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section style=""margin: 5em 0;"">
        <div class=""container"">
            <div class=""row"">

                <div class=""col-md-4 left-column"">
                    <aside class=""news-sidebar"">
                        <div class=""news-h3_title""><span class=""news-h3_title-text"">Xəbərlər</span></div>
                        <div class=""news-sidebar_content"">
                            <div class=""news-sidebar_item"">
                                <div class=""news-sidebar_item-img"" style=""background-image:url(https://vipex.az/storage/news/OfohDhhv52Ht83lVuBJBSjrRvOp9yS2ZgoJZWmVT.jpeg);background-position:center;width: 104px;height: 100px;""></div>
                ");
                WriteLiteral(@"                <div class=""news-sidebar_item-desc"">

                                    <span class=""news-sidebar_item-title""><a href=""./xeberler2.html"">Vipex.az saytında bağlamanı bəyan etmə qaydası</a></span>
                                </div>
                            </div>
                            <div class=""news-sidebar_item"">
                                <div class=""news-sidebar_item-img"" style=""background-image:url(https://vipex.az/storage/news/pDNVeH0da8GnC0nEI3RkRU9P4V7bp34B4ls5gUo6.jpeg);background-position:center;width: 104px;height: 100px;""></div>
                                <div class=""news-sidebar_item-desc"">

                                    <span class=""news-sidebar_item-title""><a href=""./xeberler3.html"">Bağlamanı e customs saytında necə bəyan etmək olar?</a></span>
                                </div>
                            </div>
                            <div class=""news-sidebar_item"">
                                <div class=""news-sidebar_item");
                WriteLiteral(@"-img"" style=""background-image:url(https://vipex.az/storage/news/TF9cPC1Q3E99jxT12pLeA3XS97uq8chWunF4KThi.jpeg);background-position:center;width: 104px;height: 100px;""></div>
                                <div class=""news-sidebar_item-desc"">

                                    <span class=""news-sidebar_item-title""><a href=""./xeberler4.html"">Kompüter hissələri sifarişi</a></span>
                                </div>
                            </div>
                            <div class=""news-sidebar_item"">
                                <div class=""news-sidebar_item-img"" style=""background-image:url(https://vipex.az/storage/news/CW8ejJxpLfdK1mUn0jisCK3sNBInx31awVsoaYMQ.jpeg);background-position:center;width: 104px;height: 100px;""></div>
                                <div class=""news-sidebar_item-desc"">

                                    <span class=""news-sidebar_item-title""><a href=""xeberler/turkiyeden-kosmetika-1.html"">Türkiyədən kosmetika</a></span>
                                </div");
                WriteLiteral(@">
                            </div>




                        </div>
                    </aside>
                </div>
               
                    <div class=""col-md-8 order-md-2 left-column"" style=""background-color: #eef5fb;"">
                        <div class=""main-news""");
                BeginWriteAttribute("style", " style=\"", 3875, "\"", 3959, 4);
                WriteAttributeValue("", 3883, "background-image:url(", 3883, 21, true);
#nullable restore
#line 77 "C:\Users\maqam\Downloads\Vipexfinal99\Vipexfinal\Views\Xeberler\Detail.cshtml"
WriteAttributeValue("", 3904, Model.Xeberdetal.Imaged, 3904, 24, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3928, ");background-repeat:no-repeat;", 3928, 30, true);
                WriteAttributeValue(" ", 3958, "", 3959, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <div class=\"main-news_title\">\r\n\r\n                                <div class=\"main-news_name\">\r\n                                    <a href=\"./xeberler2.html\" >\r\n                                      ");
#nullable restore
#line 82 "C:\Users\maqam\Downloads\Vipexfinal99\Vipexfinal\Views\Xeberler\Detail.cshtml"
                                 Write(Model.Xeberdetal.Maintitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                   

        
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class=""myelement"">
                            <div>


                                <div>

                                    <div>

                                        <p>
                                           
                                            <a href=""https://www.amazon.com/HP-X24c-Monitor-Resolution-FreeSync/dp/B08CPQ4ZL6/"" style=""font-size:26px"">
                                                ");
#nullable restore
#line 101 "C:\Users\maqam\Downloads\Vipexfinal99\Vipexfinal\Views\Xeberler\Detail.cshtml"
                                           Write(Model.Xeberdetal.Title2);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                            </a>\r\n                                        </p>\r\n                                    </div>\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 5091, "\"", 5121, 1);
#nullable restore
#line 106 "C:\Users\maqam\Downloads\Vipexfinal99\Vipexfinal\Views\Xeberler\Detail.cshtml"
WriteAttributeValue("", 5097, Model.Xeberdetal.Image2, 5097, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img1"" style=""height: 330px;width: 330px;"">
                                </div>
                                <div>

                                    <div>
                                        <p>
                                       
                                            <a href=""https://www.amazon.com/HP-X24c-Monitor-Resolution-FreeSync/dp/B08CPQ4ZL6/""  style=""font-size:26px"">
                                                ");
#nullable restore
#line 114 "C:\Users\maqam\Downloads\Vipexfinal99\Vipexfinal\Views\Xeberler\Detail.cshtml"
                                           Write(Model.Xeberdetal.Title3);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                            </a>\r\n                                        </p>\r\n                                    </div>\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 5794, "\"", 5824, 1);
#nullable restore
#line 119 "C:\Users\maqam\Downloads\Vipexfinal99\Vipexfinal\Views\Xeberler\Detail.cshtml"
WriteAttributeValue("", 5800, Model.Xeberdetal.Image3, 5800, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img3"" style=""height: 330px;width: 330px;"">
                                </div>
                                <div>

                                    <div>

                                        <p>
                                           
                                            <a href=""https://www.amazon.com/HP-X24c-Monitor-Resolution-FreeSync/dp/B08CPQ4ZL6/""  style=""font-size:26px"">
                                                ");
#nullable restore
#line 128 "C:\Users\maqam\Downloads\Vipexfinal99\Vipexfinal\Views\Xeberler\Detail.cshtml"
                                           Write(Model.Xeberdetal.Title4);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                            </a>\r\n                                        </p>\r\n                                    </div>\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 6503, "\"", 6533, 1);
#nullable restore
#line 133 "C:\Users\maqam\Downloads\Vipexfinal99\Vipexfinal\Views\Xeberler\Detail.cshtml"
WriteAttributeValue("", 6509, Model.Xeberdetal.Image4, 6509, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img1"" style=""height: 330px;width: 330px;"">
                                </div>
                                <div>

                                    <div>
                                        <p>
                                          
                                            <a href=""https://www.amazon.com/HP-X24c-Monitor-Resolution-FreeSync/dp/B08CPQ4ZL6/""  style=""font-size:26px"">
                                                ");
#nullable restore
#line 141 "C:\Users\maqam\Downloads\Vipexfinal99\Vipexfinal\Views\Xeberler\Detail.cshtml"
                                           Write(Model.Xeberdetal.Title5);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                            </a>\r\n                                        </p>\r\n                                    </div>\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 7209, "\"", 7239, 1);
#nullable restore
#line 146 "C:\Users\maqam\Downloads\Vipexfinal99\Vipexfinal\Views\Xeberler\Detail.cshtml"
WriteAttributeValue("", 7215, Model.Xeberdetal.Image5, 7215, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img3"" style=""height: 330px;width: 330px;"">
                                </div>


                            </div>
                            <div>



                            </div>


                        </div>

                    </div>
      


            </div>

        </div>
    </section>

 
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Xeber> Html { get; private set; }
    }
}
#pragma warning restore 1591