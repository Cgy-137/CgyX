using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.shopping;
using DataDal;
namespace BataBLL
{
    public class Bllshop
    {
        Dalshopping dal = new Dalshopping();
        #region 商品显示
        /// <summary>
        ///商品显示
        /// </summary>
        /// <returns></returns>
        public List<Product> shou()
        {
            return dal.shou();
        }
        #endregion

        #region 商品删除
        public int Del(int Pid)
        {
            return dal.Del(Pid);
        }
        #endregion
    }
}
