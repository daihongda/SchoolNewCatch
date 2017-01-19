using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DHD.DAL;
using DHD.ENTITY;
namespace DHD.BLL
{
    public class CommentBll
    {
        public CommentDal dal = new CommentDal();
        public Comment Get(int id)
        {
            var comment = dal.Get(id);
            return comment;
        }
        public Comment Add(Comment newComment)
        {
            var comment = dal.Add(newComment);
            return comment;
        }
        public int AddRange(IEnumerable<Comment> comments)
        {
            return dal.AddRange(comments);
        }
        public int Delete(int id)
        {
            return dal.Delete(id);
        }
        public List<Comment> GetAll()
        {
            return dal.GetAll();
        }
        public int DeleteRange(string ids)
        {
            return dal.DeleteRange(ids);
        } 
    }
}
