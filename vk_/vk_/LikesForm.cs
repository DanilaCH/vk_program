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
using System.Collections.ObjectModel;

namespace WindowsFormsApplication1
{
    public partial class LikesForm : Form
    {
        public string Access_token;
        public string User_id;
        string Owner_id;
        string IdPhoto;




        Collection<UserGet> UserColl = new Collection<UserGet>();
        public LikesForm()
        {
            InitializeComponent();
        }

        private void LikesForm_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = new Image(
        }

        private void LikeButtom_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                string request = "https://api.vk.com/method/photos.getAlbums?owner_id=" + textBox1.Text + "&" +
                        Access_token + "&v=5.52";
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));

                PhotosAlbums user = JsonConvert.DeserializeObject<PhotosAlbums>(answer);


                string[] texts = new string[user.response.count];
                listView1.Items.Clear();
                foreach (PhotosAlbums.Item item in user.response.items)
                {
                    texts[0] = item.title;
                    texts[1] = item.id.ToString();
                    ListViewItem lvi = new ListViewItem(texts);
                    listView1.Items.Add(lvi);
                }

                Owner_id = textBox1.Text;
                SearchButton.Visible = false;
                SearchFriends.Visible = false;
                button1.Visible = true;
                textBox1.Text = "";
                label1.Text = "Введите ID альбома";
                columnHeader1.Text = "Номер фотографии";
                columnHeader2.Text = "ID Фотографии";
            }
            else
            {
                string Name = listView1.SelectedItems[0].SubItems[0].Text;
                string id = listView1.SelectedItems[0].SubItems[1].Text;

                textBox1.Text = id;


                string request = "https://api.vk.com/method/photos.getAlbums?owner_id=" + textBox1.Text + "&" +
                        Access_token + "&v=5.52";
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));

                PhotosAlbums user = JsonConvert.DeserializeObject<PhotosAlbums>(answer);

                int CountPhotoAlbums = user.response.count;
                string[] texts = new string[CountPhotoAlbums];
                listView1.Items.Clear();
                foreach (PhotosAlbums.Item item in user.response.items)
                {
                    texts[0] = item.title;
                    texts[1] = item.id.ToString();
                    ListViewItem lvi = new ListViewItem(texts);
                    listView1.Items.Add(lvi);
                }

                Owner_id = textBox1.Text;
                SearchButton.Visible = false;
                SearchFriends.Visible = false;
                button1.Visible = true;
                textBox1.Text = "";
                label1.Text = "Введите ID альбома";
                columnHeader1.Text = "Номер фотографии";
                columnHeader2.Text = "ID Фотографии";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {

            }
            else
            {
                string Name = listView1.SelectedItems[0].SubItems[0].Text;
                string id = listView1.SelectedItems[0].SubItems[1].Text;

                textBox1.Text = id;

                string request = "https://api.vk.com/method/photos.get?owner_id=" + Owner_id + "&album_id=" + textBox1.Text + "&" +
                        Access_token + "&v=5.52";
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));

                Photo user2 = JsonConvert.DeserializeObject<Photo>(answer);
                int CountPhoto = 1;

                int CountPhotos = user2.response.count;
                string[] texts2 = new string[CountPhotos];
                listView1.Items.Clear();
                foreach (Photo.Item item in user2.response.items)
                {
                    texts2[0] = CountPhoto.ToString();
                    texts2[1] = item.id.ToString();

                    ListViewItem lvi = new ListViewItem(texts2);
                    listView1.Items.Add(lvi);
                    CountPhoto++;
                }



                button1.Visible = false;
                LikeButton.Visible = true;
                button2.Visible = true;
                textBox1.Text = "";
                label1.Text = "Введите ID Фотографии";
            }
        }

        private void LikeButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {

            }
            else
            {
                string Name = listView1.SelectedItems[0].SubItems[0].Text;
                string id = listView1.SelectedItems[0].SubItems[1].Text;

                textBox1.Text = id;


                string request = "https://api.vk.com/method/likes.add?type=photo&owner_id=" + Owner_id + "&item_id=" + textBox1.Text + "&" +
                        Access_token + "&v=5.52";
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));

                Photo user2 = JsonConvert.DeserializeObject<Photo>(answer);

                textBox2.Text = "Лайк поставлен!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem id in listView1.Items)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(333);
                IdPhoto = id.SubItems[1].Text;

                string request = "https://api.vk.com/method/likes.add?type=photo&owner_id=" + Owner_id + "&item_id=" + IdPhoto.ToString() + "&" +
                        Access_token + "&v=5.52";
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));

                Photo user2 = JsonConvert.DeserializeObject<Photo>(answer);

                textBox2.Text = "Лайк поставлен!";
                textBox1.Text = textBox1.Text + "\r\n" + answer;
            }
        }

        private void SearchFriends_Click(object sender, EventArgs e)
        {
            string request = "https://api.vk.com/method/friends.get?user_id=" + User_id + "&order_name&fields=nickname&" + Access_token + "&v=5.52";
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(request));

            Friends user = JsonConvert.DeserializeObject<Friends>(answer);

            int CountFriends = user.response.count;
            string[] texts = new string[CountFriends];
            foreach (Friends.Item item in user.response.items)
            {
                texts[0] = item.first_name + " " + item.last_name;
                texts[1] = item.id.ToString();
                ListViewItem lvi = new ListViewItem(texts);
                listView1.Items.Add(lvi);

                SearchFriends.Visible = false;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Help.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Help.Visible = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SearchButton.Visible = true;
            SearchFriends.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            LikeButton.Visible = false;
            label1.Text = "Введите ID пользователя";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
