#pragma checksum "D:\code\Web\v6\v6\Views\Home\_Item.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a817afe1d37475b82c94f1f0b9ebb4225b583eb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Item), @"mvc.1.0.view", @"/Views/Home/_Item.cshtml")]
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
#line 1 "D:\code\Web\v6\v6\Views\_ViewImports.cshtml"
using v6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\code\Web\v6\v6\Views\_ViewImports.cshtml"
using v6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a817afe1d37475b82c94f1f0b9ebb4225b583eb0", @"/Views/Home/_Item.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4128a6f46fed1b4d4e47199ff976f85350054de6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Item : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\code\Web\v6\v6\Views\Home\_Item.cshtml"
 for (int i = 1; i < 7; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-4 col-sm-6 mb-4\"> \r\n    <!-- Portfolio item 2-->\r\n    <div class=\"portfolio-item\">\r\n        <a class=\"portfolio-link\" data-bs-toggle=\"modal\"");
            BeginWriteAttribute("href", " href = \"", 192, "\"", 223, 1);
#nullable restore
#line 6 "D:\code\Web\v6\v6\Views\Home\_Item.cshtml"
WriteAttributeValue("", 201, "#portfolioModal"+i, 201, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n<div class=\"portfolio-hover\">\r\n                <div class=\"portfolio-hover-content\"><i class=\"fas fa-plus fa-3x\"></i></div>\r\n            </div>\r\n            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 406, "\"", 446, 2);
            WriteAttributeValue("", 412, "assets/img/portfolio/", 412, 21, true);
#nullable restore
#line 10 "D:\code\Web\v6\v6\Views\Home\_Item.cshtml"
WriteAttributeValue("", 433, i + ".jpg", 433, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\" />\r\n        </a>\r\n        <div class=\"portfolio-caption\">\r\n            <div class=\"portfolio-caption-heading\">");
#nullable restore
#line 13 "D:\code\Web\v6\v6\Views\Home\_Item.cshtml"
                                               Write("portfolioModal"+i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"portfolio-caption-subheading text-muted\">Graphic Design</div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 18 "D:\code\Web\v6\v6\Views\Home\_Item.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591