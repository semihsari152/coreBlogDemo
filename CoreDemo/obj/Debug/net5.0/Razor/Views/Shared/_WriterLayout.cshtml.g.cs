#pragma checksum "C:\Users\semih\Desktop\coreDemo\CoreDemo\Views\Shared\_WriterLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f90b8978bf25982e2c5410d5e7bf7dab951e582"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__WriterLayout), @"mvc.1.0.view", @"/Views/Shared/_WriterLayout.cshtml")]
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
#line 1 "C:\Users\semih\Desktop\coreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\semih\Desktop\coreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f90b8978bf25982e2c5410d5e7bf7dab951e582", @"/Views/Shared/_WriterLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__WriterLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex align-items-center h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\semih\Desktop\coreDemo\CoreDemo\Views\Shared\_WriterLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f90b8978bf25982e2c5410d5e7bf7dab951e5824466", async() => {
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>Purple Admin</title>
    <link rel=""stylesheet"" href=""/writerPanel/assets/vendors/mdi/css/materialdesignicons.min.css"">
    <link rel=""stylesheet"" href=""/writerPanel/assets/vendors/css/vendor.bundle.base.css"">
    <link rel=""stylesheet"" href=""/writerPanel/assets/css/style.css"">
    <link rel=""shortcut icon"" href=""/writerPanel/assets/images/favicon.ico"" />
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f90b8978bf25982e2c5410d5e7bf7dab951e5825949", async() => {
                WriteLiteral(@"
    <div class=""container-scroller"">

        <nav class=""navbar default-layout-navbar col-lg-12 col-12 p-0 fixed-top d-flex flex-row"">
            <div class=""text-center navbar-brand-wrapper d-flex align-items-center justify-content-center"">
                <a class=""navbar-brand brand-logo"" href=""index.html""><img src=""/writerPanel/assets/images/logo.svg"" alt=""logo"" /></a>
                <a class=""navbar-brand brand-logo-mini"" href=""index.html""><img src=""/writerPanel/assets/images/logo-mini.svg"" alt=""logo"" /></a>
            </div>
            <div class=""navbar-menu-wrapper d-flex align-items-stretch"">
                <button class=""navbar-toggler navbar-toggler align-self-center"" type=""button"" data-toggle=""minimize"">
                    <span class=""mdi mdi-menu""></span>
                </button>
                <div class=""search-field d-none d-md-block"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f90b8978bf25982e2c5410d5e7bf7dab951e5827146", async() => {
                    WriteLiteral(@"
                        <div class=""input-group"">
                            <div class=""input-group-prepend bg-transparent"">
                                <i class=""input-group-text border-0 mdi mdi-magnify""></i>
                            </div>
                            <input type=""text"" class=""form-control bg-transparent border-0"" placeholder=""Search projects"">
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
                <ul class=""navbar-nav navbar-nav-right"">
                    <li class=""nav-item nav-profile dropdown"">
                        <a class=""nav-link dropdown-toggle"" id=""profileDropdown"" href=""#"" data-toggle=""dropdown"" aria-expanded=""false"">
                            <div class=""nav-profile-img"">
                                <img src=""/writerPanel/assets/images/faces/face1.jpg"" alt=""image"">
                                <span class=""availability-status online""></span>
                            </div>
                            <div class=""nav-profile-text"">
                                <p class=""mb-1 text-black"">David Greymaax</p>
                            </div>
                        </a>
                        <div class=""dropdown-menu navbar-dropdown"" aria-labelledby=""profileDropdown"">
                            <a class=""dropdown-item"" href=""#"">
                                <i class=""mdi mdi-cached mr-2 text-success""></i> Activity ");
                WriteLiteral(@"Log
                            </a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">
                                <i class=""mdi mdi-logout mr-2 text-primary""></i> Signout
                            </a>
                        </div>
                    </li>
                    <li class=""nav-item d-none d-lg-block full-screen-link"">
                        <a class=""nav-link"">
                            <i class=""mdi mdi-fullscreen"" id=""fullscreen-button""></i>
                        </a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link count-indicator dropdown-toggle"" id=""messageDropdown"" href=""#"" data-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""mdi mdi-email-outline""></i>
                            <span class=""count-symbol bg-warning""></span>
                        </a>
                        ");
#nullable restore
#line 71 "C:\Users\semih\Desktop\coreDemo\CoreDemo\Views\Shared\_WriterLayout.cshtml"
                   Write(await Component.InvokeAsync("WriterMessageNotifications"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link count-indicator dropdown-toggle"" id=""notificationDropdown"" href=""#"" data-toggle=""dropdown"">
                            <i class=""mdi mdi-bell-outline""></i>
                            <span class=""count-symbol bg-danger""></span>
                        </a>
                        ");
#nullable restore
#line 78 "C:\Users\semih\Desktop\coreDemo\CoreDemo\Views\Shared\_WriterLayout.cshtml"
                   Write(await Component.InvokeAsync("WriterNotifications"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </li>
                    <li class=""nav-item nav-logout d-none d-lg-block"">
                        <a class=""nav-link"" href=""#"">
                            <i class=""mdi mdi-power""></i>
                        </a>
                    </li>
                    <li class=""nav-item nav-settings d-none d-lg-block"">
                        <a class=""nav-link"" href=""#"">
                            <i class=""mdi mdi-format-line-spacing""></i>
                        </a>
                    </li>
                </ul>
                <button class=""navbar-toggler navbar-toggler-right d-lg-none align-self-center"" type=""button"" data-toggle=""offcanvas"">
                    <span class=""mdi mdi-menu""></span>
                </button>
            </div>
        </nav>
  
    <!-- partial -->
    <div class=""container-fluid page-body-wrapper"">
        <!-- partial:partials/_sidebar.html -->
        ");
#nullable restore
#line 100 "C:\Users\semih\Desktop\coreDemo\CoreDemo\Views\Shared\_WriterLayout.cshtml"
   Write(await Html.PartialAsync("~/Views/Writer/WriterSideBar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!-- partial -->\r\n        <div class=\"main-panel\">\r\n            <div class=\"content-wrapper\">\r\n                ");
#nullable restore
#line 104 "C:\Users\semih\Desktop\coreDemo\CoreDemo\Views\Shared\_WriterLayout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <!-- partial -->
            </div>
            <!-- main-panel ends -->
        </div>

        <!-- page-body-wrapper ends -->
    </div>
        </div>
    <!-- container-scroller -->
    <!-- plugins:js -->
    <script src=""/writerPanel/assets/vendors/js/vendor.bundle.base.js""></script>
    <!-- endinject -->
    <!-- Plugin js for this page -->
    <script src=""/writerPanel/assets/vendors/chart.js/Chart.min.js""></script>
    <!-- End plugin js for this page -->
    <!-- inject:js -->
    <script src=""/writerPanel/assets/js/off-canvas.js""></script>
    <script src=""/writerPanel/assets/js/hoverable-collapse.js""></script>
    <script src=""/writerPanel/assets/js/misc.js""></script>
    <!-- endinject -->
    <!-- Custom js for this page -->
    <script src=""/writerPanel/assets/js/dashboard.js""></script>
    <script src=""/writerPanel/assets/js/todolist.js""></script>
    <!-- End custom js for this page -->
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
            WriteLiteral("\r\n</html>");
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
