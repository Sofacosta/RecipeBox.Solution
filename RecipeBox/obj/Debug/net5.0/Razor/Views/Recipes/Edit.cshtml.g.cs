#pragma checksum "/Users/sofiaacosta/Epicodus/RecipeBox.Solution/RecipeBox/Views/Recipes/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d28e53e67541ee991fab02a0fe4560bde441b9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Edit), @"mvc.1.0.view", @"/Views/Recipes/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d28e53e67541ee991fab02a0fe4560bde441b9d", @"/Views/Recipes/Edit.cshtml")]
    public class Views_Recipes_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/sofiaacosta/Epicodus/RecipeBox.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this task: ");
#nullable restore
#line 9 "/Users/sofiaacosta/Epicodus/RecipeBox.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 11 "/Users/sofiaacosta/Epicodus/RecipeBox.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/sofiaacosta/Epicodus/RecipeBox.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
Write(Html.HiddenFor(model => model.RecipeId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/sofiaacosta/Epicodus/RecipeBox.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/sofiaacosta/Epicodus/RecipeBox.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
Write(Html.EditorFor(model => model.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/sofiaacosta/Epicodus/RecipeBox.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
Write(Html.Label("Select category"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/sofiaacosta/Epicodus/RecipeBox.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
Write(Html.DropDownList("CategoryId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
#nullable restore
#line 22 "/Users/sofiaacosta/Epicodus/RecipeBox.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 24 "/Users/sofiaacosta/Epicodus/RecipeBox.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
