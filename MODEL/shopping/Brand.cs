using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.shopping
{
    /// <summary>
    /// 品牌表
    /// </summary>
    public class Brand
    {
        /// <summary>
        /// 品牌主键id
        /// </summary>
        public int Bid { get; set; }
        /// <summary>
        /// 品牌分类名称
        /// </summary>
        public string Bname { get; set; }
        /// <summary>
        /// 品牌分类图片
        /// </summary>
        public string Bpicture { get; set; }
    }
}
