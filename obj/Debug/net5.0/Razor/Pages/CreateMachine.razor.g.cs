#pragma checksum "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3be2ded35b48572f7d693cd036324608c9e83c3"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card card-lg mb-5");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-body");
            __builder.AddMarkupContent(4, "<div class=\"text-center\"><h1>Create Main Machine</h1>\r\n            <p>Input required information to create main machine</p></div>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                         mainModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                   Success

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "<label for=\"mainDeviceBarcodeNoInput\" class=\"input-label text-capitalize\">Device Barcode No</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "type", "number");
                __builder2.AddAttribute(18, "class", "form-control form-control-lg");
                __builder2.AddAttribute(19, "autocomplete", "off");
                __builder2.AddAttribute(20, "tabindex", "1");
                __builder2.AddAttribute(21, "Placeholder", "Device Barcode No");
                __builder2.AddAttribute(22, "id", "mainDeviceBarcodeNoInput");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                                                                mainModel.DeviceBarcodeNo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainModel.DeviceBarcodeNo = __value, mainModel.DeviceBarcodeNo))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => mainModel.DeviceBarcodeNo));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "<label for=\"mainsActivePowerInput\" class=\"input-label text-capitalize\">Mains Active Power</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "type", "number");
                __builder2.AddAttribute(32, "tabindex", "2");
                __builder2.AddAttribute(33, "class", "form-control form-control-lg");
                __builder2.AddAttribute(34, "Placeholder", "Mains Active Power");
                __builder2.AddAttribute(35, "id", "mainsActivePowerInput");
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                             mainModel.MainsActivePower

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainModel.MainsActivePower = __value, mainModel.MainsActivePower))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => mainModel.MainsActivePower));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "<label for=\"mainsApparentPowerInput\" class=\"input-label text-capitalize\">Mains Apparent Power</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "type", "number");
                __builder2.AddAttribute(45, "tabindex", "2");
                __builder2.AddAttribute(46, "class", "form-control form-control-lg");
                __builder2.AddAttribute(47, "Placeholder", "Mains Apparent Power");
                __builder2.AddAttribute(48, "id", "mainsApparentPowerInput");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                               mainModel.MainsApparentPower

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainModel.MainsApparentPower = __value, mainModel.MainsApparentPower))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => mainModel.MainsApparentPower));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "<label for=\"mainsCurrentInput\" class=\"input-label text-capitalize\">Mains Current</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(56);
                __builder2.AddAttribute(57, "type", "number");
                __builder2.AddAttribute(58, "tabindex", "3");
                __builder2.AddAttribute(59, "class", "form-control form-control-lg");
                __builder2.AddAttribute(60, "Placeholder", "Mains Current");
                __builder2.AddAttribute(61, "id", "mainsCurrentInput");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                         mainModel.MainsCurrent

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainModel.MainsCurrent = __value, mainModel.MainsCurrent))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => mainModel.MainsCurrent));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group");
                __builder2.AddMarkupContent(68, "<label for=\"mainsDeviceOnOffInput\" class=\"input-label text-capitalize\">Mains Device On/Off</label>\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(69);
                __builder2.AddAttribute(70, "id", "mainsDeviceOnOffInput");
                __builder2.AddAttribute(71, "class", "form-control form-control-lg");
                __builder2.AddAttribute(72, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 39 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                                                                             mainModel.MainsDeviceOnOff

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainModel.MainsDeviceOnOff = __value, mainModel.MainsDeviceOnOff))));
                __builder2.AddAttribute(74, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => mainModel.MainsDeviceOnOff));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n            ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "form-group");
                __builder2.AddMarkupContent(78, "<label for=\"mainsFrequenceInput\" class=\"input-label text-capitalize\">Mains Frequence</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(79);
                __builder2.AddAttribute(80, "type", "number");
                __builder2.AddAttribute(81, "tabindex", "4");
                __builder2.AddAttribute(82, "class", "form-control form-control-lg");
                __builder2.AddAttribute(83, "Placeholder", "Mains Frequence");
                __builder2.AddAttribute(84, "id", "mainsFrequenceInput");
                __builder2.AddAttribute(85, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                           mainModel.MainsFrequence

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainModel.MainsFrequence = __value, mainModel.MainsFrequence))));
                __builder2.AddAttribute(87, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => mainModel.MainsFrequence));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n            ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "form-group");
                __builder2.AddMarkupContent(91, "<label for=\"mainsBreakerOffInput\" class=\"input-label text-capitalize\">Mains Breaker Off</label>\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(92);
                __builder2.AddAttribute(93, "id", "mainsBreakerOffInput");
                __builder2.AddAttribute(94, "class", "form-control form-control-lg");
                __builder2.AddAttribute(95, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 48 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                                                                            mainModel.MainsBreakerOff

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainModel.MainsBreakerOff = __value, mainModel.MainsBreakerOff))));
                __builder2.AddAttribute(97, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => mainModel.MainsBreakerOff));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n            ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-group");
                __builder2.AddMarkupContent(101, "<label for=\"mainsBreakerOnInput\" class=\"input-label text-capitalize\">Mains Breaker On</label>\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(102);
                __builder2.AddAttribute(103, "id", "mainsBreakerOnInput");
                __builder2.AddAttribute(104, "class", "form-control form-control-lg");
                __builder2.AddAttribute(105, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 52 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                                                                           mainModel.MainsBreakerOn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(106, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainModel.MainsBreakerOn = __value, mainModel.MainsBreakerOn))));
                __builder2.AddAttribute(107, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => mainModel.MainsBreakerOn));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n            ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "form-group");
                __builder2.AddMarkupContent(111, "<label for=\"mainsModeManuelInput\" class=\"input-label text-capitalize\">Mains Mode Manuel</label>\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(112);
                __builder2.AddAttribute(113, "id", "mainsModeManuelInput");
                __builder2.AddAttribute(114, "class", "form-control form-control-lg");
                __builder2.AddAttribute(115, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 56 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                                                                            mainModel.MainsModeManuel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(116, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainModel.MainsModeManuel = __value, mainModel.MainsModeManuel))));
                __builder2.AddAttribute(117, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => mainModel.MainsModeManuel));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n            ");
                __builder2.OpenElement(119, "div");
                __builder2.AddAttribute(120, "class", "form-group");
                __builder2.AddMarkupContent(121, "<label for=\"mainsModeSemiInput\" class=\"input-label text-capitalize\">Mains Mode Semi</label>\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(122);
                __builder2.AddAttribute(123, "id", "mainsModeSemiInput");
                __builder2.AddAttribute(124, "class", "form-control form-control-lg");
                __builder2.AddAttribute(125, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 60 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                                                                          mainModel.MainsModeSemi

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(126, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainModel.MainsModeSemi = __value, mainModel.MainsModeSemi))));
                __builder2.AddAttribute(127, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => mainModel.MainsModeSemi));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n            ");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "form-group");
                __builder2.AddMarkupContent(131, "<label for=\"mainsStatusOffInput\" class=\"input-label text-capitalize\">Mains Status Off</label>\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(132);
                __builder2.AddAttribute(133, "id", "mainsStatusOffInput");
                __builder2.AddAttribute(134, "class", "form-control form-control-lg");
                __builder2.AddAttribute(135, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 64 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                                                                           mainModel.MainsStatusOff

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(136, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainModel.MainsStatusOff = __value, mainModel.MainsStatusOff))));
                __builder2.AddAttribute(137, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => mainModel.MainsStatusOff));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n            ");
                __builder2.OpenElement(139, "div");
                __builder2.AddAttribute(140, "class", "form-group");
                __builder2.AddMarkupContent(141, "<label for=\"mainsStatusOnInput\" class=\"input-label text-capitalize\">Mains Status On</label>\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(142);
                __builder2.AddAttribute(143, "id", "mainsStatusOnInput");
                __builder2.AddAttribute(144, "class", "form-control form-control-lg");
                __builder2.AddAttribute(145, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 68 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                                                                          mainModel.MainsStatusOn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(146, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainModel.MainsStatusOn = __value, mainModel.MainsStatusOn))));
                __builder2.AddAttribute(147, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => mainModel.MainsStatusOn));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n            ");
                __builder2.OpenElement(149, "div");
                __builder2.AddAttribute(150, "class", "form-group");
                __builder2.AddMarkupContent(151, "<label for=\"mainsReactivePowerInput\" class=\"input-label text-capitalize\">Mains Reactive Power</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(152);
                __builder2.AddAttribute(153, "type", "number");
                __builder2.AddAttribute(154, "tabindex", "5");
                __builder2.AddAttribute(155, "class", "form-control form-control-lg");
                __builder2.AddAttribute(156, "Placeholder", "Mains Reactive Power");
                __builder2.AddAttribute(157, "id", "mainsReactivePowerInput");
                __builder2.AddAttribute(158, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                               mainModel.MainsReactivePower

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(159, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainModel.MainsReactivePower = __value, mainModel.MainsReactivePower))));
                __builder2.AddAttribute(160, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => mainModel.MainsReactivePower));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n            ");
                __builder2.OpenElement(162, "div");
                __builder2.AddAttribute(163, "class", "form-group");
                __builder2.AddMarkupContent(164, "<label for=\"mainsVoltInput\" class=\"input-label text-capitalize\">Mains Volt</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(165);
                __builder2.AddAttribute(166, "type", "number");
                __builder2.AddAttribute(167, "tabindex", "6");
                __builder2.AddAttribute(168, "class", "form-control form-control-lg");
                __builder2.AddAttribute(169, "Placeholder", "Mains Volt");
                __builder2.AddAttribute(170, "id", "mainsVoltInput");
                __builder2.AddAttribute(171, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 78 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                      mainModel.MainsVolt

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(172, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainModel.MainsVolt = __value, mainModel.MainsVolt))));
                __builder2.AddAttribute(173, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => mainModel.MainsVolt));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(174, "\r\n            ");
                __builder2.OpenElement(175, "div");
                __builder2.AddAttribute(176, "class", "form-group");
                __builder2.AddMarkupContent(177, "<label for=\"writeCommandInput\" class=\"input-label text-capitalize\">Write Command</label>\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(178);
                __builder2.AddAttribute(179, "id", "writeCommandInput");
                __builder2.AddAttribute(180, "class", "form-control form-control-lg");
                __builder2.AddAttribute(181, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 82 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                                                                         mainModel.WriteCommand

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(182, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainModel.WriteCommand = __value, mainModel.WriteCommand))));
                __builder2.AddAttribute(183, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => mainModel.WriteCommand));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(184, "\r\n            ");
                __builder2.OpenElement(185, "div");
                __builder2.AddAttribute(186, "class", "form-group");
                __builder2.AddMarkupContent(187, "<label for=\"deviceAddedInput\" class=\"input-label text-capitalize\">device Added</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(188);
                __builder2.AddAttribute(189, "type", "number");
                __builder2.AddAttribute(190, "tabindex", "7");
                __builder2.AddAttribute(191, "class", "form-control form-control-lg");
                __builder2.AddAttribute(192, "Placeholder", "Device Added");
                __builder2.AddAttribute(193, "id", "deviceAddedInput");
                __builder2.AddAttribute(194, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 87 "C:\Users\aydin\Desktop\HRYURT\RoyalstarAdminPanel\Pages\CreateMachine.razor"
                                                        mainModel.deviceAdded

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(195, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainModel.deviceAdded = __value, mainModel.deviceAdded))));
                __builder2.AddAttribute(196, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => mainModel.deviceAdded));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(197, "\r\n            ");
                __builder2.AddMarkupContent(198, "<button type=\"submit\" class=\"btn btn-lg btn-block btn-primary\">Create</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
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
