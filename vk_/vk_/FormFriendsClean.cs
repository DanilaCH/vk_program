using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    public partial class FormFriendsClean : Form
    {
        int count = 0;
        string user_id;
        string friend_id;
        string access_token;
        public FormFriendsClean()
        {
            InitializeComponent();
        }

        private void FormFriendsClean_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://oauth.vk.com/authorize?client_id=6410347&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends+photos+messages&response_type=token&v=5.100&state=123456");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                user_id = textBox1.Text;
                string request = "https://api.vk.com/method/friends.get?user_id=" + user_id + "&fields=name&count=&" + access_token + "&v=5.95";
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));
                FrendsList frendsList = JsonConvert.DeserializeObject<FrendsList>(answer);



                for (int i = 0; i < frendsList.response.count; i++)
                {

                    if (frendsList.response.items[i].deactivated.Contains("deleted") || frendsList.response.items[i].deactivated.Contains("banned"))
                    {
                        friend_id = frendsList.response.items[i].id;
                        //string request2 = "https://api.vk.com/method/friends.delete?user_id=" + friend_id + "&" + access_token +"&v=5.101";
                        //WebClient client2 = new WebClient();
                        //string answer2 = Encoding.UTF8.GetString(client.DownloadData(request2));
                        //GroupName groupName = JsonConvert.DeserializeObject<GroupName>(answer2);
                        count = count + 1;
                        label1.Text = count.ToString();
                    }
                }
            }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            access_token = webBrowser1.Url.ToString();
            if (access_token.Contains("access_token"))
            {
                int pos = access_token.IndexOf("#");
                access_token = access_token.Remove(0, pos + 1);

                pos = access_token.IndexOf("&e");
                access_token = access_token.Remove(pos);
                webBrowser1.Visible = false;


            }
        }
    }
}
