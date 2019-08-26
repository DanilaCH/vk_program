using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Friends1
    {
        public class UserGet
        {
            public List<Response> response { get; set; }
            public class Response
            {
                public int id { get; set; }
                public string first_name { get; set; }
                public string last_name { get; set; }
                public string photo_200 { get; set; }
            }
        }


        public class FriendList
        {
            public Response response { get; set; }
            public class Response
            {
                public int count { get; set; }
                public List<Item> items { get; set; }
            }
            public class Item
            {
                public int id { get; set; }
                public string first_name { get; set; }
                public string last_name { get; set; }
                public bool is_closed { get; set; }
                public bool can_access_closed { get; set; }
                public string photo_200 { get; set; }
                public int online { get; set; }
                public string track_code { get; set; }
                public string deactivated { get; set; }
            }


        }
    }
}
