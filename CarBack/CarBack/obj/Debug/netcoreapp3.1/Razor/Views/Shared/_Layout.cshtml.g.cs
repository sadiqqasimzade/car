#pragma checksum "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "100186921ce421c50e8e840261b8b363818f238e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\_ViewImports.cshtml"
using CarBack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\_ViewImports.cshtml"
using CarBack.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"100186921ce421c50e8e840261b8b363818f238e", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e342cf645c5b9fee6735334b6090d160bb6e749e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "100186921ce421c50e8e840261b8b363818f238e4210", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <!-- CSS only -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor"" crossorigin=""anonymous"">
    <!-- JavaScript Bundle with Popper -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js""
            integrity=""sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2""
            crossorigin=""anonymous""></script>
    <link rel=""stylesheet""
          href=""https://maxst.icons8.com/vue-static/landings/line-awesome/font-awesome-line-awesome/css/all.min.css"">
    <link rel=""stylesheet"" href=""./assets/css/style.css"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@");
                WriteLiteral("1.8.3/font/bootstrap-icons.css\">\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "100186921ce421c50e8e840261b8b363818f238e6308", async() => {
                WriteLiteral(@"
    <header>
        <nav class=""navbar navbar-expand-lg navbar-light bg-primary"">
            <div class=""container-fluid"">
                <button class=""navbar-toggler text-white"" type=""button"" data-mdb-toggle=""collapse""
                        data-mdb-target=""#navbarNavAltMarkup"" aria-controls=""navbarNavAltMarkup"" aria-expanded=""false""
                        aria-label=""Toggle navigation"">
                    <i class=""fas fa-bars""></i>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarNavAltMarkup"">
                    <div class=""navbar-nav"">
                        <a class=""nav-link text-white active"" aria-current=""page"" href=""#"">
                            Mon - Sun: 8:00am - 6:00pm
                        </a>
                        <a class=""nav-link text-white"" href=""#""> (123) 456-7890</a>
                        <a class=""nav-link text-white"" href=""#"">facebook</a>
                        <a class=""nav-link text-white"" href=""#"">twitter</");
                WriteLiteral(@"a>
                        <a class=""nav-link text-white"" href=""#"">instagram</a>
                        <a class=""nav-link text-white"" href=""#"">pin</a>
                    </div>
                </div>
            </div>
        </nav>

        <nav class=""navbar navbar-expand-lg bg-light"">
            <div class=""container-fluid container"">
                <a class=""navbar-brand"" href=""#""><img src=""./assets/img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 2578, "\"", 2584, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarText""
                        aria-controls=""navbarText"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse ps10"" id=""navbarText"">
                    <ul class=""navbar-nav me-auto mb-2 mb-lg-0 "">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" aria-current=""page"" href=""#"">Home</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Services</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Vehicles</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-l");
                WriteLiteral(@"ink"" href=""#"">
                                Supports
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                Clients
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                Blog
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                Contact Us
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </header>


    ");
#nullable restore
#line 91 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <footer>
        <div class=""bg-primary"">
            <div class=""container"">
                <div class=""row pt-3 pb-3"">
                    <div class=""col-4 col-md-12 col-sm-12 col-lg-12 col-xxl-4"">
                        <p class=""fs-2 text-white"">Newsletter</p>
                        <p class=""fs-4 text-white"">Subscribe for our weekly newsletter.</p>
                    </div>
                    <div class=""col-8 d-flex align-items-center col-md-12 col-sm-12 col-lg-12 col-xxl-8"">
                        <div class=""input-group input-group-lg"">
                            <span class=""input-group-text"" id=""inputGroup-sizing-lg"">
                                <i class=""bi bi-messenger""></i>
                            </span>
                            <input type=""text"" class=""form-control"" aria-label=""Sizing example input""
                                   aria-describedby=""inputGroup-sizing-lg"">
                            <span class=""input-group-text"" id=""inputGroup-sizin");
                WriteLiteral(@"g-lg"">
                                SignUp <i class=""bi bi-telegram""></i>
                            </span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div>
            <div class=""row"">
                <div class=""col-6 col-md-12 col-sm-12 col-lg-12 col-xxl-6"">
                    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3039.7485018707653!2d49.81325175117497!3d40.37010057926948!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307dc397d94dc3%3A0x617bc46b47244c00!2sAzerbaijan%20Technical%20University!5e0!3m2!1sen!2s!4v1655116733359!5m2!1sen!2s""
                            width=""600"" height=""450"" style=""border:0;""");
                BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 6264, "\"", 6282, 0);
                EndWriteAttribute();
                WriteLiteral(@" loading=""lazy""
                            referrerpolicy=""no-referrer-when-downgrade"" class=""w-100""></iframe>
                </div>
                <div class=""col-6 bg-dark col-md-12 col-sm-12 col-lg-12 col-xxl-6"">
                    <div class=""container"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "100186921ce421c50e8e840261b8b363818f238e12815", async() => {
                    WriteLiteral(@"
                            <div class=""row mt-5"">
                                <input class=""form-control"" placeholder=""Name"" type=""text"">
                            </div>
                            <div class=""row mt-5"">
                                <input class=""form-control"" placeholder=""Email"" type=""text"">
                            </div>
                            <div class=""row mt-5"">
                                <input class=""form-control"" placeholder=""Phone"" type=""text"">
                            </div>
                            <div class=""row mt-5"">
                                <textarea class=""form-control"" type=""text""></textarea>
                            </div>
                            <div class=""row mt-2"">
                                <button class=""btn btn-light text-primary fs-3 fw-bolder w-25"">Submit Now</button>
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>

                </div>
            </div>
        </div>
        <div class=""container mt-5 pb-5"">
            <div class=""row"">
                <div class=""col"">
                    <div class=""d-flex"">
                        <div class=""rounded-circle border-primary border  d-flex justify-content-center align-items-center w-25"">
                            <i class=""bi bi-geo-alt fs-1 text-primary""></i>
                        </div>
                        <div>
                            <p class=""bold fs-3"">Address</p>
                            <p class=""bold fs-4 text-black-50"">Address</p>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""d-flex"">
                        <div class=""rounded-circle border-primary border  d-flex justify-content-center align-items-center w-25"">
                            <i class=""bi bi-geo-alt fs-1 text-primary""></i>
   ");
                WriteLiteral(@"                     </div>
                        <div>
                            <p class=""bold fs-3"">Address</p>
                            <p class=""bold fs-4 text-black-50"">Address</p>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""d-flex"">
                        <div class=""rounded-circle border-primary border  d-flex justify-content-center align-items-center w-25"">
                            <i class=""bi bi-geo-alt fs-1 text-primary""></i>
                        </div>
                        <div>
                            <p class=""bold fs-3"">Address</p>
                            <p class=""bold fs-4 text-black-50"">Address</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""bg-info mt-3"">
            <div class=""container"">
                <div class=""d-flex justify-content-center gap-2");
                WriteLiteral(@" pt-5"">
                    <a class=""border border-primary"" href=""#""><i class=""bi bi-facebook p-1""></i></a>
                    <a class=""border border-primary"" href=""#""><i class=""bi bi-facebook p-1""></i></a>
                    <a class=""border border-primary"" href=""#""><i class=""bi bi-facebook p-1""></i></a>
                    <a class=""border border-primary"" href=""#""><i class=""bi bi-facebook p-1""></i></a>
                    <a class=""border border-primary"" href=""#""><i class=""bi bi-facebook p-1""></i></a>
                </div>
                <p class=""pb-5 mt-5 text-center"">All Rights reserved</p>
            </div>
        </div>

    </footer>

    ");
#nullable restore
#line 199 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts",false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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