#pragma checksum "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "241dbf54f09689960799625e5ca3836f157caefc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"241dbf54f09689960799625e5ca3836f157caefc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e342cf645c5b9fee6735334b6090d160bb6e749e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Car>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pt-5 pb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main>
    <section id=""mainsection"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-9 pt-5 col-md-12 col-sm-12 col-lg-12 col-xxl-9 "">
                    <br><br><br><br><br>
                    <h1 class=""text-white mt-5 fs-1"">FIND YOUR RENT A CAR</h1>
                    <p class=""text-white  fs-3 pb-5"">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                </div>
                <div class=""col-3 col-md-12 col-sm-12 col-lg-12  col-xxl-3 "">
                    <div id=""s1f1"" class="" container d-flex justify-content-center"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "241dbf54f09689960799625e5ca3836f157caefc4528", async() => {
                WriteLiteral(@"
                            <div class=""row mt-2"">
                                <h2 class=""text-white text-center"">Search Car</h2>
                            </div>
                            <div class=""row mt-2"">
                                <input class=""form-control"" placeholder=""Text"" type=""text"">
                            </div>
                            <div class=""row mt-2"">
                                <input class=""form-control"" placeholder=""Text"" type=""text"">
                            </div>
                            <div class=""row mt-2"">
                                <input class=""form-control"" placeholder=""Text"" type=""text"">
                            </div>
                            <div class=""row mt-2"">
                                <input class=""form-control"" placeholder=""Text"" type=""text"">
                            </div>
                            <div class=""row mt-2"">
                                <button id=""custombtnhoverblack"" type=""sub");
                WriteLiteral(@"mit""
                                        class=""btn btn-warning bg-opacity-100 fw-bold w-100  mb-2 mt-2 text-black"">
                                    Search
                                    Now
                                </button>
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
    </section>

    <section class=""mt-5"">
        <div class=""container"">
            <h2 class=""text-center"">OUR BEST <span class=""text-primary"">OFFERS</span> </h2>
            <div class=""d-flex justify-content-center"">
                <hr class=""hr mt-2 text-primary"">

            </div>
            <p class=""text-center mt-2"">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras a arcu eu
                justo euismod rutrum. Quisque id enim ac tortor malesuada vestibulum non quis turpis. Ut eget ornare
                arcu. Suspendisse velit mi, pulvinar sed mauris eget, efficitur tempor ex.
            </p>
        </div>
        <div class=""mt-4 container"">
            <div class=""row d-flex justify-content-center"">
                <div class=""col-4 col-md-12 col-sm-12 col-lg-12 col-xxl-3"">
                    <div class=""d-flex mt-5"">
                        <div");
            BeginWriteAttribute("class", " class=\"", 3049, "\"", 3057, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""border bg-primary"">

                                <i class=""bi bi-gear-fill fs-1 p-2  text-white ""></i>
                            </div>
                        </div>
                        <div class=""ms-3"">
                            <p class=""fw-semibold"">Featured Luxury Cars</p>
                            <p class=""text-black-50"">
                                Lorem ipsum dolor sit amet, onsectetuer adipiscing elitcommodo
                                ligula eget dolor.
                            </p>
                        </div>
                    </div>
                    <div class=""d-flex mt-5"">
                        <div");
            BeginWriteAttribute("class", " class=\"", 3772, "\"", 3780, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""border bg-primary"">

                                <i class=""bi bi-gear-fill fs-1 p-2  text-white ""></i>
                            </div>
                        </div>
                        <div class=""ms-3"">
                            <p class=""fw-semibold"">Featured Luxury Cars</p>
                            <p class=""text-black-50"">
                                Lorem ipsum dolor sit amet, onsectetuer adipiscing elitcommodo
                                ligula eget dolor.
                            </p>
                        </div>
                    </div>
                    <div class=""d-flex mt-5"">
                        <div");
            BeginWriteAttribute("class", " class=\"", 4495, "\"", 4503, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""border bg-primary"">
                                <i class=""bi bi-gear-fill fs-1 p-2  text-white ""></i>
                            </div>
                        </div>
                        <div class=""ms-3"">
                            <p class=""fw-semibold"">Featured Luxury Cars</p>
                            <p class=""text-black-50"">
                                Lorem ipsum dolor sit amet, onsectetuer adipiscing elitcommodo
                                ligula eget dolor.
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-4 col-md-12 col-sm-12 col-lg-12 col-xxl-3 d-flex justify-content-center"">
                    <img src=""./assets/img/featureCarImg.png""");
            BeginWriteAttribute("alt", " alt=\"", 5333, "\"", 5339, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"col-4 col-md-12 col-sm-12 col-lg-12 col-xxl-3\">\r\n                    <div class=\"d-flex mt-5\">\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 5519, "\"", 5527, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <p class=""fw-semibold "">Featured Luxury Cars</p>
                            <p class=""text-black-50"">
                                Lorem ipsum dolor sit amet, onsectetuer adipiscing elitcommodo
                                ligula eget dolor.
                            </p>
                        </div>
                        <div");
            BeginWriteAttribute("class", " class=\"", 5906, "\"", 5914, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""border bg-primary"">

                                <i class=""bi bi-gear-fill fs-1 p-2  text-white ""></i>
                            </div>
                        </div>
                    </div>
                    <div class=""d-flex mt-5"">
                        <div");
            BeginWriteAttribute("class", " class=\"", 6239, "\"", 6247, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <p class=""fw-semibold "">Featured Luxury Cars</p>
                            <p class=""text-black-50"">
                                Lorem ipsum dolor sit amet, onsectetuer adipiscing elitcommodo
                                ligula eget dolor.
                            </p>
                        </div>
                        <div");
            BeginWriteAttribute("class", " class=\"", 6626, "\"", 6634, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""border bg-primary"">

                                <i class=""bi bi-gear-fill fs-1 p-2  text-white ""></i>
                            </div>
                        </div>
                    </div>
                    <div class=""d-flex mt-5"">
                        <div");
            BeginWriteAttribute("class", " class=\"", 6959, "\"", 6967, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <p class=""fw-semibold "">Featured Luxury Cars</p>
                            <p class=""text-black-50"">
                                Lorem ipsum dolor sit amet, onsectetuer adipiscing elitcommodo
                                ligula eget dolor.
                            </p>
                        </div>
                        <div");
            BeginWriteAttribute("class", " class=\"", 7346, "\"", 7354, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""border bg-primary"">

                                <i class=""bi bi-gear-fill fs-1 p-2  text-white ""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class=""bg-info"">
        <div class=""container"">
            <h2 class=""text-center pt-5"">VEHICLE MODELS <span class=""text-primary"">FOR RENT</span></h2>
            <div class=""d-flex justify-content-center"">
                <hr class=""hr mt-2"">
            </div>

            <div class=""mt-2 row  shadow"">
                <div class=""col-lg-3 col-md-12 col-sm-12 col-lg-12 col-xxl-3 "">
");
#nullable restore
#line 166 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml"
                     foreach (var car in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p data-id=\"");
#nullable restore
#line 168 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml"
                               Write(car.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"fs-3 mt-2 carelement\"><span class=\"fw-bold \">");
#nullable restore
#line 168 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml"
                                                                                            Write(car.Manufacturer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 168 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml"
                                                                                                                          Write(car.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 169 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"col-lg-9\">\r\n\r\n");
#nullable restore
#line 173 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml"
                     foreach (var car in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("id", " id=\"", 8494, "\"", 8510, 2);
            WriteAttributeValue("", 8499, "tab-", 8499, 4, true);
#nullable restore
#line 175 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 8503, car.Id, 8503, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-none cartab\">\r\n                            <div class=\"col-8 col-md-12 col-sm-12 col-lg-12 col-xxl-8\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 8661, "\"", 8693, 2);
            WriteAttributeValue("", 8667, "./assets/img/cars/", 8667, 18, true);
#nullable restore
#line 177 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 8685, car.Img, 8685, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-100\"");
            BeginWriteAttribute("alt", " alt=\"", 8708, "\"", 8714, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""col-4 bg-white col-md-12 col-sm-12 col-lg-12 col-xxl-4"">
                                <p>
                                    <span class=""text-primary fs-2 fw-bold"">
                                        $ ");
#nullable restore
#line 182 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml"
                                     Write(car.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span> Rent Per Day\r\n                                </p>\r\n                                <p");
            BeginWriteAttribute("class", " class=\"", 9151, "\"", 9159, 0);
            EndWriteAttribute();
            WriteLiteral(">Model ");
#nullable restore
#line 185 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml"
                                             Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <hr class=\"hr2\">\r\n                                <p");
            BeginWriteAttribute("class", " class=\"", 9267, "\"", 9275, 0);
            EndWriteAttribute();
            WriteLiteral(">Doors ");
#nullable restore
#line 187 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml"
                                             Write(car.Doors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <hr class=\"hr2\">\r\n                                <p");
            BeginWriteAttribute("class", " class=\"", 9383, "\"", 9391, 0);
            EndWriteAttribute();
            WriteLiteral(">Seats ");
#nullable restore
#line 189 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml"
                                             Write(car.Seats);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <hr class=\"hr2\">\r\n                                <p");
            BeginWriteAttribute("class", " class=\"", 9499, "\"", 9507, 0);
            EndWriteAttribute();
            WriteLiteral(">PropName ");
#nullable restore
#line 191 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml"
                                                Write(car.Luggage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <hr class=\"hr2\">\r\n                                <p");
            BeginWriteAttribute("class", " class=\"", 9620, "\"", 9628, 0);
            EndWriteAttribute();
            WriteLiteral(">Transmission ");
#nullable restore
#line 193 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml"
                                                     Write(car.AutoTransmission==true?"Auto":"Manual");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <hr class=\"hr2\">\r\n                                <p");
            BeginWriteAttribute("class", " class=\"", 9778, "\"", 9786, 0);
            EndWriteAttribute();
            WriteLiteral(">AirCondition ");
#nullable restore
#line 195 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml"
                                                    Write(car.AirCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <hr class=\"hr2\">\r\n                           \r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 200 "C:\Users\tu6w5xs1c\Desktop\Car\CarBack\CarBack\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>

            </div>
        </div>
    </section>

    <section id=""section3"">
        <div class=""container"">
            <div class=""row mt-5 pb-5"">
                <div class=""col-3 mt-5 pb-5 col-md-12 col-sm-12 col-lg-12 col-xxl-3"">
                    <div class=""d-flex justify-content-center"">
                        <i class=""bi bi-gear-fill text-white fs-1""></i>
                    </div>
                    <div class=""d-flex justify-content-center"">
                        <p class=""fs-1 text-white fw-bold"">StatPropVal</p>
                    </div>
                    <div class=""d-flex justify-content-center"">
                        <p class=""fs-3 text-white fw-semibold"">StatPropName</p>
                    </div>
                </div>
                <div class=""col-3 mt-5 pb-5 col-md-12 col-sm-12 col-lg-12 col-xxl-3"">
                    <div class=""d-flex justify-content-center"">
                        <i class=""bi bi-gear-fill text-white fs-1""></");
            WriteLiteral(@"i>
                    </div>
                    <div class=""d-flex justify-content-center"">
                        <p class=""fs-1 text-white fw-bold"">StatPropVal</p>
                    </div>
                    <div class=""d-flex justify-content-center"">
                        <p class=""fs-3 text-white fw-semibold"">StatPropName</p>
                    </div>
                </div>
                <div class=""col-3 mt-5 pb-5 col-md-12 col-sm-12 col-lg-12 col-xxl-3"">
                    <div class=""d-flex justify-content-center"">
                        <i class=""bi bi-gear-fill text-white fs-1""></i>
                    </div>
                    <div class=""d-flex justify-content-center"">
                        <p class=""fs-1 text-white fw-bold"">StatPropVal</p>
                    </div>
                    <div class=""d-flex justify-content-center"">
                        <p class=""fs-3 text-white fw-semibold"">StatPropName</p>
                    </div>
                </div>
     ");
            WriteLiteral(@"           <div class=""col-3 mt-5 pb-5 col-md-12 col-sm-12 col-lg-12 col-xxl-3"">
                    <div class=""d-flex justify-content-center"">
                        <i class=""bi bi-gear-fill text-white fs-1""></i>
                    </div>
                    <div class=""d-flex justify-content-center"">
                        <p class=""fs-1 text-white fw-bold"">StatPropVal</p>
                    </div>
                    <div class=""d-flex justify-content-center"">
                        <p class=""fs-3 text-white fw-semibold"">StatPropName</p>
                    </div>
                </div>
            </div>
        </div>
    </section>


</main>

");
            DefineSection("scripts", async() => {
                WriteLiteral(" \r\n <script>\r\n     $(\".carelement\").click(function () {\r\n         alert()\r\n     })\r\n </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591