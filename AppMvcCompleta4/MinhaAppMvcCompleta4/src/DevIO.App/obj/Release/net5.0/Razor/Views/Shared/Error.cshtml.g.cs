#pragma checksum "C:\repositorio\Curso-.Net-Dev.IO\AppMvcCompleta4\MinhaAppMvcCompleta4\src\DevIO.App\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "292d7609506a64daa49a5637e56db4487fddf842"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\repositorio\Curso-.Net-Dev.IO\AppMvcCompleta4\MinhaAppMvcCompleta4\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"292d7609506a64daa49a5637e56db4487fddf842", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b042e5fc3232b5e5435141a47b6f7f1bfc6439c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevIO.App.ViewModels.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\repositorio\Curso-.Net-Dev.IO\AppMvcCompleta4\MinhaAppMvcCompleta4\src\DevIO.App\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Ocorreu um erro.";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\repositorio\Curso-.Net-Dev.IO\AppMvcCompleta4\MinhaAppMvcCompleta4\src\DevIO.App\Views\Shared\Error.cshtml"
  
    if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h2>Ooops! Ocorreu um erro, mas não se preocupe. Iremos solucionar em breve.</h2>\r\n        </div>\r\n");
#nullable restore
#line 12 "C:\repositorio\Curso-.Net-Dev.IO\AppMvcCompleta4\MinhaAppMvcCompleta4\src\DevIO.App\Views\Shared\Error.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>");
#nullable restore
#line 15 "C:\repositorio\Curso-.Net-Dev.IO\AppMvcCompleta4\MinhaAppMvcCompleta4\src\DevIO.App\Views\Shared\Error.cshtml"
       Write(Html.Raw(Model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <h2 class=\"text-danger\">");
#nullable restore
#line 16 "C:\repositorio\Curso-.Net-Dev.IO\AppMvcCompleta4\MinhaAppMvcCompleta4\src\DevIO.App\Views\Shared\Error.cshtml"
                           Write(Html.Raw(Model.Mensagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 17 "C:\repositorio\Curso-.Net-Dev.IO\AppMvcCompleta4\MinhaAppMvcCompleta4\src\DevIO.App\Views\Shared\Error.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevIO.App.ViewModels.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
