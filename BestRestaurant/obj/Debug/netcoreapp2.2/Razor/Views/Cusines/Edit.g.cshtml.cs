#pragma checksum "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Cusines/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59817b9a15ccc27fb63f109e4518993b0f3fff92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cusines_Edit), @"mvc.1.0.view", @"/Views/Cusines/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cusines/Edit.cshtml", typeof(AspNetCore.Views_Cusines_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59817b9a15ccc27fb63f109e4518993b0f3fff92", @"/Views/Cusines/Edit.cshtml")]
    public class Views_Cusines_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Cuisine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Cusines/Edit.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(67, 25, true);
            WriteLiteral("\n<h2>Edit this Cuisine : ");
            EndContext();
            BeginContext(93, 36, false);
#line 7 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Cusines/Edit.cshtml"
                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(129, 7, true);
            WriteLiteral("</h2>\n\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Cusines/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(169, 40, false);
#line 11 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Cusines/Edit.cshtml"
Write(Html.HiddenFor(model => model.CuisineId));

#line default
#line hidden
            EndContext();
            BeginContext(216, 34, false);
#line 13 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Cusines/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(256, 35, false);
#line 14 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Cusines/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(298, 40, false);
#line 16 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Cusines/Edit.cshtml"
Write(Html.LabelFor(model => model.Restaurant));

#line default
#line hidden
            EndContext();
            BeginContext(344, 33, false);
#line 17 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Cusines/Edit.cshtml"
Write(Html.DropDownList("RestaurantId"));

#line default
#line hidden
            EndContext();
            BeginContext(384, 41, false);
#line 19 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Cusines/Edit.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(431, 42, false);
#line 20 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Cusines/Edit.cshtml"
Write(Html.EditorFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(475, 48, true);
            WriteLiteral("    <input class=\"btn btn-primay\" value=\"Save\">\n");
            EndContext();
#line 23 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Cusines/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(525, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(530, 40, false);
#line 25 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Cusines/Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(570, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurant.Models.Cuisine> Html { get; private set; }
    }
}
#pragma warning restore 1591
