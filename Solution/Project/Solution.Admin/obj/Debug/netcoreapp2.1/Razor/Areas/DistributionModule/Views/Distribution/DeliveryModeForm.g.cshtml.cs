#pragma checksum "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5a9d13d819d5bf4a0ca792e7c8f74d841a7ad53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DistributionModule_Views_Distribution_DeliveryModeForm), @"mvc.1.0.view", @"/Areas/DistributionModule/Views/Distribution/DeliveryModeForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/DistributionModule/Views/Distribution/DeliveryModeForm.cshtml", typeof(AspNetCore.Areas_DistributionModule_Views_Distribution_DeliveryModeForm))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a9d13d819d5bf4a0ca792e7c8f74d841a7ad53", @"/Areas/DistributionModule/Views/Distribution/DeliveryModeForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbb63252a27454f740a4d8d66b93d416b1814b6e", @"/Areas/DistributionModule/Views/_ViewImports.cshtml")]
    public class Areas_DistributionModule_Views_Distribution_DeliveryModeForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Js", async() => {
                BeginContext(68, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 81, "\"", 130, 3);
#line 6 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
WriteAttributeValue("", 87, AppGlobal.Res, 87, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 103, "js/Config.js?", 103, 13, true);
#line 6 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
WriteAttributeValue("", 116, AppGlobal.VNo, 116, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(131, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 154, "\"", 227, 3);
#line 7 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
WriteAttributeValue("", 160, AppGlobal.Res, 160, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 176, "js/plugins/yw-jq-plugin/yw.config.js?", 176, 37, true);
#line 7 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
WriteAttributeValue("", 213, AppGlobal.VNo, 213, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(228, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 251, "\"", 339, 3);
#line 8 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
WriteAttributeValue("", 257, AppGlobal.Res, 257, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 273, "js/plugins/yw-jq-plugin/validate/validates-2.1.3.js?", 273, 52, true);
#line 8 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
WriteAttributeValue("", 325, AppGlobal.VNo, 325, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(340, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 363, "\"", 447, 3);
#line 9 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
WriteAttributeValue("", 369, AppGlobal.Res, 369, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 385, "js/Admin/Areas/Distribution/DeliveryModeForm.js?", 385, 48, true);
#line 9 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
WriteAttributeValue("", 433, AppGlobal.VNo, 433, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(448, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            BeginContext(463, 281, true);
            WriteLiteral(@"
<div class=""content pd5"">
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 744, "\"", 767, 1);
#line 18 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
WriteAttributeValue("", 751, AppGlobal.Admin, 751, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(768, 68, true);
            WriteLiteral(">首页</a></li>\r\n                        <li class=\"breadcrumb-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 836, "\"", 911, 2);
#line 19 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
WriteAttributeValue("", 843, AppGlobal.Admin, 843, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 861, "DistributionModule/Distribution/DeliveryModeManage", 861, 50, true);
            EndWriteAttribute();
            BeginContext(912, 77, true);
            WriteLiteral(">配送方式管理</a></li>\r\n                        <li class=\"breadcrumb-item active\">");
            EndContext();
            BeginContext(991, 36, false);
#line 20 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
                                                       Write(ViewBag.entity == null ? "添加" : "修改");

#line default
#line hidden
            EndContext();
            BeginContext(1028, 573, true);
            WriteLiteral(@"配送方式</li>
                    </ol>
                </div>
            </div>
        </div>
    </section>

    <div class=""controls box"">
        <table class=""table_s1 wfull mt30"">
            <tr>
                <th scope=""row"">配送方式名称：</th>
                <td>
                    <input type=""text"" maxlength=""50"" data-val=""name"" id=""name"" class=""form-control form-control-sm"" />
                </td>
            </tr>
            <tr>
                <th scope=""row"">选择物流公司：</th>
                <td>
                    <ul class=""dregion_ul"">
");
            EndContext();
#line 39 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
                         foreach (var entity in ViewBag.LogisticsCompanys)
                        {

#line default
#line hidden
            BeginContext(1704, 54, true);
            WriteLiteral("                            <li><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1758, "\"", 1776, 1);
#line 41 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
WriteAttributeValue("", 1766, entity.id, 1766, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1777, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1779, 11, false);
#line 41 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
                                                                     Write(entity.name);

#line default
#line hidden
            EndContext();
            BeginContext(1790, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 42 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
                        }

#line default
#line hidden
            BeginContext(1824, 437, true);
            WriteLiteral(@"                    </ul>
                </td>
            </tr>
            <tr>
                <th scope=""row"">是否是默认：</th>
                <td>
                    <input type=""checkbox"" data-val=""is_default""> 是
                </td>
            </tr>
            <tr>
                <th scope=""row"">选择运费模板：</th>
                <td>
                    <select id=""freight_template_id"" data-val=""freight_template_id"">
");
            EndContext();
#line 56 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
                         foreach (var entity in ViewBag.FreightTemplates)
                        {

#line default
#line hidden
            BeginContext(2363, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2398, "\"", 2416, 1);
#line 58 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
WriteAttributeValue("", 2406, entity.id, 2406, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2417, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2419, 11, false);
#line 58 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
                                                  Write(entity.name);

#line default
#line hidden
            EndContext();
            BeginContext(2430, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 59 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
                        }

#line default
#line hidden
            BeginContext(2468, 731, true);
            WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <th scope=""row"">显示排序：</th>
                <td>
                    <input type=""text"" maxlength=""50"" id=""order_index"" data-val=""order_index"" class=""form-control form-control-sm"" />
                </td>
            </tr>
            <tr>
                <th scope=""row"">备注信息：</th>
                <td>
                    <textarea id=""remarks"" style=""width:400px;"" data-val=""remarks"" cols=""20"" rows=""2"" name=""remarks"" lass=""form-control form-control-sm w240""></textarea>
                </td>
            </tr>
        </table>

        <div class=""form-actions"">
            <input type=""hidden"" id=""entity""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3199, "\"", 3222, 1);
#line 78 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\DistributionModule\Views\Distribution\DeliveryModeForm.cshtml"
WriteAttributeValue("", 3207, ViewBag.entity, 3207, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3223, 386, true);
            WriteLiteral(@" />
            <input type=""button"" class=""btn btn-info"" value=""重新加载"" onclick=""javascript: window.location.reload();"" />
            <input type=""button"" class=""btn btn-cancel"" value=""返 回"" id=""BackBtn"" onclick=""javascript: history.go(-1);"" />
            <input type=""button"" class=""btn btn-small btn-primary btn-save"" value=""保 存"" id=""SaveBtn"" />
        </div>
    </div>
</div>");
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
