#pragma checksum "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa60d43cf7842510d8b34a65acf4cc6e1dca77bd"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
using Microsoft.EntityFrameworkCore.Metadata.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
           [Authorize(Roles="Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditPeople/{id}")]
    public partial class EditPeople : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EditPerson</h3>\n");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, "Editing record ");
            __builder.AddContent(3, 
#nullable restore
#line 14 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
                    id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
 if (@id == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p>Loading</p>");
#nullable restore
#line 19 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<h1>EDit</h1>\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 23 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
                      myPerson

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 23 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
                                                HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\n\n        ");
                __builder2.AddMarkupContent(14, "<label for=\"firstname\">First Name</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "id", "firstname");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
                                               myPerson.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => myPerson.FirstName = __value, myPerson.FirstName))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => myPerson.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\n\n        ");
                __builder2.AddMarkupContent(21, "<label for=\"lastname\">Last Name</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", "lastname");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
                                              myPerson.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => myPerson.LastName = __value, myPerson.LastName))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => myPerson.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n\n        ");
                __builder2.AddMarkupContent(28, "<label for=\"email\">Email</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "id", "email");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
                                           myPerson.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => myPerson.EmailAddress = __value, myPerson.EmailAddress))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => myPerson.EmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\n\n        ");
                __builder2.AddMarkupContent(35, "<button type=\"submit\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 38 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/EditPeople.razor"
       

    [Parameter]
    public string id { get; set; }

    private PersonModel person;
    private DisplayPersonModel myPerson = new DisplayPersonModel();

    // Call the database and get the selected person from it
    protected override async Task OnInitializedAsync()
    {
        person = await _db.GetSinglePerson(Int32.Parse(id));
        myPerson = new DisplayPersonModel
        {
            Id = person.Id,
            FirstName = person.FirstName,
            LastName = person.LastName,
            EmailAddress = person.EmailAddress
        };
    }

    private async void HandleValidSubmit()
    {
        person = new PersonModel
        {
            Id = myPerson.Id,
            FirstName = myPerson.FirstName,
            LastName = myPerson.LastName,
            EmailAddress = myPerson.EmailAddress
        };
        
        await _db.UpdatePerson(person);
        _navigationManager.NavigateTo("data/people");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleData _db { get; set; }
    }
}
#pragma warning restore 1591
