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
#line 2 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\Pages\Employee.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\Pages\Employee.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\Pages\Employee.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\Pages\Employee.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee")]
    public partial class Employee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\selim\Desktop\BlazorApp\EmployeeApi\EmployeeBlazor\Pages\Employee.razor"
       
    public class DepartmentClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    private IEnumerable<DepartmentClass> departments = Array.Empty<DepartmentClass>();


    public class EmployeeClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string DateOfJoining { get; set; }
        public string ProfileFileName { get; set; }
    }

    private IEnumerable<EmployeeClass> employees = Array.Empty<EmployeeClass>();



    private async Task createClick()
    {
        var employeeObj = new EmployeeClass()
            {
                Name = Name,
                Department = Department,
                DateOfJoining = DateOfJoining.ToString("yyyy-MM-dd"),
                ProfileFileName = ProfileFileName
            };

        var request = new HttpRequestMessage(HttpMethod.Post, config["API_URL"] + "employee");

        request.Content = new StringContent(JsonSerializer.Serialize(employeeObj), null, "application/json");

        var client = ClientFactory.CreateClient();

        var response = await client.SendAsync(request);

        using var responseStream = await response.Content.ReadAsStreamAsync();
        var res = await JsonSerializer.DeserializeAsync<object>(responseStream);

        await JS.InvokeVoidAsync("alert", res);
        await refreshList();
    }


    private async Task updateClick()
    {
        var employeeObj = new EmployeeClass()
            {
                Id = Id,
                Name = Name,
                Department = Department,
                DateOfJoining = DateOfJoining.ToString("yyyy-MM-dd"),
                ProfileFileName = ProfileFileName
            };

        var request = new HttpRequestMessage(HttpMethod.Put, config["API_URL"] + "employee");

        request.Content = new StringContent(JsonSerializer.Serialize(employeeObj), null, "application/json");

        var client = ClientFactory.CreateClient();

        var response = await client.SendAsync(request);

        using var responseStream = await response.Content.ReadAsStreamAsync();
        var res = await JsonSerializer.DeserializeAsync<object>(responseStream);

        await JS.InvokeVoidAsync("alert", res);
        await refreshList();
    }

    private async Task deleteClick(int id)
    {
        var request = new HttpRequestMessage(HttpMethod.Delete, config["API_URL"] + "employee/" + id.ToString());

        var client = ClientFactory.CreateClient();

        var response = await client.SendAsync(request);

        using var responseStream = await response.Content.ReadAsStreamAsync();
        var res = await JsonSerializer.DeserializeAsync<object>(responseStream);

        await JS.InvokeVoidAsync("alert", res);
        await refreshList();
    }

    private string modalTitle;
    private int Id { get; set; }
    private string Name { get; set; }
    private string Department { get; set; }
    private DateTime DateOfJoining { get; set; }
    private string ProfileFileName { get; set; }
    private string PhotoPath { get; set; }


    private async Task refreshList()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, config["API_URL"] + "employee");
        var client = ClientFactory.CreateClient();

        var response = await client.SendAsync(request);

        using var responseStream = await response.Content.ReadAsStreamAsync();
        employees = await JsonSerializer.DeserializeAsync<IEnumerable<EmployeeClass>>(responseStream);

        var request2 = new HttpRequestMessage(HttpMethod.Get, config["API_URL"] + "department");
        var client2 = ClientFactory.CreateClient();

        var response2 = await client2.SendAsync(request2);

        using var responseStream2 = await response2.Content.ReadAsStreamAsync();
        departments = await JsonSerializer.DeserializeAsync<IEnumerable<DepartmentClass>>(responseStream2);
    }

    protected override async Task OnInitializedAsync()
    {
        PhotoPath = config["Photo_URL"];
        ProfileFileName = "1.jpg";
        await refreshList();
    }

    private void addClick()
    {
        modalTitle = "Add Employee";
        Id = 0;
        Name = "";
        Department = "";
        DateOfJoining = DateTime.Now;
        ProfileFileName = "1.jpg";
    }

    private void editClick(EmployeeClass employee)
    {
        modalTitle = "Edit Employee";
        Id = employee.Id;
        Name = employee.Name;
        Department = employee.Department;
        DateOfJoining = Convert.ToDateTime(employee.DateOfJoining);
        ProfileFileName = employee.ProfileFileName;
    }


    private async Task UploadFile(IFileListEntry[] files)
    {
        var file = files.FirstOrDefault();
        var ms = new MemoryStream();
        await file.Data.CopyToAsync(ms);

        var content = new MultipartFormDataContent { { new ByteArrayContent(ms.GetBuffer()),"\"file\"",file.Name} };

        var request = new HttpRequestMessage(HttpMethod.Post, config["API_URL"] + "employee/savefile");

        request.Content = content;

        var client = ClientFactory.CreateClient();

        var response = await client.SendAsync(request);

        using var responseStream = await response.Content.ReadAsStreamAsync();
        ProfileFileName = await JsonSerializer.DeserializeAsync<string>(responseStream);

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