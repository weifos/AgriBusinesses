#pragma checksum "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\FreightTemplateManage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb3c0e2128bff581ace5f6a24f35d33f633a892a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DistributionModule_Views_Distribution_FreightTemplateManage), @"mvc.1.0.view", @"/Areas/DistributionModule/Views/Distribution/FreightTemplateManage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/DistributionModule/Views/Distribution/FreightTemplateManage.cshtml", typeof(AspNetCore.Areas_DistributionModule_Views_Distribution_FreightTemplateManage))]
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
#line 1 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\_ViewImports.cshtml"
using Solution.Admin;

#line default
#line hidden
#line 2 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\_ViewImports.cshtml"
using Solution.Entity.BizTypeModule;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb3c0e2128bff581ace5f6a24f35d33f633a892a", @"/Areas/DistributionModule/Views/Distribution/FreightTemplateManage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbb63252a27454f740a4d8d66b93d416b1814b6e", @"/Areas/DistributionModule/Views/_ViewImports.cshtml")]
    public class Areas_DistributionModule_Views_Distribution_FreightTemplateManage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\FreightTemplateManage.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("Js", async() => {
                BeginContext(66, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 79, "\"", 128, 3);
#line 5 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\FreightTemplateManage.cshtml"
WriteAttributeValue("", 85, AppGlobal.Res, 85, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 101, "js/Config.js?", 101, 13, true);
#line 5 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\FreightTemplateManage.cshtml"
WriteAttributeValue("", 114, AppGlobal.VNo, 114, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(129, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 152, "\"", 224, 3);
#line 6 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\FreightTemplateManage.cshtml"
WriteAttributeValue("", 158, AppGlobal.Res, 158, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 174, "js/plugins/template/template-web.js?", 174, 36, true);
#line 6 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\FreightTemplateManage.cshtml"
WriteAttributeValue("", 210, AppGlobal.VNo, 210, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(225, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 248, "\"", 323, 3);
#line 7 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\FreightTemplateManage.cshtml"
WriteAttributeValue("", 254, AppGlobal.Res, 254, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 270, "js/plugins/template/template.helper.js?", 270, 39, true);
#line 7 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\FreightTemplateManage.cshtml"
WriteAttributeValue("", 309, AppGlobal.VNo, 309, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(324, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 347, "\"", 432, 3);
#line 8 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\FreightTemplateManage.cshtml"
WriteAttributeValue("", 353, AppGlobal.Res, 353, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 369, "js/plugins/yw-jq-plugin/datagrid/datagrid-1.0.js?", 369, 49, true);
#line 8 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\FreightTemplateManage.cshtml"
WriteAttributeValue("", 418, AppGlobal.VNo, 418, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(433, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 456, "\"", 545, 3);
#line 9 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\FreightTemplateManage.cshtml"
WriteAttributeValue("", 462, AppGlobal.Res, 462, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 478, "js/Admin/Areas/Distribution/FreightTemplateManage.js?", 478, 53, true);
#line 9 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\FreightTemplateManage.cshtml"
WriteAttributeValue("", 531, AppGlobal.VNo, 531, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(546, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            BeginContext(561, 2584, true);
            WriteLiteral(@"
<div class=""content pd5"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card-body"">
                <div class=""dataTables_wrapper container-fluid dt-bootstrap4"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""dataTables_length"">
                                <div class=""input-group input-group-sm"">
                                    <input type=""text"" id=""keyword"" class=""form-control float-right form-control-sm"" placeholder=""运费模板名称"" />
                                    <div class=""input-group-append"">
                                        <button type=""button"" class=""btn btn-default"" name=""search_btn""><i class=""fa fa-search""></i></button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""dataTabl");
            WriteLiteral(@"es_filter"">
                                <div class=""btn-group btn-group-sm"">
                                    <a name=""refresh_btn"" class=""btn btn-default""><i class=""fa fa-refresh""></i></a>
                                </div>
                                <div class=""btn-group btn-group-sm"">
                                    <a name=""add_btn"" class=""btn btn-default""><i class=""fa fa-plus""></i>&nbsp;新增</a>
                                    <a name=""edit_btn"" class=""btn btn-default""><i class=""fa fa-pencil-square-o""></i>&nbsp;编辑</a>
                                    <a name=""delete_btn"" class=""btn btn-default""><i class=""fa fa-unlock""></i>&nbsp;删除</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-sm-12 mt6"">
                            <div name=""datagrid""></div>
                        </div>
                    </div>");
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>

    <script type=""text/html"" id=""template"">
        {{each data as obj i}}
        <tr data-id=""{{obj.id}}"">
            <td>{{obj.name}}</td>
            <td>{{obj.first_weight}}</td>
            <td>{{obj.add_weight}}</td>
            <td style=""color:red;"">{{formaToMoney(obj.default_first_price,2) }}</td>
            <td style=""color:red;"">{{formaToMoney(obj.default_add_price,2) }}</td>
        </tr>
        {{/each}}
    </script>
</div>

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
