#pragma checksum "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55988d52c22c963de2dfb8dfbf60208daf4c246c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ShowOrders), @"mvc.1.0.view", @"/Views/Customer/ShowOrders.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\_ViewImports.cshtml"
using pet_shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\_ViewImports.cshtml"
using pet_shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55988d52c22c963de2dfb8dfbf60208daf4c246c", @"/Views/Customer/ShowOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"599930df5247481aeb900ca90655e2adf3d630bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ShowOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("data1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RefuseOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>My Orders:</h1>

<table class=""table-primary table-striped col-md-12"">
    <thead>
        <tr>
            <th scope=""col"">order number</th>
            <th scope=""col"">id</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Pet type</th>
            <th scope=""col"">Age</th>
            <th scope=""col"">Color</th>
            <th scope=""col"">Swim Ability</th>
            <th scope=""col"">Reproduce Ability</th>
            <th scope=""col"">Gender</th>
            <th scope=""col"">Pet Breed</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">Shop Adress</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml"
         foreach (pet_shop.Models.DisplayInfo display in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml"
           Write(display.order_number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml"
           Write(display.pet_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml"
           Write(display.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml"
           Write(display.pet_type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml"
           Write(display.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml"
           Write(display.color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml"
           Write(display.can_swim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml"
           Write(display.reproduce_ability);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml"
           Write(display.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml"
           Write(display.pet_breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml"
           Write(display.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml"
           Write(display.adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55988d52c22c963de2dfb8dfbf60208daf4c246c8685", async() => {
                WriteLiteral("\r\n                    <button class=\"btn-warning\" type=\"submit\">Refuse Order</button>\r\n                    <input type=\"hidden\" name=\"orderNumber\"");
                BeginWriteAttribute("value", " value=", 1462, "", 1490, 1);
#nullable restore
#line 40 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml"
WriteAttributeValue("", 1469, display.order_number, 1469, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"petId\"");
                BeginWriteAttribute("value", " value=", 1548, "", 1570, 1);
#nullable restore
#line 41 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml"
WriteAttributeValue("", 1555, display.pet_id, 1555, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\Danon\Documents\GitHub\BMSTU_7sem\Web\Kursach_bd\pet_shop\pet_shop\Views\Customer\ShowOrders.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591