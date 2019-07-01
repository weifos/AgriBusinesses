using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Solution.Admin.Code.Authorization;
using Solution.Admin.Controllers;
using WeiFos.Core;
using WeiFos.Core.Extensions;
using WeiFos.Core.XmlHelper;
using Solution.Entity.BizTypeModule;
using Solution.Entity.Enums;
using Solution.Entity.ProductModule;
using Solution.Entity.SystemModule;
using WeiFos.ORM.Data;
using WeiFos.ORM.Data.Const;
using WeiFos.ORM.Data.Restrictions;
using Solution.Service;
using Solution.Service.ProductModule;
using Solution.Service.ResourceModule;
using Solution.Entity.SiteSettingModule;
using Solution.Entity.Common;
using EntpWebSite.Service.SiteSettingModule;

namespace Solution.Admin.Areas.SiteSettingModule.Controllers
{
    /// <summary>
    /// 站点信息 控制器
    /// @author yewei 
    /// add by @date 2015-08-29
    /// </summary>
    [LoginAuth]
    [Area(AreaNames.SiteSettingModule)]
    public class SiteSettingController : BaseController
    {


        #region 资讯模块


        /// <summary>
        /// 资讯分类
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public IActionResult InformtCatgManage()
        {
            return View();
        }


        /// <summary>
        /// 获取资讯类别分页
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="name"></param>
        /// <param name="createdDate"></param>
        /// <returns></returns>
        public JsonResult GetInformtCatgs(int pageSize, int currentPage, string name)
        {
            //创建查询对象
            Criteria ct = new Criteria();
            ct.SetPageSize(pageSize)
            .SetStartPage(currentPage)
            .SetFields(new string[] { "*" })
            .AddOrderBy(new OrderBy("id", "desc"));

            //查询表达式
            MutilExpression me = new MutilExpression();

            if (!string.IsNullOrEmpty(name))
            {
                me.Add(new SingleExpression("name", LogicOper.LIKE, name));
            }

            if (me.Expressions.Count > 0)
            {
                //设置查询条件
                ct.SetWhereExpression(me);
            }

            List<InformtCatg> data = ServiceIoc.Get<InformtCatgService>().GetList(ct);

            return PageResult(StateCode.State_200, ct.TotalRow, data);
        }


        /// <summary>
        /// 资讯分类页
        /// </summary>
        /// <returns></returns>
        public IActionResult InformtCatgForm()
        {
            //缺省图片路劲
            ViewBag.defurl = ResXmlConfig.Instance.DefaultImgSrc(AppGlobal.Res, ImgType.InformtCatg);
            ViewBag.imgurl = ViewBag.defurl;

            InformtCatg infoCgty = ServiceIoc.Get<InformtCatgService>().GetById(bid);
            if (infoCgty != null)
            {
                //正面图
                Img img = ServiceIoc.Get<ImgService>().GetImg(ImgType.InformtCatg, infoCgty.id);
                if (img != null)
                {
                    ViewBag.imgurl = string.IsNullOrEmpty(img.getImgUrl()) ? ViewBag.imgurl : img.getImgUrl();
                }

                ViewBag.informtCgty = JsonConvert.SerializeObject(infoCgty);
            }
            return View();
        }


        /// <summary>
        /// 保存资讯分类
        /// </summary>
        /// <param name="user"></param>
        /// <param name="infoCgty"></param>
        /// <returns></returns>
        public JsonResult SaveInformtCatg(SysUser user, InformtCatg informtCgty, string imgmsg)
        {
            StateCode state = ServiceIoc.Get<InformtCatgService>().Save(user.id, informtCgty, imgmsg);
            return Json(GetResult(state));
        }


        /// <summary>
        /// 资讯列表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public IActionResult InformtManage(SysUser user)
        {
            List<InformtCatg> Cgtys = new List<InformtCatg>();
            Cgtys.Add(new InformtCatg() { id = 0, name = "——请选择——" });

            List<InformtCatg> ListInformtCatgs = ServiceIoc.Get<InformtCatgService>().GetAll();
            if (ListInformtCatgs != null)
            {
                Cgtys.AddRange(ListInformtCatgs);
            }

            ViewBag.informtCgtys = Cgtys;

            //资讯集合
            //List<Informt> Informts = ServiceIoc.Get<InformtService>().Where(i => i.id > 1 && i.cgty_id == 2 || i.title.Contains("t") || i.context.Contains("t")).ToList();

            return View();
        }


        /// <summary>
        /// 资讯翻页
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="title"></param>
        /// <param name="cgty_id"></param>
        /// <param name="createdDate"></param>
        /// <returns></returns>
        public ContentResult GetInformts(int pageSize, int currentPage, string title, long cgty_id, string createdDate)
        {
            //创建查询对象
            Criteria ct = new Criteria();
            ct.SetFromTables("v_info_informt")
            .SetPageSize(pageSize)
            .SetStartPage(currentPage)
            .SetFields(new string[] { "*" })
            .AddOrderBy(new OrderBy("order_index", "desc"));

            //查询表达式
            MutilExpression me = new MutilExpression();

            if (!string.IsNullOrEmpty(title))
            {
                me.Add(new SingleExpression("title", LogicOper.LIKE, title));
            }

            if (cgty_id != 0)
            {
                me.Add(new SingleExpression("cgty_id", LogicOper.EQ, cgty_id));
            }

            //日期
            if (!string.IsNullOrEmpty(createdDate))
            {
                DateTime startDate = Convert.ToDateTime(createdDate.Split('-')[0]);
                DateTime endDate = Convert.ToDateTime(createdDate.Split('-')[1]);

                if (startDate.CompareTo(endDate) == 0)
                {
                    me.Add(new SingleExpression("created_date", LogicOper.BETWEEN, new[] { startDate.ToString("yyyy/MM/dd"), endDate.AddDays(1).ToString("yyyy/MM/dd") }));
                }
                else
                {
                    me.Add(new SingleExpression("created_date", LogicOper.BETWEEN, new[] { startDate.ToString("yyyy/MM/dd"), endDate.AddDays(1).ToString("yyyy/MM/dd") }));
                }
            }

            if (me.Expressions.Count > 0)
            {
                //设置查询条件
                ct.SetWhereExpression(me);
            }

            DataTable dt = ServiceIoc.Get<InformtService>().Fill(ct);

            return PageResult(StateCode.State_200, ct.TotalRow, dt);
        }


        /// <summary>
        /// 删除资讯
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ids"></param>
        /// <returns></returns>
        public JsonResult DeleteInformt(SysUser user, long[] ids)
        {
            try
            {
                ServiceIoc.Get<InformtService>().Deletes(ids);
                return Json(GetResult(StateCode.State_200));
            }
            catch
            {
                return Json(GetResult(StateCode.State_500));
            }
        }


        /// <summary>
        /// 资讯页面
        /// </summary>
        /// <returns></returns>
        public IActionResult InformtForm()
        {
            //缺省图片路劲
            ViewBag.defurl = ResXmlConfig.Instance.DefaultImgSrc(ViewBag.Res, ImgType.Informt);
            ViewBag.imgurl = ViewBag.defurl;

            List<InformtCatg> cgtys = ServiceIoc.Get<InformtCatgService>().GetListByParentId(0);
            cgtys.Insert(0, new InformtCatg() { name = "根目录", id = 0 });
            ViewBag.Parents = cgtys;

            ViewBag.Ticket = StringHelper.GetEncryption(ImgType.Informt + "#" + bid);
            ViewBag.DetailsTicket = StringHelper.GetEncryption(ImgType.InformtDetails + "#" + bid);

            Informt informt = ServiceIoc.Get<InformtService>().GetById(bid);
            if (informt != null)
            {
                //正面图
                Img img = ServiceIoc.Get<ImgService>().GetImg(ImgType.Informt, informt.id);
                if (img != null)
                {
                    ViewBag.imgurl = string.IsNullOrEmpty(img.getImgUrl()) ? ViewBag.imgurl : img.getImgUrl();
                }
                ViewBag.informt = JsonConvert.SerializeObject(informt);
            }
            return View();
        }


        /// <summary>
        /// 保存资讯
        /// </summary>
        /// <param name="user"></param>
        /// <param name="informt"></param>
        /// <param name="imgmsg"></param>
        /// <returns></returns>
        public JsonResult SaveInformt(SysUser user, Informt informt, string imgmsg)
        {
            StateCode state = ServiceIoc.Get<InformtService>().Save(user.id, informt, imgmsg);
            return Json(GetResult(state));
        }

        #endregion


        #region Banner 模块


        /// <summary>
        /// 广告图管理
        /// </summary>
        /// <returns></returns>
        public IActionResult BannerManage()
        {
            return View();
        }



        /// <summary>
        /// 保存广告图
        /// </summary>
        /// <param name="user"></param>
        /// <param name="adimg"></param>
        /// <param name="imgmsg"></param>
        /// <returns></returns>
        public IActionResult BannerForm(SysUser user, Banner entity, string imgmsg)
        {
            if (NHttpContext.Current.Request.IsAjaxRequest())
            {
                StateCode code = ServiceIoc.Get<BannerService>().Save(user.id, entity, imgmsg);
                return Json(GetResult(code));
            }
            else
            {
                //所属分类
                List<ProductCatg> productCgtys = ServiceIoc.Get<ProductCatgService>().GetTrees("", HttpUtility.HtmlDecode("&nbsp;&nbsp;"));
                productCgtys.Insert(0, new ProductCatg() { name = "——商品分类——", id = 0 });
                ViewBag.productCgtys = productCgtys;

                //上传票据
                ViewBag.Ticket = StringHelper.GetEncryption(ImgType.Banner + "#" + bid);
                //缺省图片路
                ViewBag.defurl = ResXmlConfig.Instance.DefaultImgSrc(AppGlobal.Res, ImgType.Banner);
                ViewBag.imgurl = ViewBag.defurl;

                entity = ServiceIoc.Get<BannerService>().GetById(bid);
                if (entity != null)
                {
                    ViewBag.entity = JsonConvert.SerializeObject(entity);

                    Img img = ServiceIoc.Get<ImgService>().GetImg(ImgType.Banner, entity.id);
                    if (img != null)
                    {
                        ViewBag.imgurl = string.IsNullOrEmpty(img.getImgUrl()) ? ViewBag.defimgurl : img.getImgUrl();
                    }

                    //商品详情
                    if (entity.content_type == (int)BannerLink.ProductDetails && !string.IsNullOrEmpty(entity.content_value))
                    {
                        long pid = 0;
                        long.TryParse(entity.content_value, out pid);
                        Product product = ServiceIoc.Get<ProductService>().GetById(pid);
                        if (product != null)
                        {
                            ViewBag.bizEntity = JsonConvert.SerializeObject(product);
                        }
                    }//商品列表
                    else if (entity.content_type == (int)BannerLink.ProductList && !string.IsNullOrEmpty(entity.content_value))
                    {
                        GuideProductCatg guideProductCgty = ServiceIoc.Get<GuideProductCatgService>().GetById(long.Parse(entity.content_value));
                        if (guideProductCgty != null)
                        {
                            ViewBag.bizEntity = JsonConvert.SerializeObject(guideProductCgty);
                        }
                    }

                }
            }

            return View();
        }


        /// <summary>
        /// 广告图分页
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public ContentResult GetBanners(int pageSize, int pageIndex, string keyword)
        {
            //查询对象
            Criteria ct = new Criteria();

            //查询表达式
            MutilExpression me = new MutilExpression();

            ct.SetFromTables("v_fnt_banner")
            .SetPageSize(pageSize)
            .SetStartPage(pageIndex)
            .SetFields(new string[] { "*" })
            .AddOrderBy(new OrderBy("order_index", "desc"));

            if (!string.IsNullOrEmpty(keyword))
            {
                me.Add(new SingleExpression("name", LogicOper.LIKE, keyword));
            }

            if (me.Expressions.Count > 0)
            {
                ct.SetWhereExpression(me);
            }

            DataTable dt = ServiceIoc.Get<BannerService>().Fill(ct);

            return PageResult(StateCode.State_200, ct.TotalRow, dt);
        }



        /// <summary>
        /// 删除广告图
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ids"></param>
        /// <returns></returns>
        public JsonResult DeleteBanner(SysUser user, long[] ids)
        {
            try
            {
                ServiceIoc.Get<BannerService>().Deletes(ids);
                return Json(GetResult(StateCode.State_200));
            }
            catch
            {
                return Json(GetResult(StateCode.State_500));
            }
        }

        #endregion



    }
}