#pragma checksum "C:\Users\azerh\Desktop\C# Html\Asp.net\ASP - Intro\ASP-Intro\ASP-Intro\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e97502aab5fb73ed7209e47e16ecbfabc75df36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e97502aab5fb73ed7209e47e16ecbfabc75df36", @"/Views/Login/Index.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\azerh\Desktop\C# Html\Asp.net\ASP - Intro\ASP-Intro\ASP-Intro\Views\Login\Index.cshtml"
   
    string[] surname = { "Humbetov", "Bashirov", "Qarayev" };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 6 "C:\Users\azerh\Desktop\C# Html\Asp.net\ASP - Intro\ASP-Intro\ASP-Intro\Views\Login\Index.cshtml"
     foreach (var item in surname)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 8 "C:\Users\azerh\Desktop\C# Html\Asp.net\ASP - Intro\ASP-Intro\ASP-Intro\Views\Login\Index.cshtml"
       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 9 "C:\Users\azerh\Desktop\C# Html\Asp.net\ASP - Intro\ASP-Intro\ASP-Intro\Views\Login\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
