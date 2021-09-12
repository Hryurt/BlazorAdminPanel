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
#line 2 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\UpdateMainMachine.razor"
using RoyalstarAdminPanel.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\UpdateMainMachine.razor"
using RoyalstarAdminPanel.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\UpdateMainMachine.razor"
using RoyalstarAdminPanel.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/updatemain/{Id:int}")]
    public partial class UpdateMainMachine : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "C:\Users\HRYurt\Desktop\SWE\Blazor\RoyalstarAdminPanel\Pages\UpdateMainMachine.razor"
      
    [Parameter]
    public int Id { get; set; }
    private MainMachineBindingModel mainModel = new();
    protected override async Task OnInitializedAsync()
    {
        mainModel = await MachineService.GetMainMachineBindingModel(Id);
    }
    async Task Success()
    {
        var machineFromService = await MachineService.UpdateMainMachine(mainModel, Id);
        if (machineFromService == false)
        {
            await JS.InvokeAsync<object>("alert", "Unsuccessful update!");
        }
        else
        {
            await JS.InvokeAsync<object>("alert", "Successful update!");
            NavigationManager.NavigateTo("/mainmachine/"+ mainModel.DeviceBarcodeNo);
        }
    }
    async Task Delete()
    {
        var machineFromService = await MachineService.DeleteMainMachine(Id);
        if (machineFromService == false)
        {
            await JS.InvokeAsync<object>("alert", "Unsuccessful deletion!");
        }
        else
        {
            await JS.InvokeAsync<object>("alert", "Successful deletion!");
            NavigationManager.NavigateTo("/machines/");
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
