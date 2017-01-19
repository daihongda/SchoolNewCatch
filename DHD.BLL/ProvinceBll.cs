using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DHD.ENTITY;
using DHD.DAL;
namespace DHD.BLL
{
    public class ProvinceBll
    {
        public ProvinceDal dal = new ProvinceDal();
        public Province Get(int id)
        {
            var Province = dal.Get(id);
            return Province;
        }
        public Province Add(Province newProvince)
        {
            var Province = dal.Add(newProvince);
            return Province;
        }
        public int AddRange(IEnumerable<Province> Provinces)
        {
            return dal.AddRange(Provinces);
        }
        public int Delete(int id)
        {
            return dal.Delete(id);
        }
        public List<Province> GetAll()
        {
            return dal.GetAll();
        }
        public int DeleteRange(string ids)
        {
            return dal.DeleteRange(ids);
        } 
    }
}
