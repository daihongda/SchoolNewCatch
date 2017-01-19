using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DHD.ENTITY;
using DHD.DAL;
namespace DHD.BLL
{
    public class NewTypeUrlBll
    {
        public NewTypeUrlDal dal = new NewTypeUrlDal();
        public NewTypeUrl Get(int id)
        {
            var NewTypeUrl = dal.Get(id);
            return NewTypeUrl;
        }
        public NewTypeUrl Add(NewTypeUrl newNewTypeUrl)
        {
            var NewTypeUrl = dal.Add(newNewTypeUrl);
            return NewTypeUrl;
        }
        public int AddRange(IEnumerable<NewTypeUrl> NewTypeUrls)
        {
            return dal.AddRange(NewTypeUrls);
        }
        public int Delete(int id)
        {
            return dal.Delete(id);
        }
        public List<NewTypeUrl> GetAll()
        {
            return dal.GetAll();
        }
        public int DeleteRange(string ids)
        {
            return dal.DeleteRange(ids);
        } 
    }
}
