#pragma checksum "D:\AspNetCore\Homework06\Homework06\Views\Course\GetFacultiesByCrsId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edfbc0f7bde06c3226d286d0573a7ae0e374a019"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_GetFacultiesByCrsId), @"mvc.1.0.view", @"/Views/Course/GetFacultiesByCrsId.cshtml")]
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
#line 1 "D:\AspNetCore\Homework06\Homework06\Views\_ViewImports.cshtml"
using Homework06;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AspNetCore\Homework06\Homework06\Views\_ViewImports.cshtml"
using Homework06.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edfbc0f7bde06c3226d286d0573a7ae0e374a019", @"/Views/Course/GetFacultiesByCrsId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a5d48fbe1390ab2814196e3ade04bcbb8526bf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_GetFacultiesByCrsId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>");
#nullable restore
#line 3 "D:\AspNetCore\Homework06\Homework06\Views\Course\GetFacultiesByCrsId.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
</div>
<div class=""layui-form"">
    <table class=""layui-table text-center layui-side-scroll"" lay-skin=""line"">
        <thead class=""layui-table-header"">
        <tr>
            <th class=""text-center"">Id</th>
            <th class=""text-center"">名字</th>
            <th class=""text-center"">城市</th>
            <th class=""text-center"">国家</th>
            <th class=""text-center"" style=""width:80px"">级别</th>
            <th class=""text-center"">操作</th>
        </tr>
        </thead>
        <tbody class=""layui-table-body"">
        ");
#nullable restore
#line 18 "D:\AspNetCore\Homework06\Homework06\Views\Course\GetFacultiesByCrsId.cshtml"
   Write(Html.DisplayForModel());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>");
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
