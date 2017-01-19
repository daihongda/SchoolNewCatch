using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DHD.ENTITY;
namespace DHD.DAL
{
    public class SchoolDal
    {
        public MyDataContext db = new MyDataContext();
        public School Get(int id)
        {
            try
            {
                School School = db.Schools.Find(id);
                return School;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public School Add(School newSchool)
        {
            var School = db.Schools.Add(newSchool);
            db.SaveChanges();
            return School;
        }
        public int AddRange(IEnumerable<School> Schools)
        {
            db.Schools.AddRange(Schools);
            return db.SaveChanges();
        }
        public int Delete(int id)
        {
            var School = db.Schools.Find(id);
            School.IsDelete = 1;
            return db.SaveChanges();
        }
        public List<School> GetAll()
        {
            return db.Schools.ToList<School>();
        }
        public int DeleteRange(string ids)
        {
            List<School> Schools = new List<School>();
            string[] SchoolArray = ids.Split(',');
            foreach (var id in SchoolArray)
            {
                var School = db.Schools.Find(id);
                if (School != null)
                {
                    db.Schools.Remove(School);
                }
            }
            return db.SaveChanges();
        }
        public int Edit(School newSchool)
        {

            var school = db.Schools.Find(newSchool.Id);
            school.HomePage = newSchool.HomePage;
            school.Introduce = newSchool.Introduce;
            school.Name = newSchool.Name;
            return db.SaveChanges();
        }
    }
}
