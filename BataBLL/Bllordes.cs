using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.Customer;
using DataDal;
namespace BataBLL
{
    public class Bllordes
    {
        DalOrders dal = new DalOrders();
        /// <summary>
        /// 显示用户订单
        /// </summary>
        /// <returns></returns>
        public List<Orders> Oshou()
        {
            return dal.Oshou();
        }
        #region 商品删除
        /// <summary>
        /// 商品删除
        /// </summary>
        /// <param name="Pid"></param>
        /// <returns></returns>
        public int Dels(int Oid)
        {
            return dal.Dels(Oid);
        }
        #endregion
    }
}
