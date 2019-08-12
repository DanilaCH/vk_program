using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Photo
    {
        public Response response { get; set; }
        public class Item
        {
            public int id { get; set; }
            public int album_id { get; set; }
            public int owner_id { get; set; }
            public List<Size> sizes { get; set; }
            public string text { get; set; }
            public int date { get; set; }
        }

        public class Size
        {
            public string type { get; set; }
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Response
        {
            public int count { get; set; }
            public List<Item> items { get; set; }
        }
    }
}
