#pragma checksum "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af1bdb4c5f064dbb084a9a1b7fc169908fd1998f"
// <auto-generated/>
#pragma warning disable 1591
namespace Heavenly_Residences_Server.Pages.HotelRoomOrder
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
#line 2 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
           [Authorize(Roles = Common.SD.Role_Admin)]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room-order/details/{Id:int}")]
    public partial class HotelRoomOrderManagment : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mt-4 px-md-1 mx-md-1");
#nullable restore
#line 8 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
     if (IsLoading)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div class=\"spinner\"></div>");
#nullable restore
#line 11 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row p-2 my-3 bg-dark");
            __builder.AddAttribute(5, "style", "border-radius:20px; ");
            __builder.AddMarkupContent(6, "<div class=\"col-6 pt-2 pl-4 text-info\"><h2>Booking Details : </h2></div>\n            ");
            __builder.AddMarkupContent(7, "<div class=\"col-6 pt-2 col-md-3 offset-md-3\"><a href=\"/hotel-room-order\" class=\"btn btn-info form-control\">Back to Booking</a></div>\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-12 col-lg-8 p-4");
            __builder.AddMarkupContent(10, "<div class=\"row px-2 text-success border-bottom\"><div class=\"col-8 py-1\"><p style=\"font-size:x-large;margin:0px;\">Selected Room</p></div></div>\n\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-7");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "id");
            __builder.AddAttribute(17, "class", "carousel slide mb-4 m-md-3 m-0 pt-3 pt-md-0");
            __builder.AddAttribute(18, "data-ride", "carousel");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "id", "carouselExampleIndicators");
            __builder.AddAttribute(21, "class", "carousel slide");
            __builder.AddAttribute(22, "data-ride", "carousel");
            __builder.OpenElement(23, "ol");
            __builder.AddAttribute(24, "class", "carousel-indicators");
#nullable restore
#line 32 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                      
                                        int imageIndex = 0;
                                        int innerImageIndex = 0;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                     foreach (var image in HotelBooking.HotelRoomDTO.HotelRoomImages)
                                    {
                                        if (imageIndex == 0)
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "data-target", "#carouselExampleIndicators");
            __builder.AddAttribute(27, "data-slide-to", 
#nullable restore
#line 40 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                                                                                         imageIndex

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "class", "active");
            __builder.CloseElement();
#nullable restore
#line 41 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"

                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "li");
            __builder.AddAttribute(30, "data-target", "#carouselExampleIndicators");
            __builder.AddAttribute(31, "data-slide-to", 
#nullable restore
#line 45 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                                                                                         imageIndex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 46 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                        }
                                        imageIndex++;
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n                                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "carousel-inner");
#nullable restore
#line 51 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                     foreach (var image in HotelBooking.HotelRoomDTO.HotelRoomImages)
                                    {
                                        if (innerImageIndex == 0)
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "carousel-item active");
            __builder.OpenElement(37, "img");
            __builder.AddAttribute(38, "class", "d-block w-100");
            __builder.AddAttribute(39, "style", "border-radius:20px;");
            __builder.AddAttribute(40, "src", 
#nullable restore
#line 56 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                                                                                             image.RoomImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "alt", "First slide");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "carousel-item");
            __builder.OpenElement(44, "img");
            __builder.AddAttribute(45, "class", "d-block w-100");
            __builder.AddAttribute(46, "style", "border-radius:20px;");
            __builder.AddAttribute(47, "src", 
#nullable restore
#line 62 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                                                                                             image.RoomImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(48, "alt", "First slide");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                        }

                                        innerImageIndex++;
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n                                ");
            __builder.AddMarkupContent(50, @"<a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev""><span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                                    <span class=""sr-only"">Previous</span></a>
                                ");
            __builder.AddMarkupContent(51, "<a class=\"carousel-control-next\" href=\"#carouselExampleIndicators\" role=\"button\" data-slide=\"next\"><span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\n                                    <span class=\"sr-only\">Next</span></a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n                    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col-5");
            __builder.OpenElement(55, "span");
            __builder.AddAttribute(56, "class", "float-right pt-4 text-white-50");
            __builder.OpenElement(57, "span");
            __builder.AddAttribute(58, "class", "float-right");
            __builder.AddContent(59, "Max Occupancy : ");
#nullable restore
#line 82 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
__builder.AddContent(60, HotelBooking.HotelRoomDTO.Occupancy);

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, " adults ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "<br>\n                            ");
            __builder.OpenElement(63, "span");
            __builder.AddAttribute(64, "class", "float-right pt-1");
            __builder.AddContent(65, "Villa Size : ");
#nullable restore
#line 83 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
__builder.AddContent(66, HotelBooking.HotelRoomDTO.SqFt);

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, " sqft");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "<br>\n                            ");
            __builder.OpenElement(69, "span");
            __builder.AddAttribute(70, "class", "float-right pt-1");
            __builder.AddContent(71, "Cost for ");
#nullable restore
#line 84 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
__builder.AddContent(72, HotelBooking.HotelRoomDTO.TotalDays);

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, " nights");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "<br>\n                            ");
            __builder.OpenElement(75, "h4");
            __builder.AddAttribute(76, "class", "text-warning font-weight-bold pt-5 float-right");
            __builder.AddMarkupContent(77, "\n                                USD\n                                ");
            __builder.OpenElement(78, "span");
            __builder.AddAttribute(79, "style", "border-bottom:1px solid #ff6a00");
#nullable restore
#line 88 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
__builder.AddContent(80, HotelBooking.TotalCost.ToString("#,#.00#;(#,#.00#)"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\n                ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "row p-2");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "col-12");
            __builder.OpenElement(86, "p");
            __builder.AddAttribute(87, "class", "card-title text-warning");
            __builder.AddAttribute(88, "style", "font-size:xx-large");
#nullable restore
#line 97 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
__builder.AddContent(89, HotelBooking.HotelRoomDTO.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\n                        ");
            __builder.OpenElement(91, "p");
            __builder.AddAttribute(92, "class", "card-text");
            __builder.AddAttribute(93, "style", "font-size:large");
#nullable restore
#line 99 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
__builder.AddContent(94, (MarkupString)HotelBooking.HotelRoomDTO.Details);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\n                ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "row p-2");
#nullable restore
#line 105 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                     if (HotelBooking.Status == SD.Status_Booked || HotelBooking.Status == SD.Status_Pending)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "col-3");
            __builder.OpenElement(100, "button");
            __builder.AddAttribute(101, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                              CancelBooking

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "class", "btn btn-danger form-control");
            __builder.AddContent(103, "Cancel Booking ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 110 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                     if (HotelBooking.Status == SD.Status_Booked)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "col-3 offset-1");
            __builder.OpenElement(106, "button");
            __builder.AddAttribute(107, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 115 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                              NoShowBooking

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "class", "btn btn-warning form-control");
            __builder.AddContent(109, "No Show ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 117 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\n\n            ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "col-12 col-lg-4 p-4 2 mt-4 mt-md-0");
            __builder.AddMarkupContent(113, "<div class=\"row px-2 text-success border-bottom\"><div class=\"col-7 py-1\"><p style=\"font-size:x-large;margin:0px;\">Enter Details</p></div></div>\n                ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "form-group pt-2");
            __builder.AddMarkupContent(116, "<label class=\"text-warning\">Booking Status</label>\n                    ");
            __builder.OpenElement(117, "input");
            __builder.AddAttribute(118, "type", "text");
            __builder.AddAttribute(119, "disabled");
            __builder.AddAttribute(120, "class", "form-control");
            __builder.AddAttribute(121, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 125 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                        HotelBooking.Status

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(122, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HotelBooking.Status = __value, HotelBooking.Status));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\n                ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "form-group pt-2");
            __builder.AddMarkupContent(126, "<label class=\"text-warning\">Name</label>\n                    ");
            __builder.OpenElement(127, "input");
            __builder.AddAttribute(128, "type", "text");
            __builder.AddAttribute(129, "disabled");
            __builder.AddAttribute(130, "class", "form-control");
            __builder.AddAttribute(131, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 129 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                        HotelBooking.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(132, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HotelBooking.Name = __value, HotelBooking.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\n                ");
            __builder.OpenElement(134, "div");
            __builder.AddAttribute(135, "class", "form-group pt-2");
            __builder.AddMarkupContent(136, "<label class=\"text-warning\">Phone</label>\n                    ");
            __builder.OpenElement(137, "input");
            __builder.AddAttribute(138, "type", "text");
            __builder.AddAttribute(139, "disabled");
            __builder.AddAttribute(140, "class", "form-control");
            __builder.AddAttribute(141, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 133 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                        HotelBooking.Phone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(142, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HotelBooking.Phone = __value, HotelBooking.Phone));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\n                ");
            __builder.OpenElement(144, "div");
            __builder.AddAttribute(145, "class", "form-group");
            __builder.AddMarkupContent(146, "<label class=\"text-warning\">Email</label>\n                    ");
            __builder.OpenElement(147, "input");
            __builder.AddAttribute(148, "type", "text");
            __builder.AddAttribute(149, "disabled");
            __builder.AddAttribute(150, "class", "form-control");
            __builder.AddAttribute(151, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 137 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                        HotelBooking.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(152, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HotelBooking.Email = __value, HotelBooking.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\n                ");
            __builder.OpenElement(154, "div");
            __builder.AddAttribute(155, "class", "form-group");
            __builder.AddMarkupContent(156, "<label class=\"text-warning\">Check in Date</label>\n                    ");
            __builder.OpenElement(157, "input");
            __builder.AddAttribute(158, "type", "text");
            __builder.AddAttribute(159, "disabled");
            __builder.AddAttribute(160, "value", 
#nullable restore
#line 141 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                                        HotelBooking.CheckInDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(161, "class", "form-control");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\n\n                ");
            __builder.OpenElement(163, "div");
            __builder.AddAttribute(164, "class", "form-group");
            __builder.AddMarkupContent(165, "<label class=\"text-warning\">Check out Date</label>\n                    ");
            __builder.OpenElement(166, "input");
            __builder.AddAttribute(167, "type", "text");
            __builder.AddAttribute(168, "disabled");
            __builder.AddAttribute(169, "value", 
#nullable restore
#line 146 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                                        HotelBooking.CheckOutDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(170, "class", "form-control");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 148 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                 if (HotelBooking.Status == SD.Status_CheckedIn || HotelBooking.Status == SD.Status_CheckedOut_Completed)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(171, "div");
            __builder.AddAttribute(172, "class", "form-group");
            __builder.AddMarkupContent(173, "<label class=\"text-warning\">Actual Check In Date</label>\n                        ");
            __builder.OpenElement(174, "input");
            __builder.AddAttribute(175, "type", "text");
            __builder.AddAttribute(176, "disabled");
            __builder.AddAttribute(177, "value", 
#nullable restore
#line 152 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                                            HotelBooking.ActualCheckInDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(178, "class", "form-control");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 154 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                 if (HotelBooking.Status == SD.Status_CheckedOut_Completed)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(179, "div");
            __builder.AddAttribute(180, "class", "form-group");
            __builder.AddMarkupContent(181, "<label class=\"text-warning\">Actual Check Out Date</label>\n                        ");
            __builder.OpenElement(182, "input");
            __builder.AddAttribute(183, "type", "text");
            __builder.AddAttribute(184, "disabled");
            __builder.AddAttribute(185, "value", 
#nullable restore
#line 159 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                                            HotelBooking.ActualCheckOutDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(186, "class", "form-control");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 161 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(187, "div");
            __builder.AddAttribute(188, "class", "form-group");
#nullable restore
#line 164 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                     if (HotelBooking.Status == SD.Status_Booked)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(189, "button");
            __builder.AddAttribute(190, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 166 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                          ConfirmCheckIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(191, "class", "btn btn-success");
            __builder.AddContent(192, "Confirm Check In");
            __builder.CloseElement();
#nullable restore
#line 167 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 169 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                     if (HotelBooking.Status == SD.Status_CheckedIn)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(193, "button");
            __builder.AddAttribute(194, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 171 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                                          ConfirmCheckOut

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(195, "class", "btn btn-success");
            __builder.AddContent(196, "Confirm Check Out ");
            __builder.CloseElement();
#nullable restore
#line 172 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 178 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 184 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\Pages\HotelRoomOrder\HotelRoomOrderManagment.razor"
       
    [Parameter]
    public int Id { get; set; }

    private RoomOrderDetailsDTO HotelBooking { get; set; } = new RoomOrderDetailsDTO() { HotelRoomDTO = new HotelRoomDTO() };
    private bool IsLoading { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        IsLoading = true;

        if (Id != 0)
        {
            HotelBooking = await roomOrderDetailsRepository.GetRoomOrderDetail(Id);
        }
        else
        {
            //error
        }

        IsLoading = false;
    }

    private async Task ConfirmCheckIn()
    {
        await roomOrderDetailsRepository.UpdateOrderStatus(HotelBooking.Id, SD.Status_CheckedIn);
        HotelBooking = await roomOrderDetailsRepository.GetRoomOrderDetail(Id);
    }

    private async Task ConfirmCheckOut()
    {
        await roomOrderDetailsRepository.UpdateOrderStatus(HotelBooking.Id, SD.Status_CheckedOut_Completed);
        HotelBooking = await roomOrderDetailsRepository.GetRoomOrderDetail(Id);
    }

    private async Task CancelBooking()
    {
        await roomOrderDetailsRepository.UpdateOrderStatus(HotelBooking.Id, SD.Status_Cancelled);
        HotelBooking = await roomOrderDetailsRepository.GetRoomOrderDetail(Id);
    }

    private async Task NoShowBooking()
    {
        await roomOrderDetailsRepository.UpdateOrderStatus(HotelBooking.Id, SD.Status_NoShow);
        HotelBooking = await roomOrderDetailsRepository.GetRoomOrderDetail(Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoomOrderDetailsRepository roomOrderDetailsRepository { get; set; }
    }
}
#pragma warning restore 1591
