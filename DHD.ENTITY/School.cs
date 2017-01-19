using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHD.ENTITY
{
    public class School
    {
        /// <summary>
        /// 高校ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 高校名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 高校介绍
        /// </summary>
        public string Introduce { get; set; }
        /// <summary>
        /// 高校主页
        /// </summary>
        public string HomePage { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public int IsDelete { get; set; }
    }
}
