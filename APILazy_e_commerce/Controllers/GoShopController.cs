using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BataBLL;
using MODEL.shopping;
namespace APILazy_e_commerce.Controllers
{
    public class GoShopController : ApiController
    {
        Bllshop bll = new Bllshop();
        #region 分页
        public PageInfor Get(int CurrentPage = 1, int PageSize = 2) {
            var list = bll.shou();
            var p = new PageInfor();
            p.TotalCount = list.Count();
            if (p.TotalCount==0)
            {
                p.TotalPage = 1;
            }
            else if(p.TotalCount%PageSize==0)
            {
                p.TotalPage = p.TotalCount / PageSize;
            }
            else
            {
                p.TotalPage = (p.TotalCount / PageSize) + 1;
            }

            if (CurrentPage<1)
            {
                CurrentPage = 1;
            }
            if (CurrentPage>p.TotalPage)
            {
                CurrentPage = p.TotalPage;
            }
            p.products = list.Skip(PageSize * (CurrentPage - 1)).Take(PageSize).ToList();
            p.CurrentPage = CurrentPage;
            return p;
        }
        #endregion


        #region 商品显示
        /// <summary>
        ///商品显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Product> shou()
        {
            return bll.shou();
        }
        #endregion

        #region 商品删除
        [HttpGet]
        public int Del(int Pid)
        {
            return bll.Del(Pid);
        }
        #endregion

        [HttpPost]
        public int GDel(string Pid)
        {
            int t = 0;
            Pid = Pid.Substring(0, Pid.Length - 1);//删除字符串最后一个字符
            string[] datalist = Pid.Split(',');
            foreach (var item in datalist)
            {
                int daa = int.Parse(item);
                t = t + bll.Del(daa);
            }
            return t;
        }
    }
}
