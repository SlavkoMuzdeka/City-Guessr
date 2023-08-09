using System;

namespace Kviz.Model
{
    internal class Result
    {

        public String UserName { get; set; }
        public String Res { get; set; }

        public Result(String userName, String result)
        {
            this.UserName = userName;
            this.Res = result;
        }

    }
}
