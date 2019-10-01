using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Photo
    {
        public class Item
        {
            public int id { get; set; }
            public int album_id { get; set; }
            public int owner_id { get; set; }
            public string photo_75 { get; set; }
            public string photo_130 { get; set; }
            public string photo_604 { get; set; }
            public string photo_807 { get; set; }
            public string photo_1280 { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string text { get; set; }
            public int date { get; set; }
            public string photo_2560 { get; set; }
        }

        public class Response
        {
            public int count { get; set; }
            public List<Item> items { get; set; }
        }
        public Response response { get; set; }
    }
}


