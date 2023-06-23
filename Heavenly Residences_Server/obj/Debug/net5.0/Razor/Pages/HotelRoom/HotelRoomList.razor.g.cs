#pragma checksum "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bec1fe015a60120ed6eb3ec856dbb4c3152c086f"
// <auto-generated/>
#pragma warning disable 1591
namespace Heavenly_Residences_Server.Pages.HotelRoom
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
#line 2 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
using Heavenly_Residences_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
using Heavenly_Residences_Server.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
using Heavenly_Residences_Server.Services.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
           [Authorize(Roles = Common.SD.Role_Admin)]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room")]
    public partial class HotelRoomList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-4");
            __builder.AddMarkupContent(2, "<div class=\"col-8\"><h4 class=\"card-title text-info\">Hotel Room\'s</h4></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-3 offset-1");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "href", (object)("hotel-room/create"));
            __builder.AddAttribute(7, "class", (object)("btn btn-info form-control"));
            __builder.AddAttribute(8, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(9, "Add New Room");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row mt-4");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-12");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(17, @"<thead><tr><th>Name</th>
                    <th>Occupancy</th>
                    <th>Rate</th>
                    <th>Sqft</th>
                    <th>Details</th>
                    <th>RoomImage</th>
                    <th>Count</th>
                    <th></th></tr></thead>
            ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 36 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
                 if (model!= null && model.Any())
                {
                    foreach (var room in model)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
#nullable restore
#line 41 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(21, room.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 42 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(24, room.Occupancy);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "td");
#nullable restore
#line 43 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(27, room.RegularRate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "td");
#nullable restore
#line 44 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(30, room.SqFt);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "td");
#nullable restore
#line 45 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(33, (MarkupString)(room.Details.Length > 100 ? room.Details.Substring(0, 100) + "..." : room.Details));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "td");
#nullable restore
#line 46 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(36, room.HotelRoomImages.FirstOrDefault()?.RoomImageUrl);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                            ");
            __builder.OpenElement(38, "td");
#nullable restore
#line 47 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(39, room.HotelRoomImages.Count());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                          \r\n                            ");
            __builder.OpenElement(41, "td");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(42);
            __builder.AddAttribute(43, "href", (object)(
#nullable restore
#line 50 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
                                                 $"/hotel-room/edit/{room.Id}"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "class", (object)("btn btn-primary"));
            __builder.AddAttribute(45, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(46, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\r\n                                ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "btn btn-danger");
            __builder.AddAttribute(50, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
                                                                         () =>HandleDelete(room.Id) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
                    }

                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(52, "<tr><td colspan=\"6\">No records found</td></tr>");
#nullable restore
#line 62 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.OpenComponent<global::Heavenly_Residences_Server.Shared.DeleteConfirmation>(54);
            __builder.AddAttribute(55, "ConfirmationChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, 
#nullable restore
#line 68 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
                                         ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(56, "IsParentComponentProcessing", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 68 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
                                                                                           IsProcessing

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoom\HotelRoomList.razor"
       

    private IEnumerable<HotelRoomDTO> model { get; set; } = new List<HotelRoomDTO>();
    private int? DeleteRoomId { get; set; } = null;
    private bool IsProcessing { get; set; } = false;
    string x = "";
    protected override async Task OnInitializedAsync()
    {
        model = await HotelRoomRepository.GetAllHotelRooms();
    }

    #region Comment

    //protected override async Task OnAfterRenderAsync(bool firstRender)
    //{
    //    await JsRuntime.InvokeVoidAsync("ShowDeleteConfirmationModal");
    //}

    #endregion
    private async Task HandleDelete(int roomId)
    {
        DeleteRoomId = roomId;

        await JsRuntime.InvokeVoidAsync("ShowDeleteConfirmationModal");
    }
    public async Task ConfirmDelete_Click(bool isConfirmed)
    {
        IsProcessing = true;
        if (isConfirmed && DeleteRoomId != null)
        {
            HotelRoomDTO hotelRoom = await HotelRoomRepository.GetHotelRoom(DeleteRoomId.Value);
            foreach (var image in hotelRoom.HotelRoomImages)
            {
                // x = $"{NavigationManager.BaseUri}RoomImages/";
                var imageName = image.RoomImageUrl.Replace($"{NavigationManager.BaseUri}RoomImages/", "");

                FileUpload.DeleteFile(imageName);
            }

            await HotelRoomRepository.DeleteHotelRoom(DeleteRoomId.Value);
            await JsRuntime.ToastrSuccess("Hotel Room Deleted successfully");
            model = await HotelRoomRepository.GetAllHotelRooms();
        }
        await JsRuntime.InvokeVoidAsync("HideDeleteConfirmationModal");
        IsProcessing = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository HotelRoomRepository { get; set; }
    }
}
#pragma warning restore 1591