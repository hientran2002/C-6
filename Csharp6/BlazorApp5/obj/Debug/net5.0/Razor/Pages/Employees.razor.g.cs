#pragma checksum "D:\C#6\Csharp6\BlazorApp5\Pages\Employees.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c69e3e823fc9f27b2b5cd274bd4283a0850d5b8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp5.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\C#6\Csharp6\BlazorApp5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#6\Csharp6\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#6\Csharp6\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#6\Csharp6\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C#6\Csharp6\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C#6\Csharp6\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\C#6\Csharp6\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\C#6\Csharp6\BlazorApp5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\C#6\Csharp6\BlazorApp5\_Imports.razor"
using BlazorApp5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\C#6\Csharp6\BlazorApp5\_Imports.razor"
using BlazorApp5.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employees")]
    public partial class Employees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>List Employees</h3>\r\n");
            __builder.AddMarkupContent(1, "<a href=\"employee/0\">Add Employee</a>\r\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><td>ID</td>\r\n            <td>Name</td>\r\n            <td>\r\n                123\r\n            </td></tr></thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 16 "D:\C#6\Csharp6\BlazorApp5\Pages\Employees.razor"
         foreach (var employee in employees)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
#nullable restore
#line 19 "D:\C#6\Csharp6\BlazorApp5\Pages\Employees.razor"
__builder.AddContent(8, employee.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
#nullable restore
#line 20 "D:\C#6\Csharp6\BlazorApp5\Pages\Employees.razor"
__builder.AddContent(11, employee.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", "employee/" + (
#nullable restore
#line 23 "D:\C#6\Csharp6\BlazorApp5\Pages\Employees.razor"
                                       employee.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, "\r\n                        Edit\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\C#6\Csharp6\BlazorApp5\Pages\Employees.razor"
                                e=> OnDelete(employee.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "D:\C#6\Csharp6\BlazorApp5\Pages\Employees.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\C#6\Csharp6\BlazorApp5\Pages\Employees.razor"
       
    private List<BlazorApp5.Data.Employee> employees;
    protected override void OnInitialized()
    {
        employees = EmployeeService.GetEmployees();
    }
    private void OnDelete(Guid id)
    {
        EmployeeService.deleteEmployess(id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorApp5.Data.IEmployeeService EmployeeService { get; set; }
    }
}
#pragma warning restore 1591
