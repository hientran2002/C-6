#pragma checksum "D:\C#6\Csharp6\BlazorWebAssemblyApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d857548ba74bd9e6cf7858a4bf7b3971ad958c5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebAssemblyApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\C#6\Csharp6\BlazorWebAssemblyApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#6\Csharp6\BlazorWebAssemblyApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#6\Csharp6\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#6\Csharp6\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C#6\Csharp6\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C#6\Csharp6\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\C#6\Csharp6\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\C#6\Csharp6\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\C#6\Csharp6\BlazorWebAssemblyApp\_Imports.razor"
using BlazorWebAssemblyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\C#6\Csharp6\BlazorWebAssemblyApp\_Imports.razor"
using BlazorWebAssemblyApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<BlazorWebAssemblyApp.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.AddMarkupContent(4, "<a href=\"/jsindotnet\">\r\nHow to call JavaScript code from .Net    \r\n</a>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591