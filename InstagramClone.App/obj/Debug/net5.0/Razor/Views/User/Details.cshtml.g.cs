#pragma checksum "C:\Users\micha\Documents\Microservices\Docker Projects\InstagramClone\InstagramClone.App\Views\User\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7e77c5b69132d1b796f18008c3eaaec7d510b63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Details), @"mvc.1.0.view", @"/Views/User/Details.cshtml")]
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
#line 1 "C:\Users\micha\Documents\Microservices\Docker Projects\InstagramClone\InstagramClone.App\Views\_ViewImports.cshtml"
using InstagramClone.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micha\Documents\Microservices\Docker Projects\InstagramClone\InstagramClone.App\Views\_ViewImports.cshtml"
using InstagramClone.App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\micha\Documents\Microservices\Docker Projects\InstagramClone\InstagramClone.App\Views\_ViewImports.cshtml"
using InstagramClone.App.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e77c5b69132d1b796f18008c3eaaec7d510b63", @"/Views/User/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7ff085cdbf8830f2abbfa663021bae073262931", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>");
#nullable restore
#line 4 "C:\Users\micha\Documents\Microservices\Docker Projects\InstagramClone\InstagramClone.App\Views\User\Details.cshtml"
   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>");
#nullable restore
#line 5 "C:\Users\micha\Documents\Microservices\Docker Projects\InstagramClone\InstagramClone.App\Views\User\Details.cshtml"
   Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>");
#nullable restore
#line 6 "C:\Users\micha\Documents\Microservices\Docker Projects\InstagramClone\InstagramClone.App\Views\User\Details.cshtml"
   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>");
#nullable restore
#line 7 "C:\Users\micha\Documents\Microservices\Docker Projects\InstagramClone\InstagramClone.App\Views\User\Details.cshtml"
   Write(Model.Forename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\micha\Documents\Microservices\Docker Projects\InstagramClone\InstagramClone.App\Views\User\Details.cshtml"
   Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>");
#nullable restore
#line 9 "C:\Users\micha\Documents\Microservices\Docker Projects\InstagramClone\InstagramClone.App\Views\User\Details.cshtml"
   Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>");
#nullable restore
#line 10 "C:\Users\micha\Documents\Microservices\Docker Projects\InstagramClone\InstagramClone.App\Views\User\Details.cshtml"
   Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
