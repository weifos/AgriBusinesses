#pragma checksum "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "927fc4bae6623d21fea56acc2bf36c0ea0d5f8eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemModule_Views_System_UpdateUserForm), @"mvc.1.0.view", @"/Areas/SystemModule/Views/System/UpdateUserForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SystemModule/Views/System/UpdateUserForm.cshtml", typeof(AspNetCore.Areas_SystemModule_Views_System_UpdateUserForm))]
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
#line 1 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\_ViewImports.cshtml"
using Solution.Admin;

#line default
#line hidden
#line 2 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\_ViewImports.cshtml"
using Solution.Entity.SystemModule;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"927fc4bae6623d21fea56acc2bf36c0ea0d5f8eb", @"/Areas/SystemModule/Views/System/UpdateUserForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e8a7f1eb1f0338c9f3304a83320395f0068162", @"/Areas/SystemModule/Views/_ViewImports.cshtml")]
    public class Areas_SystemModule_Views_System_UpdateUserForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
  
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
                BeginWriteAttribute("href", " href=\"", 80, "\"", 164, 3);
#line 6 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 87, AppGlobal.Res, 87, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 103, "js/plugins/daterangepicker/daterangepicker.css?", 103, 47, true);
#line 6 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 150, AppGlobal.VNo, 150, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(165, 22, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n");
                EndContext();
            }
            );
            BeginContext(190, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Js", async() => {
                BeginContext(204, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 217, "\"", 266, 3);
#line 10 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 223, AppGlobal.Res, 223, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 239, "js/Config.js?", 239, 13, true);
#line 10 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 252, AppGlobal.VNo, 252, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(267, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 290, "\"", 363, 3);
#line 11 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 296, AppGlobal.Res, 296, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 312, "js/plugins/daterangepicker/moment.js?", 312, 37, true);
#line 11 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 349, AppGlobal.VNo, 349, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(364, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 387, "\"", 473, 3);
#line 12 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 393, AppGlobal.Res, 393, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 409, "js/plugins/daterangepicker/daterangepicker.min.js?", 409, 50, true);
#line 12 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 459, AppGlobal.VNo, 459, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(474, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 497, "\"", 570, 3);
#line 13 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 503, AppGlobal.Res, 503, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 519, "js/plugins/yw-jq-plugin/yw.config.js?", 519, 37, true);
#line 13 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 556, AppGlobal.VNo, 556, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(571, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 594, "\"", 676, 3);
#line 14 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 600, AppGlobal.Res, 600, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 616, "js/plugins/yw-jq-plugin/upload/jquery.form.js?", 616, 46, true);
#line 14 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 662, AppGlobal.VNo, 662, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(677, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 700, "\"", 791, 3);
#line 15 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 706, AppGlobal.Res, 706, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 722, "js/plugins/yw-jq-plugin/upload/jquery.uploadimg-1.0.js?", 722, 55, true);
#line 15 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 777, AppGlobal.VNo, 777, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(792, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 815, "\"", 899, 3);
#line 16 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 821, AppGlobal.Res, 821, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 837, "js/plugins/yw-jq-plugin/city-area/area-1.0.js?", 837, 46, true);
#line 16 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 883, AppGlobal.VNo, 883, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(900, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 923, "\"", 1011, 3);
#line 17 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 929, AppGlobal.Res, 929, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 945, "js/plugins/yw-jq-plugin/validate/validates-2.1.3.js?", 945, 52, true);
#line 17 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 997, AppGlobal.VNo, 997, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1012, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1035, "\"", 1111, 3);
#line 18 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 1041, AppGlobal.Res, 1041, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 1057, "js/Admin/Areas/System/UpdateUserForm.js?", 1057, 40, true);
#line 18 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 1097, AppGlobal.VNo, 1097, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1112, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            BeginContext(1127, 281, true);
            WriteLiteral(@"
<div class=""content pd5"">
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1408, "\"", 1431, 1);
#line 27 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 1415, AppGlobal.Admin, 1415, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1432, 3803, true);
            WriteLiteral(@">首页</a></li>
                        <li class=""breadcrumb-item active"">修改个人信息</li>
                    </ol>
                </div>
            </div>
        </div>
    </section>

    <div class=""controls box"">
        <table class=""table_s1 wfull mt30 "">
            <tr>
                <th scope=""row"" style=""width:120px;"">图像设置：</th>
                <td colspan=""3"">
                    <div id=""img_up""></div>
                </td>
            </tr>
            <tr>
                <th scope=""row"" style=""width:120px;"">用户姓名：</th>
                <td style=""width:440px;"">
                    <input type=""text"" id=""name"" data-val=""name"" maxlength=""30"" class=""form-control form-control-sm"" />
                </td>
                <th scope=""row"">微信号码：</th>
                <td colspan=""3"">
                    <input type=""text"" id=""wechat_no"" maxlength=""30"" data-val=""wechat_no"" class=""form-control form-control-sm"" />
                </td>
            </tr>
            <tr>
            ");
            WriteLiteral(@"    <th scope=""row"">用户编号：</th>
                <td>
                    <input type=""text"" id=""no"" data-val=""no"" maxlength=""30"" class=""form-control form-control-sm"" />
                </td>
                <th scope=""row""> 邮箱：</th>
                <td>
                    <input type=""text"" class=""form-control form-control-sm"" id=""email"" data-val=""email"" maxlength=""30"" />
                </td>
            </tr>
            <tr>
                <th scope=""row"">手机号码：</th>
                <td>
                    <input type=""text"" id=""mobile"" data-val=""mobile"" maxlength=""11"" class=""form-control form-control-sm"" />
                </td>
                <th scope=""row"">用户性别：</th>
                <td>
                    <select id=""sex"" data-val=""sex"" class=""form-control form-control-sm w178"">
                        <option value=""true"">男</option>
                        <option value=""false"">女</option>
                    </select>
                </td>
            </tr>
            <tr>
");
            WriteLiteral(@"                <th scope=""row"">账号状态：</th>
                <td>
                    <select id=""status"" data-val=""status"" class=""form-control form-control-sm w178"">
                        <option value=""1"">正常</option>
                        <option value=""0"">冻结</option>
                    </select>
                </td>
                <th scope=""row"">QQ号码：</th>
                <td>
                    <input type=""text"" data-val=""qq"" maxlength=""30"" class=""form-control form-control-sm"" />
                </td>
            </tr>
            <tr>
                <th scope=""row"">地区：</th>
                <td>
                    <div id=""area_div""></div>
                </td>
                <th scope=""row"">出生年月：</th>
                <td>
                    <div class=""input-group input-group-sm"">
                        <div class=""input-group-prepend"">
                            <span class=""btn btn-default"">
                                <i class=""fa fa-calendar""></i>
            ");
            WriteLiteral(@"                </span>
                        </div>
                        <span>
                            <input type=""text"" class=""form-control form-control-sm w148"" onfocus=""$(this).blur()"" data-val=""birthday"" id=""birthday"" />
                        </span>
                    </div>
                </td>
            </tr>
            <tr>
                <th scope=""row"">详细地址：</th>
                <td colspan=""3"">
                    <input type=""text"" id=""address"" maxlength=""200"" data-val=""address"" style=""width:307px;"" class=""form-control form-control-sm"" />
                </td>
            </tr>
        </table>

        <div class=""form-actions"">
            <input type=""hidden"" id=""defurl""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5235, "\"", 5258, 1);
#line 117 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 5243, ViewBag.defurl, 5243, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5259, 49, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"imgurl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5308, "\"", 5331, 1);
#line 118 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 5316, ViewBag.imgurl, 5316, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5332, 49, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"entity\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5381, "\"", 5404, 1);
#line 119 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 5389, ViewBag.entity, 5389, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5405, 49, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"Ticket\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5454, "\"", 5477, 1);
#line 120 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 5462, ViewBag.Ticket, 5462, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5478, 49, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"imgmsg\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5527, "\"", 5550, 1);
#line 121 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 5535, ViewBag.imgmsg, 5535, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5551, 53, true);
            WriteLiteral(" />\r\n\r\n            <input type=\"hidden\" id=\"employee\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5604, "\"", 5629, 1);
#line 123 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\UpdateUserForm.cshtml"
WriteAttributeValue("", 5612, ViewBag.employee, 5612, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5630, 394, true);
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