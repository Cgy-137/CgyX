using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MODEL.Customer;
using BataBLL;
namespace APILazy_e_commerce.Controllers
{
    public class CustomerController : ApiController
    {
        Bllordes bll = new Bllordes();

        /// <summary>
        /// 显示用户订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Orders> Oshou()
        {
            return bll.Oshou();
        }
        #region 商品删除
        /// <summary>
        /// 商品删除
        /// </summary>
        /// <param name="Pid"></param>
        /// <returns></returns>
        [HttpGet]
        public int Dels(int Oid)
        {
            return bll.Dels(Oid);
        }
        [HttpPost]
        public int Delss(string Oid)
        {
            int t = 0;
            Oid = Oid.Substring(0, Oid.Length - 1);//删除字符串最后一个字符
            string[] datalist = Oid.Split(',');
            foreach (var item in datalist)
            {
                int daa = int.Parse(item);
                t = t + bll.Dels(daa);
            }
            return t;
        }
        #endregion
    }
}
