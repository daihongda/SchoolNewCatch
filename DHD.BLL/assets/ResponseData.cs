using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHD.BLL.assets
{
    public class ResponseData
    {
        public bool IsSuccess { get; set; }
        public string Msg { get; set; }
        public Object Data { get; set; }
        public ResponseData(string msg,bool isSuccess)
        {
            this.Msg = msg;
            this.IsSuccess = IsSuccess;
        }
        public ResponseData(string msg,bool isSuccess,Object data)
        {
            this.Msg = msg;
            this.IsSuccess = IsSuccess;
            this.Data = data;
        }
    }
}
