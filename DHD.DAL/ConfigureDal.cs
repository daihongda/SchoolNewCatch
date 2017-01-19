using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DHD.ENTITY;
namespace DHD.DAL
{
    public class ConfigureDal
    {
        public MyDataContext db = new MyDataContext();
        public Configure Get(int id)
        {
            var Configure = db.Configures.Find(id);
            return Configure;
        }
        public Configure Add(Configure newConfigure)
        {
            var Configure = db.Configures.Add(newConfigure);
            db.SaveChanges();
            return Configure;
        }
        public int AddRange(IEnumerable<Configure> Configures)
        {
            db.Configures.AddRange(Configures);
            return db.SaveChanges();
        }
        public int Delete(int id)
        {
            var Configure = db.Configures.Find(id);
            Configure.IsDelete = 1;
            return db.SaveChanges();
        }
        public List<Configure> GetAll()
        {
            return db.Configures.ToList<Configure>();
        }
        public int DeleteRange(string ids)
        {
            List<Configure> Configures = new List<Configure>();
            string[] ConfigureArray = ids.Split(',');
            foreach (var id in ConfigureArray)
            {
                var Configure = db.Configures.Find(id);
                if (Configure != null)
                {
                    db.Configures.Remove(Configure);
                }
            }
            return db.SaveChanges();
        }
    }
}
