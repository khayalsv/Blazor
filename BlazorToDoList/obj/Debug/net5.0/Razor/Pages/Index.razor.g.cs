#pragma checksum "C:\Users\selim\Desktop\BlazorApp\BlazorToDoList\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e1872ae8b8c089782e404e79dbe471e6f2934ff"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorToDoList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\selim\Desktop\BlazorApp\BlazorToDoList\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\BlazorApp\BlazorToDoList\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\selim\Desktop\BlazorApp\BlazorToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\selim\Desktop\BlazorApp\BlazorToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\selim\Desktop\BlazorApp\BlazorToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\selim\Desktop\BlazorApp\BlazorToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\selim\Desktop\BlazorApp\BlazorToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\selim\Desktop\BlazorApp\BlazorToDoList\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\selim\Desktop\BlazorApp\BlazorToDoList\_Imports.razor"
using BlazorToDoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\selim\Desktop\BlazorApp\BlazorToDoList\_Imports.razor"
using BlazorToDoList.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\selim\Desktop\BlazorApp\BlazorToDoList\_Imports.razor"
using BlazorToDoList.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-6");
            __builder.OpenComponent<BlazorToDoList.Pages.Components.ToDo>(4);
            __builder.AddAttribute(5, "HeaderName", "Daily Task");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-6");
            __builder.OpenComponent<BlazorToDoList.Pages.Components.ToDo>(9);
            __builder.AddAttribute(10, "HeaderName", "Monthly Task");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591