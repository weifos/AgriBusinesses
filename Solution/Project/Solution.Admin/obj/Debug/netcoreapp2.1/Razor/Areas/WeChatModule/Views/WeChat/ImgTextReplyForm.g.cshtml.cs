#pragma checksum "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adbdb41a95aa7b190633068aecae59298fbdb2f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_WeChatModule_Views_WeChat_ImgTextReplyForm), @"mvc.1.0.view", @"/Areas/WeChatModule/Views/WeChat/ImgTextReplyForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/WeChatModule/Views/WeChat/ImgTextReplyForm.cshtml", typeof(AspNetCore.Areas_WeChatModule_Views_WeChat_ImgTextReplyForm))]
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
#line 1 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\_ViewImports.cshtml"
using Solution.Admin;

#line default
#line hidden
#line 2 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\_ViewImports.cshtml"
using Solution.Admin.Code;

#line default
#line hidden
#line 3 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\_ViewImports.cshtml"
using Solution.Entity.BizTypeModule;

#line default
#line hidden
#line 4 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\_ViewImports.cshtml"
using Solution.Entity.ReplyModule;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adbdb41a95aa7b190633068aecae59298fbdb2f7", @"/Areas/WeChatModule/Views/WeChat/ImgTextReplyForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b20af353fb08a1746489dc4ba8a823086fcc73d9", @"/Areas/WeChatModule/Views/_ViewImports.cshtml")]
    public class Areas_WeChatModule_Views_WeChat_ImgTextReplyForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
  
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
#line 6 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 87, AppGlobal.Res, 87, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 103, "js/Config.js?", 103, 13, true);
#line 6 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 116, AppGlobal.VNo, 116, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(131, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 154, "\"", 236, 3);
#line 7 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 160, AppGlobal.Res, 160, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 176, "js/plugins/yw-jq-plugin/upload/jquery.form.js?", 176, 46, true);
#line 7 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 222, AppGlobal.VNo, 222, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(237, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 260, "\"", 351, 3);
#line 8 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 266, AppGlobal.Res, 266, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 282, "js/plugins/yw-jq-plugin/upload/jquery.uploadimg-1.0.js?", 282, 55, true);
#line 8 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 337, AppGlobal.VNo, 337, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(352, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 375, "\"", 447, 3);
#line 9 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 381, AppGlobal.Res, 381, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 397, "js/plugins/template/template-web.js?", 397, 36, true);
#line 9 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 433, AppGlobal.VNo, 433, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(448, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 471, "\"", 546, 3);
#line 10 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 477, AppGlobal.Res, 477, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 493, "js/plugins/template/template.helper.js?", 493, 39, true);
#line 10 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 532, AppGlobal.VNo, 532, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(547, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 570, "\"", 643, 3);
#line 11 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 576, AppGlobal.Res, 576, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 592, "js/plugins/yw-jq-plugin/yw.config.js?", 592, 37, true);
#line 11 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 629, AppGlobal.VNo, 629, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(644, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 667, "\"", 737, 3);
#line 12 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 673, AppGlobal.Res, 673, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 689, "Content/Ueditor/ueditor.config.js?", 689, 34, true);
#line 12 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 723, AppGlobal.VNo, 723, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(738, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 761, "\"", 832, 3);
#line 13 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 767, AppGlobal.Res, 767, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 783, "Content/Ueditor/ueditor.all.min.js?", 783, 35, true);
#line 13 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 818, AppGlobal.VNo, 818, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(833, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 856, "\"", 944, 3);
#line 14 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 862, AppGlobal.Res, 862, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 878, "js/plugins/yw-jq-plugin/validate/validates-2.1.3.js?", 878, 52, true);
#line 14 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 930, AppGlobal.VNo, 930, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(945, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 968, "\"", 1053, 3);
#line 15 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 974, AppGlobal.Res, 974, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 990, "js/plugins/yw-jq-plugin/datagrid/datagrid-1.0.js?", 990, 49, true);
#line 15 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 1039, AppGlobal.VNo, 1039, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1054, 110, true);
                WriteLiteral("></script>\r\n    <script src=\"http://api.map.baidu.com/api?v=1.4\" type=\"text/javascript\"></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1164, "\"", 1242, 3);
#line 17 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 1170, AppGlobal.Res, 1170, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 1186, "js/Admin/Areas/WeChat/ImgTextReplyForm.js?", 1186, 42, true);
#line 17 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 1228, AppGlobal.VNo, 1228, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1243, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            BeginContext(1258, 281, true);
            WriteLiteral(@"
<div class=""content pd5"">
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1539, "\"", 1562, 1);
#line 26 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 1546, AppGlobal.Admin, 1546, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1563, 68, true);
            WriteLiteral(">首页</a></li>\r\n                        <li class=\"breadcrumb-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1631, "\"", 1694, 2);
#line 27 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 1638, AppGlobal.Admin, 1638, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1656, "WeChatModule/WeChat/ImgTextReplyManage", 1656, 38, true);
            EndWriteAttribute();
            BeginContext(1695, 77, true);
            WriteLiteral(">图文信息管理</a></li>\r\n                        <li class=\"breadcrumb-item active\">");
            EndContext();
            BeginContext(1774, 36, false);
#line 28 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
                                                       Write(ViewBag.entity == null ? "添加" : "修改");

#line default
#line hidden
            EndContext();
            BeginContext(1811, 487, true);
            WriteLiteral(@"图文信息</li>
                    </ol>
                </div>
            </div>
        </div>
    </section>

    <div class=""controls box"">
        <ul id=""Tabs"" class=""nav nav-tabs"">
            <li class=""active"">
                <a href=""#base_panel"" data-toggle=""tab"">基本信息</a>
            </li>
            <li>
                <a href=""#details_panel"" data-toggle=""tab"">图文详细</a>
            </li>
        </ul>

        <div id=""myTabContent"" class=""tab-content"">
");
            EndContext();
            BeginContext(2320, 407, true);
            WriteLiteral(@"            <div id=""base_panel"" class=""tab-pane active"">
                <div class=""controls box"">
                    <table class=""table_s1 mt20"">
                        <tbody>
                            <tr>
                                <th scope=""row"" style=""width:120px;"">关键词：</th>
                                <td>
                                    <input type=""text"" id=""keywords""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2727, "\"", 2752, 1);
#line 54 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 2735, ViewBag.keywords, 2735, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2753, 1421, true);
            WriteLiteral(@" class=""form-control form-control-sm chosen-select w178"" />
                                </td>
                            </tr>
                            <tr>
                                <th scope=""row"">封面标题：</th>
                                <td>
                                    <input type=""text"" data-val=""title"" id=""title"" maxlength=""50"" class=""form-control form-control-sm chosen-select w178"" />
                                </td>
                            </tr>
                            <tr>
                                <th scope=""row"">封面简介：</th>
                                <td>
                                    <textarea style=""width:400px;"" id=""introduction"" data-val=""introduction"" cols=""20"" rows=""3"" name=""introduction"" class=""form-control form-control-sm chosen-select""></textarea>
                                </td>
                            </tr>
                            <tr>
                                <th scope=""row"">封面图片：</th>
             ");
            WriteLiteral(@"                   <td>
                                    <div id=""imgtext_reply_img"">
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <th scope=""row"">多图文：</th>
                                <td>
                                    <div id=""more_div"">
");
            EndContext();
#line 80 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
                                         foreach (ImgTextReply it in ViewBag.moreImgTextReplys)
                                        {

#line default
#line hidden
            BeginContext(4314, 80, true);
            WriteLiteral("                                            <div class=\"moreimgtext_d\" data-id=\"");
            EndContext();
            BeginContext(4395, 5, false);
#line 82 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
                                                                           Write(it.id);

#line default
#line hidden
            EndContext();
            BeginContext(4400, 311, true);
            WriteLiteral(@""" name=""more_imgtexts"">
                                                <a class=""btn-mini del btn_del"" href=""javascript:;"">
                                                    <i class=""fa fa-remove""></i>
                                                </a>
                                                ");
            EndContext();
            BeginContext(4712, 8, false);
#line 86 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
                                           Write(it.title);

#line default
#line hidden
            EndContext();
            BeginContext(4720, 54, true);
            WriteLiteral("\r\n                                            </div>\r\n");
            EndContext();
#line 88 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4817, 415, true);
            WriteLiteral(@"                                    </div>
                                    <input type=""button"" id=""moreImgText"" value=""添 加"" class=""more_btn"" />

                                </td>
                            </tr>
                            <tr>
                                <th scope=""row"">推荐阅读：</th>
                                <td>
                                    <div id=""rec_div"">
");
            EndContext();
#line 98 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
                                         foreach (ImgTextReply it in ViewBag.recImgTextReplys)
                                        {

#line default
#line hidden
            BeginContext(5371, 80, true);
            WriteLiteral("                                            <div class=\"moreimgtext_d\" data-id=\"");
            EndContext();
            BeginContext(5452, 5, false);
#line 100 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
                                                                           Write(it.id);

#line default
#line hidden
            EndContext();
            BeginContext(5457, 305, true);
            WriteLiteral(@""" name=""rec_div"">
                                                <a class=""btn-mini del btn_del"" href=""javascript:;"">
                                                    <i class=""fa fa-remove""></i>
                                                </a>
                                                ");
            EndContext();
            BeginContext(5763, 8, false);
#line 104 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
                                           Write(it.title);

#line default
#line hidden
            EndContext();
            BeginContext(5771, 54, true);
            WriteLiteral("\r\n                                            </div>\r\n");
            EndContext();
#line 106 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
                                        }

#line default
#line hidden
            BeginContext(5868, 976, true);
            WriteLiteral(@"                                    </div>
                                    <input type=""button"" id=""moreRec"" value=""添 加"" class=""more_btn"">
                                </td>
                            </tr>
                            <tr>
                                <th scope=""row"">详细页显示图文封面：</th>
                                <td>
                                    <input type=""radio"" checked=""checked"" value=""show_titleimg"" name=""titleimg_g"" id=""show_titleimg"">是&nbsp;&nbsp;
                                    <input type=""radio"" value=""_show_titleimg"" name=""titleimg_g"" id=""_show_titleimg"">否
                                </td>
                            </tr>
                            <tr>
                                <th scope=""row"">图文消息类型：</th>
                                <td>
                                    <select data-val=""content_type"" id=""content_type"" class=""form-control form-control-sm chosen-select w148"">
");
            EndContext();
#line 122 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
                                         foreach (var item in ViewBag.imgTextTypes)
                                        {

#line default
#line hidden
            BeginContext(6972, 51, true);
            WriteLiteral("                                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7023, "\"", 7040, 1);
#line 124 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 7031, item.Key, 7031, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7041, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(7043, 10, false);
#line 124 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
                                                                 Write(item.Value);

#line default
#line hidden
            EndContext();
            BeginContext(7053, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 125 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
                                        }

#line default
#line hidden
            BeginContext(7107, 192, true);
            WriteLiteral("                                    </select>\r\n                                </td>\r\n                            </tr>\r\n                            <tr name=\"imgtexttr\" style=\"display: none;\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 7299, "\"", 7327, 1);
#line 129 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 7304, MsgContentType.OutLink, 7304, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7328, 229, true);
            WriteLiteral(">\r\n                                <th scope=\"row\" style=\"width:120px;\">外部连接：</th>\r\n                                <td>\r\n                                    <input type=\"text\" style=\"width:400px;\" id=\"OutLinkTxt\" maxlength=\"300\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7557, "\"", 7581, 1);
#line 132 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 7565, ViewBag.outlink, 7565, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7582, 201, true);
            WriteLiteral(" class=\"form-control form-control-sm chosen-select\" />\r\n                                </td>\r\n                            </tr>\r\n                            <tr name=\"imgtexttr\" style=\"display: none;\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 7783, "\"", 7814, 1);
#line 135 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 7788, MsgContentType.Navigation, 7788, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7815, 214, true);
            WriteLiteral(">\r\n                                <th scope=\"row\" style=\"width:120px;\">导航信息</th>\r\n                                <td>\r\n                                    <input type=\"text\" style=\"width:300px;\" id=\"address_text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8029, "\"", 8058, 1);
#line 138 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 8037, ViewBag.address_text, 8037, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8059, 392, true);
            WriteLiteral(@" name=""address_text"" />
                                    <input type=""button"" onclick=""fun_geocoder_getPoint()"" id=""searchmap"" value=""搜 索"" class=""btn btn-small btn-primary btn-save"" />
                                    <div style=""width: 520px; height: 340px; border: 1px solid #CCCCCC; margin-top: 10px;"" id=""container""></div>
                                    <input type=""hidden""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8451, "\"", 8475, 1);
#line 141 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 8459, ViewBag.lat_lng, 8459, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8476, 730, true);
            WriteLiteral(@" id=""lat_lng"" />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <script type=""text/html"" id=""template"">
                        {{each data as obj i}}
                        <tr>
                            <td><input name=""checkboxs"" type=""checkbox"" value=""{{obj.id}}"" title=""{{obj.title}}"" /> </td>
                            <td>{{obj.keywords}} </td>
                            <td>{{obj.title}} </td>
                            <td>{{obj.created_date}} </td>
                        </tr>
                        {{/each}}
                    </script>
                </div>
            </div>

");
            EndContext();
            BeginContext(9228, 268, true);
            WriteLiteral(@"            <div id=""details_panel"" class=""tab-pane"">
                <textarea id=""details"" data-val=""details"" rows=""2"" cols=""20""></textarea>
            </div>
        </div>

        <div class=""form-actions mb60"">
            <input type=""hidden"" id=""defurl""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9496, "\"", 9519, 1);
#line 166 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 9504, ViewBag.defurl, 9504, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9520, 49, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"imgurl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9569, "\"", 9592, 1);
#line 167 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 9577, ViewBag.imgurl, 9577, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9593, 49, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"entity\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9642, "\"", 9665, 1);
#line 168 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 9650, ViewBag.entity, 9650, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9666, 49, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"Ticket\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9715, "\"", 9738, 1);
#line 169 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 9723, ViewBag.Ticket, 9723, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9739, 49, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"imgmsg\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9788, "\"", 9811, 1);
#line 170 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 9796, ViewBag.imgmsg, 9796, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9812, 64, true);
            WriteLiteral(" />\r\n             \r\n            <input type=\"hidden\" id=\"Ticket\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9876, "\"", 9899, 1);
#line 172 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 9884, ViewBag.Ticket, 9884, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9900, 56, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"DetailsTicket\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9956, "\"", 9986, 1);
#line 173 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\WeChatModule\Views\WeChat\ImgTextReplyForm.cshtml"
WriteAttributeValue("", 9964, ViewBag.DetailsTicket, 9964, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9987, 388, true);
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