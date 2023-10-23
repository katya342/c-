using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLib
{
    public class UserResponse
    {
        public List<UserData> Results { get; set; }
    }

    public class UserData
    {
        public UserPicture Picture { get; set; }
    }

    public class UserPicture
    {
        public string Large { get; set; }

    }
}
