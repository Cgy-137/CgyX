using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.shopping
{
    /// <summary>
    /// 商品分类
    /// </summary>
    public class ShopType
    {
        /// <summary>
        /// 商品分类主键id
        /// </summary>
        public int Sid { get; set; }
        /// <summary>
        ///商品分裂名称
        /// </summary>
        public string Sname { get; set; }
        /// <summary>
        /// 分类图片
        /// </summary>
        public string Spicture { get; set; }
    }
}
