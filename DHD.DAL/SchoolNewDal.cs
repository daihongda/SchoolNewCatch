using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DHD.ENTITY;
namespace DHD.DAL
{
    public class SchoolNewDal
    {
        public MyDataContext db = new MyDataContext();
        public SchoolNew Get(int id)
        {
            var SchoolNew = db.SchoolNews.Find(id);
            return SchoolNew;
        }
        public SchoolNew Add(SchoolNew newSchoolNew)
        {
            var SchoolNew = db.SchoolNews.Add(newSchoolNew);
            db.SaveChanges();
            return SchoolNew;
        }
        public int AddRange(IEnumerable<SchoolNew> SchoolNews)
        {
            db.SchoolNews.AddRange(SchoolNews);
            return db.SaveChanges();
        }
        public int Delete(int id)
        {
            var SchoolNew = db.SchoolNews.Find(id);
            SchoolNew.IsDelete = 1;
            return db.SaveChanges();
        }
        public List<SchoolNew> GetAll()
        {
            return db.SchoolNews.ToList<SchoolNew>();
        }
        public int DeleteRange(string ids)
        {
            List<SchoolNew> SchoolNews = new List<SchoolNew>();
            string[] SchoolNewArray = ids.Split(',');
            foreach (var id in SchoolNewArray)
            {
                var SchoolNew = db.SchoolNews.Find(id);
                if (SchoolNew != null)
                {
                    db.SchoolNews.Remove(SchoolNew);
                }
            }
            return db.SaveChanges();
        }
    }
}
