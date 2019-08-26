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
    public partial class FormComments : Form
    {
        string post_id;
         public  string access_token;
        string owner_id;
        string postCount;
        string groupId;
        bool groupYes;
        public FormComments()
        {
            InitializeComponent();
        }

        private void FormComments_Load(object sender, EventArgs e)
        {
          if(Properties.Settings.Default.SavesCommentsGroups == null)
            {

            }
            else
            {
            for (int i = 0; i < Properties.Settings.Default.SavesCommentsGroups.Count; i++)
            {
                owner_id = Properties.Settings.Default.SavesCommentsGroups[i];
                string request2 = "https://api.vk.com/method/groups.getById?group_id=" + owner_id + "&" + access_token + "&v=5.52";
                WebClient client2 = new WebClient();
                string answer2 = Encoding.UTF8.GetString(client2.DownloadData(request2));
                GroupName groupName = JsonConvert.DeserializeObject<GroupName>(answer2);
                string[] texts = new string[3];
                texts[0] = groupName.response[0].name;
                texts[1] = owner_id;
                texts[2] = groupName.response[0].screen_name;
                ListViewItem itm = new ListViewItem(texts);
                listViewGroups.Items.Add(itm);
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

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            if(textBoxGroups.Text != "")
            {
                if (textBoxGroups.Text.Contains("https://vk.com/"))
               {
                textBoxGroups.Text = textBoxGroups.Text.Remove(0, 15);
                owner_id = textBoxGroups.Text;
                string request2 = "https://api.vk.com/method/groups.getById?group_id=" + owner_id + "&" + access_token + "&v=5.52";
                WebClient client2 = new WebClient();
                string answer2 = Encoding.UTF8.GetString(client2.DownloadData(request2));
                GroupName groupName = JsonConvert.DeserializeObject<GroupName>(answer2);
                groupYes = true;
                groupId = groupName.response[0].id;
                for (int i = 0; i < listViewGroups.Items.Count; i++)
                {
                    if (textBoxGroups.Text.Contains(listViewGroups.Items[i].SubItems[2].Text))
                    {
                        MessageBox.Show("Данная группа уже есть в списке");
                        groupYes = false;
                        break;
                    }
                }
                if(groupYes == true)
                {
                if (answer2.Contains("error"))
                {
                    MessageBox.Show("Неверный ID сообщества");
                    owner_id = "";
                }
                else
                {
                        string[] texts = new string[3];
                        texts[0] = groupName.response[0].name;
                        texts[1] = owner_id;
                        texts[2] = groupName.response[0].screen_name;
                    ListViewItem itm = new ListViewItem(texts);
                        listViewGroups.Items.Add(itm);
                }
                }
               }
                else
                {
                    MessageBox.Show("Проверьте правильность введенной вами ссылки");
                }
                
                
            }
        }

        private void buttonDistribution_Click(object sender, EventArgs e)
        {
            
            if(textBoxMessage.Text != "" )
            {
                string request = "https://api.vk.com/method/wall.get?owner_id=-" + groupId  + "&filter=owner&count=" +postCount + "&" +
                       access_token + "&v=5.52";
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));
                GroupList group = JsonConvert.DeserializeObject<GroupList>(answer);
                for(int i = 0;i< group.response.items.Count; i++)
                {
                    post_id = group.response.items[i].id;
                    string request2 = "https://api.vk.com/method/wall.createComment?owner_id=-" + groupId + "&post_id=" + post_id+ "&message=" + textBoxMessage.Text + "&" + access_token + "&v=5.95";
                    WebClient client2 = new WebClient();
                    string answer2 = Encoding.UTF8.GetString(client2.DownloadData(request2));

                }
            }
        }

        private void listViewGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewGroups.SelectedItems.Count > 0)
            {
                textBoxGroups.Text = "https://vk.com/" + listViewGroups.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void FormComments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.SavesCommentsGroups = new System.Collections.Specialized.StringCollection();
            for(int i = 0; i < listViewGroups.Items.Count; i++)
            {
                Properties.Settings.Default.SavesCommentsGroups.Add(listViewGroups.Items[i].SubItems[1].Text);
            }
            Properties.Settings.Default.Save();
        }

        private void textBoxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxCount.Text == "")
            {
                textBoxCount.Text = "1";
            }
            postCount = textBoxCount.Text;
        }

     
        private void button3_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem itm in listViewGroups.SelectedItems)
            {
                listViewGroups.Items.Remove(itm);
            }
        }
    }
}
