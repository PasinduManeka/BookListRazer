#pragma checksum "D:\Visual Studio Workspace 2\BookListRazor\Pages\BookList\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d4290cc0acf3c442c583eea3f5b3db9c265589c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookListRazor.Pages.BookList.Pages_BookList_index), @"mvc.1.0.razor-page", @"/Pages/BookList/index.cshtml")]
namespace BookListRazor.Pages.BookList
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
#line 1 "D:\Visual Studio Workspace 2\BookListRazor\Pages\_ViewImports.cshtml"
using BookListRazor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d4290cc0acf3c442c583eea3f5b3db9c265589c", @"/Pages/BookList/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61eeec048b07d9cebb7c677f29d03bb0b044966d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_BookList_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <br />
    <div class=""container row p-0 m-0"" >
        <div class=""col-10"">
            <h2 class=""text-info"">Book List</h2>
        </div>
        <div class=""col-2"">
            <a href=""#"" class=""btn btn-info form-control"">Create new book</a>
        </div>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookListRazor.Pages.BookList.indexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookListRazor.Pages.BookList.indexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookListRazor.Pages.BookList.indexModel>)PageContext?.ViewData;
        public BookListRazor.Pages.BookList.indexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591