#pragma checksum "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "049841345aa8b7e89b9f843ac82f2d6668a5102a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemModule_Views_System_SysUserForm), @"mvc.1.0.view", @"/Areas/SystemModule/Views/System/SysUserForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SystemModule/Views/System/SysUserForm.cshtml", typeof(AspNetCore.Areas_SystemModule_Views_System_SysUserForm))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"049841345aa8b7e89b9f843ac82f2d6668a5102a", @"/Areas/SystemModule/Views/System/SysUserForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e8a7f1eb1f0338c9f3304a83320395f0068162", @"/Areas/SystemModule/Views/_ViewImports.cshtml")]
    public class Areas_SystemModule_Views_System_SysUserForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
  
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
#line 6 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 87, AppGlobal.Res, 87, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 103, "js/plugins/daterangepicker/daterangepicker.css?", 103, 47, true);
#line 6 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
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
                BeginWriteAttribute("src", " src=\"", 217, "\"", 290, 3);
#line 10 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 223, AppGlobal.Res, 223, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 239, "js/plugins/daterangepicker/moment.js?", 239, 37, true);
#line 10 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 276, AppGlobal.VNo, 276, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(291, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 314, "\"", 400, 3);
#line 11 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 320, AppGlobal.Res, 320, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 336, "js/plugins/daterangepicker/daterangepicker.min.js?", 336, 50, true);
#line 11 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 386, AppGlobal.VNo, 386, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(401, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 424, "\"", 497, 3);
#line 12 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 430, AppGlobal.Res, 430, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 446, "js/plugins/yw-jq-plugin/yw.config.js?", 446, 37, true);
#line 12 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 483, AppGlobal.VNo, 483, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(498, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 521, "\"", 605, 3);
#line 13 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 527, AppGlobal.Res, 527, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 543, "js/plugins/yw-jq-plugin/city-area/area-1.0.js?", 543, 46, true);
#line 13 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 589, AppGlobal.VNo, 589, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(606, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 629, "\"", 717, 3);
#line 14 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 635, AppGlobal.Res, 635, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 651, "js/plugins/yw-jq-plugin/validate/validates-2.1.3.js?", 651, 52, true);
#line 14 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 703, AppGlobal.VNo, 703, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(718, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 741, "\"", 814, 3);
#line 15 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 747, AppGlobal.Res, 747, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 763, "js/Admin/Areas/System/SysUserForm.js?", 763, 37, true);
#line 15 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 800, AppGlobal.VNo, 800, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(815, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            BeginContext(830, 281, true);
            WriteLiteral(@"
<div class=""content pd5"">
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1111, "\"", 1134, 1);
#line 24 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 1118, AppGlobal.Admin, 1118, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1135, 68, true);
            WriteLiteral(">首页</a></li>\r\n                        <li class=\"breadcrumb-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1203, "\"", 1261, 2);
#line 25 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 1210, AppGlobal.Admin, 1210, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1228, "SystemModule/System/SysUserManage", 1228, 33, true);
            EndWriteAttribute();
            BeginContext(1262, 75, true);
            WriteLiteral(">用户管理</a></li>\r\n                        <li class=\"breadcrumb-item active\">");
            EndContext();
            BeginContext(1339, 36, false);
#line 26 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                                                       Write(ViewBag.entity == null ? "添加" : "修改");

#line default
#line hidden
            EndContext();
            BeginContext(1376, 1158, true);
            WriteLiteral(@"系统用户</li>
                    </ol>
                </div>
            </div>
        </div>
    </section>

    <div class=""controls box"">
        <ul id=""Tabs"" class=""nav nav-tabs"">
            <li class=""active"">
                <a href=""#user"" data-toggle=""tab"">用户信息</a>
            </li>
            <li>
                <a href=""#user_role"" data-toggle=""tab"">分配角色</a>
            </li>
            <li>
                <a href=""#user_permission"" data-toggle=""tab"">分配权限</a>
            </li>
        </ul>

        <div id=""myTabContent"" class=""tab-content"">
            <div id=""user"" class=""tab-pane active"">
                <table class=""table_s1 wfull "">
                    <thead>
                        <tr>
                            <td colspan=""4"">
                                <label class=""control-label"" for=""inputWarning""><i class=""fa fa-bars""></i> 账号信息</label>
                            </td>
                        </tr>
                    </thead>
               ");
            WriteLiteral("     <tr>\r\n                        <th scope=\"row\" style=\"width:120px;\">登录名：</th>\r\n                        <td style=\"width:440px;\">\r\n");
            EndContext();
#line 59 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                             if (ViewBag.entity == null)
                            {

#line default
#line hidden
            BeginContext(2623, 145, true);
            WriteLiteral("                                <input type=\"text\" class=\"form-control form-control-sm\" id=\"login_name\" data-val=\"login_name\" maxlength=\"30\" />\r\n");
            EndContext();
#line 62 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2864, 127, true);
            WriteLiteral("                                <label data-val=\"login_name\" style=\"color:#dd5600;font-weight:bold; font-size:14px;\"></label>\r\n");
            EndContext();
#line 66 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                            }

#line default
#line hidden
            BeginContext(3022, 5385, true);
            WriteLiteral(@"                        </td>
                        <th scope=""row"">账号状态：</th>
                        <td>
                            <select id=""status"" data-val=""status"" class=""form-control form-control-sm w178"">
                                <option value=""1"">正常</option>
                                <option value=""0"">冻结</option>
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <th scope=""row"">是否是管理员：</th>
                        <td>
                            <input id=""is_shelves"" data-val=""is_shelves"" type=""checkbox"" checked=""checked"">
                        </td>
                    </tr>
                </table>

                <table class=""table_s1 wfull "">
                    <thead>
                        <tr>
                            <td colspan=""4"">
                                <label class=""control-label"" for=""inputWarning""><i class=""fa fa-bars""></i> 员工信息</label>");
            WriteLiteral(@"
                            </td>
                        </tr>
                    </thead>
                    <tr>
                        <th scope=""row"" style=""width:120px;"">员工姓名：</th>
                        <td style=""width:440px;"">
                            <input type=""text"" data-val-e=""name"" class=""form-control form-control-sm"" maxlength=""30"" />
                        </td>
                        <th scope=""row"">微信号码：</th>
                        <td>
                            <input type=""text"" class=""form-control form-control-sm"" id=""wechat_no"" data-val-e=""wechat_no"" maxlength=""30"" />
                        </td>
                    </tr>
                    <tr>
                        <th scope=""row"">员工编号：</th>
                        <td>
                            <input type=""text"" class=""form-control form-control-sm"" id=""no"" data-val-e=""no"" maxlength=""30"" />
                        </td>
                        <th scope=""row""> 邮箱：</th>
                        <t");
            WriteLiteral(@"d>
                            <input type=""text"" class=""form-control form-control-sm"" id=""email"" data-val-e=""email"" maxlength=""30"" />
                        </td>
                    </tr>
                    <tr>
                        <th scope=""row"">手机号码：</th>
                        <td>
                            <input type=""text"" class=""form-control form-control-sm"" id=""mobile"" data-val-e=""mobile"" maxlength=""30"" />
                        </td>
                        <th scope=""row"">员工性别：</th>
                        <td>
                            <select id=""sex"" data-val-e=""sex"" class=""form-control form-control-sm w178"">
                                <option value=""true"">男</option>
                                <option value=""false"">女</option>
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <th scope=""row"">QQ号码：</th>
                        <td>
                            <in");
            WriteLiteral(@"put type=""text"" class=""form-control form-control-sm"" id=""qq"" data-val-e=""qq"" maxlength=""30"" />
                        </td>
                        <th scope=""row"">出生年月：</th>
                        <td>
                            <div class=""input-group input-group-sm"">
                                <div class=""input-group-prepend"">
                                    <span class=""btn btn-default"">
                                        <i class=""fa fa-calendar""></i>
                                    </span>
                                </div>
                                <span>
                                    <input type=""text"" class=""form-control form-control-sm w148"" onfocus=""$(this).blur()"" data-val-e=""birthday"" id=""birthday"" />
                                </span>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <th scope=""row"">地区：</th>
                        <td>
          ");
            WriteLiteral(@"                  <div id=""area_div""></div>
                        </td>
                    </tr>
                    <tr>
                        <th scope=""row"">详细地址：</th>
                        <td>
                            <input type=""text"" id=""address"" maxlength=""200"" data-val-e=""address"" style=""width:307px;"" class=""form-control form-control-sm"" />
                        </td>
                    </tr>
                </table>
            </div>
            <div id=""user_role"" class=""tab-pane"">
                <table class=""text-center"" cellspacing=""0"" style=""width: 100%"">
                    <tbody>
                        <tr>
                            <td style=""width: 200px"">
                                已有角色
                            </td>
                            <td style=""width: 20px"">
                                分配
                            </td>
                            <td style=""width: 200px"">
                                待分配角色
            ");
            WriteLiteral(@"                </td>
                        </tr>
                        <tr>
                            <td valign=""top"">
                                <select name=""HaveRole"" multiple=""multiple"" style=""width: 98%; height: 180px;"" class=""form-control"">
");
            EndContext();
#line 175 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                                     foreach (SysRole r in ViewBag.hasRoles)
                                    {

#line default
#line hidden
            BeginContext(8524, 47, true);
            WriteLiteral("                                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8571, "\"", 8584, 1);
#line 177 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 8579, r.id, 8579, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8585, 47, true);
            WriteLiteral(">\r\n                                            ");
            EndContext();
            BeginContext(8633, 6, false);
#line 178 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                                       Write(r.name);

#line default
#line hidden
            EndContext();
            BeginContext(8639, 53, true);
            WriteLiteral("\r\n                                        </option>\r\n");
            EndContext();
#line 180 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                                    }

#line default
#line hidden
            BeginContext(8731, 1070, true);
            WriteLiteral(@"                                </select>
                            </td>
                            <td align=""center"">
                                <div class=""btn-group-vertical"">
                                    <button type=""button"" class=""btn btn-default"" name=""MoveAllToRight""><i class=""fa fa-fw fa-angle-double-right""></i></button>
                                    <button type=""button"" class=""btn btn-default"" name=""MoveToRight""><i class=""fa fa-fw fa-angle-right""></i></button>
                                    <button type=""button"" class=""btn btn-default"" name=""MoveToLeft""><i class=""fa fa-fw fa-angle-left""></i></button>
                                    <button type=""button"" class=""btn btn-default"" name=""MoveAllToLeft""><i class=""fa fa-fw fa-angle-double-left""></i></button>
                                </div>
                            </td>
                            <td valign=""top"">
                                <select name=""OtherRole"" multiple=""multiple"" style=""width");
            WriteLiteral(": 98%; height: 180px;\" class=\"form-control\">\r\n");
            EndContext();
#line 193 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                                     foreach (SysRole r in ViewBag.tobeRoles)
                                    {

#line default
#line hidden
            BeginContext(9919, 47, true);
            WriteLiteral("                                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9966, "\"", 9979, 1);
#line 195 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 9974, r.id, 9974, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9980, 47, true);
            WriteLiteral(">\r\n                                            ");
            EndContext();
            BeginContext(10028, 6, false);
#line 196 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                                       Write(r.name);

#line default
#line hidden
            EndContext();
            BeginContext(10034, 53, true);
            WriteLiteral("\r\n                                        </option>\r\n");
            EndContext();
#line 198 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                                    }

#line default
#line hidden
            BeginContext(10126, 454, true);
            WriteLiteral(@"                                </select>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <div id=""user_permission"" class=""tab-pane"">
                <div style=""margin-bottom:10px;"" class=""card card-warning"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">选择权限</h3>
                    </div>

");
            EndContext();
#line 211 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                     foreach (SysPermission module in ViewBag.permissions)
                    {

#line default
#line hidden
            BeginContext(10679, 136, true);
            WriteLiteral("                        <div>\r\n                            <div class=\"right_f\">\r\n                                <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("parentid", " parentid=\"", 10815, "\"", 10843, 1);
#line 215 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 10826, module.parent_id, 10826, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\'", 10844, "\'", 10862, 1);
#line 215 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 10852, module.id, 10852, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10863, 43, true);
            WriteLiteral(" />\r\n                                <span>");
            EndContext();
            BeginContext(10907, 11, false);
#line 216 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                                 Write(module.name);

#line default
#line hidden
            EndContext();
            BeginContext(10918, 77, true);
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 219 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"

                        foreach (SysPermission function in ((List<SysPermission>)ViewBag.pchildrens).Where(p => p.parent_id == module.id))
                        {

#line default
#line hidden
            BeginContext(11164, 148, true);
            WriteLiteral("                            <div>\r\n                                <div class=\"right_s\">\r\n                                    <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("parentid", " parentid=\"", 11312, "\"", 11342, 1);
#line 224 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 11323, function.parent_id, 11323, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\'", 11343, "\'", 11363, 1);
#line 224 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 11351, function.id, 11351, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(11364, 47, true);
            WriteLiteral(" />\r\n                                    <span>");
            EndContext();
            BeginContext(11412, 13, false);
#line 225 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                                     Write(function.name);

#line default
#line hidden
            EndContext();
            BeginContext(11425, 85, true);
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
            BeginContext(11512, 57, true);
            WriteLiteral("                            <div style=\"display:flex;\">\r\n");
            EndContext();
#line 230 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                                 foreach (SysPermission action in ((List<SysPermission>)ViewBag.pchildrens).Where(p => p.parent_id == function.id))
                                {

#line default
#line hidden
            BeginContext(11753, 130, true);
            WriteLiteral("                                    <div class=\"right_t disBlock\">\r\n                                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("parentid", " parentid=\"", 11883, "\"", 11911, 1);
#line 233 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 11894, action.parent_id, 11894, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 11912, "\"", 11930, 1);
#line 233 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 11920, action.id, 11920, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(11931, 51, true);
            WriteLiteral(" />\r\n                                        <span>");
            EndContext();
            BeginContext(11983, 11, false);
#line 234 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                                         Write(action.name);

#line default
#line hidden
            EndContext();
            BeginContext(11994, 53, true);
            WriteLiteral("</span>\r\n                                    </div>\r\n");
            EndContext();
#line 236 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                                }

#line default
#line hidden
            BeginContext(12082, 36, true);
            WriteLiteral("                            </div>\r\n");
            EndContext();
#line 238 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(12168, 142, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-actions\">\r\n            <input type=\"hidden\" id=\"defurl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 12310, "\"", 12333, 1);
#line 245 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 12318, ViewBag.defurl, 12318, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(12334, 49, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"imgurl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 12383, "\"", 12406, 1);
#line 246 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 12391, ViewBag.imgurl, 12391, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(12407, 49, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"entity\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 12456, "\"", 12479, 1);
#line 247 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 12464, ViewBag.entity, 12464, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(12480, 49, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"Ticket\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 12529, "\"", 12552, 1);
#line 248 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 12537, ViewBag.Ticket, 12537, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(12553, 49, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"imgmsg\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 12602, "\"", 12625, 1);
#line 249 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 12610, ViewBag.imgmsg, 12610, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(12626, 49, true);
            WriteLiteral(" />\r\n\r\n            <input type=\"hidden\" id=\"pids\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 12675, "\"", 12696, 1);
#line 251 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 12683, ViewBag.pids, 12683, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(12697, 51, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"employee\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 12748, "\"", 12773, 1);
#line 252 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\SystemModule\Views\System\SysUserForm.cshtml"
WriteAttributeValue("", 12756, ViewBag.employee, 12756, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(12774, 394, true);
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