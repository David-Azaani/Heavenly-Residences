// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
