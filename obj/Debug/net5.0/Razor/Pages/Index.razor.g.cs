#pragma checksum "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eba26d342e2c870fb5a792564e5722f0e35e7042"
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
#line 2 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\Index.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "h1");
                __builder2.AddContent(3, "Hello, ");
                __builder2.AddContent(4, 
#nullable restore
#line 7 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\Index.razor"
                    context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(5, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.AddMarkupContent(7, "<p>You can only see this content if you\'re authorized.</p>");
            }
            ));
            __builder.AddAttribute(8, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "<h1>Authentication Failure!</h1>\r\n        ");
                __builder2.AddMarkupContent(10, "<p>You\'re not signed in.</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenComponent<RoyalstarAdminPanel.Shared.SurveyPrompt>(12);
            __builder.AddAttribute(13, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\Index.razor"
      
    ClaimsPrincipal claimsPrincipal;

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    protected async override Task OnInitializedAsync()
    {
        claimsPrincipal = (await authenticationStateTask).User;

        if (!claimsPrincipal.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo("/login");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
