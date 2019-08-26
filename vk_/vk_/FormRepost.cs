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
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class FormRepost : Form 
    {
        int pos;
        bool groupYes;
        bool LoadGroup;
        string post_id;
        string user_id;
        string owner_id;
        string NameGroup;
        public  string access_token;

        public FormRepost()
        {
            InitializeComponent();
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {

            if (textBoxGroup != null)
            {
                if (textBoxGroup.Text.Contains("https://vk.com/"))
                {
                    textBoxGroup.Text = textBoxGroup.Text.Remove(0, 15);
                    owner_id = textBoxGroup.Text;
                    string request2 = "https://api.vk.com/method/groups.getById?group_id=" + owner_id + "&" + access_token + "&v=5.52";
                    WebClient client2 = new WebClient();
                    string answer2 = Encoding.UTF8.GetString(client2.DownloadData(request2));
                    GroupName groupName = JsonConvert.DeserializeObject<GroupName>(answer2);
                    NameGroup = groupName.response[0].id;
                    string request = "https://api.vk.com/method/wall.get?owner_id=-" + NameGroup + "&filter=owner&" +
                            access_token + "&v=5.52";
                    WebClient client = new WebClient();
                    string answer = Encoding.UTF8.GetString(client.DownloadData(request));
                    GroupList group = JsonConvert.DeserializeObject<GroupList>(answer);
                    groupYes = true;
                    for (int i = 0; i < listViewGroups.Items.Count; i++)
                    {
                        if (textBoxGroup.Text.Contains(listViewGroups.Items[i].SubItems[2].Text))
                        {
                            MessageBox.Show("Данная группа уже есть в списке");
                            groupYes = false;
                            break;
                        }
                    }
                    if (groupYes == true)
                    {
                        if (answer.Contains("error"))
                        {
                            MessageBox.Show("Неверный ID сообщества");
                            owner_id = "";
                        }
                        else
                        {
                            if (group.response.items.Count == 0)
                            {
                                MessageBox.Show("Неверный ID сообщества");
                                owner_id = "";
                            }
                            else
                            {
                                post_id = "wall" + group.response.items[0].owner_id + "_" + group.response.items[0].id;
                                string[] texts = new string[3];
                                texts[0] = groupName.response[0].name;
                                texts[1] = groupName.response[0].id;
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
            // Куйбышева 23 3 этаж


        }
        private void FormRepost_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.SavesGroups == null)
            {

            }
            for (int i = 0; i < Properties.Settings.Default.SavesGroups.Count; i++)
            {
                try
                {

                    owner_id = Properties.Settings.Default.SavesGroups[i];
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
                catch
                { }


            }




            //8198
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //access_token = webBrowserAutorization.Url.ToString();
            if (access_token.Contains("access_token"))
            {
                int pos = access_token.IndexOf("#");
                access_token = access_token.Remove(0, pos + 1);

                pos = access_token.IndexOf("&e");
                access_token = access_token.Remove(pos);
                //webBrowserAutorization.Visible = false;
                
              
            }
        }

      

        private void buttonResost_Click(object sender, EventArgs e)
        {
            string request = "https://api.vk.com/method/wall.repost?group_id=" +"&object=" + post_id + "&" + access_token + "&v=5.95";
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(request));
            if (answer.Contains("error"))
            {
                MessageBox.Show("Проверьте правильность введенных вами данных");
                user_id = "";
                owner_id = "";
            }

        }

      

        private void listViewGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
          if(listViewGroups.SelectedItems.Count > 0)
            {
                textBoxGroup.Text = "https://vk.com/" + listViewGroups.SelectedItems[0].SubItems[2].Text;
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemGroup in listViewGroups.SelectedItems)
            {
                listViewGroups.Items.Remove(itemGroup);
            }
        }

      

        private void FormRepost_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.SavesGroups = new System.Collections.Specialized.StringCollection();


            for (int i = 0; i < listViewGroups.Items.Count; i++)
            {
              Properties.Settings.Default.SavesGroups.Add(listViewGroups.Items[i].SubItems[1].Text);
            }
            Properties.Settings.Default.Save();
        }

        
    }
}