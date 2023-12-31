#pragma checksum "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0dacfddf59908dc7c880840a96dc304dc951360"
// <auto-generated/>
#pragma warning disable 1591
namespace Heavenly_Residences_Server.Pages.HotelAmenity
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Heavenly_Residences_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Heavenly_Residences_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Heavenly_Residences_Server.Pages.MyComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
using Heavenly_Residences_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
           [Authorize(Roles = Common.SD.Role_Admin)]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/hotel-amenity/create")]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/hotel-amenity/edit/{Id:int}")]
    public partial class HotelAmenityUpsert : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-2 mb-5");
            __builder.OpenElement(2, "h3");
            __builder.AddAttribute(3, "class", "card-title text-info mb-3 ml-3");
#nullable restore
#line 12 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
__builder.AddContent(4, Title);

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, " Hotel Amenity");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-12");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 18 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
                                  HotelAmenityModel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
                                                                    HandleHotelAmenityCreate

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(16, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label>Name</label>\n                        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", (object)("form-control"));
                __builder2.AddAttribute(24, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 23 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
                                                HotelAmenityModel.Name

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(25, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelAmenityModel.Name = __value, HotelAmenityModel.Name)))));
                __builder2.AddAttribute(26, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelAmenityModel.Name)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n                        ");
                global::__Blazor.Heavenly_Residences_Server.Pages.HotelAmenity.HotelAmenityUpsert.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 24 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
                                                ()=>HotelAmenityModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n                    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label>Description</label>\n                        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputTextArea>(34);
                __builder2.AddAttribute(35, "class", (object)("form-control"));
                __builder2.AddAttribute(36, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 28 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
                                                    HotelAmenityModel.Description

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(37, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelAmenityModel.Description = __value, HotelAmenityModel.Description)))));
                __builder2.AddAttribute(38, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelAmenityModel.Description)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\n                        ");
                global::__Blazor.Heavenly_Residences_Server.Pages.HotelAmenity.HotelAmenityUpsert.TypeInference.CreateValidationMessage_1(__builder2, 40, 41, 
#nullable restore
#line 29 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
                                                ()=>HotelAmenityModel.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\n                    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "<label>Timming</label>\n                        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "class", (object)("form-control"));
                __builder2.AddAttribute(48, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 33 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
                                                HotelAmenityModel.Timming

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(49, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelAmenityModel.Timming = __value, HotelAmenityModel.Timming)))));
                __builder2.AddAttribute(50, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelAmenityModel.Timming)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\n                        ");
                global::__Blazor.Heavenly_Residences_Server.Pages.HotelAmenity.HotelAmenityUpsert.TypeInference.CreateValidationMessage_2(__builder2, 52, 53, 
#nullable restore
#line 34 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
                                                ()=>HotelAmenityModel.Timming

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n                    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "<label>Icon Style</label>\n                        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "class", (object)("form-control"));
                __builder2.AddAttribute(60, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 38 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
                                                HotelAmenityModel.IconStyle

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(61, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelAmenityModel.IconStyle = __value, HotelAmenityModel.IconStyle)))));
                __builder2.AddAttribute(62, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelAmenityModel.IconStyle)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\n                        ");
                global::__Blazor.Heavenly_Residences_Server.Pages.HotelAmenity.HotelAmenityUpsert.TypeInference.CreateValidationMessage_3(__builder2, 64, 65, 
#nullable restore
#line 39 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
                                                ()=>HotelAmenityModel.IconStyle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\n\n\n\n                    ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __builder2.OpenElement(69, "button");
                __builder2.AddAttribute(70, "class", "btn btn-primary");
#nullable restore
#line 45 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
__builder2.AddContent(71, Title);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(72, " Amenity ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\n                        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(74);
                __builder2.AddAttribute(75, "href", (object)(
#nullable restore
#line 46 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
                                         $"hotel-amenity"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "class", (object)("btn btn-secondary"));
                __builder2.AddAttribute(77, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(78, "Back to Index ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
 
    [Parameter]
    public int? Id { get; set; }
    //instantiate right away
    internal HotelAmenityDTO HotelAmenityModel { get; set; } = new HotelAmenityDTO();

    internal string Title { get; set; } = "Create";

    internal bool IsProcessingStart { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            //we work with update
            Title = "Update";

            HotelAmenityModel = await AmenityRepository.GetHotelAmenity(Id.Value);
        }
        else
        {
            HotelAmenityModel = new HotelAmenityDTO();
        }
    }



    internal async Task HandleHotelAmenityCreate()
    {
        try
        {
            IsProcessingStart = true;

            if (HotelAmenityModel.Id != 0 && Title == "Update")
            {
                var amenityDetailsByName = await AmenityRepository.IsSameNameAmenityAlreadyExists(HotelAmenityModel.Name);
                if (amenityDetailsByName != null && amenityDetailsByName.Id != HotelAmenityModel.Id)
                {
                    await jsRuntime.ToastrError("Hotel Amenity already exists.");
                    return;
                }
                //Update the hotel amenity here
                var updateAmenityResult = await AmenityRepository.UpdateHotelAmenity(HotelAmenityModel.Id, HotelAmenityModel);


                await jsRuntime.ToastrSuccess("Hotel Amenity updated successfully.");
            }
            else
            {

                var amenityDetailsByName = await AmenityRepository.IsSameNameAmenityAlreadyExists(HotelAmenityModel.Name);
                if (amenityDetailsByName != null)
                {
                    await jsRuntime.ToastrError("Hotel Amenity name is already exists.");
                }


                //Create new Hotel Amenity here
                var createdResult = await AmenityRepository.CreateHotelAmenity(HotelAmenityModel);
                HotelAmenityModel = new HotelAmenityDTO();
                await jsRuntime.ToastrSuccess("Hotel amenity created successfully.");

            }
            NavigationManager.NavigateTo("hotel-amenity");
            IsProcessingStart = false;

        }
        catch (Exception e)
        {
            IsProcessingStart = false;
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAmenityRepository AmenityRepository { get; set; }
    }
}
namespace __Blazor.Heavenly_Residences_Server.Pages.HotelAmenity.HotelAmenityUpsert
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
