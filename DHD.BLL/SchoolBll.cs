using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DHD.ENTITY;
using DHD.DAL;
namespace DHD.BLL
{
    public class SchoolBll
    {
        public SchoolDal dal = new SchoolDal();
        public School Get(int id)
        {
            var School = dal.Get(id);
            return School;
        }
        public School Add(School newSchool)
        {
            var School = dal.Add(newSchool);
            return School;
        }
        public int AddRange(IEnumerable<School> Schools)
        {
            return dal.AddRange(Schools);
        }
        public int Delete(int id)
        {
            return dal.Delete(id);
        }
        public List<School> GetAll()
        {
            return dal.GetAll();
        }
        public int DeleteRange(string ids)
        {
            return dal.DeleteRange(ids);
        }
        public int Edit(School newSchool)
        {
            return dal.Edit(newSchool);
        }
    }
}
