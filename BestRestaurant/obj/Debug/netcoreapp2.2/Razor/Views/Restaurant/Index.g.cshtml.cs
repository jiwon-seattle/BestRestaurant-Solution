#pragma checksum "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurant/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c856f70574ddcd5497a194de65b291e259f99b9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurant_Index), @"mvc.1.0.view", @"/Views/Restaurant/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurant/Index.cshtml", typeof(AspNetCore.Views_Restaurant_Index))]
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
#line 5 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurant/Index.cshtml"
using BestRestaurant.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c856f70574ddcd5497a194de65b291e259f99b9c", @"/Views/Restaurant/Index.cshtml")]
    public class Views_Restaurant_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BestRestaurant.Models.Restaurant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurant/Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(107, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurant/Index.cshtml"
 if(Model.Count == 0)
{

#line default
#line hidden
            BeginContext(132, 49, true);
            WriteLiteral("    <h3>No Restaurants have been added yet.</h3>\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurant/Index.cshtml"
}

#line default
#line hidden
            BeginContext(183, 6, true);
            WriteLiteral("\n<ul>\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurant/Index.cshtml"
     foreach(Restaurant restaurant in Model)
    {

#line default
#line hidden
            BeginContext(240, 25, true);
            WriteLiteral("        <li class=\"link\">");
            EndContext();
            BeginContext(266, 84, false);
#line 16 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurant/Index.cshtml"
                    Write(Html.ActionLink($"{restaurant.Name}", "Details", new {id = restaurant.RestaurantId}));

#line default
#line hidden
            EndContext();
            BeginContext(350, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 17 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurant/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(362, 23, true);
            WriteLiteral("</ul>\n\n<p class=\"link\">");
            EndContext();
            BeginContext(386, 48, false);
#line 20 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurant/Index.cshtml"
           Write(Html.ActionLink("Add new restaurants", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(434, 26, true);
            WriteLiteral("</p>\n<!-- <p class=\"link\">");
            EndContext();
            BeginContext(461, 40, false);
#line 21 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurant/Index.cshtml"
                Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(501, 8, true);
            WriteLiteral("</p> -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BestRestaurant.Models.Restaurant>> Html { get; private set; }
    }
}
#pragma warning restore 1591