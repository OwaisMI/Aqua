#pragma checksum "C:\Users\Owais\source\repos\Aqua Project\Aqua Project\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fd3522749a903f9ee8b4bcfd951326409c3c9fe"
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
#line 1 "C:\Users\Owais\source\repos\Aqua Project\Aqua Project\Views\_ViewImports.cshtml"
using Aqua_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owais\source\repos\Aqua Project\Aqua Project\Views\_ViewImports.cshtml"
using Aqua_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd3522749a903f9ee8b4bcfd951326409c3c9fe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c041afcecc1d586ef5b5be9a691286d71c71759", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-subscribe"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-sb-form-api-token", new global::Microsoft.AspNetCore.Html.HtmlString("API_TOKEN"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactFormFooter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Owais\source\repos\Aqua Project\Aqua Project\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Masthead-->
<header class=""masthead"">
    <div class=""container position-relative"">
        <div class=""row justify-content-center"">
            <div class=""col-xl-6"">
                <div class=""text-center text-white"">
                    <!-- Page heading-->
                    <h1 class=""mb-5"">Generate more leads with a professional landing page!</h1>
                    <!-- Signup form-->
                    <!-- * * * * * * * * * * * * * * *-->
                    <!-- * * SB Forms Contact Form * *-->
                    <!-- * * * * * * * * * * * * * * *-->
                    <!-- This form is pre-integrated with SB Forms.-->
                    <!-- To make this form functional, sign up at-->
                    <!-- https://startbootstrap.com/solution/contact-forms-->
                    <!-- to get an API token!-->
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fd3522749a903f9ee8b4bcfd951326409c3c9fe5726", async() => {
                WriteLiteral(@"
                        <!-- Email address input-->
                        <div class=""row"">
                            <div class=""col"">
                                <input class=""form-control form-control-lg"" id=""emailAddress"" type=""email"" placeholder=""Email Address"" data-sb-validations=""required,email"" />
                                <div class=""invalid-feedback text-white"" data-sb-feedback=""emailAddress:required"">Email Address is required.</div>
                                <div class=""invalid-feedback text-white"" data-sb-feedback=""emailAddress:email"">Email Address Email is not valid.</div>
                            </div>
                            <div class=""col-auto""><button class=""btn btn-primary btn-lg disabled"" id=""submitButton"" type=""submit"">Submit</button></div>
                        </div>
                        <!-- Submit success message-->
                        <!---->
                        <!-- This is what your users will see when the form-->
             ");
                WriteLiteral(@"           <!-- has successfully submitted-->
                        <div class=""d-none"" id=""submitSuccessMessage"">
                            <div class=""text-center mb-3"">
                                <div class=""fw-bolder"">Form submission successful!</div>
                                <p>To activate this form, sign up at</p>
                                <a class=""text-white"" href=""https://startbootstrap.com/solution/contact-forms"">https://startbootstrap.com/solution/contact-forms</a>
                            </div>
                        </div>
                        <!-- Submit error message-->
                        <!---->
                        <!-- This is what your users will see when there is-->
                        <!-- an error submitting the form-->
                        <div class=""d-none"" id=""submitErrorMessage""><div class=""text-center text-danger mb-3"">Error sending message!</div></div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
</header>
<!-- Testimonials-->
<section class=""testimonials text-center bg-light"">
    <div class=""container"">
        <h2 class=""mb-5"">Services</h2>
        <div class=""row"">
            <div class=""card"" style=""width: 18rem;"">
                <img class=""card-img-top"" src=""assets/img/gas.jpg"" alt=""Card image cap"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Get Gas</h5>
                    <p class=""card-text"">Get Gas From Various Companies</p>
                    <a href=""#"" class=""btn btn-primary"">Purchase</a>
                </div>
            </div>

            <div class=""card"" style=""width: 18rem;"">
                <img class=""card-img-top"" src=""assets/img/water.png"" alt=""Card image cap"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Get Water</h5>
                    <p class=""card-text"">Get Water From Various Companies</p>
        ");
            WriteLiteral(@"            <a href=""#"" class=""btn btn-primary"">Purchase</a>
                </div>
            </div>

</section>
<!-- Call to Action-->
<section class=""call-to-action text-white text-center"" id=""signup"">
    <div class=""container position-relative"">
        <div class=""row justify-content-center"">
            <div class=""col-xl-6"">
                <h2 class=""mb-4"">Ready to get started? Sign up now!</h2>
                <!-- Signup form-->
                <!-- * * * * * * * * * * * * * * *-->
                <!-- * * SB Forms Contact Form * *-->
                <!-- * * * * * * * * * * * * * * *-->
                <!-- This form is pre-integrated with SB Forms.-->
                <!-- To make this form functional, sign up at-->
                <!-- https://startbootstrap.com/solution/contact-forms-->
                <!-- to get an API token!-->
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fd3522749a903f9ee8b4bcfd951326409c3c9fe11289", async() => {
                WriteLiteral(@"
                    <!-- Email address input-->
                    <div class=""row"">
                        <div class=""col"">
                            <input class=""form-control form-control-lg"" id=""emailAddressBelow"" type=""email"" placeholder=""Email Address"" data-sb-validations=""required,email"" />
                            <div class=""invalid-feedback text-white"" data-sb-feedback=""emailAddressBelow:required"">Email Address is required.</div>
                            <div class=""invalid-feedback text-white"" data-sb-feedback=""emailAddressBelow:email"">Email Address Email is not valid.</div>
                        </div>
                        <div class=""col-auto""><button class=""btn btn-primary btn-lg disabled"" id=""submitButton"" type=""submit"">Submit</button></div>
                    </div>
                    <!-- Submit success message-->
                    <!---->
                    <!-- This is what your users will see when the form-->
                    <!-- has successfully subm");
                WriteLiteral(@"itted-->
                    <div class=""d-none"" id=""submitSuccessMessage"">
                        <div class=""text-center mb-3"">
                            <div class=""fw-bolder"">Form submission successful!</div>
                            <p>To activate this form, sign up at</p>
                            <a class=""text-white"" href=""https://startbootstrap.com/solution/contact-forms"">https://startbootstrap.com/solution/contact-forms</a>
                        </div>
                    </div>
                    <!-- Submit error message-->
                    <!---->
                    <!-- This is what your users will see when there is-->
                    <!-- an error submitting the form-->
                    <div class=""d-none"" id=""submitErrorMessage""><div class=""text-center text-danger mb-3"">Error sending message!</div></div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
</section>
<!-- Footer-->
<footer class=""footer bg-light"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 h-100 text-center text-lg-start my-auto"">
                <ul class=""list-inline mb-2"">
                    <li class=""list-inline-item""><a href=""#!"">About</a></li>
                    <li class=""list-inline-item"">⋅</li>
                    <li class=""list-inline-item""><a href=""#!"">Contact</a></li>
                    <li class=""list-inline-item"">⋅</li>
                    <li class=""list-inline-item""><a href=""#!"">Terms of Use</a></li>
                    <li class=""list-inline-item"">⋅</li>
                    <li class=""list-inline-item""><a href=""#!"">Privacy Policy</a></li>
                </ul>
                <p class=""text-muted small mb-4 mb-lg-0"">&copy; Your Website 2021. All Rights Reserved.</p>
            </div>
            <div class=""col-lg-6 h-100 text-center text-lg-end my-auto"">
      ");
            WriteLiteral(@"          <ul class=""list-inline mb-0"">
                    <li class=""list-inline-item me-4"">
                        <a href=""#!""><i class=""bi-facebook fs-3""></i></a>
                    </li>
                    <li class=""list-inline-item me-4"">
                        <a href=""#!""><i class=""bi-twitter fs-3""></i></a>
                    </li>
                    <li class=""list-inline-item"">
                        <a href=""#!""><i class=""bi-instagram fs-3""></i></a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</footer>
<!-- Bootstrap core JS-->
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js""></script>
<!-- Core theme JS-->
<script src=""js/scripts.js""></script>
<!-- * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *-->
<!-- * *                               SB Forms JS                               * *-->
<!-- * * Activate your form at https://startbootstrap.com/solut");
            WriteLiteral("ion/contact-forms * *-->\r\n<!-- * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *-->\r\n<script src=\"https://cdn.startbootstrap.com/sb-forms-latest.js\"></script>");
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