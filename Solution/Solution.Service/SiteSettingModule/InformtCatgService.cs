using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution.Entity.BizTypeModule;
using Solution.Entity.Enums;
using Solution.Entity.SiteSettingModule;
using WeiFos.ORM.Data;
using Solution.Entity.Enums;
using Solution.Entity.SystemModule;
using WeiFos.ORM.Data.Restrictions;
using WeiFos.ORM.Data.Const;
using Solution.Service;

namespace EntpWebSite.Service.SiteSettingModule
{
    /// <summary>
    /// 资讯分类 Service
    /// @author yewei 
    /// @date 2015-01-09
    /// </summary>
    public class InformtCatgService : BaseService<InformtCatg>
    {


        /// <summary>
        /// 保存资讯类别
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="infoCgty"></param>
        /// <param name="imgmsg"></param>
        /// <returns></returns>
        public StateCode Save(long userId, InformtCatg infoCgty, string imgmsg)
        {
            using (ISession s = SessionFactory.Instance.CreateSession())
            {
                try
                {
                    s.StartTransaction();

                    if (infoCgty.id == 0)
                    {
                        //创建用户ID
                        infoCgty.created_user_id = userId;
                        //创建时间
                        infoCgty.created_date = DateTime.Now;
                        s.Insert<InformtCatg>(infoCgty);
                    }
                    else
                    {
                        //修改用户ID
                        infoCgty.updated_user_id = userId;
                        //修改时间
                        infoCgty.updated_date = DateTime.Now;
                        s.Update<InformtCatg>(infoCgty);
                    }

                    //判断是否存在图片信息
                    if (!string.IsNullOrEmpty(imgmsg))
                    {
                        //去除重复图片
                        s.ExcuteUpdate("update tb_img set biz_id = 0 where biz_type = @0 and biz_id = @1", ImgType.InformtCatg, infoCgty.id);
                        //修改图片
                        s.ExcuteUpdate("update tb_img set biz_id = @0 where biz_type = @1 and file_name = @2", infoCgty.id, ImgType.InformtCatg, imgmsg);
                    }
                }
                catch
                {
                    s.RollBack();
                    return StateCode.State_500;
                }

                s.Commit();
                return StateCode.State_200;
            }
        }



        /// <summary>
        /// 根据上级ID获取
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        public List<InformtCatg> GetListByParentId(long parentId)
        {
            using (ISession s = SessionFactory.Instance.CreateSession())
            {
                return s.List<InformtCatg>("where parent_id = @0", parentId);
            }
        }



        /// <summary>
        /// 设置状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isenable"></param>
        public StateCode SetEnable(long id, bool isenable)
        {
            using (ISession s = SessionFactory.Instance.CreateSession())
            {
                try
                {
                    s.StartTransaction();
                    int exist = s.Exist<InformtCatg>("where id = @0", id);
                    if (exist > 0)
                    {
                        s.ExcuteUpdate("update tb_info_category set is_enable = @0 where id = @1", isenable, id);

                        //将自己的子菜单设置不可用
                        List<InformtCatg> cgtys = s.List<InformtCatg>("where ParentID = @0", id);
                        if (cgtys != null && cgtys.Count() > 0)
                        {
                            foreach (InformtCatg m in cgtys)
                            {
                                s.ExcuteUpdate("update tb_info_category set is_enable = @0 where id = @1", isenable, m.id);
                            }
                        }
                    }
                    s.Commit();
                    return StateCode.State_200;
                }
                catch
                {
                    s.RollBack();
                    return StateCode.State_500;
                }
            }
        }



        /// <summary>
        /// 根据上级ID获取
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        public List<InformtCatg> GetIndexCtgy(ConfigParam config)
        {
            using (ISession s = SessionFactory.Instance.CreateSession())
            {
                if (config != null)
                {
                    //资讯类别
                    List<InformtCatg> catgs = new List<InformtCatg>();
                    foreach (string id in config.config_value.Split(','))
                    {
                        InformtCatg cgty = s.Get<InformtCatg>(long.Parse(id));
                        if (cgty != null) catgs.Add(cgty);
                    }
                    return catgs;
                }
                return null;
            }
        }



        /// <summary>
        /// 递归获取
        /// </summary>
        /// <param name="parent_id"></param>
        /// <param name="index"></param>
        /// <param name="tagstr"></param>
        /// <returns></returns>
        public List<InformtCatg> GetChildrenTag(long parent_id, int index, string tagstr)
        {
            List<InformtCatg> webCategory = new List<InformtCatg>();

            List<InformtCatg> children = GetListByParentId(parent_id);

            if (children != null && children.Count > 0)
            {
                index++;

                string tag = "|--";
                for (int i = 0; i < index; i++)
                {
                    tag = tagstr + tag;
                }

                foreach (InformtCatg c in children)
                {
                    c.name = tag + c.name;
                    webCategory.Add(c);
                    webCategory.AddRange(GetChildrenTag(c.id, index, tagstr));
                }
            }
            return webCategory;
        }


        /// <summary>
        /// 获取分类
        /// 递归排序
        /// </summary>
        /// <param name="parent_id"></param>
        /// <returns></returns>
        public List<InformtCatg> GetCatgs(string name)
        {
            //查询对象
            Criteria ct = new Criteria();

            //查询表达式
            MutilExpression me = new MutilExpression();

            ct.SetFromTables("tb_info_category")
            .SetFields(new string[] { "*" })
            .AddOrderBy(new OrderBy("order_index", "desc"));

            //名称
            if (!string.IsNullOrEmpty(name))
            {
                me.Add(new SingleExpression("name", LogicOper.LIKE, name));
            }

            //设置查询条件
            if (me.Expressions.Count > 0)
            {
                ct.SetWhereExpression(me);
            }

            //结果集合
            List<InformtCatg> result = new List<InformtCatg>();

            using (ISession s = SessionFactory.Instance.CreateSession())
            {
                //查询数据库所有
                List<InformtCatg> catgs = s.List<InformtCatg>(ct);
                //初始化父级分类
                List<InformtCatg> parents = catgs.Where(m => m.parent_id == 0).ToList();
                //初始化子级分类
                List<InformtCatg> childs = catgs.Where(m => m.parent_id != 0).ToList();
                if (parents.Count > 0)
                {
                    foreach (InformtCatg catg in parents)
                    {
                        result.Add(catg);
                        List<InformtCatg> tmps = GetItemChilds(catg.id, catgs);
                        if (tmps != null) result.AddRange(GetItemChilds(catg.id, catgs));
                    }
                }
                else
                {
                    foreach (InformtCatg catg in childs)
                    {
                        result.Add(catg);
                        List<InformtCatg> tmps = GetItemChilds(catg.id, catgs);
                        if (tmps != null) result.AddRange(GetItemChilds(catg.id, catgs));
                    }
                }

                return result;
            }
        }



        /// <summary>
        /// 获取指定集合子类
        /// </summary>
        /// <param name="id"></param>
        /// <param name="catgs"></param>
        /// <returns></returns>
        public List<InformtCatg> GetItemChilds(long id, List<InformtCatg> catgs)
        {
            if (catgs == null || catgs.Count == 0) return null;

            //结果集合
            List<InformtCatg> result = new List<InformtCatg>();

            //获取子集合
            List<InformtCatg> children = catgs.Where(m => m.parent_id == id).ToList();
            if (children != null && children.Count > 0)
            {
                foreach (InformtCatg c in children)
                {
                    result.Add(c);
                    result.AddRange(GetItemChilds(c.id, catgs));
                }
            }

            return result;
        }



    }
}