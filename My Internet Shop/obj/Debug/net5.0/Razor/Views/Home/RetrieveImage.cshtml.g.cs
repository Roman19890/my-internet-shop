#pragma checksum "C:\Users\romaX\OneDrive\Рабочий стол\Diploma Project\My Internet Shop\My Internet Shop\Views\Home\RetrieveImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67c64e6d45f76868217b69285dfe2186d2b2f135"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RetrieveImage), @"mvc.1.0.view", @"/Views/Home/RetrieveImage.cshtml")]
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
#line 1 "C:\Users\romaX\OneDrive\Рабочий стол\Diploma Project\My Internet Shop\My Internet Shop\Views\_ViewImports.cshtml"
using MyInternetShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\romaX\OneDrive\Рабочий стол\Diploma Project\My Internet Shop\My Internet Shop\Views\_ViewImports.cshtml"
using MyInternetShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67c64e6d45f76868217b69285dfe2186d2b2f135", @"/Views/Home/RetrieveImage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec3ecda61ed45fb9f4afa194e841acbe56af90c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RetrieveImage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 1 "C:\Users\romaX\OneDrive\Рабочий стол\Diploma Project\My Internet Shop\My Internet Shop\Views\Home\RetrieveImage.cshtml"
Write(ViewBag.ImageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 34, "\"", 61, 1);
#nullable restore
#line 2 "C:\Users\romaX\OneDrive\Рабочий стол\Diploma Project\My Internet Shop\My Internet Shop\Views\Home\RetrieveImage.cshtml"
WriteAttributeValue("", 40, ViewBag.ImageDataUrl, 40, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"400px\" width=\"400px\"/>");
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