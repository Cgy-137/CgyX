using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.shopping;
namespace MODEL
{
    public class PageInfor
    {
        //当前页
        public int CurrentPage { get; set; }
        /// <summary>
        ///总页数
        /// </summary>
        public int TotalPage { get; set; }
        /// <summary>
        /// 总记录数
        /// </summary>
        public int TotalCount { get; set; }
        public List<Product> products {get; set; }
    }
}
