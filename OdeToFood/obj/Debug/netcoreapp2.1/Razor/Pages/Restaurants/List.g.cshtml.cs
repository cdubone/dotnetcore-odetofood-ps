#pragma checksum "C:\Users\c.a.williams\source\repos\OdeToFood-ps\OdeToFood\Pages\Restaurants\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c6906dc47eec002bbb3c65261dd7dfafdf83a93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_List), @"mvc.1.0.razor-page", @"/Pages/Restaurants/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/List.cshtml", typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_List), null)]
namespace OdeToFood.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\c.a.williams\source\repos\OdeToFood-ps\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c6906dc47eec002bbb3c65261dd7dfafdf83a93", @"/Pages/Restaurants/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0820fb6dbe507f6ce740cdfd07cdc5236e4275df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 49, true);
            WriteLiteral("\r\n<h1>Restaurants</h1>\r\n\r\n<table class=\"table\">\r\n");
            EndContext();
#line 9 "C:\Users\c.a.williams\source\repos\OdeToFood-ps\OdeToFood\Pages\Restaurants\List.cshtml"
     foreach(var restaurant in Model.Restaurants)
    {

#line default
#line hidden
            BeginContext(139, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(170, 15, false);
#line 12 "C:\Users\c.a.williams\source\repos\OdeToFood-ps\OdeToFood\Pages\Restaurants\List.cshtml"
           Write(restaurant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(185, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(209, 19, false);
#line 13 "C:\Users\c.a.williams\source\repos\OdeToFood-ps\OdeToFood\Pages\Restaurants\List.cshtml"
           Write(restaurant.Location);

#line default
#line hidden
            EndContext();
            BeginContext(228, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(252, 18, false);
#line 14 "C:\Users\c.a.williams\source\repos\OdeToFood-ps\OdeToFood\Pages\Restaurants\List.cshtml"
           Write(restaurant.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(270, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 16 "C:\Users\c.a.williams\source\repos\OdeToFood-ps\OdeToFood\Pages\Restaurants\List.cshtml"
    }

#line default
#line hidden
            BeginContext(299, 19, true);
            WriteLiteral("</table>\r\n\r\n\r\n<div>");
            EndContext();
            BeginContext(319, 13, false);
#line 20 "C:\Users\c.a.williams\source\repos\OdeToFood-ps\OdeToFood\Pages\Restaurants\List.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(332, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ListModel>)PageContext?.ViewData;
        public ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
