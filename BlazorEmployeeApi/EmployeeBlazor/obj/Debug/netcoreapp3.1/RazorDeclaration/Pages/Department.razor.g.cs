// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EmployeeBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\_Imports.razor"
using EmployeeBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\_Imports.razor"
using EmployeeBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\Pages\Department.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\Pages\Department.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/department")]
    public partial class Department : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\Pages\Department.razor"
       
    public class DepartmentClass
    {
        public int Id { get; set; }
        public string Name { get; set; }         
    }

    private IEnumerable<DepartmentClass> departments = Array.Empty<DepartmentClass>();


    protected override async Task OnInitializedAsync()
    {
        await refreshList();
    }


    private async Task refreshList()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, config["API_URL"] + "department");
        var client = ClientFactory.CreateClient();

        var response = await client.SendAsync(request);

        using var responseStream = await response.Content.ReadAsStreamAsync();
        departments = await JsonSerializer.DeserializeAsync<IEnumerable<DepartmentClass>>(responseStream);
    }

    private async Task createClick()
    {
        var departmentObj = new DepartmentClass() { Name = Name };

        var request = new HttpRequestMessage(HttpMethod.Post, config["API_URL"] + "department");

        request.Content = new StringContent(JsonSerializer.Serialize(departmentObj),null,"application/json");

        var client = ClientFactory.CreateClient();

        var response = await client.SendAsync(request);

        using var responseStream = await response.Content.ReadAsStreamAsync();
        var res = await JsonSerializer.DeserializeAsync<object>(responseStream);

        await JS.InvokeVoidAsync("alert",res);
        await refreshList();
    }


    private async Task updateClick()
    {
        var departmentObj = new DepartmentClass() {Id=Id, Name = Name };

        var request = new HttpRequestMessage(HttpMethod.Put, config["API_URL"] + "department");

        request.Content = new StringContent(JsonSerializer.Serialize(departmentObj), null, "application/json");

        var client = ClientFactory.CreateClient();

        var response = await client.SendAsync(request);

        using var responseStream = await response.Content.ReadAsStreamAsync();
        var res = await JsonSerializer.DeserializeAsync<object>(responseStream);

        await JS.InvokeVoidAsync("alert", res);
        await refreshList();
    }

    private async Task deleteClick(int id)
    {
        var request = new HttpRequestMessage(HttpMethod.Delete, config["API_URL"] + "department/"+id.ToString());

        var client = ClientFactory.CreateClient();

        var response = await client.SendAsync(request);

        using var responseStream = await response.Content.ReadAsStreamAsync();
        var res = await JsonSerializer.DeserializeAsync<object>(responseStream);

        await JS.InvokeVoidAsync("alert", res);
        await refreshList();
    }

    private string modalTitle;
    private int Id;
    private string Name;

    private void addClick()
    {
        modalTitle = "Add Department";
        Id = 0;
        Name = "";
    }

    private void editClick(DepartmentClass department)
    {
        modalTitle = "Edit Department";
        Id = department.Id;
        Name = department.Name;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
#pragma warning restore 1591
