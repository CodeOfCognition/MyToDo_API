#pragma checksum "/Users/robdow/Desktop/MyToDo_API/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef4521f976d1b3e1a210a244f29b623497d1d29d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/robdow/Desktop/MyToDo_API/Views/_ViewImports.cshtml"
using MyToDo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/robdow/Desktop/MyToDo_API/Views/_ViewImports.cshtml"
using MyToDo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef4521f976d1b3e1a210a244f29b623497d1d29d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"702c8605502a7c27045bb7c6d0ddbb0a8c1e2ee6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyToDoItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/robdow/Desktop/MyToDo_API/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">I\'m very excited to see if this will work!</h1>\r\n    <p>\r\n\r\n\r\n    </p>\r\n</div>\r\n\r\n");
#nullable restore
#line 15 "/Users/robdow/Desktop/MyToDo_API/Views/Home/Index.cshtml"
 foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Name: ");
#nullable restore
#line 18 "/Users/robdow/Desktop/MyToDo_API/Views/Home/Index.cshtml"
         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\r\n        Id: ");
#nullable restore
#line 19 "/Users/robdow/Desktop/MyToDo_API/Views/Home/Index.cshtml"
       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <br/>\r\n        IsComplete: ");
#nullable restore
#line 20 "/Users/robdow/Desktop/MyToDo_API/Views/Home/Index.cshtml"
               Write(item.IsComplete);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 22 "/Users/robdow/Desktop/MyToDo_API/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MyToDoItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
