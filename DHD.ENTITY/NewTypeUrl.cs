using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DHD.ENTITY
{
    public class NewTypeUrl
    {
        /// <summary>
        /// 高校ID
        /// </summary>
         [Key, Column(Order = 1)]
        public int SchoolId { get; set; }
        /// <summary>
        /// 新闻类型ID
        /// </summary>
        [Key, Column(Order = 2)]
        public int NewTypeId { get; set; }
        /// <summary>
        /// 高校对应新闻分类的地址
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public int IsDelete { get; set; }
    }
}
