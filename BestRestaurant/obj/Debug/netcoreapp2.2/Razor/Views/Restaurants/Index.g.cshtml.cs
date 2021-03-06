#pragma checksum "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfe45154b06b313dd2a509ebc837d84d8c0a79bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Index), @"mvc.1.0.view", @"/Views/Restaurants/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Index.cshtml", typeof(AspNetCore.Views_Restaurants_Index))]
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
#line 5 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Index.cshtml"
using BestRestaurant.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe45154b06b313dd2a509ebc837d84d8c0a79bf", @"/Views/Restaurants/Index.cshtml")]
    public class Views_Restaurants_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BestRestaurant.Models.Restaurant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(113, 57, true);
            WriteLiteral("\r\n<div class=\"restaurantIndex\">\r\n\r\n<h1>Restaurant<h1>\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Index.cshtml"
 if (TempData.ContainsKey("ErrorMessage"))
{

#line default
#line hidden
            BeginContext(217, 24, true);
            WriteLiteral("    <h3>Error message: \"");
            EndContext();
            BeginContext(242, 24, false);
#line 14 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Index.cshtml"
                   Write(TempData["ErrorMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(266, 8, true);
            WriteLiteral("\"</h3>\r\n");
            EndContext();
#line 15 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Index.cshtml"
}

#line default
#line hidden
#line 16 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(304, 48, true);
            WriteLiteral("    <h3>No restaurant has been added yet!</h3>\r\n");
            EndContext();
#line 19 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Index.cshtml"
}

#line default
#line hidden
            BeginContext(355, 44, true);
            WriteLiteral("\r\n<div id=\"restaurantIndexList\">\r\n    <ul>\r\n");
            EndContext();
#line 23 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Index.cshtml"
     foreach (Restaurant restaurant in Model)
    {

#line default
#line hidden
            BeginContext(453, 12, true);
            WriteLiteral("        <h3>");
            EndContext();
            BeginContext(466, 90, false);
#line 25 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Index.cshtml"
       Write(Html.ActionLink($"{@restaurant.Location }", "Details", new {id = restaurant.RestaurantId}));

#line default
#line hidden
            EndContext();
            BeginContext(556, 9, true);
            WriteLiteral(" </h3> \r\n");
            EndContext();
#line 26 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(572, 46, true);
            WriteLiteral("    </ul>\r\n</div>\r\n<p style=\"font-size:15px;\">");
            EndContext();
            BeginContext(619, 47, false);
#line 29 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Index.cshtml"
                      Write(Html.ActionLink("Add new restaurant", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(666, 14, true);
            WriteLiteral("</p>\r\n\r\n</div>");
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
