#pragma checksum "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\Components\EventList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4d8e369c65c2aac64f7150de00b95a7e8002e74"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCalendar.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\_Imports.razor"
using BlazorCalendar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\_Imports.razor"
using BlazorCalendar.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\_Imports.razor"
using BlazorCalendar.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\_Imports.razor"
using BlazorCalendar.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\_Imports.razor"
using BlazorCalendar.Services;

#line default
#line hidden
#nullable disable
    public partial class EventList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "ms-depth-16 card");
            __builder.AddMarkupContent(2, "\r\n            ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-content");
            __builder.AddMarkupContent(5, "\r\n              ");
            __builder.OpenElement(6, "h3");
            __builder.AddAttribute(7, "class", "ms-fontSize-22 ms-fontWeight-regular");
            __builder.AddContent(8, 
#nullable restore
#line 4 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\Components\EventList.razor"
                                                                SelectedDay.Date.ToString("D")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 5 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\Components\EventList.razor"
                
                if(SelectedDay.Events == null || SelectedDay.Events.Count == 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                    ");
            __builder.AddMarkupContent(11, "<h3 class=\"ms-fontSize-14 ms-fontWeight-regular\">No Events in this Day</h3>\r\n");
#nullable restore
#line 9 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\Components\EventList.razor"
                }else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\Components\EventList.razor"
                     foreach (var item in SelectedDay.Events)
                    { 
                        string colorClass = item.Color;


#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "event" + " shadow-effect" + " " + (
#nullable restore
#line 15 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\Components\EventList.razor"
                                                         colorClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(15, "\r\n                            ");
            __builder.OpenElement(16, "h3");
            __builder.AddAttribute(17, "class", "ms-fontSize-14 ms-fontWeight-regular");
            __builder.AddContent(18, 
#nullable restore
#line 16 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\Components\EventList.razor"
                                                                              item.StartDate.ToString("HH:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, " to ");
            __builder.AddContent(20, 
#nullable restore
#line 16 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\Components\EventList.razor"
                                                                                                                   item.EndDate.ToString("HH:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "p");
            __builder.AddAttribute(24, "class", "ms-fontSize-11 ms-fontWeight-regular");
            __builder.AddContent(25, 
#nullable restore
#line 17 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\Components\EventList.razor"
                                                                             item.Subject

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 19 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\Components\EventList.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\Components\EventList.razor"
                             
                }            
                
            

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "             \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n          ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\BlazorAppProjects\Projects\BlazorCalendar\BlazorCalendar\Components\EventList.razor"
      
    [Parameter]
    public CalendarDay SelectedDay {get; set;}

    protected override void OnInitialized()
    {
        AddEvent.OnEventAdded += () => 
        {
            StateHasChanged();
        };
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
