#pragma checksum "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ca593d5367c3789e4a89e4e734d8fb5bc9efe79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CalisanTakip.Pages.WorkOrder.Views_WorkOrder_Index), @"mvc.1.0.view", @"/Views/WorkOrder/Index.cshtml")]
namespace CalisanTakip.Pages.WorkOrder
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
#line 1 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\_ViewImports.cshtml"
using CalisanTakip;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ca593d5367c3789e4a89e4e734d8fb5bc9efe79", @"/Views/WorkOrder/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a619d2fc190c56c6d6b26a59630a5d982188cfcc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_WorkOrder_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CalisanTakip.Common.PagingListModels.PaginatedList<CalisanTakip.Common.ViewModels.WorkOrderVM>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WorkOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"page-content\">\r\n    <div class=\"page-header\">\r\n        <h2>İş Emri Listesi</h2>\r\n    </div><!-- /.page-header -->\r\n    <br />\r\n    <div class=\"col-6 text-left text-white\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca593d5367c3789e4a89e4e734d8fb5bc9efe796048", async() => {
                WriteLiteral("İş Emri Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <br />
    <div class=""row"">
        <div class=""col-xs-12"">
            <!-- PAGE CONTENT BEGINS -->
            <div class=""row"">
                <div class=""col-xs-12"">
                    <table id=""simple-table"" class=""table  table-bordered table-hover"">
                        <thead>
                            <tr>
                                <th>İş Emri Numarası</th>
                                <th>Oluşturulma Tarihi</th>
                                <th>İş Emri Durumu</th>
                                <th>İşlemler</th>
                            </tr>
                        </thead>

                        <tbody>
");
#nullable restore
#line 33 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
                             if (Model != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 40 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
                                       Write(item.WorkOrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 42 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
                                       Write(item.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 43 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
                                       Write(item.WorkOrderStatusText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <div class=\"hidden-sm hidden-xs btn-group\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca593d5367c3789e4a89e4e734d8fb5bc9efe7910255", async() => {
                WriteLiteral("\r\n                                                    <i class=\"ace-icon fa fa-pencil bigger-120\"></i>\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
                                                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("                                                <a class=\"btn btn-xs btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2555, "\"", 2585, 3);
            WriteAttributeValue("", 2565, "removeItem(", 2565, 11, true);
#nullable restore
#line 53 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
WriteAttributeValue("", 2576, item.Id, 2576, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2584, ")", 2584, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 53 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
                                                                                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                    <i class=""ace-icon fa fa-trash bigger-120""></i>
                                                </a>

                                                <button class=""btn btn-xs btn-warning"">
                                                    <i class=""ace-icon fa fa-flag bigger-120""></i>
                                                </button>
                                            </div>
                                        </td>
                                    </tr>
");
#nullable restore
#line 63 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
                                 
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>Data Bulunamadı...</td>\r\n                                </tr>\r\n");
#nullable restore
#line 70 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div><!-- /.span -->\r\n            </div><!-- /.row -->\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 80 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
  
    var prevDisabled = !Model.PreviousPage ? "disabled" : "";
    var nextDisabled = !Model.NextPage ? "disabled" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca593d5367c3789e4a89e4e734d8fb5bc9efe7916131", async() => {
                WriteLiteral(" Önceki Sayfa\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
                                 WriteLiteral(Model.PageIndex-1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3841, "btn", 3841, 3, true);
            AddHtmlAttributeValue(" ", 3844, "btn-success", 3845, 12, true);
#nullable restore
#line 86 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
AddHtmlAttributeValue(" ", 3856, prevDisabled, 3857, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca593d5367c3789e4a89e4e734d8fb5bc9efe7919021", async() => {
                WriteLiteral(" Sonraki Sayfa\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
                                 WriteLiteral(Model.PageIndex+1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3967, "btn", 3967, 3, true);
            AddHtmlAttributeValue(" ", 3970, "btn-info", 3971, 9, true);
#nullable restore
#line 89 "C:\Users\baran.dogan\Desktop\Çalışmalarım\Projeler\CalisanTakip\CalisanTakip.UI\CalisanTakip\Views\WorkOrder\Index.cshtml"
AddHtmlAttributeValue(" ", 3979, nextDisabled, 3980, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
    function removeItem(rowId){
        swal({
            title:'Silmek istediğinize emin misiniz?',
            text:'Silinen veri geri alınamaz',
            icon: 'warning',
            buttons: true,
            dangerMode: true
        }).then((willDelete) =>{
            if(willDelete){
            $.ajax({
                type:""DELETE"",
                url:""/WorkOrder/Delete/"" + rowId,
                success : function(data){
                    if(data.success){
                        toastr.success(data.message);
                        
                    }else{
                        toastr.error(data.message);
                    }
                    location.reload();
            }
            });
         }
        });
    }

     //$(document).ready(function (){
    //$(""#btnRemove"").on(""click"", function () {
    //    var id = $(""#btnRemove"").data(""id"");

</script>
");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8ca593d5367c3789e4a89e4e734d8fb5bc9efe7922987", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CalisanTakip.Common.PagingListModels.PaginatedList<CalisanTakip.Common.ViewModels.WorkOrderVM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591