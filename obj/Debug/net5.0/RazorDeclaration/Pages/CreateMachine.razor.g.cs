// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RoyalstarAdminPanel.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\_Imports.razor"
using RoyalstarAdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\_Imports.razor"
using RoyalstarAdminPanel.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
using Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createmain")]
    public partial class CreateMachine : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
       
    private MainMachineBindingModel mainModel = new();
    async Task Success()
    {
        var machineFromService = await MachineService.CreateMainMachine(mainModel);
        if (machineFromService == false)
        {
            await JS.InvokeAsync<object>("alert", "Unsuccessful creation!");
        }
        else
        {
            await JS.InvokeAsync<object>("alert", "Successful creation!");
            NavigationManager.NavigateTo("/machines");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MachineService MachineService { get; set; }
    }
}
#pragma warning restore 1591