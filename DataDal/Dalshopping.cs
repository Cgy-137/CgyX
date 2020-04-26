using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.shopping;
namespace DataDal
{
    public class Dalshopping
    {
        #region 商品显示
        /// <summary>
        ///商品显示
        /// </summary>
        /// <returns></returns>
        public List<Product> shou()
        {
            //获取sql语句
            string sql = string.Format("select * from Product as pp join ShopType as ss on pp.Ptype=ss.Sid join Brand as bb on pp.Ppinpai=bb.Bid");
            //返回
            return DBHelper.GetToList<Product>(sql);
        }
        #endregion

        #region 商品删除
        /// <summary>
        /// 商品删除
        /// </summary>
        /// <param name="Pid"></param>
        /// <returns></returns>
        public int Del(int Pid) {
            string sql = string.Format("delete from Product where Pid in ({0})", Pid);
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion


    }
}
