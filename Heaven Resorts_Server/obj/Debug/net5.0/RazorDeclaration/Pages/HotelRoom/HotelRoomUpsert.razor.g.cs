// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Heaven_Resorts_Server.Pages.HotelRoom
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Heaven_Resorts_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Heaven_Resorts_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Heaven_Resorts_Server.Pages.MyComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using Heaven_Resorts_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using Microsoft.EntityFrameworkCore.Design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using Business.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using Heaven_Resorts_Server.Services.IService;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/create")]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/edit/{id:int}")]
    public partial class HotelRoomUpsert : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
       

    [Parameter]
    public int? Id { get; set; }


    private HotelRoomDTO model { get; set; } = new HotelRoomDTO();
    private string Title { get; set; } = "Create";
    private HotelRoomImageDTO RoomImage { get; set; } = new HotelRoomImageDTO();
    private List<string> DeletedImageNames { get; set; } = new List<string>();
    private bool IsImageUploadProcessStarted { get; set; } = false;
    private BlazoredTextEditor QuillHtml { get; set; } = new BlazoredTextEditor();

    #region Comment

    //private async Task SuccessAlert()
    //{
    //    await JsRuntime.InvokeVoidAsync("ShowToastr", "success","Done!");
    //}
    //private async Task FailureAlert()
    //{
    //    await JsRuntime.InvokeVoidAsync("ShowToastr", "error", "We've got some Errors!!");

    //}

    #endregion

    protected async override Task OnInitializedAsync()
    {
        if (Id != null)
        {
            //Update
            Title = "Update";
            model = await HotelRoomRepository.GetHotelRoom(Id.Value);
            if (model?.HotelRoomImages != null)
            {
                model.ImageUrls = model.HotelRoomImages.Select(a => a.RoomImageUrl).ToList();
            }

        }
        else
        {
            //Create
            Title = "Cretae";
            model = new HotelRoomDTO();
        }


        //return base.OnInitializedAsync();

    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        //SetHTML();
        if (!firstRender)
            return;
        bool loading = true;
        while (loading)
        {
            try
            {
                if (!string.IsNullOrEmpty(model.Details))
                {
                    await this.QuillHtml.LoadHTMLContent(model.Details);
                }
                loading = false;
            }
            catch
            {
                await Task.Delay(10);
                loading = true;
            }
        }


        //return base.OnAfterRenderAsync(firstRender);
    }

    private async Task HandledHotelRoomUpsert()

    {
        try
        {
            var roomDetailsByName = await HotelRoomRepository.IsRoomUniq(model.Name, model.Id);
            if (roomDetailsByName != null)
            {
                //Show Error
                // await FailureAlert(); or better is below

                await JsRuntime.ToastrError("Room Name already exists");
                return;
                ;
            }
            if (model.Id != 0 && Title == "Update")
            {
                model.Details = await QuillHtml.GetHTML();
                //Update
                var updateRoomResult = await HotelRoomRepository.UpdateHotelRoom(model.Id, model);
                if (model.ImageUrls != null && model.ImageUrls.Any())
                {

                    if (DeletedImageNames != null && DeletedImageNames.Any())
                    {
                        foreach (var deletedImageName in DeletedImageNames)
                        {
                            var imageName = deletedImageName.Replace($"{NavigationManager.BaseUri}RoomImages/", "");

                            var result = FileUpload.DeleteFile(imageName);
                            await ImagesRepository.DeleteHotelImageByImageUrl(deletedImageName);
                        }
                    }

                    await AddHotelRoomImage(updateRoomResult);
                }
                await JsRuntime.ToastrSuccess("Hotel Room Updated Successfully!");
            }
            else
            {
                //Create
                model.Details = await QuillHtml.GetHTML();
                var createRoom = await HotelRoomRepository.CreateHotelRoom(model);
                //if (createRoom.HotelRoomImages.Any())
                //{
                //    await AddHotelRoomImage(createRoom);
                //}
                await AddHotelRoomImage(createRoom);
                await JsRuntime.ToastrSuccess("Hotel Room Created Successfully!");

            }
        }
        catch (Exception ex)
        {
            //Log Exception
            await JsRuntime.ToastrError($"Unknown Error is Occurred!:{ex.Message}");
        }


        //await SuccessAlert();
        //await JsRuntime.ToastrSuccess("Done!");
        NavigationManager.NavigateTo("hotel-room");

    }

    private async Task AddHotelRoomImage(HotelRoomDTO roomDetails)
    {
        //if (model.ImageUrls.Count> 0 && model.ImageUrls.Any())
        //{
        //if (model.ImageUrls.Any())
        //{
        if (model.ImageUrls ==null)
        {
            model.ImageUrls = new List<string>();
        }
        foreach (var imageUrl in model.ImageUrls)
        {
            if (model.HotelRoomImages == null || model.HotelRoomImages.Where(x => x.RoomImageUrl == imageUrl).Count() == 0)
            {

                RoomImage = new HotelRoomImageDTO()
                {
                    RoomId = roomDetails.Id,
                    RoomImageUrl = imageUrl
                };
                await ImagesRepository.CreateHotelRoomImage(RoomImage);
            }
            //}
            //}
        }



    }

    private async Task HandleImageUpload(InputFileChangeEventArgs e)
    {
        IsImageUploadProcessStarted = true;
        try
        {
            var images = new List<string>
    ();
            if (e.GetMultipleFiles().Count > 0)
            {
                foreach (var file in e.GetMultipleFiles())
                {
                    FileInfo fileInfo = new FileInfo(file.Name);
                    if (fileInfo.Extension.ToLower() == ".jpg" ||
                    fileInfo.Extension.ToLower() == ".png" ||
                    fileInfo.Extension.ToLower() == ".jpeg")
                    {
                        var uploadedImagePath = await FileUpload.UploadFile(file);
                        images.Add(uploadedImagePath);
                    }
                    else
                    {
                        await JsRuntime.ToastrError("Please just Select .jpg/.jpeg/.png file only");
                        return;
                    }
                }
                if (images.Any())
                {
                    if (model.ImageUrls != null && model.ImageUrls.Any())
                    {
                        model.ImageUrls.AddRange(images);
                    }
                    else
                    {
                        model.ImageUrls = new List<string>();
                        model.ImageUrls.AddRange(images);
                    }
                }
                else
                {
                    await JsRuntime.ToastrError("Image Uploading Failed");
                    return;
                }
            }
            IsImageUploadProcessStarted = false;
        }
        catch (Exception ex)
        {

            await JsRuntime.ToastrError(ex.Message);

        }

    }

    internal async Task DeletePhoto(string imageUrl)
    {
        try
        {
            var imageIndex = model.ImageUrls.FindIndex(x => x == imageUrl);
            var imageName = imageUrl.Replace($"{NavigationManager.BaseUri}RoomImages/", "");
            if (model.Id == 0 && Title == "Create")
            {
                var result = FileUpload.DeleteFile(imageName);
            }
            else
            {
                //update
                DeletedImageNames ??= new List<string>
                    ();
                DeletedImageNames.Add(imageUrl);
            }
            model.ImageUrls.RemoveAt(imageIndex);
        }
        catch (Exception ex)
        {
            await JsRuntime.ToastrError(ex.Message);
        }

    }

    //public void SetHTML()
    //{
    //    if (!string.IsNullOrEmpty(model.Details))
    //    {
    //        this.QuillHtml.LoadHTMLContent(model.Details);
    //    }
    //    StateHasChanged();
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelImagesRepository ImagesRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository HotelRoomRepository { get; set; }
    }
}
#pragma warning restore 1591
