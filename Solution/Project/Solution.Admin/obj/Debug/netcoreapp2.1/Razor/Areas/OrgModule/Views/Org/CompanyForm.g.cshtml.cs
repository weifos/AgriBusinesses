#pragma checksum "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12dae3fc655884076c637d7f7fb8ef90d93cd160"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrgModule_Views_Org_CompanyForm), @"mvc.1.0.view", @"/Areas/OrgModule/Views/Org/CompanyForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/OrgModule/Views/Org/CompanyForm.cshtml", typeof(AspNetCore.Areas_OrgModule_Views_Org_CompanyForm))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12dae3fc655884076c637d7f7fb8ef90d93cd160", @"/Areas/OrgModule/Views/Org/CompanyForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94c6bc928e3f7223c4491989bed4d14e0be05d90", @"/Areas/OrgModule/Views/_ViewImports.cshtml")]
    public class Areas_OrgModule_Views_Org_CompanyForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("Css", async() => {
                BeginContext(67, 11, true);
                WriteLiteral("\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 78, "\"", 160, 3);
#line 5 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 85, AppGlobal.Res, 85, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 101, "js/plugins/daterangepicker/daterangepicker.css?", 101, 47, true);
#line 5 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 148, ViewBag.VNo, 148, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(161, 22, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n");
                EndContext();
            }
            );
            BeginContext(186, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Js", async() => {
                BeginContext(200, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 213, "\"", 284, 3);
#line 9 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 219, AppGlobal.Res, 219, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 235, "js/plugins/daterangepicker/moment.js?", 235, 37, true);
#line 9 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 272, ViewBag.VNo, 272, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(285, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 308, "\"", 392, 3);
#line 10 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 314, AppGlobal.Res, 314, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 330, "js/plugins/daterangepicker/daterangepicker.min.js?", 330, 50, true);
#line 10 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 380, ViewBag.VNo, 380, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(393, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 416, "\"", 489, 3);
#line 11 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 422, AppGlobal.Res, 422, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 438, "js/plugins/yw-jq-plugin/yw.config.js?", 438, 37, true);
#line 11 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 475, AppGlobal.VNo, 475, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(490, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 513, "\"", 595, 3);
#line 12 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 519, AppGlobal.Res, 519, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 535, "js/plugins/yw-jq-plugin/city-area/area-1.0.js?", 535, 46, true);
#line 12 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 581, ViewBag.VNo, 581, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(596, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 619, "\"", 707, 3);
#line 13 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 625, AppGlobal.Res, 625, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 641, "js/plugins/yw-jq-plugin/validate/validates-2.1.3.js?", 641, 52, true);
#line 13 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 693, AppGlobal.VNo, 693, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(708, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 731, "\"", 801, 3);
#line 14 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 737, AppGlobal.Res, 737, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 753, "js/Admin/Areas/Org/CompanyForm.js?", 753, 34, true);
#line 14 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 787, AppGlobal.VNo, 787, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(802, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            BeginContext(817, 281, true);
            WriteLiteral(@"
<div class=""content pd5"">
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1098, "\"", 1121, 1);
#line 23 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 1105, AppGlobal.Admin, 1105, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1122, 68, true);
            WriteLiteral(">首页</a></li>\r\n                        <li class=\"breadcrumb-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1190, "\"", 1242, 2);
#line 24 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 1197, AppGlobal.Admin, 1197, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1215, "OrgModule/Org/SysMenuManage", 1215, 27, true);
            EndWriteAttribute();
            BeginContext(1243, 75, true);
            WriteLiteral(">公司管理</a></li>\r\n                        <li class=\"breadcrumb-item active\">");
            EndContext();
            BeginContext(1320, 36, false);
#line 25 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
                                                       Write(ViewBag.entity == null ? "添加" : "修改");

#line default
#line hidden
            EndContext();
            BeginContext(1357, 438, true);
            WriteLiteral(@"公司信息</li>
                    </ol>
                </div>
            </div>
        </div>
    </section>

    <div class=""controls box"">
        <table class=""table_s1 mt30"">
            <tr>
                <th scope=""row"" style=""width:120px;"">上级公司：</th>
                <td style=""width:440px;"">
                    <select name=""parent_id"" id=""parent_id"" data-val=""parent_id"" class=""form-control form-control-sm w178"">
");
            EndContext();
#line 38 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
                         foreach (Company m in ViewBag.Parents)
                        {

#line default
#line hidden
            BeginContext(1887, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1922, "\"", 1935, 1);
#line 40 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 1930, m.id, 1930, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1936, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1938, 6, false);
#line 40 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
                                             Write(m.name);

#line default
#line hidden
            EndContext();
            BeginContext(1944, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 41 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
                        }

#line default
#line hidden
            BeginContext(1982, 4312, true);
            WriteLiteral(@"                    </select>
                </td>
                <th scope=""row"">成立时间：</th>
                <td>
                    <div class=""input-group input-group-sm"">
                        <div class=""input-group-prepend"">
                            <span class=""btn btn-default"">
                                <i class=""fa fa-calendar""></i>
                            </span>
                        </div>
                        <span>
                            <input type=""text"" class=""form-control form-control-sm w148"" onfocus=""$(this).blur()"" data-val=""f_time"" />
                        </span>
                    </div>
                </td>
            </tr>
            <tr>
                <th scope=""row"">公司名称：</th>
                <td>
                    <input type=""text"" maxlength=""50"" data-val=""name"" class=""form-control form-control-sm w240"" />
                </td>
                <th scope=""row"">公司性质：</th>
                <td>
                    <select da");
            WriteLiteral(@"ta-val=""nature"" class=""form-control form-control-sm w178"">
                        <option value=""-1"">==请选择==</option>
                        <option value=""1"">国家机关</option>
                        <option value=""2"">房地产</option>
                        <option value=""3"">建筑业</option>
                        <option value=""4"">社会服务业</option>
                        <option value=""5"">IT/互联网</option>
                        <option value=""6"">制造业</option>
                        <option value=""7"">金融业</option>
                        <option value=""8"">其他业</option>
                    </select>
                </td>
            </tr>
            <tr>
                <th scope=""row"">英文名称：</th>
                <td>
                    <input type=""text"" maxlength=""50"" data-val=""en_name"" class=""form-control form-control-sm w240"" />
                </td>
                <th scope=""row"">中文简称：</th>
                <td>
                    <input type=""text"" maxlength=""50"" data-val=""for_short"" class=""fo");
            WriteLiteral(@"rm-control form-control-sm"" />
                </td>
            </tr>
            <tr>
                <th scope=""row"">负责人：</th>
                <td>
                    <input type=""text"" maxlength=""50"" data-val=""manager"" class=""form-control form-control-sm"" />
                </td>
                <th scope=""row"">公司电话：</th>
                <td>
                    <input type=""text"" maxlength=""50"" data-val=""tel"" class=""form-control form-control-sm"" />
                </td>
            </tr>
            <tr>
                <th scope=""row"">公司邮箱：</th>
                <td>
                    <input type=""text"" maxlength=""50"" data-val=""email"" class=""form-control form-control-sm"" />
                </td>
                <th scope=""row"">公司传真：</th>
                <td>
                    <input type=""text"" maxlength=""50"" data-val=""fax"" class=""form-control form-control-sm"" />
                </td>
            </tr>
            <tr>
                <th scope=""row"">所在区域：</th>
             ");
            WriteLiteral(@"   <td>
                    <div id=""area_div""></div>
                </td>
                <th scope=""row"">详细地址：</th>
                <td>
                    <input type=""text"" maxlength=""200"" data-val=""address"" style=""width:307px;"" class=""form-control form-control-sm"" />
                </td>
            </tr>
            <tr>
                <th scope=""row"">经验范围：</th>
                <td colspan=""4"">
                    <textarea data-val=""biz_scope"" rows=""3"" cols=""30"" class=""form-control form-control-sm"" style=""width:500px;""></textarea>
                </td>
            </tr>
            <tr>
                <th scope=""row"">备注信息：</th>
                <td colspan=""4"">
                    <textarea data-val=""remarks"" rows=""3"" cols=""30"" class=""form-control form-control-sm"" style=""width:500px;""></textarea>
                </td>
            </tr>
            <tr>
                <th scope=""row"">显示排序：</th>
                <td>
                    <input type=""text"" maxlength=""50"" id=""ord");
            WriteLiteral("er_index\" data-val=\"order_index\" class=\"form-control form-control-sm\" />\r\n                </td>\r\n            </tr>\r\n        </table>\r\n\r\n        <div class=\"form-actions\">\r\n            <input type=\"hidden\" id=\"entity\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6294, "\"", 6317, 1);
#line 139 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrgModule\Views\Org\CompanyForm.cshtml"
WriteAttributeValue("", 6302, ViewBag.entity, 6302, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6318, 390, true);
            WriteLiteral(@" />
            <input type=""button"" class=""btn btn-info"" value=""重新加载"" onclick=""javascript: window.location.reload();"" />
            <input type=""button"" class=""btn btn-cancel"" value=""返 回"" id=""BackBtn"" onclick=""javascript: history.go(-1);"" />
            <input type=""button"" class=""btn btn-small btn-primary btn-save"" value=""保 存"" id=""SaveBtn"" />
        </div>
    </div>

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
