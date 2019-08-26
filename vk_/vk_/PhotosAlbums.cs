using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class PhotosAlbums
    {
        public Response response { get; set; }

        public class Item
        {
            public int id { get; set; }
            public int thumb_id { get; set; }
            public int owner_id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public int created { get; set; }
            public int updated { get; set; }
            public int size { get; set; }
            public int thumb_is_last { get; set; }
            public List<string> privacy_view { get; set; }
            public List<string> privacy_comment { get; set; }
        }

        public class Response
        {
            public int count { get; set; }
            public List<Item> items { get; set; }
        }
    }
}
