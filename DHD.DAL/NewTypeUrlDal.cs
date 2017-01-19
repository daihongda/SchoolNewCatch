using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DHD.ENTITY;
namespace DHD.DAL
{
    public class NewTypeUrlDal
    {
        public MyDataContext db = new MyDataContext();
        public NewTypeUrl Get(int id)
        {
            var NewTypeUrl = db.NewTypeUrls.Find(id);
            return NewTypeUrl;
        }
        public NewTypeUrl Add(NewTypeUrl newNewTypeUrl)
        {
            var NewTypeUrl = db.NewTypeUrls.Add(newNewTypeUrl);
            db.SaveChanges();
            return NewTypeUrl;
        }
        public int AddRange(IEnumerable<NewTypeUrl> NewTypeUrls)
        {
            db.NewTypeUrls.AddRange(NewTypeUrls);
            return db.SaveChanges();
        }
        public int Delete(int id)
        {
            var NewTypeUrl = db.NewTypeUrls.Find(id);
            NewTypeUrl.IsDelete = 1;
            return db.SaveChanges();
        }
        public List<NewTypeUrl> GetAll()
        {
            return db.NewTypeUrls.ToList<NewTypeUrl>();
        }
        public int DeleteRange(string ids)
        {
            List<NewTypeUrl> NewTypeUrls = new List<NewTypeUrl>();
            string[] NewTypeUrlArray = ids.Split(',');
            foreach (var id in NewTypeUrlArray)
            {
                var NewTypeUrl = db.NewTypeUrls.Find(id);
                if (NewTypeUrl != null)
                {
                    db.NewTypeUrls.Remove(NewTypeUrl);
                }
            }
            return db.SaveChanges();
        }
    }
}
