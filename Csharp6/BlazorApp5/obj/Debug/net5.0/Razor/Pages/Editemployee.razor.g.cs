#pragma checksum "D:\C#6\Csharp6\BlazorApp5\Pages\Editemployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c75e04f08b2ba70266d10e4dae2564e2124b766"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee/{id}")]
    public partial class Editemployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit employee</h3>\r\n");
            __builder.OpenElement(1, "h5");
#nullable restore
#line 5 "D:\C#6\Csharp6\BlazorApp5\Pages\Editemployee.razor"
__builder.AddContent(2, Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "D:\C#6\Csharp6\BlazorApp5\Pages\Editemployee.razor"
                 employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "D:\C#6\Csharp6\BlazorApp5\Pages\Editemployee.razor"
                                      SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "<label>ID</label>\r\n        ");
                __builder2.OpenElement(11, "input");
                __builder2.AddAttribute(12, "id", "id");
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "value", 
#nullable restore
#line 9 "D:\C#6\Csharp6\BlazorApp5\Pages\Editemployee.razor"
                                                    employee.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(15, "readonly");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "<label>Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "id", "name");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "name", "name");
                __builder2.AddAttribute(24, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "D:\C#6\Csharp6\BlazorApp5\Pages\Editemployee.razor"
                                                               employee.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => employee.Name = __value, employee.Name))));
                __builder2.AddAttribute(26, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => employee.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.AddMarkupContent(28, "<button type=\"submit\" class=\"btn btn-primary\">Update</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "D:\C#6\Csharp6\BlazorApp5\Pages\Editemployee.razor"
       
    [Parameter]
    public string Id { get; set; }

    private  BlazorApp5.Data.Employee employee { get; set; }

    protected override void OnInitialized()
    {
        if (!string.IsNullOrEmpty(Id) & Id == "0")
        {
            employee = new Data.Employee();
        }
        else
        {
            employee=  EmployeeService.GetEmployee(Guid.Parse(Id));
        }

    }
    private void SubmitForm()
    {
        if (employee.Id == Guid.Empty)
        {
            EmployeeService.addEmployee(employee);
        }
        else
        {
             EmployeeService.updateEmployee(employee);
        }
       
        Navigation.NavigateTo("employees");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorApp5.Data.IEmployeeService EmployeeService { get; set; }
    }
}
#pragma warning restore 1591
