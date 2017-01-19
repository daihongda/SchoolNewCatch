using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DHD.ENTITY;
namespace DHD.DAL
{
    public class CommentDal
    {
        public MyDataContext db = new MyDataContext();
        public Comment Get(int id)
        {
            var comment = db.Comments.Find(id);
            return comment;
        }
        public Comment Add(Comment newComment)
        {
            var comment = db.Comments.Add(newComment);
            db.SaveChanges();
            return comment;
        }
        public int AddRange(IEnumerable<Comment> comments)
        {
            db.Comments.AddRange(comments);
            return db.SaveChanges();
        }
        public int Delete(int id)
        {
            var comment = db.Comments.Find(id);
            comment.IsDelete = 1;
            return db.SaveChanges();
        }
        public List<Comment> GetAll()
        {
            return db.Comments.ToList<Comment>();
        }
        public int DeleteRange(string ids)
        {
            List<Comment> comments = new List<Comment>();
            string[] commentArray = ids.Split(',');
            foreach (var id in commentArray)
            {
                var comment = db.Comments.Find(id);
                if (comment != null)
                {
                    db.Comments.Remove(comment);
                }
            }
            return db.SaveChanges();
        }
    }
}
