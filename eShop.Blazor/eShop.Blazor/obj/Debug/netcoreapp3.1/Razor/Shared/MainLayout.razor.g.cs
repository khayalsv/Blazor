#pragma checksum "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe921a86507b8224f3eaec842ea439fafe1aba7e"
// <auto-generated/>
#pragma warning disable 1591
namespace eShop.Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using eShop.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using eShop.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using eShop.UseCases.SearchProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using eShop.UseCases.ViewProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using eShop.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using eShop.Blazor.Controls;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    \r\n    ");
            __builder.OpenComponent<eShop.Blazor.Shared.TopNavBar>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "content px-4");
            __builder.AddMarkupContent(7, "\r\n        ");
#nullable restore
#line 8 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\Shared\MainLayout.razor"
__builder.AddContent(8, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591