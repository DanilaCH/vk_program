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
    public partial class Form1 : Form
    {
        string access_token;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            access_token = webBrowserAutorization.Url.ToString();
            if (access_token.Contains("access_token"))
            {
                int pos = access_token.IndexOf("#");
                access_token = access_token.Remove(0, pos + 1);

                pos = access_token.IndexOf("&e");
                access_token = access_token.Remove(pos);
                webBrowserAutorization.Visible = false;

                string request = "https://api.vk.com/method/users.get?fields=photo_200&" +
                    access_token + "&v=5.52";
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));

                UserGet user = JsonConvert.DeserializeObject<UserGet>(answer);

                labelFirstName.Text = user.response[0].first_name;
                labelLastName.Text = user.response[0].last_name;

                pictureBoxAvatar.Load(user.response[0].photo_200);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowserAutorization.BringToFront();
            webBrowserAutorization.Navigate("https://oauth.vk.com/authorize?client_id=6410347&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends+photos+messages&response_type=token&v=5.100&state=123456");
        }

        private void buttonSpam_Click(object sender, EventArgs e)
        {
            FormSpam Spam = new FormSpam();
            Spam.Show();
        }

    }
}
