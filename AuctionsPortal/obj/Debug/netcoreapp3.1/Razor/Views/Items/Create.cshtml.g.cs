#pragma checksum "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Items\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1468e35fbd5a2b3f87ecbac7d98dc43ec6f1b7a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Create), @"mvc.1.0.view", @"/Views/Items/Create.cshtml")]
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
#line 1 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\_ViewImports.cshtml"
using BartlomiejJagielloLab5ZadDom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\_ViewImports.cshtml"
using BartlomiejJagielloLab5ZadDom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1468e35fbd5a2b3f87ecbac7d98dc43ec6f1b7a0", @"/Views/Items/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50fe626cb7a8dc90013d6b7f34bb504c2cf7efc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BartlomiejJagielloLab5ZadDom.Models.Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Items\Create.cshtml"
  
    ViewData["Title"] = "New item";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 8 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Items\Create.cshtml"
 using (Html.BeginForm("Create", "Items", FormMethod.Post))
{
    // Item title

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 12 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Items\Create.cshtml"
   Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md\">\n            ");
#nullable restore
#line 14 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Items\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n");
#nullable restore
#line 17 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Items\Create.cshtml"

    // Item description 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 20 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Items\Create.cshtml"
   Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md\">\n            ");
#nullable restore
#line 22 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Items\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n");
#nullable restore
#line 25 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Items\Create.cshtml"
    // Button to add new item

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Add item\" class=\"btn btn-primary\" />\n");
#nullable restore
#line 27 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Items\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BartlomiejJagielloLab5ZadDom.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
