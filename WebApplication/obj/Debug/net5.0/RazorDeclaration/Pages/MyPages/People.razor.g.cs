// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication.Pages.MyPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/danny/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/danny/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/danny/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/danny/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/danny/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/danny/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/danny/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/danny/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/danny/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/danny/RiderProjects/WebApplication/WebApplication/_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
using Microsoft.EntityFrameworkCore.Metadata.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/People")]
    public partial class People : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
       
    private List<PersonModel> people;
    
    private DisplayPersonModel newPerson = new DisplayPersonModel();

    protected override async Task OnInitializedAsync()
    {
        people = await _db.GetPeople();
    }

    private async Task InsertPerson()
    {
        // Convert the model (map it)
        PersonModel p = new PersonModel
        {
            FirstName = newPerson.FirstName,
            LastName = newPerson.LastName,
            EmailAddress = newPerson.EmailAddress
        };
        await _db.InsertPerson(p);
        // Add it to the list (so no reload required)
        people.Add(p);
        // Wipe out the previously entered data
        newPerson = new DisplayPersonModel();
    }
    
    // Delete the record
    private async Task DeletePerson(int id)
    {
        await _db.DeletePerson(id);
        people = await _db.GetPeople();
    }

    private async Task EditPerson(PersonModel p)
    {
        p.FirstName = "Coco Flanel";
        await _db.UpdatePerson(p);
        people = await _db.GetPeople();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleData _db { get; set; }
    }
}
#pragma warning restore 1591
