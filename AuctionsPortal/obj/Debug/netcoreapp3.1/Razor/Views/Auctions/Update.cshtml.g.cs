#pragma checksum "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19644966382ffff4d013757a965b2076bf4ad7e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auctions_Update), @"mvc.1.0.view", @"/Views/Auctions/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19644966382ffff4d013757a965b2076bf4ad7e6", @"/Views/Auctions/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50fe626cb7a8dc90013d6b7f34bb504c2cf7efc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Auctions_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BartlomiejJagielloLab5ZadDom.Models.Auction>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Update.cshtml"
  
    ViewData["Title"] = "Change auction";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 8 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Update.cshtml"
 using (Html.BeginForm("Update", "Auctions", FormMethod.Post))
{
    // Auction title

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group\">\n    ");
#nullable restore
#line 12 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Update.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"col-md\">\n        ");
#nullable restore
#line 14 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Update.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"col-md\">\n        ");
#nullable restore
#line 17 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Update.cshtml"
   Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>\n");
#nullable restore
#line 20 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Update.cshtml"

    // Seller Id

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group\">\n    ");
#nullable restore
#line 23 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Update.cshtml"
Write(Html.LabelFor(model => model.SellerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"col-md\">\n        ");
#nullable restore
#line 25 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Update.cshtml"
   Write(Html.DisplayFor(model => model.SellerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"col-md\">\n        ");
#nullable restore
#line 28 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Update.cshtml"
   Write(Html.TextBoxFor(model => model.SellerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>\n");
#nullable restore
#line 31 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Update.cshtml"

    // Item Id

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group\">\n    ");
#nullable restore
#line 34 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Update.cshtml"
Write(Html.LabelFor(model => model.ItemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"col-md\">\n        ");
#nullable restore
#line 36 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Update.cshtml"
   Write(Html.DisplayFor(model => model.ItemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"col-md\">\n        ");
#nullable restore
#line 39 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Update.cshtml"
   Write(Html.TextBoxFor(model => model.ItemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>\n    <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\n");
#nullable restore
#line 43 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Update.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BartlomiejJagielloLab5ZadDom.Models.Auction> Html { get; private set; }
    }
}
#pragma warning restore 1591