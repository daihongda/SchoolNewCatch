using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DHD.ENTITY;
namespace DHD.DAL
{
    public class NewTypeDal
    {
        public MyDataContext db = new MyDataContext();
        public NewType Get(int id)
        {
            var NewType = db.NewTypes.Find(id);
            return NewType;
        }
        public NewType Add(NewType newNewType)
        {
            var NewType = db.NewTypes.Add(newNewType);
            db.SaveChanges();
            return NewType;
        }
        public int AddRange(IEnumerable<NewType> NewTypes)
        {
            db.NewTypes.AddRange(NewTypes);
            return db.SaveChanges();
        }
        public int Delete(int id)
        {
            var NewType = db.NewTypes.Find(id);
            NewType.IsDelete = 1;
            return db.SaveChanges();
        }
        public List<NewType> GetAll()
        {
            return db.NewTypes.ToList<NewType>();
        }
        public int DeleteRange(string ids)
        {
            List<NewType> NewTypes = new List<NewType>();
            string[] NewTypeArray = ids.Split(',');
            foreach (var id in NewTypeArray)
            {
                var NewType = db.NewTypes.Find(id);
                if (NewType != null)
                {
                    db.NewTypes.Remove(NewType);
                }
            }
            return db.SaveChanges();
        }
    }
}
