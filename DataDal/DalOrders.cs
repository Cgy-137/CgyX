using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.Customer;
using System.Data.SqlClient;

namespace DataDal
{
    public class DalOrders
    {
        /// <summary>
        /// 显示用户订单
        /// </summary>
        /// <returns></returns>
        public List<Orders> Oshou() {
            List<Orders> list = new List<Orders>();
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Lazy_e_commerce;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText= "select* from Orders";
            var re = command.ExecuteReader();
            while (re.Read())
            {
                Orders md = new Orders() {
                    Oid = Convert.ToInt32(re["Oid"]),
                    Oids = Convert.ToString(re["Oids"]),
                    Odianpu = Convert.ToString(re["Odianpu"]),
                    Omaijia = Convert.ToString(re["Omaijia"]),
                    Otimes = Convert.ToDateTime(re["Otimes"]),
                    Ozhifu = Convert.ToString(re["Ozhifu"]),
                    Osum = Convert.ToDecimal(re["Osum"]),
                    Otype = Convert.ToString(re["Otype"]),
                    Ostate = Convert.ToBoolean(re["Ostate"]),
                };
                list.Add(md);
            }
            connection.Close();
            return list;

        }
        #region 商品删除
        /// <summary>
        /// 商品删除
        /// </summary>
        /// <param name="Pid"></param>
        /// <returns></returns>
        public int Dels(int Oid)
        {
            string sql = string.Format("delete from Orders where Oid in ({0})", Oid);
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion
    }
}
