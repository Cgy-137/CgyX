using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Customer
{
    /// <summary>
    /// 用户订单表
    /// </summary>
    public class Orders
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public int Oid      { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string Oids     { get; set; }
        /// <summary>
        /// 店铺名
        /// </summary>
        public string Odianpu  { get; set; }
        /// <summary>
        /// 买家
        /// </summary>
        public string Omaijia  { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime Otimes   { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        public string Ozhifu   { get; set; }
        /// <summary>
        /// 订单金额
        /// </summary>
        public decimal Osum     { get; set; }
        /// <summary>
        /// 订单类型
        /// </summary>
        public string Otype    { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public bool Ostate   { get; set; }
    }
}
