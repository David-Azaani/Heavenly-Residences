#pragma checksum "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61ce019c00c00143cfe4b5730ab9386b3cc83a58"
// <auto-generated/>
#pragma warning disable 1591
namespace Heavenly_Residences_Client.Pages.HotelRooms
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Heavenly_Residences_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Heavenly_Residences_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Heavenly_Residences_Client.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Heavenly_Residences_Client.Model.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Heavenly_Residences_Client.Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Heavenly_Residences_Client.Pages.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/hotel/rooms")]
    public partial class HotelRooms : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
 if (Rooms != null && Rooms.Any())
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 9 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                     HomeModel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                               SaveBookingInfo

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(3, "class", (object)("bg-light"));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "pt-3 pb-2 px-5 mx-1 mx-md-0 bg-secondary");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\n            ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row px-3 mx-3");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-6 col-md-4");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "<label class=\"text-warning\">Check in Date</label>\n                        ");
                global::__Blazor.Heavenly_Residences_Client.Pages.HotelRooms.HotelRooms.TypeInference.CreateInputDate_0(__builder2, 16, 17, "form-control", 18, 
#nullable restore
#line 17 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                                HomeModel.StartDate

#line default
#line hidden
#nullable disable
                , 19, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HomeModel.StartDate = __value, HomeModel.StartDate)), 20, () => HomeModel.StartDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n                ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "col-6 col-md-4");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "<label class=\"text-warning\">Check Out Date</label>\n                        ");
                __builder2.OpenElement(27, "input");
                __builder2.AddAttribute(28, "disabled", "disabled");
                __builder2.AddAttribute(29, "readonly", "readonly");
                __builder2.AddAttribute(30, "type", "date");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                      HomeModel.EndDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(33, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HomeModel.EndDate = __value, HomeModel.EndDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\n                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", " col-4 col-md-2");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "<label class=\"text-warning\">No. of nights</label>\n                        ");
                __builder2.OpenElement(40, "select");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                                            HomeModel.NoOfNights

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HomeModel.NoOfNights = __value, HomeModel.NoOfNights));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(44, "option");
                __builder2.AddAttribute(45, "value", "Select");
                __builder2.AddAttribute(46, "selected");
                __builder2.AddAttribute(47, "disabled", "disabled");
                __builder2.AddContent(48, "(Select No. Of Nights)");
                __builder2.CloseElement();
#nullable restore
#line 31 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                             for (var i = 1; i <= 10; i++)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(49, "option");
                __builder2.AddAttribute(50, "value", 
#nullable restore
#line 33 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                                i

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 33 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
__builder2.AddContent(51, i);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 34 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n\n                ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col-8 col-md-2");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddAttribute(57, "style", "margin-top: 1.9rem !important;");
#nullable restore
#line 41 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                         if (IsProcessing)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(58, "<button class=\"btn btn-success btn-block form-control \"><i class=\"fa fa-spin fa-spinner\"></i>Processing...</button>");
#nullable restore
#line 44 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(59, "<input type=\"submit\" value=\"Update\" class=\"btn btn-success btn-block form-control\">");
#nullable restore
#line 48 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "mt-4 mx-4 px-0 px-md-5 mx-md-5");
#nullable restore
#line 56 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
         foreach (var room in Rooms)
        {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "row p-2 my-3 ");
            __builder.AddAttribute(65, "style", "border-radius:20px; border: 1px solid #ffffff");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col-12 col-lg-3 col-md-4");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "id", "carouselExampleIndicators_" + (
#nullable restore
#line 61 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                                        room.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "class", "carousel slide mb-4 m-md-3 m-0 pt-3 pt-md-0");
            __builder.AddAttribute(71, "data-ride", "carousel");
            __builder.OpenElement(72, "ol");
            __builder.AddAttribute(73, "class", "carousel-indicators");
#nullable restore
#line 63 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                              
                                int imageIndex = 0;
                                int innerImageIndex = 0;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                             foreach (var image in room.HotelRoomImages)
                            {
                                if (imageIndex == 0)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(74, "li");
            __builder.AddAttribute(75, "data-target", "#carouselExampleIndicators_" + (
#nullable restore
#line 71 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                                                                 room.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "data-slide-to", 
#nullable restore
#line 71 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                                                                                          imageIndex

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(77, "class", "active");
            __builder.CloseElement();
#nullable restore
#line 72 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(78, "li");
            __builder.AddAttribute(79, "data-target", "#carouselExampleIndicators_" + (
#nullable restore
#line 76 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                                                                 room.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "data-slide-to", 
#nullable restore
#line 76 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                                                                                          imageIndex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 77 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                }
                                imageIndex++;
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\n                        ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "carousel-inner");
#nullable restore
#line 84 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                             foreach (var image in room.HotelRoomImages)
                            {
                                if (innerImageIndex == 0)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "carousel-item active");
            __builder.OpenElement(86, "img");
            __builder.AddAttribute(87, "class", "d-block w-100");
            __builder.AddAttribute(88, "style", "border-radius:20px;");
            __builder.AddAttribute(89, "src", 
#nullable restore
#line 89 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                                                                                     image.RoomImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(90, "alt", "First slide");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 91 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "carousel-item");
            __builder.OpenElement(93, "img");
            __builder.AddAttribute(94, "class", "d-block w-100");
            __builder.AddAttribute(95, "style", "border-radius:20px;");
            __builder.AddAttribute(96, "src", 
#nullable restore
#line 95 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                                                                                     image.RoomImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(97, "alt", "First slide");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 97 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                }

                                innerImageIndex++;
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\n                        ");
            __builder.OpenElement(99, "a");
            __builder.AddAttribute(100, "class", "carousel-control-prev");
            __builder.AddAttribute(101, "href", "#carouselExampleIndicators_" + (
#nullable restore
#line 102 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                                                                           room.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "role", "button");
            __builder.AddAttribute(103, "data-slide", "prev");
            __builder.AddMarkupContent(104, "<span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\n                            ");
            __builder.AddMarkupContent(105, "<span class=\"sr-only\">Previous</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\n                        ");
            __builder.OpenElement(107, "a");
            __builder.AddAttribute(108, "class", "carousel-control-next");
            __builder.AddAttribute(109, "href", "#carouselExampleIndicators_" + (
#nullable restore
#line 106 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                                                                           room.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "role", "button");
            __builder.AddAttribute(111, "data-slide", "next");
            __builder.AddMarkupContent(112, "<span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\n                            ");
            __builder.AddMarkupContent(113, "<span class=\"sr-only\">Next</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\n                ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "col-12 col-lg-9 col-md-8");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "row pt-3");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "col-12 col-lg-8");
            __builder.OpenElement(121, "p");
            __builder.AddAttribute(122, "class", "card-title text-warning");
            __builder.AddAttribute(123, "style", "font-size:xx-large");
#nullable restore
#line 115 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
__builder.AddContent(124, room.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\n                            ");
            __builder.OpenElement(126, "p");
            __builder.AddAttribute(127, "class", "card-text");
#nullable restore
#line 117 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
__builder.AddContent(128, (MarkupString)room.Details);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\n                        ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "col-12 col-lg-4");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "row pb-3 pt-2");
            __builder.OpenElement(134, "div");
            __builder.AddAttribute(135, "class", "col-12 col-lg-11 offset-lg-1");
#nullable restore
#line 123 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                     if (room.IsBooked)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(136, "<button disabled class=\"btn btn-secondary btn-block\">Sold Out</button>");
#nullable restore
#line 126 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                    }
                                    else
                                    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(137, "a");
            __builder.AddAttribute(138, "href", 
#nullable restore
#line 130 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                                   $"hotel/room-details/{room.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(139, "class", "btn btn-success btn-block");
            __builder.AddContent(140, "Book");
            __builder.CloseElement();
#nullable restore
#line 131 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\n                            ");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "row ");
            __builder.OpenElement(144, "div");
            __builder.AddAttribute(145, "class", "col-12 pb-5");
            __builder.OpenElement(146, "span");
            __builder.AddAttribute(147, "class", "float-right");
            __builder.OpenElement(148, "span");
            __builder.AddAttribute(149, "class", "float-right");
            __builder.AddContent(150, "Max Occupancy : ");
#nullable restore
#line 137 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
__builder.AddContent(151, room.Occupancy);

#line default
#line hidden
#nullable disable
            __builder.AddContent(152, " adults ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "<br>\n                                        ");
            __builder.OpenElement(154, "span");
            __builder.AddAttribute(155, "class", "float-right pt-1");
            __builder.AddContent(156, "Villa Size : ");
#nullable restore
#line 138 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
__builder.AddContent(157, room.SqFt);

#line default
#line hidden
#nullable disable
            __builder.AddContent(158, " sqft");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "<br>\n                                        ");
            __builder.OpenElement(160, "h4");
            __builder.AddAttribute(161, "class", "text-warning font-weight-bold pt-4");
            __builder.AddMarkupContent(162, "\n                                            USD\n                                            ");
            __builder.OpenElement(163, "span");
            __builder.AddAttribute(164, "style", "border-bottom:1px solid #ff6a00");
#nullable restore
#line 142 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
__builder.AddContent(165, room.TotalAmount.ToString("#,#.00;(#,#.00#)"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\n                                        ");
            __builder.OpenElement(167, "span");
            __builder.AddAttribute(168, "class", "float-right");
            __builder.AddContent(169, "Cost for  ");
#nullable restore
#line 145 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
__builder.AddContent(170, room.TotalDays);

#line default
#line hidden
#nullable disable
            __builder.AddContent(171, " nights");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 154 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 157 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(172, "<div style=\"position:fixed;top:50%;left:50%;margin-top:-50px;margin-left:-100px;\"><img src=\"images/ajax-loader.gif\"></div>");
#nullable restore
#line 163 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 166 "D:\Projects\Heavenly Residences\Heavenly Residences_Client\Pages\HotelRooms\HotelRooms.razor"
       
    //    private HomeVM HomeModel { get; set; } = new HomeVM();
    //    public IEnumerable<HotelRoomDTO> Rooms { get; set; } = new List<HotelRoomDTO>();
    //    private bool IsProcessing { get; set; } = false;

    //    protected override async Task OnInitializedAsync()
    //    {
    //        try
    //        {
    //            // await Task.Delay(5000); for debuging in this cycle
    //#if DEBUG
    //            await Task.Delay(5000);
    //#endif
    //            if (await localStorage.GetItemAsync<HomeVM>(SD.Local_InitialBooking) != null)
    //            {
    //                HomeModel = await localStorage.GetItemAsync<HomeVM>(SD.Local_InitialBooking);
    //            }
    //            else
    //            {
    //                HomeModel.NoOfNights = 1;
    //            }
    //            await LoadRooms();
    //        }
    //        catch (Exception e)
    //        {
    //            await jsRuntime.ToastrError(e.Message);
    //        }
    //    }

    //    private async Task LoadRooms()
    //    {
    //        Rooms = await hotelRoomService.GetHotelRooms(HomeModel.StartDate.ToString("MM/dd/yyyy"), HomeModel.EndDate.ToString("MM/dd/yyyy"));

    //        foreach (var room in Rooms)
    //        {
    //            room.TotalAmount = room.RegularRate * HomeModel.NoOfNights;
    //            room.TotalDays = HomeModel.NoOfNights;
    //        }

    //    }

    //    private async Task SaveBookingInfo()
    //    {
    //        IsProcessing = true;
    //        HomeModel.EndDate = HomeModel.StartDate.AddDays(HomeModel.NoOfNights);
    //        await localStorage.SetItemAsync(SD.Local_InitialBooking, HomeModel);
    //        await LoadRooms();
    //        IsProcessing = false;
    //    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomService hotelRoomService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
    }
}
namespace __Blazor.Heavenly_Residences_Client.Pages.HotelRooms.HotelRooms
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", (object)__arg0);
        __builder.AddAttribute(__seq1, "Value", (object)__arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", (object)__arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
