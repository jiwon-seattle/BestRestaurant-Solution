#pragma checksum "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "021f777dda941253bfec030869a52a5d3878eb23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Delete), @"mvc.1.0.view", @"/Views/Restaurants/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Delete.cshtml", typeof(AspNetCore.Views_Restaurants_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"021f777dda941253bfec030869a52a5d3878eb23", @"/Views/Restaurants/Delete.cshtml")]
    public class Views_Restaurants_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Delete.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(75, 88, true);
            WriteLiteral("<div class=\"restaurantDelete\">\r\n<h2>Delete this restaurant?</h2>\r\n\r\n<p>Restaurant Name: ");
            EndContext();
            BeginContext(164, 46, false);
#line 9 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Delete.cshtml"
               Write(Html.DisplayFor(model => model.RestaurantName));

#line default
#line hidden
            EndContext();
            BeginContext(210, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 10 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(246, 66, true);
            WriteLiteral("    <input class=\"btn btn-primary\" type=\"submit\" value=\"Delete\">\r\n");
            EndContext();
#line 13 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Delete.cshtml"
}

#line default
#line hidden
            BeginContext(315, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurant.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
