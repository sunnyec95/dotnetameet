#pragma checksum "C:\Users\amparida\source\repos\DummyPipelineTestApp\DummyPipelineTestApp\Pages\Clients\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd302e4b4179f85a2b4dfc27df8b20b66f0034d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DummyPipelineTestApp.Pages.Clients.Pages_Clients_Index), @"mvc.1.0.razor-page", @"/Pages/Clients/Index.cshtml")]
namespace DummyPipelineTestApp.Pages.Clients
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
#line 1 "C:\Users\amparida\source\repos\DummyPipelineTestApp\DummyPipelineTestApp\Pages\_ViewImports.cshtml"
using DummyPipelineTestApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd302e4b4179f85a2b4dfc27df8b20b66f0034d1", @"/Pages/Clients/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f27785c41a3f2044d9cc53120c1646153e841f7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clients_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<br>
<h2>List of Clients</h2>
<a class=""btn btn-primary btn-sm"" href=""/Clients/Create"">New Client</a>
<table class=""table"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>Phone</th>
            <th>Address</th>
            <th>Created At</th>
            <th>Action</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\amparida\source\repos\DummyPipelineTestApp\DummyPipelineTestApp\Pages\Clients\Index.cshtml"
         foreach (var item in Model.listClients)
        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\amparida\source\repos\DummyPipelineTestApp\DummyPipelineTestApp\Pages\Clients\Index.cshtml"
           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\amparida\source\repos\DummyPipelineTestApp\DummyPipelineTestApp\Pages\Clients\Index.cshtml"
           Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\amparida\source\repos\DummyPipelineTestApp\DummyPipelineTestApp\Pages\Clients\Index.cshtml"
           Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\amparida\source\repos\DummyPipelineTestApp\DummyPipelineTestApp\Pages\Clients\Index.cshtml"
           Write(item.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\amparida\source\repos\DummyPipelineTestApp\DummyPipelineTestApp\Pages\Clients\Index.cshtml"
           Write(item.address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\amparida\source\repos\DummyPipelineTestApp\DummyPipelineTestApp\Pages\Clients\Index.cshtml"
           Write(item.created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 817, "\"", 849, 2);
            WriteAttributeValue("", 824, "/Clients/Edit?id=", 824, 17, true);
#nullable restore
#line 32 "C:\Users\amparida\source\repos\DummyPipelineTestApp\DummyPipelineTestApp\Pages\Clients\Index.cshtml"
WriteAttributeValue("", 841, item.id, 841, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                <a class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 909, "\"", 943, 2);
            WriteAttributeValue("", 916, "/Clients/Delete?id=", 916, 19, true);
#nullable restore
#line 33 "C:\Users\amparida\source\repos\DummyPipelineTestApp\DummyPipelineTestApp\Pages\Clients\Index.cshtml"
WriteAttributeValue("", 935, item.id, 935, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\amparida\source\repos\DummyPipelineTestApp\DummyPipelineTestApp\Pages\Clients\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DummyPipelineTestApp.Pages.Clients.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DummyPipelineTestApp.Pages.Clients.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DummyPipelineTestApp.Pages.Clients.IndexModel>)PageContext?.ViewData;
        public DummyPipelineTestApp.Pages.Clients.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
