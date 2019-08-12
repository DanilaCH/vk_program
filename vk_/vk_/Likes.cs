using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Likes
    {
        public Response response { get; set; }
        public class Response
        {
            public int likes { get; set; }
        }
    }
}
