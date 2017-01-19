using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHD.ENTITY
{
    public class Configure
    {
        /// <summary>
        /// 配置ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 新闻列表路径
        /// </summary>
        public string ListPath { get; set; }
        /// <summary>
        /// 新闻链接路径
        /// </summary>
        public string HrefPath { get; set; }
        /// <summary>
        /// 新闻标题路径
        /// </summary>
        public string TitlePath { get; set; }
        /// <summary>
        /// 新闻发表时间路径
        /// </summary>
        public string TimePath { get; set; }
        /// <summary>
        /// 新闻内容路径
        /// </summary>
        public string ContentPath { get; set; }
        /// <summary>
        /// 高校ID
        /// </summary>
        public int SchoolId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public int IsDelete { get; set; }
    }
}
