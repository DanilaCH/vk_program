using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Messages
    {
        public class Peer
        {
            public int id { get; set; }
            public string type { get; set; }
            public int local_id { get; set; }
        }

        public class CanWrite
        {
            public bool allowed { get; set; }
        }

        public class Conversation
        {
            public Peer peer { get; set; }
            public int in_read { get; set; }
            public int out_read { get; set; }
            public int last_message_id { get; set; }
            public int unread_count { get; set; }
            public bool unanswered { get; set; }
            public CanWrite can_write { get; set; }
        }

        public class LastMessage
        {
            public int date { get; set; }
            public int from_id { get; set; }
            public int id { get; set; }
            public int @out { get; set; }
            public int peer_id { get; set; }
            public string text { get; set; }
            public int conversation_message_id { get; set; }
            public List<object> fwd_messages { get; set; }
            public bool important { get; set; }
            public int random_id { get; set; }
            public List<object> attachments { get; set; }
            public bool is_hidden { get; set; }
        }

        public class Item
        {
            public Conversation conversation { get; set; }
            public LastMessage last_message { get; set; }
        }

        public class Response
        {
            public int count { get; set; }
            public List<Item> items { get; set; }
            public int unread_count { get; set; }
        }


        public Response response { get; set; }
    }
}
