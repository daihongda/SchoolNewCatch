using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DHD.BLL;
using DHD.ENTITY;
namespace SchoolNewCatch.Controllers
{
    /// <summary>
    /// 高校信息的控制器
    /// </summary>
    public class SchoolController : Controller
    {
        private SchoolBll bll = new SchoolBll();
        // GET: School
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            var school = bll.Get(id);
            if(school == null)
            {
                school = new School();
            }
            return View(school);
        }
        public int EditSchool(School newSchool)
        {
            return bll.Edit(newSchool);
        }
    }
}