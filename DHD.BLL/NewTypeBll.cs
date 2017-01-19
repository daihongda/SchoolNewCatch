using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DHD.ENTITY;
using DHD.DAL;
namespace DHD.BLL
{
    public class NewTypeBll
    {
        public NewTypeDal dal = new NewTypeDal();
        public NewType Get(int id)
        {
            var NewType = dal.Get(id);
            return NewType;
        }
        public NewType Add(NewType newNewType)
        {
            var NewType = dal.Add(newNewType);
            return NewType;
        }
        public int AddRange(IEnumerable<NewType> NewTypes)
        {
            return dal.AddRange(NewTypes);
        }
        public int Delete(int id)
        {
            return dal.Delete(id);
        }
        public List<NewType> GetAll()
        {
            return dal.GetAll();
        }
        public int DeleteRange(string ids)
        {
            return dal.DeleteRange(ids);
        } 
    }
}
