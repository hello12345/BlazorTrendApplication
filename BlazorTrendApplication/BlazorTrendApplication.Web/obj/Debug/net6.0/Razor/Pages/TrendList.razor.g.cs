#pragma checksum "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da21513b0a5a3ebbf2a777c7a0f19248d30bf8cc"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTrendApplication.Web.Pages
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
#nullable restore
#line 4 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/trendlist/{userId}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/trendlist/")]
    public partial class TrendList : TrendListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
 if (trends == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner\"></div>");
#nullable restore
#line 8 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "float-right m-2");
            __builder.AddAttribute(5, "style", "float: right");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "type", "button");
            __builder.AddAttribute(8, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
                                                                              createtrend

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "<i class=\"fa fa-plus\" aria-hidden=\"true\"></i> Trend");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table mt-3");
            __builder.AddMarkupContent(14, @"<thead><tr><th scope=""col"">Image</th>
                    <th scope=""col"">TrendType</th>
                    <th scope=""col"">Title</th>
                    <th scope=""col"">Introduction</th>
                    <th scope=""col"">Summary</th>
                    <th scope=""col"">TargetedViewer</th>
                    <th scope=""col"">Price</th>
                    <th scope=""col"">Status</th>
                    <th scope=""col"">Action</th></tr></thead>
            ");
            __builder.OpenElement(15, "tbody");
#nullable restore
#line 30 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
                 foreach (var trend in trends)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "tr");
            __builder.OpenElement(17, "td");
            __builder.OpenElement(18, "img");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 33 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
                                       trend.ImgFile

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "alt", "Lights");
            __builder.AddAttribute(21, "style", "width: 125px;height: 75px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "td");
#nullable restore
#line (35,30)-(35,45) 25 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
__builder.AddContent(24, trend.TrendType);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "td");
#nullable restore
#line (36,30)-(36,41) 25 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
__builder.AddContent(27, trend.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "td");
#nullable restore
#line (37,30)-(37,48) 25 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
__builder.AddContent(30, trend.Introduction);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "td");
#nullable restore
#line (38,30)-(38,43) 25 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
__builder.AddContent(33, trend.Summary);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "td");
#nullable restore
#line (39,30)-(39,50) 25 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
__builder.AddContent(36, trend.TargetedViewer);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "td");
            __builder.OpenElement(39, "strong");
#nullable restore
#line (40,38)-(40,49) 25 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
__builder.AddContent(40, trend.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "td");
#nullable restore
#line (41,30)-(41,42) 25 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
__builder.AddContent(43, trend.Status);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.OpenElement(45, "td");
            __builder.OpenElement(46, "i");
            __builder.AddAttribute(47, "class", "fa fa-edit");
            __builder.AddAttribute(48, "style", "font-size:18px;");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
                                                                                    () => edittrend(trend.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "&nbsp;\r\n                            ");
            __builder.OpenElement(51, "i");
            __builder.AddAttribute(52, "class", "fa fa-trash-o");
            __builder.AddAttribute(53, "style", "font-size:18px;color:red");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
                                                                                                () => deletetrend(trend.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazorise.Modal>(55);
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.ModalContent>(57);
                __builder2.AddAttribute(58, "Centered", true);
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.ModalHeader>(60);
                    __builder3.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.ModalTitle>(62);
                        __builder4.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(64, "Delete Trend");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.ModalBody>(66);
                    __builder3.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(68, "\r\n            Are you sure you want to delete trend?\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.ModalFooter>(70);
                    __builder3.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.Button>(72);
                        __builder4.AddAttribute(73, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 62 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
                           Color.Secondary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(74, "Clicked", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 62 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
                                                      CloseModal

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(76, "Close");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(77, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.Button>(78);
                        __builder4.AddAttribute(79, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 63 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
                           Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(80, "Clicked", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 63 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
                                                    deleteTrend

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(82, "Okay");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(83, (__value) => {
#nullable restore
#line 53 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\TrendList.razor"
             modalTrend = (Blazorise.Modal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
