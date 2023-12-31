// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Heavenly_Residences_Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Heavenly_Residences_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Heavenly_Residences_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Heavenly_Residences_Server.Pages.MyComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\Pages\DemoHotel.razor"
using Heavenly_Residences_Server.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\Pages\DemoHotel.razor"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/demohotel")]
    public partial class DemoHotel : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "E:\Git\Heavenly Residences\Heavenly Residences\Heavenly Residences_Server\Pages\DemoHotel.razor"
      

    public int CountOfSelectedRooms { get; set; } = 0;
    public string SelectedAmenities { get; set; } = ""; 
    List<BlazorRoom> roomList = new();
    List<BlazorAmenities> AmenittList = new List<BlazorAmenities>();

    protected override void OnInitialized()
    {
        base.OnInitialized();

        roomList.Add(new BlazorRoom()
        {
            Id = 1,
            IsActive = true,
            Price = 46.99,
            RoomName = "GreateRooom",
            RoomProps = new List<BlazorRoomProp>()
{
                new BlazorRoomProp() { Id = 1, Name = "Item1", Value = "val1" },
                new BlazorRoomProp() { Id = 2, Name = "Item2", Value = "val2" },
                new BlazorRoomProp() { Id = 3, Name = "Item3", Value = "val3" },

            }

        });
        roomList.Add(new BlazorRoom()
        {
            Id = 2,
            IsActive = false,
            Price = 500,
            RoomName = "ExcelentRooom",
            RoomProps = new List<BlazorRoomProp>()
{
                new BlazorRoomProp() { Id = 11, Name = "Item11", Value = "val11" },
                new BlazorRoomProp() { Id = 21, Name = "Item21", Value = "val21" },
                new BlazorRoomProp() { Id = 31, Name = "Item31", Value = "val31" },

            }

        });



        AmenittList.Add(new BlazorAmenities()
        {
            Name = "A",
            Id = 1,
            Description = "AAA"

        });
        AmenittList.Add(new BlazorAmenities()
        {
            Name = "B",
            Id = 2,
            Description = "BBB"

        });
        AmenittList.Add(new BlazorAmenities()
        {
            Name = "C",
            Id = 3,
            Description = "CCC"

        });



    }

    protected void SelecetedRoom(bool isRoomSelected)
    {

        if (isRoomSelected)
        {
            CountOfSelectedRooms++;
            ;
        }
        else
        {
            CountOfSelectedRooms--;
        }


    }

    protected void ChangeSelectedAmenities(string amenity)
    {

        SelectedAmenities += amenity;
    }






#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
