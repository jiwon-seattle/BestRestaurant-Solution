#pragma checksum "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd9c3c5870a17daa3dbe61ddfba8aa1b8e54694c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seattle_Details), @"mvc.1.0.view", @"/Views/Seattle/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Seattle/Details.cshtml", typeof(AspNetCore.Views_Seattle_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd9c3c5870a17daa3dbe61ddfba8aa1b8e54694c", @"/Views/Seattle/Details.cshtml")]
    public class Views_Seattle_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Seattle>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Details.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(67, 59, true);
            WriteLiteral("\n<div class=\"container\">\n    <h2>Area Details</h2>\n    <h3>");
            EndContext();
            BeginContext(127, 44, false);
#line 9 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Details.cshtml"
   Write(Html.DisplayNameFor(model => model.AreaName));

#line default
#line hidden
            EndContext();
            BeginContext(171, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(175, 40, false);
#line 9 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.AreaName));

#line default
#line hidden
            EndContext();
            BeginContext(215, 65, true);
            WriteLiteral("</h3>\n\n    <br>\n    <div class=\"bottom\">\n        <p class=\"link\">");
            EndContext();
            BeginContext(281, 69, false);
#line 13 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Details.cshtml"
                   Write(Html.ActionLink("Edit this area", "Edit", new {id = Model.SeattleId}));

#line default
#line hidden
            EndContext();
            BeginContext(350, 27, true);
            WriteLiteral("\n        &nbsp &nbsp &nbsp ");
            EndContext();
            BeginContext(378, 73, false);
#line 14 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Details.cshtml"
                     Write(Html.ActionLink("Delete this area", "Delete", new {id = Model.SeattleId}));

#line default
#line hidden
            EndContext();
            BeginContext(451, 27, true);
            WriteLiteral("\n        &nbsp &nbsp &nbsp ");
            EndContext();
            BeginContext(479, 45, false);
#line 15 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Details.cshtml"
                     Write(Html.ActionLink("Back to area list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(524, 34, true);
            WriteLiteral("</p>\n        <!-- <p class=\"link\">");
            EndContext();
            BeginContext(559, 40, false);
#line 16 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Details.cshtml"
                        Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(599, 26, true);
            WriteLiteral("</p> -->\n    </div>\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurant.Models.Seattle> Html { get; private set; }
    }
}
#pragma warning restore 1591
