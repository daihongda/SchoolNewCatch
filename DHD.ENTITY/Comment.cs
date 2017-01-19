using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHD.ENTITY
{
    public class Comment
    {
        /// <summary>
        /// 评论ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 评论标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 评论发布时间
        /// </summary>
        public DateTime PublishTime { get; set; }
        /// <summary>
        /// 评论作者
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// 高校新闻ID
        /// </summary>
        public int SchoolNewId { get; set; }
        /// <summary>
        /// 父级评论ID
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public int IsDelete { get; set; }
    }
}
