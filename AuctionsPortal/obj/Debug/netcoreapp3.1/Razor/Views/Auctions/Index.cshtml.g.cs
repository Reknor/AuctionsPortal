#pragma checksum "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a19a2972c6b823b7dad7c3e530a554c31e67889"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auctions_Index), @"mvc.1.0.view", @"/Views/Auctions/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a19a2972c6b823b7dad7c3e530a554c31e67889", @"/Views/Auctions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50fe626cb7a8dc90013d6b7f34bb504c2cf7efc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Auctions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BartlomiejJagielloLab5ZadDom.Models.Auction>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Index.cshtml"
  
    ViewData["Title"] = "Auctions list";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>\n    ");
#nullable restore
#line 8 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Index.cshtml"
Write(Html.ActionLink("Create new", "Create", "Auctions"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 15 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 18 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 21 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Index.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Seller.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 24 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Index.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Item));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th>
                <!-- Header for bids link -->
            </th>
            <th>
                <!-- Header for modify link -->
            </th>
            <th>
                <!-- Header for delete link -->
            </th>
        </tr>
    </thead>

    <!-- Display every auction's id, name, seller login and item name-->
    <tbody>
");
#nullable restore
#line 40 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Index.cshtml"
         foreach (var auction in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 44 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => auction.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 47 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => auction.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 50 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => auction.Seller.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 53 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => auction.Item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <!-- Check all bids for auction -->\n            <td>\n                ");
#nullable restore
#line 57 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Index.cshtml"
           Write(Html.ActionLink("Bids", "Index", "Bids", routeValues: new { AuctionId = auction.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <!-- Change auction -->\n            <td>\n                ");
#nullable restore
#line 61 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Index.cshtml"
           Write(Html.ActionLink("Modify", "Update", "Auctions", routeValues: new { id = auction.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <!-- Delete auction -->\n            <td>\n                ");
#nullable restore
#line 65 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", "Auctions", routeValues: new { id = auction.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 68 "C:\Users\barci\Downloads\temp\BartlomiejJagielloLab5ZadDom\AuctionsPortal\Views\Auctions\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BartlomiejJagielloLab5ZadDom.Models.Auction>> Html { get; private set; }
    }
}
#pragma warning restore 1591