#pragma checksum "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba53495180391b418cdc8edbde47bcdce8c6f3ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrderModule_Views_Order_ProductOrderReport), @"mvc.1.0.view", @"/Areas/OrderModule/Views/Order/ProductOrderReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/OrderModule/Views/Order/ProductOrderReport.cshtml", typeof(AspNetCore.Areas_OrderModule_Views_Order_ProductOrderReport))]
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
#line 1 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\_ViewImports.cshtml"
using Solution.Admin;

#line default
#line hidden
#line 2 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\_ViewImports.cshtml"
using Solution.Entity.OrderModule;

#line default
#line hidden
#line 3 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\_ViewImports.cshtml"
using Solution.Entity.BizTypeModule;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba53495180391b418cdc8edbde47bcdce8c6f3ad", @"/Areas/OrderModule/Views/Order/ProductOrderReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65d8f7823360cc2d6155a83f8b2e56a275a06034", @"/Areas/OrderModule/Views/_ViewImports.cshtml")]
    public class Areas_OrderModule_Views_Order_ProductOrderReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
  
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
#line 6 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 87, AppGlobal.Res, 87, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 103, "js/plugins/daterangepicker/daterangepicker.css?", 103, 47, true);
#line 6 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
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
#line 10 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 223, AppGlobal.Res, 223, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 239, "js/Config.js?", 239, 13, true);
#line 10 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 252, AppGlobal.VNo, 252, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(267, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 290, "\"", 363, 3);
#line 11 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 296, AppGlobal.Res, 296, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 312, "js/plugins/yw-jq-plugin/yw.config.js?", 312, 37, true);
#line 11 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 349, AppGlobal.VNo, 349, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(364, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 387, "\"", 476, 3);
#line 12 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 393, AppGlobal.Res, 393, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 409, "js/plugins/yw-jq-plugin/dynamic.form/dynamic.form.js?", 409, 53, true);
#line 12 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 462, AppGlobal.VNo, 462, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(477, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 500, "\"", 573, 3);
#line 13 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 506, AppGlobal.Res, 506, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 522, "js/plugins/daterangepicker/moment.js?", 522, 37, true);
#line 13 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 559, AppGlobal.VNo, 559, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(574, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 597, "\"", 683, 3);
#line 14 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 603, AppGlobal.Res, 603, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 619, "js/plugins/daterangepicker/daterangepicker.min.js?", 619, 50, true);
#line 14 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 669, AppGlobal.VNo, 669, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(684, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 707, "\"", 779, 3);
#line 15 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 713, AppGlobal.Res, 713, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 729, "js/plugins/template/template-web.js?", 729, 36, true);
#line 15 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 765, AppGlobal.VNo, 765, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(780, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 803, "\"", 878, 3);
#line 16 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 809, AppGlobal.Res, 809, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 825, "js/plugins/template/template.helper.js?", 825, 39, true);
#line 16 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 864, AppGlobal.VNo, 864, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(879, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 902, "\"", 987, 3);
#line 17 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 908, AppGlobal.Res, 908, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 924, "js/plugins/yw-jq-plugin/datagrid/datagrid-1.0.js?", 924, 49, true);
#line 17 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 973, AppGlobal.VNo, 973, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(988, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1011, "\"", 1090, 3);
#line 18 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 1017, AppGlobal.Res, 1017, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 1033, "js/Admin/Areas/Order/ProductOrderReport.js?", 1033, 43, true);
#line 18 "\\Mac\Home\Documents\Projects.Zone\PModule01\AgriBusinesses\Solution\Project\Solution.Admin\Areas\OrderModule\Views\Order\ProductOrderReport.cshtml"
WriteAttributeValue("", 1076, AppGlobal.VNo, 1076, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1091, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            BeginContext(1106, 413, true);
            WriteLiteral(@"
<div class=""content pd5"">
    <div class=""controls box"">
        <ul id=""Tabs"" class=""nav nav-tabs"">
            <li class=""active"">
                <a href=""#order_report_panel"" data-toggle=""tab"">订单报表</a>
            </li>
            <li>
                <a href=""#sale_details_panel"" data-toggle=""tab"">销售明细</a>
            </li>
        </ul>

        <div id=""myTabContent"" class=""tab-content"">
");
            EndContext();
            BeginContext(1541, 5446, true);
            WriteLiteral(@"            <div id=""order_report_panel"" class=""tab-pane active"">
                <div class=""row"">
                    <div class=""col-sm-2 col-6"">
                        <div class=""description-block border-right"">
                            <h5 class=""description-header"" data-val=""actual_amount"" format-money=""2"">0.00</h5>
                            <span class=""description-text text-danger"">订单总金额</span>
                        </div>
                    </div>
                    <div class=""col-sm-2 col-6"">
                        <div class=""description-block border-right"">
                            <h5 class=""description-header"" data-val=""cost_price"" format-money=""2"">0.00</h5>
                            <span class=""description-text text-success"">订单总成本</span>
                        </div>
                    </div>
                    <div class=""col-sm-2 col-6"">
                        <div class=""description-block border-right"">
                            <h5 class=""description");
            WriteLiteral(@"-header"" data-val=""discount_amount"">0.00</h5>
                            <span class=""description-text text-success"">折扣总金额</span>
                        </div>
                    </div>
                    <div class=""col-sm-2 col-6"">
                        <div class=""description-block border-right"">
                            <h5 class=""description-header"" data-val=""coupon_amount"" format-money=""2"">0.00</h5>
                            <span class=""description-text text-success"" >优惠卷总金额</span>
                        </div>
                    </div>
                    <div class=""col-sm-2 col-6"">
                        <div class=""description-block border-right"">
                            <h5 class=""description-header"" data-val=""freight"" format-money=""2"">0.00</h5>
                            <span class=""description-text text-success"" >总运费</span>
                        </div>
                    </div>
                    <div class=""col-sm-2 col-6"">
                        <div c");
            WriteLiteral(@"lass=""description-block"">
                            <h5 class=""description-header"" data-val=""profit"" format-money=""2"" >0.00</h5>
                            <span class=""description-text text-danger"" >总利润</span>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""card-body"">
                            <div class=""dataTables_wrapper container-fluid dt-bootstrap4"">
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""dataTables_length"">
                                            <div class=""input-group input-group-sm"">
                                                <input type=""text"" id=""keyword"" class=""form-control float-right form-control-sm"" placeholder=""订单编号/手机号码"" />
                                                <div class=""input-group-append");
            WriteLiteral(@""">
                                                    <span class=""btn btn-default"">
                                                        <i class=""fa fa-calendar""></i>
                                                    </span>
                                                </div>
                                                <span class=""input-group-append"">
                                                    <input type=""text"" class=""form-control form-control-sm w178"" onfocus=""$(this).blur()"" name=""date"" id=""date"" placeholder=""上传日期"" />
                                                </span>
                                                <div class=""input-group-append"">
                                                    <span class=""btn btn-default"" id=""clear"">
                                                        <i class=""fa fa-trash-o""></i>
                                                    </span>
                                                </div>
                           ");
            WriteLiteral(@"                     <div class=""input-group-append"">
                                                    <button type=""button"" class=""btn btn-default"" name=""search_btn""><i class=""fa fa-search""></i></button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""dataTables_filter"">
                                            <div class=""btn-group btn-group-sm"">
                                                <a name=""refresh_btn"" class=""btn btn-default""><i class=""fa fa-refresh""></i></a>
                                            </div> 
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                  ");
            WriteLiteral(@"  <div class=""col-sm-12 mt6"">
                                        <div name=""datagrid""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

");
            EndContext();
            BeginContext(7009, 4728, true);
            WriteLiteral(@"            <div id=""sale_details_panel"" class=""tab-pane"">
                <div class=""row"">
                    <div class=""col-sm-3 col-6"">
                        <div class=""description-block border-right"">
                            <h5 class=""description-header"" data-val1=""sale_total_amount"" format-money=""2"">0.00</h5>
                            <span class=""description-text text-danger"">销售总额</span>
                        </div>
                    </div>
                    <div class=""col-sm-3 col-6"">
                        <div class=""description-block border-right"">
                            <h5 class=""description-header"" data-val1=""total_num"" format-money=""2"">0.00</h5>
                            <span class=""description-text text-success"">销售总量</span>
                        </div>
                    </div>
                    <div class=""col-sm-3 col-6"">
                        <div class=""description-block border-right"">
                            <h5 class=""description-hea");
            WriteLiteral(@"der"" data-val1=""sale_cost"" format-money=""2"">0</h5>
                            <span class=""description-text text-success"">总成本</span>
                        </div>
                    </div>
                    <div class=""col-sm-3 col-6"">
                        <div class=""description-block"">
                            <h5 class=""description-header"" data-val1=""profit"" format-money=""2"">0.00</h5>
                            <span class=""description-text text-success"" >总利润</span>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""card-body"">
                            <div class=""dataTables_wrapper container-fluid dt-bootstrap4"">
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""dataTables_length"">
                                            ");
            WriteLiteral(@"<div class=""input-group input-group-sm"">
                                                <input type=""text"" id=""keyword"" class=""form-control float-right form-control-sm"" placeholder=""订单编号/手机号码"" />
                                                <div class=""input-group-append"">
                                                    <span class=""btn btn-default"">
                                                        <i class=""fa fa-calendar""></i>
                                                    </span>
                                                </div>
                                                <span class=""input-group-append"">
                                                    <input type=""text"" class=""form-control form-control-sm w178"" onfocus=""$(this).blur()"" name=""date"" id=""date"" placeholder=""上传日期"" />
                                                </span>
                                                <div class=""input-group-append"">
                                                 ");
            WriteLiteral(@"   <span class=""btn btn-default"" id=""clear"">
                                                        <i class=""fa fa-trash-o""></i>
                                                    </span>
                                                </div>
                                                <div class=""input-group-append"">
                                                    <button type=""button"" class=""btn btn-default"" name=""search_btn""><i class=""fa fa-search""></i></button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""dataTables_filter"">
                                            <div class=""btn-group btn-group-sm"">
                                                <a name=""refresh_btn"" class=""btn btn-default""><i class=""fa fa-refresh""></i");
            WriteLiteral(@"></a>
                                            </div> 
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-sm-12 mt6"">
                                        <div name=""datagrid1""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

");
            EndContext();
            BeginContext(11753, 855, true);
            WriteLiteral(@"    <script type=""text/html"" id=""template"">
        {{each data as obj i}}
        <tr>
            <td><p style=""color:blue;""> {{obj.serial_no }} </p> </td>
            <td style=""color:red;"">{{obj.total_amount | formaToMoney}}    </td>
            <td style=""color:red;"">{{obj.cost_price | formaToMoney}}      </td>
            <td style=""color:#23b621;"">{{obj.discount_amount | formaToMoney}} </td>
            <td style=""color:#23b621;"">{{obj.coupon_amount | formaToMoney}}   </td>
            <td style=""color:red;"">{{obj.freight | formaToMoney}}         </td>
            <td style=""color:red;"">{{obj.actual_amount | formaToMoney}}   </td>
            <td style=""color:red;"">{{obj.profit | formaToMoney}}   </td>
            <td>{{obj.created_date  | ChangeCompleteDateFormat}}   </td>
        </tr>
        {{/each}}
    </script>

");
            EndContext();
            BeginContext(12624, 707, true);
            WriteLiteral(@"    <script type=""text/html"" id=""details_template"">
        {{each data as obj i}}
        <tr>
            <td><p style=""color:blue;""> {{obj.serial_no }} </p> </td>
            <td>{{obj.product_name }}</td>
            <td style=""color:red;"">{{obj.unit_price | formaToMoney}} </td>
            <td>x{{obj.count }}         </td>
            <td style=""color:red;"">{{obj.actual_amount | formaToMoney}} </td>
            <td style=""color:red;"">{{obj.cost_price | formaToMoney}} </td>
            <td style=""color:red;"">{{obj.profit | formaToMoney}} </td>
            <td>{{obj.created_date  | ChangeCompleteDateFormat}}   </td>
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
