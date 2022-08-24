#pragma checksum "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\Pages\PlaceOrderComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "467c2e941369f732411ae1534107c5065c81a87d"
// <auto-generated/>
#pragma warning disable 1591
namespace eShop.Blazor.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/placeorder")]
    public partial class PlaceOrderComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Placing Order</h3>\r\n<br>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\Pages\PlaceOrderComponent.razor"
 if (order != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<eShop.Blazor.Controls.CustomerFormComponent>(7);
            __builder.AddAttribute(8, "OnCustomerInfoSubmitted", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<eShop.Blazor.ViewModels.CustomerViewModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<eShop.Blazor.ViewModels.CustomerViewModel>(this, 
#nullable restore
#line 16 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\Pages\PlaceOrderComponent.razor"
                                                        HandleCustomerInfoSubmitted

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenComponent<eShop.Blazor.Controls.OrderSummaryComponent>(14);
            __builder.AddAttribute(15, "Order", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<eShop.CoreBusiness.Models.Order>(
#nullable restore
#line 19 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\Pages\PlaceOrderComponent.razor"
                                      order

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "HidePlaceOrderButton", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\Pages\PlaceOrderComponent.razor"
                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 22 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\Pages\PlaceOrderComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\selim\Desktop\BlazorApp\eShop.Blazor\eShop.Blazor\Pages\PlaceOrderComponent.razor"
       

    private Order order;

    //private MessageComponent msgComponent;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            order = await viewShoppingCart.Execute();
            StateHasChanged();
        }
    }

    private async void HandleCustomerInfoSubmitted(CustomerViewModel customer)
    {
        var mapper = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<CustomerViewModel, Order>()).CreateMapper();
        mapper.Map<CustomerViewModel, Order>(customer, order);

        var orderUniqueId = await placeOrder.Execute(order);
        if (string.IsNullOrWhiteSpace(orderUniqueId))
        {
            // error occured, not able to place order, please contact the admin
            //msgComponent.ShowError("Information in the order is invalid, please double check.");
        }
        else
        {
            NavigationManager.NavigateTo($"/orderconfirm/{orderUniqueId}");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlaceOrder placeOrder { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IViewShoppingCart viewShoppingCart { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591