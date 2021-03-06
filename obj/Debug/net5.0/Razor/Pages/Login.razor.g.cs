#pragma checksum "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f1d3135ba88c01d62d7295269827c5a421948dc"
// <auto-generated/>
#pragma warning disable 1591
namespace RoyalstarAdminPanel.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\_Imports.razor"
using RoyalstarAdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\_Imports.razor"
using RoyalstarAdminPanel.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\Login.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\Login.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\Login.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main-login-page");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container py-5 py-sm-7");
            __builder.AddMarkupContent(4, "<div class=\"row justify-content-center mb-5\"><img src=\"user-avatar-with-check-mark.svg\" alt class=\"login-page-logo\"></div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row justify-content-center");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-7 col-lg-5");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card card-lg mb-5");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "<div class=\"text-center\"><h1>Sign In</h1>\r\n                            <p>Enter your username and password</p></div>\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(14);
            __builder.AddAttribute(15, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\Login.razor"
                                         myModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 22 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\Login.razor"
                                                                 Success

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(18);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n                            ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label for=\"loginUsername\" class=\"input-label text-capitalize\">Username</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control form-control-lg");
                __builder2.AddAttribute(25, "autocomplete", "off");
                __builder2.AddAttribute(26, "tabindex", "1");
                __builder2.AddAttribute(27, "Placeholder", "Username");
                __builder2.AddAttribute(28, "id", "loginUsername");
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\Login.razor"
                                                                     myModel.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => myModel.Username = __value, myModel.Username))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => myModel.Username));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "<label for=\"loginPassword\" class=\"input-label text-capitalize\">Password</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "type", "password");
                __builder2.AddAttribute(38, "tabindex", "2");
                __builder2.AddAttribute(39, "class", "form-control form-control-lg");
                __builder2.AddAttribute(40, "Placeholder", "Password");
                __builder2.AddAttribute(41, "id", "loginPassword");
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\Login.razor"
                                                                                            myModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => myModel.Password = __value, myModel.Password))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => myModel.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                            ");
                __builder2.AddMarkupContent(46, "<button type=\"submit\" class=\"btn btn-lg btn-block btn-primary\">Sign In</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\Login.razor"
       
    ClaimsPrincipal claimsPrincipal;

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    protected async override Task OnInitializedAsync()
    {
        claimsPrincipal = (await authenticationStateTask).User;

        if (claimsPrincipal.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo("/");
        }

    }
    async Task Success()
    {
        var userFromService = await
        ((CustomAuthenticationStateProvider)AuthenticationStateProvider).AuthenticateUser(myModel.Username, myModel.Password);
        if (userFromService == false)
        {
            await JS.InvokeAsync<object>("alert", "Unsuccessful login!");
        }
        else
        {
            await JS.InvokeAsync<object>("alert", "Successful login!");
            NavigationManager.NavigateTo("/");
        }
    }
    LoginModel myModel = new LoginModel();

    public class LoginModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        //[MinLength(8)]
        public string Password { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
