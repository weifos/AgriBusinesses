#pragma checksum "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\PostManage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "437c2a2bc57677e3db2d864c72500a9250af7dc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrgModule_Views_Org_PostManage), @"mvc.1.0.view", @"/Areas/OrgModule/Views/Org/PostManage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/OrgModule/Views/Org/PostManage.cshtml", typeof(AspNetCore.Areas_OrgModule_Views_Org_PostManage))]
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
#line 1 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\_ViewImports.cshtml"
using Solution.Admin;

#line default
#line hidden
#line 2 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\_ViewImports.cshtml"
using Solution.Entity.OrgModule;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"437c2a2bc57677e3db2d864c72500a9250af7dc9", @"/Areas/OrgModule/Views/Org/PostManage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94c6bc928e3f7223c4491989bed4d14e0be05d90", @"/Areas/OrgModule/Views/_ViewImports.cshtml")]
    public class Areas_OrgModule_Views_Org_PostManage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\PostManage.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(69, 11, true);
                WriteLiteral("\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 80, "\"", 170, 3);
#line 6 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\PostManage.cshtml"
WriteAttributeValue("", 87, AppGlobal.Res, 87, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 103, "js/plugins/bootstrap-treeview/bootstrap-treeview.css?", 103, 53, true);
#line 6 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\PostManage.cshtml"
WriteAttributeValue("", 156, AppGlobal.VNo, 156, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(171, 232, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <style type=\"text/css\">\r\n        .list-group-item { border: none }\r\n            .list-group-item:first-child { border-top-left-radius: 0rem; border-top-right-radius: 0rem; border-top: 0px; }\r\n    </style>\r\n");
                EndContext();
            }
            );
            DefineSection("Js", async() => {
                BeginContext(418, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 431, "\"", 503, 3);
#line 13 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\PostManage.cshtml"
WriteAttributeValue("", 437, AppGlobal.Res, 437, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 453, "js/plugins/template/template-web.js?", 453, 36, true);
#line 13 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\PostManage.cshtml"
WriteAttributeValue("", 489, AppGlobal.VNo, 489, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(504, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 527, "\"", 602, 3);
#line 14 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\PostManage.cshtml"
WriteAttributeValue("", 533, AppGlobal.Res, 533, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 549, "js/plugins/template/template.helper.js?", 549, 39, true);
#line 14 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\PostManage.cshtml"
WriteAttributeValue("", 588, AppGlobal.VNo, 588, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(603, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 626, "\"", 711, 3);
#line 15 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\PostManage.cshtml"
WriteAttributeValue("", 632, AppGlobal.Res, 632, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 648, "js/plugins/yw-jq-plugin/datagrid/datagrid-1.0.js?", 648, 49, true);
#line 15 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\PostManage.cshtml"
WriteAttributeValue("", 697, AppGlobal.VNo, 697, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(712, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 735, "\"", 823, 3);
#line 16 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\PostManage.cshtml"
WriteAttributeValue("", 741, AppGlobal.Res, 741, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 757, "js/plugins/bootstrap-treeview/bootstrap-treeview.js?", 757, 52, true);
#line 16 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\PostManage.cshtml"
WriteAttributeValue("", 809, AppGlobal.VNo, 809, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(824, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 847, "\"", 916, 3);
#line 17 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\PostManage.cshtml"
WriteAttributeValue("", 853, AppGlobal.Res, 853, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 869, "js/Admin/Areas/Org/PostManage.js?", 869, 33, true);
#line 17 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\PostManage.cshtml"
WriteAttributeValue("", 902, AppGlobal.VNo, 902, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(917, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            BeginContext(932, 3415, true);
            WriteLiteral(@"
<div class=""content pd5"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card-body"">
                <div class=""dataTables_wrapper container-fluid dt-bootstrap4"">
                    <div class=""row"">
                        <div class=""col-md-20"">
                            <div class=""card card-info card-outline"">
                                <div class=""card-header"">
                                    <h3 class=""card-title"">
                                        公司信息
                                    </h3>
                                </div>
                                <div class=""card-body p-0"" style=""display: block;"">
                                    <div id=""treeview"" style=""overflow-y:hidden;""></div>
                                </div>
                            </div>
                        </div>

                        <div class=""col-md-80 ml-sub8"">
                            <div style=""display:flex;"">
                  ");
            WriteLiteral(@"              <div class=""col-md-6"" style=""margin-left:0px;margin-left:-8px;"">
                                    <div class=""dataTables_length"">
                                        <div class=""input-group input-group-sm"">
                                            <input type=""text"" id=""keyword"" class=""form-control float-right form-control-sm"" placeholder=""岗位名称"" />
                                            <div class=""input-group-append"">
                                                <button type=""button"" class=""btn btn-default"" name=""search_btn""><i class=""fa fa-search""></i></button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-6 pdr-18 ml-15"">
                                    <div class=""dataTables_filter"">
                                        <div class=""btn-group btn-group-sm"">
                ");
            WriteLiteral(@"                            <a name=""refresh_btn"" class=""btn btn-default""><i class=""fa fa-refresh""></i></a>
                                        </div>
                                        <div class=""btn-group btn-group-sm"">
                                            <a name=""add_btn"" class=""btn btn-default""><i class=""fa fa-plus""></i> 新增</a>
                                            <a name=""edit_btn"" class=""btn btn-default""><i class=""fa fa-pencil-square-o""></i> 编辑</a>
                                            <a name=""delete_btn"" class=""btn btn-default""><i class=""fa fa-trash-o""></i> 删除</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div name=""datagrid"" class=""mt5""></div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script type=""text/html"" id");
            WriteLiteral(@"=""template"">
    {{each data as obj i}}
    <tr data-id=""{{obj.id}}"">
        <td>{{obj.order_index}}</td>
        <td>{{obj.company_name}}</td>
        <td>{{obj.parent_name == null ? ""--"":""""}}</td>
        <td>{{obj.name}}</td>
        <td>{{obj.created_date | ChangeCompleteDateFormat}} </td>
    </tr>
    {{/each}}
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
