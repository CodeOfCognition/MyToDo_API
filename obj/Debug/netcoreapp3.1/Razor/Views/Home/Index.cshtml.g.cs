#pragma checksum "/Users/robdow/Desktop/MyToDo_API/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "374a2fecb312f8f2515a86f2ed62462cd03256b3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"374a2fecb312f8f2515a86f2ed62462cd03256b3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"702c8605502a7c27045bb7c6d0ddbb0a8c1e2ee6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyToDoItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("postForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/process.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "374a2fecb312f8f2515a86f2ed62462cd03256b34094", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 6 "/Users/robdow/Desktop/MyToDo_API/Views/Home/Index.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" = ""Home Page"";</title>
    <script src=""https://code.jquery.com/jquery-3.4.1.js""
            integrity=""sha256-WpOohJOqMqqyKL9FccASB9O0KwACQJpFTUBLTYOVvVU=""
            crossorigin=""anonymous""></script>
    <script>
        $(document).ready(function () {
            var itemName, itemID, itemCompletion;
            var apiurl = ""http://localhost:5000/api/MyToDoItems"";
            $('form').submit(function (evt) {
                evt.preventDefault();
                alert(""Standard submitting procedure prevented"");
                
                itemName = $('#itemName').val();
                itemID = parseInt($('#itemID').val());
                itemCompletion = $('input[name=itemCompletion]:checked').val();
                //document.write(""<p>The following details are now saved in js variables:"" +
                    //""<br/>Name: "" + itemName + ""<br/>ID: "" + itemID +
                    //""<br/>Complete: "" + itemCompletion);

                var data =
                {
         ");
                WriteLiteral(@"           ""Id"": itemID,
                    ""Name"": itemName,
                    ""IsComplete"": itemCompletion,
                }

                $.ajax({
                    url: apiurl,
                    type: 'POST',
                    dataType: 'json',
                    data: JSON.stringify(data),
                    contentType: 'application/json',
                    success: function () {
                        alert(""Saved Successfully"");
                        document.getElementById(""postForm"").reset();
                    },
                    error: function () {
                        alert(""Error, please try again"");
                    }


                }); //end ajax
            }); // end submit
        }); // end ready
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "374a2fecb312f8f2515a86f2ed62462cd03256b37144", async() => {
                WriteLiteral(@"


    <div class=""text-center"">
        <h1 class=""display-4"">Check out this neat list y'all!</h1>
        <p>
            The list is displayed below
        </p>
    </div>
    <div>
        <table border=""1"" align=""center"" width=""100%"" cellpadding=""5"" cellspacing=""5"">
            <tr align=""center"">
                <th colspan=""3"">
                    <h3>My To-Do Items</h3>
                </th>
            </tr>
            <tr align=""center"">
                <th>
                    Name
                </th>
                <th>
                    ID
                </th>
                <th>
                    IsComplete
                </th>
            </tr>


");
#nullable restore
#line 81 "/Users/robdow/Desktop/MyToDo_API/Views/Home/Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr align =\"center\">\r\n                <td>\r\n                    ");
#nullable restore
#line 85 "/Users/robdow/Desktop/MyToDo_API/Views/Home/Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 88 "/Users/robdow/Desktop/MyToDo_API/Views/Home/Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 91 "/Users/robdow/Desktop/MyToDo_API/Views/Home/Index.cshtml"
               Write(item.IsComplete);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 94 "/Users/robdow/Desktop/MyToDo_API/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n     </div>\r\n\r\n    <p>\r\n        Fill out fields to add new item to the list:\r\n    </p>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "374a2fecb312f8f2515a86f2ed62462cd03256b39533", async() => {
                    WriteLiteral(@"
        <div>
            <label for=""itemName"" class=""label"">Name</label>
            <input name=""itemName"" type=""text"" id=""itemName"" size=""32"">
        </div>
        <div>
            <label for=""itemID"" class=""label"">ID</label>
            <input name=""itemID"" type=""number"" id=""itemID"" size=""32"">
        </div>
        <div>
            <label for=""itemCompletion"" class=""label"">Is it Complete?</label>
            <input name=""itemCompletion"" type=""radio"" id=""yes"" value=""True"">
             <label for=""yes"">Yes</label>
            <input name=""itemCompletion"" type=""radio"" id=""no"" value=""False"">
             <label for""no"">No</label>
        </div>
        <div>
            <input type=""submit"" name=""submit"" id=""submit"" value=""Submit"">
        </div>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    \r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
