#pragma checksum "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Shared\DeleteConfirmation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23d0c6834277f42139e4bc2ae954eaf22e010ade"
// <auto-generated/>
#pragma warning disable 1591
namespace Heaven_Resorts_Server.Shared
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
#line 13 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class DeleteConfirmation : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade");
            __builder.AddAttribute(2, "data-backdrop", "static");
            __builder.AddAttribute(3, "data-keyboard", "false");
            __builder.AddAttribute(4, "id", "deleteConfirmationModal");
            __builder.AddAttribute(5, "tabindex", "-1");
            __builder.AddAttribute(6, "role", "dialog");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog  modal-dialog-centered");
            __builder.AddAttribute(9, "role", "document");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-header");
            __builder.AddMarkupContent(14, "<h5 class=\"modal-title\" id=\"exampleModalLabel\">Confirm Delete</h5>\n                ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "class", "close");
            __builder.AddAttribute(18, "data-dismiss", "modal");
            __builder.AddAttribute(19, "aria-label", "Close");
            __builder.AddAttribute(20, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Shared\DeleteConfirmation.razor"
                                  ()=>OnConfirmationChange(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n            ");
            __builder.AddMarkupContent(23, "<div class=\"modal-body\">\n                Are you sure you want to delete\n            </div>\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "modal-footer");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "class", "btn btn-secondary");
            __builder.AddAttribute(29, "data-dismiss", "modal");
            __builder.AddAttribute(30, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Shared\DeleteConfirmation.razor"
                                                                                               ()=>OnConfirmationChange(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(31, "\n                    Cancel\n                ");
            __builder.CloseElement();
#nullable restore
#line 19 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Shared\DeleteConfirmation.razor"
                 if (IsProcessStart)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<button type=\"button\" class=\"btn btn-danger\"><i class=\"fa fa-spin fa-spinner\"></i>Processing..</button>");
#nullable restore
#line 22 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Shared\DeleteConfirmation.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "class", "btn btn-danger");
            __builder.AddAttribute(36, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Shared\DeleteConfirmation.razor"
                                                                           ()=>OnConfirmationChange(true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "\n                        Delete\n                    ");
            __builder.CloseElement();
#nullable restore
#line 28 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Shared\DeleteConfirmation.razor"

                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Shared\DeleteConfirmation.razor"
       

    public bool IsProcessStart { get; set; } = false;

    [Parameter]
    public EventCallback<bool> ConfirmationChanged { get; set; }

    [Parameter]
    public bool IsParentComponentProcessing { get; set; }

    protected override void OnParametersSet()
    {
        IsProcessStart = IsParentComponentProcessing;
    }

    protected async Task OnConfirmationChange(bool value)
    {
        if (value)
        {
            IsProcessStart = true;
        }
        await ConfirmationChanged.InvokeAsync(value);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
