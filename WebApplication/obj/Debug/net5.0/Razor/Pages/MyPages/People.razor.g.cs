#pragma checksum "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f308cf06249f63dafae6aefb3f34c9d4343ce34a"
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
            __builder.AddMarkupContent(0, "<h1>People Page</h1>\n\n");
            __builder.AddMarkupContent(1, "<h4>Insert new person</h4>\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
                  newPerson

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
                                             InsertPerson

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n    ");
                __builder2.AddMarkupContent(10, "<label for=\"firstName\">First Name</label>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "id", "firstName");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
                                           newPerson.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.FirstName = __value, newPerson.FirstName))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n    ");
                __builder2.AddMarkupContent(17, "<label for=\"lastName\">Last Name</label>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "id", "lastName");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
                                          newPerson.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.LastName = __value, newPerson.LastName))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\n    ");
                __builder2.AddMarkupContent(24, "<label for=\"emailAddress\">Email</label>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "id", "emailAddress");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
                                              newPerson.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.EmailAddress = __value, newPerson.EmailAddress))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.EmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\n    ");
                __builder2.AddMarkupContent(31, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\n\n");
            __builder.AddMarkupContent(33, "<h4>Current People</h4>");
#nullable restore
#line 26 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
 if (people is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "<div class=\"spinner-border text-primary\" role=\"status\"><span class=\"sr-only\">Loading People data...</span></div>");
#nullable restore
#line 31 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "table");
            __builder.AddAttribute(36, "class", "table table-striped table-sm");
            __builder.AddMarkupContent(37, "<thead class=\"thead-dark\"><tr><th>First Name</th>\n            <th>Last Name</th>\n            <th>Email address</th>\n            <th>Action</th>\n            <th>Action</th>\n            <th>Action</th></tr></thead>\n        ");
            __builder.OpenElement(38, "tbody");
#nullable restore
#line 46 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
         foreach(var person in people) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "tr");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 48 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
                     person.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 49 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
                     person.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n                ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 50 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
                     person.EmailAddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n                ");
            __builder.OpenElement(49, "td");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "class", "btn btn-danger");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
                                                             () => DeletePerson(person.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(53, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n                ");
            __builder.OpenElement(55, "td");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "class", "btn btn-danger");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
                                                             () => EditPerson(person)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(59, "Update");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n                ");
            __builder.OpenElement(61, "td");
            __builder.OpenElement(62, "a");
            __builder.AddAttribute(63, "href", 
#nullable restore
#line 53 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
                              $"/EditPeople/{person.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(64, "Go to counter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "/home/danny/RiderProjects/WebApplication/WebApplication/Pages/MyPages/People.razor"
       
    private List<PersonModel> people;
    
    private DisplayPersonModel newPerson = new DisplayPersonModel();
    
    private PersonModel editPerson;

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
