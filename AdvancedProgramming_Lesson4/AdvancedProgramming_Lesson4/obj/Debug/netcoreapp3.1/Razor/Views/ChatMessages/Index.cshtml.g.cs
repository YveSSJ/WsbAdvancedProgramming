#pragma checksum "C:\Users\myths\Desktop\WsbAdvancedProgramming-main (1)\WsbAdvancedProgramming-main\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Views\ChatMessages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2687ac7400d72e63c7cf6613425a62f9003e1c97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChatMessages_Index), @"mvc.1.0.view", @"/Views/ChatMessages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2687ac7400d72e63c7cf6613425a62f9003e1c97", @"/Views/ChatMessages/Index.cshtml")]
    public class Views_ChatMessages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdvancedProgramming_Lesson4.ChatMessage>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\myths\Desktop\WsbAdvancedProgramming-main (1)\WsbAdvancedProgramming-main\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Views\ChatMessages\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\myths\Desktop\WsbAdvancedProgramming-main (1)\WsbAdvancedProgramming-main\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Views\ChatMessages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\myths\Desktop\WsbAdvancedProgramming-main (1)\WsbAdvancedProgramming-main\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Views\ChatMessages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\myths\Desktop\WsbAdvancedProgramming-main (1)\WsbAdvancedProgramming-main\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Views\ChatMessages\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\myths\Desktop\WsbAdvancedProgramming-main (1)\WsbAdvancedProgramming-main\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Views\ChatMessages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\myths\Desktop\WsbAdvancedProgramming-main (1)\WsbAdvancedProgramming-main\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Views\ChatMessages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 781, "\"", 804, 1);
#nullable restore
#line 34 "C:\Users\myths\Desktop\WsbAdvancedProgramming-main (1)\WsbAdvancedProgramming-main\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Views\ChatMessages\Index.cshtml"
WriteAttributeValue("", 796, item.id, 796, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 857, "\"", 880, 1);
#nullable restore
#line 35 "C:\Users\myths\Desktop\WsbAdvancedProgramming-main (1)\WsbAdvancedProgramming-main\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Views\ChatMessages\Index.cshtml"
WriteAttributeValue("", 872, item.id, 872, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 935, "\"", 958, 1);
#nullable restore
#line 36 "C:\Users\myths\Desktop\WsbAdvancedProgramming-main (1)\WsbAdvancedProgramming-main\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Views\ChatMessages\Index.cshtml"
WriteAttributeValue("", 950, item.id, 950, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\myths\Desktop\WsbAdvancedProgramming-main (1)\WsbAdvancedProgramming-main\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Views\ChatMessages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdvancedProgramming_Lesson4.ChatMessage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
