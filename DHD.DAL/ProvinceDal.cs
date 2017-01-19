using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DHD.ENTITY;
namespace DHD.DAL
{
    public class ProvinceDal
    {
        public MyDataContext db = new MyDataContext();
        public Province Get(int id)
        {
            var Province = db.Provinces.Find(id);
            return Province;
        }
        public Province Add(Province newProvince)
        {
            var Province = db.Provinces.Add(newProvince);
            db.SaveChanges();
            return Province;
        }
        public int AddRange(IEnumerable<Province> Provinces)
        {
            db.Provinces.AddRange(Provinces);
            return db.SaveChanges();
        }
        public int Delete(int id)
        {
            var Province = db.Provinces.Find(id);
            Province.IsDelete = 1;
            return db.SaveChanges();
        }
        public List<Province> GetAll()
        {
            return db.Provinces.ToList<Province>();
        }
        public int DeleteRange(string ids)
        {
            List<Province> Provinces = new List<Province>();
            string[] ProvinceArray = ids.Split(',');
            foreach (var id in ProvinceArray)
            {
                var Province = db.Provinces.Find(id);
                if (Province != null)
                {
                    db.Provinces.Remove(Province);
                }
            }
            return db.SaveChanges();
        }
    }
}
