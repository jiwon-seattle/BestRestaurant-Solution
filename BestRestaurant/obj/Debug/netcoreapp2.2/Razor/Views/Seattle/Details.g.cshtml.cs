#pragma checksum "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c29591605bc8100822a5f7dc1021674f1c50198"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c29591605bc8100822a5f7dc1021674f1c50198", @"/Views/Seattle/Details.cshtml")]
    public class Views_Seattle_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Seattle>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Details.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(72, 85, true);
            WriteLiteral("\r\n<div class=\"seattleDetail\">\r\n    <h2>Area Details</h2>\r\n    <hr />\r\n    <h3>Name : ");
            EndContext();
            BeginContext(158, 40, false);
#line 10 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Details.cshtml"
          Write(Html.DisplayFor(model => model.AreaName));

#line default
#line hidden
            EndContext();
            BeginContext(198, 87, true);
            WriteLiteral("</h3>\r\n    <hr />\r\n    <br>\r\n    <div id=\"seattleDetailLink\">\r\n        <p class=\"link\">");
            EndContext();
            BeginContext(286, 69, false);
#line 14 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Details.cshtml"
                   Write(Html.ActionLink("Edit this area", "Edit", new {id = Model.SeattleId}));

#line default
#line hidden
            EndContext();
            BeginContext(355, 28, true);
            WriteLiteral("\r\n        &nbsp &nbsp &nbsp ");
            EndContext();
            BeginContext(384, 73, false);
#line 15 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Details.cshtml"
                     Write(Html.ActionLink("Delete this area", "Delete", new {id = Model.SeattleId}));

#line default
#line hidden
            EndContext();
            BeginContext(457, 24, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>");
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
