#pragma checksum "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17ea979ad7ede835b21b64d87ca61191a515549a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animal_Index), @"mvc.1.0.view", @"/Views/Animal/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Animal/Index.cshtml", typeof(AspNetCore.Views_Animal_Index))]
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
#line 5 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Index.cshtml"
using AnimalShelter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ea979ad7ede835b21b64d87ca61191a515549a", @"/Views/Animal/Index.cshtml")]
    public class Views_Animal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AnimalShelter.Models.Animal>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(99, 24, true);
            WriteLiteral("\n<h1>Animals</h1>\n\n<ul>\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Index.cshtml"
   foreach(Animal animal in Model)
  {

#line default
#line hidden
            BeginContext(162, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(173, 74, false);
#line 13 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Index.cshtml"
     Write(Html.ActionLink($"{animal.Name}", "Details", new { id = animal.AnimalId }));

#line default
#line hidden
            EndContext();
            BeginContext(247, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(257, 10, true);
            WriteLiteral("</ul>\n\n<p>");
            EndContext();
            BeginContext(268, 44, false);
#line 17 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Index.cshtml"
Write(Html.ActionLink("Add new animal!", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(312, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AnimalShelter.Models.Animal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
