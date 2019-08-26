using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{

    public class UserGet
    {
        public List<Response> response { get; set; }
        public class Response
        {
            public string id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string photo_200 { get; set; }
        }
    }





    public class FrendsList
    {
        public Response response { get; set; }
        public class Item
        {
            public string id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public bool is_closed { get; set; }
            public bool can_access_closed { get; set; }
            public string photo_50 { get; set; }
            public int online { get; set; }
            public string track_code { get; set; }
            public List<int?> lists { get; set; }
            public string deactivated { get; set; }
        }

        public class Response
        {
            public int count { get; set; }
            public List<Item> items { get; set; }
        }
    }


    public class GroupList
    {
        public Response response { get; set; }
        public class Photo
        {
            public int id { get; set; }
            public int album_id { get; set; }
            public int owner_id { get; set; }
            public int user_id { get; set; }
            public string photo_75 { get; set; }
            public string photo_130 { get; set; }
            public string photo_604 { get; set; }
            public string photo_807 { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string text { get; set; }
            public int date { get; set; }
            public string access_key { get; set; }
            public int? post_id { get; set; }
        }

        public class Attachment
        {
            public string type { get; set; }
            public Photo photo { get; set; }
        }

        public class PostSource
        {
            public string type { get; set; }
            public string platform { get; set; }
        }

        public class CopyHistory
        {
            public int id { get; set; }
            public int owner_id { get; set; }
            public int from_id { get; set; }
            public int date { get; set; }
            public string post_type { get; set; }
            public string text { get; set; }
            public List<Attachment> attachments { get; set; }
            public PostSource post_source { get; set; }
        }

        public class PostSource2
        {
            public string type { get; set; }
            public string data { get; set; }
        }

        public class Comments
        {
            public int count { get; set; }
            public int can_post { get; set; }
            public bool groups_can_post { get; set; }
        }

        public class Likes
        {
            public int count { get; set; }
            public int user_likes { get; set; }
            public int can_like { get; set; }
            public int can_publish { get; set; }
        }

        public class Reposts
        {
            public int count { get; set; }
            public int user_reposted { get; set; }
        }

        public class Photo2
        {
            public int id { get; set; }
            public int album_id { get; set; }
            public int owner_id { get; set; }
            public string photo_75 { get; set; }

            public string photo_604 { get; set; }
            public string photo_807 { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string text { get; set; }
            public int date { get; set; }
            public int post_id { get; set; }
        }

        public class Attachment2
        {
            public string type { get; set; }
            public Photo2 photo { get; set; }
        }

        public class Item
        {
            public string id { get; set; }
            public int from_id { get; set; }
            public string owner_id { get; set; }
            public int date { get; set; }
            public string post_type { get; set; }
            public string text { get; set; }
            public List<CopyHistory> copy_history { get; set; }
            public int can_delete { get; set; }
            public int can_pin { get; set; }
            public bool can_archive { get; set; }
            public bool is_archived { get; set; }
            public PostSource2 post_source { get; set; }
            public Comments comments { get; set; }
            public Likes likes { get; set; }
            public Reposts reposts { get; set; }
            public List<Attachment2> attachments { get; set; }
            public string photo_130 { get; set; }
        }

        public class Response
        {
            public int count { get; set; }
            public List<Item> items { get; set; }
        }
    }


    

    public class GroupName
    {
        public List<Response> response { get; set; }
        public class Response
    {
        public string id { get; set; }
        public string name { get; set; }
        public string screen_name { get; set; }
        public int is_closed { get; set; }
        public string type { get; set; }
        public string photo_50 { get; set; }
        public string photo_100 { get; set; }
        public string photo_200 { get; set; }
    }
    }

    


}
