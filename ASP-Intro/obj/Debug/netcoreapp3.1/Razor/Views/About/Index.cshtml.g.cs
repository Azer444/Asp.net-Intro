#pragma checksum "C:\Users\azerh\Desktop\C# Html\Asp.net\ASP - Intro\ASP-Intro\ASP-Intro\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30100667956fdf12d2fef13589bb3b5d5c6324dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30100667956fdf12d2fef13589bb3b5d5c6324dd", @"/Views/About/Index.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\azerh\Desktop\C# Html\Asp.net\ASP - Intro\ASP-Intro\ASP-Intro\Views\About\Index.cshtml"
  
    string[] name = { "Salam", "Necesen" };
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul>\r\n    \r\n");
#nullable restore
#line 7 "C:\Users\azerh\Desktop\C# Html\Asp.net\ASP - Intro\ASP-Intro\ASP-Intro\Views\About\Index.cshtml"
         foreach (var item in name)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 9 "C:\Users\azerh\Desktop\C# Html\Asp.net\ASP - Intro\ASP-Intro\ASP-Intro\Views\About\Index.cshtml"
   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 10 "C:\Users\azerh\Desktop\C# Html\Asp.net\ASP - Intro\ASP-Intro\ASP-Intro\Views\About\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</ul>");
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
