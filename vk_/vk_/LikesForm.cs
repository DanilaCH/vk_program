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
        int LikesCount = 0;




        Collection<UserGet> UserColl = new Collection<UserGet>();
        public LikesForm()
        {
            InitializeComponent();
        }

        private void LikeButtom_Click(object sender, EventArgs e)
        {
            //if (listView1.SelectedItems.Count == 0)
            //{
            //    string request = "https://api.vk.com/method/photos.getAlbums?owner_id=" + textBox1.Text + "&" +
            //            Access_token + "&v=5.52";
            //    WebClient client = new WebClient();
            //    string answer = Encoding.UTF8.GetString(client.DownloadData(request));

            //    PhotosAlbums user = JsonConvert.DeserializeObject<PhotosAlbums>(answer);


            //    string[] texts = new string[user.response.count];
            //    listView1.Items.Clear();
            //    foreach (PhotosAlbums.Item item in user.response.items)
            //    {
            //        texts[0] = item.title;
            //        texts[1] = item.id.ToString();
            //        ListViewItem lvi = new ListViewItem(texts);
            //        listView1.Items.Add(lvi);
            //    }

            //    Owner_id = textBox1.Text;
            //    SearchButton.Visible = false;
            //    SearchFriends.Visible = false;
            //    button1.Visible = true;
            //    textBox1.Text = "";
            //    label1.Text = "Введите ID альбома";
            //    columnHeader1.Text = "Название альбома";
            //    columnHeader2.Text = "ID альбома";
            //}
            //else
            //{
            if (listView1.SelectedItems.Count == 0)
            {

            }
            else
            {
                listView1.View = View.Details;
                imageList1.ImageSize = new Size(35, 35);

                string Name = listView1.SelectedItems[0].SubItems[0].Text;
                string id = listView1.SelectedItems[0].SubItems[1].Text;

                textBox1.Text = id;


                string request = "https://api.vk.com/method/photos.getAlbums?owner_id=" + textBox1.Text + "&" +
                        Access_token + "&v=5.52";
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));

                PhotosAlbums user = JsonConvert.DeserializeObject<PhotosAlbums>(answer);

                //int CountPhotoAlbums = user.response.count;
                string[] texts = new string[2];
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
                columnHeader1.Text = "Название альбома";
                columnHeader2.Text = "ID альбома";
                UsersSearchB.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
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
                imageList1.ImageSize = new Size(70, 70);
                foreach (Photo.Item item in user2.response.items)
                {
                    Application.DoEvents();
                    try
                    {
                        pictureBox1.Load(item.photo_1280);

                    }
                    catch
                    {
                        pictureBox1.Load(Application.StartupPath + @"\help.png");
                    }

                    imageList1.Images.Add(pictureBox1.Image);
                    texts2[0] = CountPhoto.ToString();
                    texts2[1] = item.id.ToString();

                    ListViewItem lvi = new ListViewItem(texts2, imageList1.Images.Count - 1);
                    listView1.Items.Add(lvi);
                    CountPhoto++;
                }



                button1.Visible = false;
                LikeButton.Visible = true;
                button2.Visible = true;
                textBox1.Text = "";
                label1.Text = "Введите ID Фотографии";
                columnHeader1.Text = "Номер фотографии";
                columnHeader2.Text = "ID фотографии";
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
                //textBox2.Text = "Лайк поставлен!";
                textBox1.Text = textBox1.Text + "\r\n" + answer;
                LikesCount++;
            }
            textBox2.Text = "поставлено лайков - " + LikesCount.ToString();
            LikesCount = 0;
        }

        private void SearchFriends_Click(object sender, EventArgs e)
        {
            string request = "https://api.vk.com/method/friends.get?user_id=" + User_id + "&order_name&fields=nickname,photo_200_orig&" + Access_token + "&v=5.52";
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(request));

            Friends user = JsonConvert.DeserializeObject<Friends>(answer);

            int CountFriends = user.response.count;
            string[] texts = new string[CountFriends];

            listView1.Items.Clear();
            imageList1.ImageSize = new Size(70, 70);
            foreach (Friends.Item item in user.response.items)
            {
                Application.DoEvents();
                try
                {
                    pictureBox1.Load(item.photo_200_orig);
                    
                }
                catch
                {
                    pictureBox1.Load(Application.StartupPath + @"\Photo2.png");
                }
                imageList1.Images.Add(pictureBox1.Image);

                texts[0] = item.first_name + " " + item.last_name;
                texts[1] = item.id.ToString();
                ListViewItem lvi = new ListViewItem(texts, imageList1.Images.Count-1);
                listView1.Items.Add(lvi);

                SearchFriends.Visible = false;
                SearchButton.Enabled = true;
                textBox1.Visible = false;
                textBox3.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                textBox1.Text = "";
                textBox3.Text = "";
                UsersSearchB.Visible = false;
            }
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
            textBox1.Visible = true;
            textBox3.Visible = true;
            UsersSearchB.Enabled = true;
            SearchButton.Enabled = false;
            listView1.View = View.List;
            UsersSearchB.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Visible = true;
            label2.Visible = true;
        }

        private void UsersSearch_Click(object sender, EventArgs e)
        {
            string request = "https://api.vk.com/method/users.search?q=" + textBox1.Text + "&hometown=" + textBox3.Text + "&fields=photo_200_orig&" + Access_token + "&v=5.52";
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(request));

            UsersSearch user = JsonConvert.DeserializeObject<UsersSearch>(answer);

            string[] texts1 = new string[2];
            listView1.Items.Clear();
            imageList1.ImageSize = new Size(70, 70);
            foreach (UsersSearch.Item ID in user.response.items)
            {
                try
                {
                    Application.DoEvents();
                    try
                    {
                        pictureBox1.Load(ID.photo_200_orig);

                    }
                    catch
                    {
                        pictureBox1.Load(Application.StartupPath + @"\Photo2.png");
                    }
                    imageList1.Images.Add(pictureBox1.Image);

                    texts1[0] = ID.last_name + " " + ID.first_name;
                    texts1[1] = ID.id.ToString();

                    ListViewItem lvi = new ListViewItem(texts1, imageList1.Images.Count - 1);
                    listView1.Items.Add(lvi);

                }
                catch
                {

                }
                SearchButton.Enabled = true;
                textBox1.Visible = false;
                textBox3.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                textBox1.Text = "";
                textBox3.Text = "";
                UsersSearchB.Enabled = false;
            }
        }
    }
}
