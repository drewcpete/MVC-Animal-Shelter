#pragma checksum "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edbd4fba965c4f0e06a5ffb21abbac386d9a27f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animal_Edit), @"mvc.1.0.view", @"/Views/Animal/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Animal/Edit.cshtml", typeof(AspNetCore.Views_Animal_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edbd4fba965c4f0e06a5ffb21abbac386d9a27f6", @"/Views/Animal/Edit.cshtml")]
    public class Views_Animal_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnimalShelter.Models.Animal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(63, 36, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this task: ");
            EndContext();
            BeginContext(100, 36, false);
#line 9 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Edit.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(136, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(176, 39, false);
#line 13 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Edit.cshtml"
Write(Html.HiddenFor(model => model.AnimalId));

#line default
#line hidden
            EndContext();
            BeginContext(222, 34, false);
#line 15 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(262, 35, false);
#line 16 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(304, 33, false);
#line 18 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Edit.cshtml"
Write(Html.LabelFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(343, 34, false);
#line 19 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Edit.cshtml"
Write(Html.EditorFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(384, 35, false);
#line 21 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Edit.cshtml"
Write(Html.LabelFor(model => model.Breed));

#line default
#line hidden
            EndContext();
            BeginContext(425, 36, false);
#line 22 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Edit.cshtml"
Write(Html.EditorFor(model => model.Breed));

#line default
#line hidden
            EndContext();
            BeginContext(468, 45, false);
#line 24 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Edit.cshtml"
Write(Html.HiddenFor(model => model.AdmittanceDate));

#line default
#line hidden
            EndContext();
            BeginContext(515, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 27 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(558, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(562, 40, false);
#line 28 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(602, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnimalShelter.Models.Animal> Html { get; private set; }
    }
}
#pragma warning restore 1591
