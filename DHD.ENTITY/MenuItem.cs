using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHD.ENTITY
{
    public class MenuItem
    {
        /// <summary>
        /// 菜单项Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 菜单项名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 菜单项的父级
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 菜单项的跳转地址
        /// </summary>
        public string Href { get; set; }
    }
}
