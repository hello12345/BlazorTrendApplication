#pragma checksum "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d24a9fc18da567d832a9cec9f07e2b3c199518d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTrendApplication.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\_Imports.razor"
using BlazorTrendApplication.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\_Imports.razor"
using BlazorTrendApplication.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\_Imports.razor"
using Blazorise.Snackbar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\_Imports.razor"
using Blazorise.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\_Imports.razor"
using Blazorise.DataGrid;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "BlazorTrendApplication.Web");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "page");
            __builder.AddAttribute(6, "b-wr6pfqq8fk");
            __builder.OpenElement(7, "main");
            __builder.AddAttribute(8, "b-wr6pfqq8fk");
            __builder.OpenComponent<BlazorTrendApplication.Web.Shared.Header>(9);
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n\r\n        ");
            __builder.OpenElement(11, "article");
            __builder.AddAttribute(12, "class", "content");
            __builder.AddAttribute(13, "b-wr6pfqq8fk");
#nullable restore
#line (10,14)-(10,18) 25 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Shared\MainLayout.razor"
__builder.AddContent(14, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
