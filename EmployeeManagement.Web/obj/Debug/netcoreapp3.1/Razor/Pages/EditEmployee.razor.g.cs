#pragma checksum "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32ac12b6b0cc6437527fc8270c512349f2b5864f"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using PragimTech.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee")]
    public partial class EditEmployee : EditEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                  EditEmployeeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                                    HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ObjectGraphDataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "h3");
                __builder2.AddContent(8, 
#nullable restore
#line 8 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
         PageHeaderText

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n    <hr>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group row");
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.AddMarkupContent(15, "<label for=\"firstName\" class=\"col-sm-2 col-form-label\">\r\n            First Name\r\n        </label>\r\n        ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-sm-10");
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "id", "firstName");
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "placeholder", "First Name");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                    EditEmployeeModel.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.FirstName = __value, EditEmployeeModel.FirstName))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditEmployeeModel.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __Blazor.EmployeeManagement.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_0(__builder2, 27, 28, 
#nullable restore
#line 18 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                      () => EditEmployeeModel.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group row");
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.AddMarkupContent(35, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">\r\n            Last Name\r\n        </label>\r\n        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col-sm-10");
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "id", "lastName");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "placeholder", "Last Name");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                    EditEmployeeModel.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.LastName = __value, EditEmployeeModel.LastName))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditEmployeeModel.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __Blazor.EmployeeManagement.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_1(__builder2, 47, 48, 
#nullable restore
#line 28 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                      () => EditEmployeeModel.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group row");
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.AddMarkupContent(55, "<label for=\"email\" class=\"col-sm-2 col-form-label\">\r\n            Email\r\n        </label>\r\n        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-sm-10");
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(59);
                __builder2.AddAttribute(60, "id", "email");
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "placeholder", "Email");
                __builder2.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                    EditEmployeeModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.Email = __value, EditEmployeeModel.Email))));
                __builder2.AddAttribute(65, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditEmployeeModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __Blazor.EmployeeManagement.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_2(__builder2, 67, 68, 
#nullable restore
#line 38 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                      () => EditEmployeeModel.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group row");
                __builder2.AddMarkupContent(74, "\r\n        ");
                __builder2.AddMarkupContent(75, "<label for=\"confirmEmail\" class=\"col-sm-2 col-form-label\">\r\n            Confirm Email\r\n        </label>\r\n        ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "col-sm-10");
                __builder2.AddMarkupContent(78, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(79);
                __builder2.AddAttribute(80, "id", "confirmEmail");
                __builder2.AddAttribute(81, "class", "form-control");
                __builder2.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                    EditEmployeeModel.ConfirmEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.ConfirmEmail = __value, EditEmployeeModel.ConfirmEmail))));
                __builder2.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditEmployeeModel.ConfirmEmail));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n            ");
                __Blazor.EmployeeManagement.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_3(__builder2, 86, 87, 
#nullable restore
#line 48 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                      () => EditEmployeeModel.ConfirmEmail

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(88, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n    ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "form-group row");
                __builder2.AddMarkupContent(93, "\r\n        ");
                __builder2.AddMarkupContent(94, "<label for=\"department\" class=\"col-sm-2 col-form-label\">\r\n            Department\r\n        </label>\r\n        ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "col-sm-10");
                __builder2.AddMarkupContent(97, "\r\n            ");
                __Blazor.EmployeeManagement.Web.Pages.EditEmployee.TypeInference.CreateCustomInputSelect_4(__builder2, 98, 99, "form-control", 100, 
#nullable restore
#line 56 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                            EditEmployeeModel.DepartmentId

#line default
#line hidden
#nullable disable
                , 101, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.DepartmentId = __value, EditEmployeeModel.DepartmentId)), 102, () => EditEmployeeModel.DepartmentId, 103, (__builder3) => {
                    __builder3.AddMarkupContent(104, "\r\n");
#nullable restore
#line 58 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                 foreach (var dept in Departments)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(105, "                    ");
                    __builder3.OpenElement(106, "option");
                    __builder3.AddAttribute(107, "value", 
#nullable restore
#line 60 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                    dept.DepartmentId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(108, "\r\n                        ");
                    __builder3.AddContent(109, 
#nullable restore
#line 61 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                         dept.DepartmentName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(110, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(111, "\r\n");
#nullable restore
#line 63 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(112, "            ");
                }
                );
                __builder2.AddMarkupContent(113, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n    ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "form-group row");
                __builder2.AddMarkupContent(118, "\r\n        ");
                __builder2.AddMarkupContent(119, "<label for=\"gender\" class=\"col-sm-2 col-form-label\">\r\n            Gender\r\n        </label>\r\n        ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "col-sm-10");
                __builder2.AddMarkupContent(122, "\r\n            ");
                __Blazor.EmployeeManagement.Web.Pages.EditEmployee.TypeInference.CreateInputSelect_5(__builder2, 123, 124, "form-control", 125, 
#nullable restore
#line 72 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                      EditEmployeeModel.Gender

#line default
#line hidden
#nullable disable
                , 126, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.Gender = __value, EditEmployeeModel.Gender)), 127, () => EditEmployeeModel.Gender, 128, (__builder3) => {
                    __builder3.AddMarkupContent(129, "\r\n");
#nullable restore
#line 73 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                 foreach (var gender in Enum.GetValues(typeof(Gender)))
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(130, "                    ");
                    __builder3.OpenElement(131, "option");
                    __builder3.AddAttribute(132, "value", 
#nullable restore
#line 75 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                    gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(133, 
#nullable restore
#line 75 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                             gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(134, "\r\n");
#nullable restore
#line 76 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(135, "            ");
                }
                );
                __builder2.AddMarkupContent(136, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(137, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n    ");
                __builder2.OpenElement(139, "div");
                __builder2.AddAttribute(140, "class", "form-group row");
                __builder2.AddMarkupContent(141, "\r\n        ");
                __builder2.AddMarkupContent(142, "<label for=\"dateOfBirth\" class=\"col-sm-2 col-form-label\">\r\n            Date Of Birth\r\n        </label>\r\n        ");
                __builder2.OpenElement(143, "div");
                __builder2.AddAttribute(144, "class", "col-sm-10");
                __builder2.AddMarkupContent(145, "\r\n            ");
                __Blazor.EmployeeManagement.Web.Pages.EditEmployee.TypeInference.CreateInputDate_6(__builder2, 146, 147, "form-control", 148, 
#nullable restore
#line 85 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                    EditEmployeeModel.DateOfBrith

#line default
#line hidden
#nullable disable
                , 149, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.DateOfBrith = __value, EditEmployeeModel.DateOfBrith)), 150, () => EditEmployeeModel.DateOfBrith);
                __builder2.AddMarkupContent(151, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(153, "\r\n    ");
                __builder2.AddMarkupContent(154, "<button class=\"btn btn-primary\" type=\"submit\">Submit</button>\r\n");
#nullable restore
#line 99 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
     if (EditEmployeeModel.EmployeeId > 0)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(155, "        ");
                __builder2.OpenElement(156, "button");
                __builder2.AddAttribute(157, "class", "btn btn-danger");
                __builder2.AddAttribute(158, "type", "button");
                __builder2.AddAttribute(159, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                                               Delete_Click

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(160, "Delete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n");
#nullable restore
#line 102 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(162, "\r\n\r\n");
            __builder.OpenComponent<PragimTech.Components.Confirm>(163);
            __builder.AddAttribute(164, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 105 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                                        ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(165, "ConfirmationMessage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 106 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                               $"Are you sure you want to delete \"{EditEmployeeModel.FirstName}\""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(166, (__value) => {
#nullable restore
#line 105 "C:\Users\mtkat\Desktop\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
               DeleteConfirmation = (PragimTech.Components.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.EmployeeManagement.Web.Pages.EditEmployee
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateCustomInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::PragimTech.Components.CustomInputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591