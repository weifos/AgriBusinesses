#pragma checksum "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\EmployeeManage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdd4e6660237dae43636ba75a142ad1f3532b362"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrgModule_Views_Org_EmployeeManage), @"mvc.1.0.view", @"/Areas/OrgModule/Views/Org/EmployeeManage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/OrgModule/Views/Org/EmployeeManage.cshtml", typeof(AspNetCore.Areas_OrgModule_Views_Org_EmployeeManage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdd4e6660237dae43636ba75a142ad1f3532b362", @"/Areas/OrgModule/Views/Org/EmployeeManage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94c6bc928e3f7223c4491989bed4d14e0be05d90", @"/Areas/OrgModule/Views/_ViewImports.cshtml")]
    public class Areas_OrgModule_Views_Org_EmployeeManage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\EmployeeManage.cshtml"
  
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
#line 6 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\EmployeeManage.cshtml"
WriteAttributeValue("", 87, AppGlobal.Res, 87, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 103, "js/plugins/bootstrap-treeview/bootstrap-treeview.css?", 103, 53, true);
#line 6 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\EmployeeManage.cshtml"
WriteAttributeValue("", 156, AppGlobal.VNo, 156, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(171, 22, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n");
                EndContext();
            }
            );
            DefineSection("Js", async() => {
                BeginContext(208, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 221, "\"", 293, 3);
#line 9 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\EmployeeManage.cshtml"
WriteAttributeValue("", 227, AppGlobal.Res, 227, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 243, "js/plugins/template/template-web.js?", 243, 36, true);
#line 9 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\EmployeeManage.cshtml"
WriteAttributeValue("", 279, AppGlobal.VNo, 279, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(294, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 317, "\"", 392, 3);
#line 10 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\EmployeeManage.cshtml"
WriteAttributeValue("", 323, AppGlobal.Res, 323, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 339, "js/plugins/template/template.helper.js?", 339, 39, true);
#line 10 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\EmployeeManage.cshtml"
WriteAttributeValue("", 378, AppGlobal.VNo, 378, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(393, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 416, "\"", 501, 3);
#line 11 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\EmployeeManage.cshtml"
WriteAttributeValue("", 422, AppGlobal.Res, 422, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 438, "js/plugins/yw-jq-plugin/datagrid/datagrid-1.0.js?", 438, 49, true);
#line 11 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\EmployeeManage.cshtml"
WriteAttributeValue("", 487, AppGlobal.VNo, 487, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(502, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 525, "\"", 613, 3);
#line 12 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\EmployeeManage.cshtml"
WriteAttributeValue("", 531, AppGlobal.Res, 531, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 547, "js/plugins/bootstrap-treeview/bootstrap-treeview.js?", 547, 52, true);
#line 12 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\EmployeeManage.cshtml"
WriteAttributeValue("", 599, AppGlobal.VNo, 599, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(614, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 637, "\"", 710, 3);
#line 13 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\EmployeeManage.cshtml"
WriteAttributeValue("", 643, AppGlobal.Res, 643, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 659, "js/Admin/Areas/Org/EmployeeManage.js?", 659, 37, true);
#line 13 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\EmployeeManage.cshtml"
WriteAttributeValue("", 696, AppGlobal.VNo, 696, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(711, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            BeginContext(726, 3485, true);
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
                                            <input type=""text"" id=""keyword"" class=""form-control float-right form-control-sm"" placeholder=""部门名称"" />
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
        <td>{{obj.company_name == null ? ""--"": obj.company_name}}</td>
        <td>{{obj.d_name == null ? ""--"": obj.d_name}}</td>
        <td>{{obj.name}}</td>
        <td>{{obj.mobile}}</td>
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
