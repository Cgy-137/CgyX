using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.shopping
{
    /// <summary>
    /// 商品管理表
    /// </summary>
    public class Product
    {
        /// <summary>
        /// 商品id
        /// </summary>
        public int Pid { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Pname { get; set; }
        /// <summary>
        /// 商品分类（外键）
        /// </summary>
        public int Ptype { get; set; }
        /// <summary>
        /// 商品分类名称
        /// </summary>
        public string Sname { get; set; }
        /// <summary>
        /// 分类图片
        /// </summary>
        public string Spicture { get; set; }
        /// <summary>
        /// 商品品牌（外键）
        /// </summary>
        public int Ppinpai { get; set; }
        /// <summary>
        /// 品牌分类名称
        /// </summary>
        public string Bname { get; set; }
        /// <summary>
        /// 品牌分类图片
        /// </summary>
        public string Bpicture { get; set; }
        /// <summary>
        /// 商品库存
        /// </summary>
        public int Pkucun { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        public decimal Pprice { get; set; }
        /// <summary>
        /// 商品市场价格
        /// </summary>
        public decimal Pmarket { get; set; }
        /// <summary>
        /// 商品单位
        /// </summary>
        public string Pdanwei { get; set; }
        /// <summary>
        /// 商品货号
        /// </summary>
        public string Phuohao { get; set; }
        /// <summary>
        /// 商品规格
        /// </summary>
        public string Pguige { get; set; }
        /// <summary>
        ///商品单位内重量
        /// </summary>
        public string Pzhong { get; set; }
        /// <summary>
        /// 商品运费
        /// </summary>
        public decimal Pyunfei { get; set; }
        /// <summary>
        /// 商品状态
        /// </summary>
        public bool Pstate { get; set; }
        

        public virtual PageInfor PageInfor { get; set; }

    }
}
