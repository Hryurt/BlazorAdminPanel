#pragma checksum "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d0c231b7ddd8f71ac014a169ea89ffb9a1250c4"
// <auto-generated/>
#pragma warning disable 1591
namespace RoyalstarAdminPanel.Shared
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
#line 1 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Shared\MainLayout.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Shared\MainLayout.razor"
using RoyalstarAdminPanel.Pages;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-7z39vzfh8h");
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(5);
            __builder.AddAttribute(6, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "sidebar");
                __builder2.AddAttribute(9, "b-7z39vzfh8h");
                __builder2.OpenComponent<RoyalstarAdminPanel.Shared.NavMenu>(10);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "main");
                __builder2.AddAttribute(14, "b-7z39vzfh8h");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "top-row px-4");
                __builder2.AddAttribute(17, "b-7z39vzfh8h");
                __builder2.OpenElement(18, "a");
                __builder2.AddAttribute(19, "href", "login");
                __builder2.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Shared\MainLayout.razor"
                                              Logout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "b-7z39vzfh8h");
                __builder2.AddContent(22, "Logout");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "content px-4");
                __builder2.AddAttribute(26, "b-7z39vzfh8h");
                __builder2.AddContent(27, 
#nullable restore
#line 20 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Shared\MainLayout.razor"
                     Body

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(28, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "px-0");
                __builder2.AddAttribute(31, "b-7z39vzfh8h");
                __builder2.OpenComponent<RoyalstarAdminPanel.Pages.Login>(32);
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Shared\MainLayout.razor"
       
    public void Logout()
    {
        ((CustomAuthenticationStateProvider)AuthenticationStateProvider).Logout();
        NavigationManager.NavigateTo("/login");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
