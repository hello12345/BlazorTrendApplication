#pragma checksum "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "808f4dc4b733d87590d6bd088de286343003473a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : RegisterBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card mt-3 center p-3");
            __builder.AddAttribute(4, "style", "width: 75rem;");
            __builder.AddMarkupContent(5, "<h4 style=\"text-align:center\" class=\"mt-1\" OnValidSubmit=\"saveUser\">Register</h4>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\Register.razor"
                          user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "<label>First Name</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "id", "firstname");
                __builder2.AddAttribute(17, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\Register.razor"
                                                                            user.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.FirstName = __value, user.FirstName))));
                __builder2.AddAttribute(19, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __Blazor.BlazorTrendApplication.Web.Pages.Register.TypeInference.CreateValidationMessage_0(__builder2, 21, 22, 
#nullable restore
#line 12 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\Register.razor"
                                          () => user.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "<label>Last Name</label>\r\n               ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "id", "lastname");
                __builder2.AddAttribute(30, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\Register.razor"
                                                                          user.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.LastName = __value, user.LastName))));
                __builder2.AddAttribute(32, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n                ");
                __Blazor.BlazorTrendApplication.Web.Pages.Register.TypeInference.CreateValidationMessage_1(__builder2, 34, 35, 
#nullable restore
#line 17 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\Register.razor"
                                          () => user.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "<label>User Name</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "id", "username");
                __builder2.AddAttribute(43, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\Register.razor"
                                                                           user.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.UserName = __value, user.UserName))));
                __builder2.AddAttribute(45, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n                ");
                __Blazor.BlazorTrendApplication.Web.Pages.Register.TypeInference.CreateValidationMessage_2(__builder2, 47, 48, 
#nullable restore
#line 22 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\Register.razor"
                                          () => user.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group");
                __builder2.AddMarkupContent(52, "<label>Email</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "class", "form-control");
                __builder2.AddAttribute(55, "id", "email");
                __builder2.AddAttribute(56, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\Register.razor"
                                                                        user.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Email = __value, user.Email))));
                __builder2.AddAttribute(58, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n                ");
                __Blazor.BlazorTrendApplication.Web.Pages.Register.TypeInference.CreateValidationMessage_3(__builder2, 60, 61, 
#nullable restore
#line 27 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\Register.razor"
                                          () => user.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n            ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group");
                __builder2.AddMarkupContent(65, "<label>Password</label>\r\n               ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(66);
                __builder2.AddAttribute(67, "type", "password");
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "id", "password");
                __builder2.AddAttribute(70, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\Register.razor"
                                                                                          user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                __builder2.AddAttribute(72, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n                ");
                __Blazor.BlazorTrendApplication.Web.Pages.Register.TypeInference.CreateValidationMessage_4(__builder2, 74, 75, 
#nullable restore
#line 32 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\Register.razor"
                                          () => user.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n            ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group");
                __builder2.AddMarkupContent(79, "<label>Phone Number</label>\r\n                ");
                __Blazor.BlazorTrendApplication.Web.Pages.Register.TypeInference.CreateNumericEdit_5(__builder2, 80, 81, "form-control", 82, "phone", 83, 
#nullable restore
#line 36 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\Register.razor"
                                                                           user.Phone

#line default
#line hidden
#nullable disable
                , 84, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Phone = __value, user.Phone)), 85, () => user.Phone);
                __builder2.AddMarkupContent(86, "\r\n                ");
                __Blazor.BlazorTrendApplication.Web.Pages.Register.TypeInference.CreateValidationMessage_6(__builder2, 87, 88, 
#nullable restore
#line 37 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\Register.razor"
                                          () => user.Phone

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n            ");
                __builder2.AddMarkupContent(90, "<div class=\"text-center m-2\"><button type=\"submit\" class=\"btn btn-outline-secondary\">Submit</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BlazorTrendApplication.Web.Pages.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateNumericEdit_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Blazorise.NumericEdit<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591