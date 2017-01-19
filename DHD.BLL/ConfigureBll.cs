using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DHD.ENTITY;
using DHD.DAL;
namespace DHD.BLL
{
    public class ConfigureBll
    {
        public ConfigureDal dal = new ConfigureDal();
        public Configure Get(int id)
        {
            var Configure = dal.Get(id);
            return Configure;
        }
        public Configure Add(Configure newConfigure)
        {
            var Configure = dal.Add(newConfigure);
            return Configure;
        }
        public int AddRange(IEnumerable<Configure> Configures)
        {
            return dal.AddRange(Configures);
        }
        public int Delete(int id)
        {
            return dal.Delete(id);
        }
        public List<Configure> GetAll()
        {
            return dal.GetAll();
        }
        public int DeleteRange(string ids)
        {
            return dal.DeleteRange(ids);
        } 
    }
}
