#pragma checksum "C:\Users\myths\Desktop\Repos\WsbAdvancedProgramming\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Views\ChatMessages\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a48575e9a516daf2f62599765b265bd742a3ebce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChatMessages_Create), @"mvc.1.0.view", @"/Views/ChatMessages/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a48575e9a516daf2f62599765b265bd742a3ebce", @"/Views/ChatMessages/Create.cshtml")]
    public class Views_ChatMessages_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdvancedProgramming_Lesson4.ChatMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\myths\Desktop\Repos\WsbAdvancedProgramming\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Views\ChatMessages\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>ChatMessage</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""User"" class=""control-label""></label>
                <input asp-for=""User"" class=""form-control"" />
                <span asp-validation-for=""User"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Message"" class=""control-label""></label>
                <input asp-for=""Message"" class=""form-control"" />
                <span asp-validation-for=""Message"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\myths\Desktop\Repos\WsbAdvancedProgramming\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Views\ChatMessages\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvancedProgramming_Lesson4.ChatMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591