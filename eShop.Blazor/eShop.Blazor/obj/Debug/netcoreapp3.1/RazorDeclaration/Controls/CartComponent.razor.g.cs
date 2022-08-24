// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace eShop.Blazor.Controls
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
#line 13 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using eShop.UseCases.ShoppingCartScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using eShop.UseCases.OrderConfirmationScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using eShop.UseCases.PluginInterfaces.StateStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using eShop.Blazor.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using eShop.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\_Imports.razor"
using eShop.Blazor.Controls;

#line default
#line hidden
#nullable disable
    public partial class CartComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\Controls\CartComponent.razor"
       
    private int lineItemsCount = 0;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            shoppingCartStateStore.AddStateChangeListeners(HandleShoppingCartStateChange);
            lineItemsCount = await shoppingCartStateStore.GetLineItemsCount();
            StateHasChanged();

        }
    }

    private async void HandleShoppingCartStateChange()
    {
        lineItemsCount = await shoppingCartStateStore.GetLineItemsCount();
        StateHasChanged();
    }

    public void Dispose(){
        shoppingCartStateStore.RemoveStateChangeListeners(HandleShoppingCartStateChange);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IShoppingCartStateStore shoppingCartStateStore { get; set; }
    }
}
#pragma warning restore 1591
