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
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        string useless;
        FormWordGame f = new FormWordGame();
        int num = 0;
        public string access_token;
        string[] aray = File.ReadAllLines(Application.StartupPath + @"\word_rus.txt");
        bool FirstMessage = false;
        bool SecondMessage = false;
        int lengthtext = 1;
        int length = 0;
        string AnotherTxt;
        int count = 0;
        string user_id;
        string friend_id;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowserAuthorization.BringToFront();
            webBrowserAuthorization.Navigate("https://oauth.vk.com/authorize?client_id=6410347&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends+photos+messages+wall&response_type=token&v=5.100&state=123456");

        }

        private void buttonRepost_Click(object sender, EventArgs e)
        {

            FormRepost f = new FormRepost();
            f.access_token = access_token;
            f.ShowDialog();

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            access_token = webBrowserAuthorization.Url.ToString();
            if (access_token.Contains("access_token"))
            {
                int pos = access_token.IndexOf("#");
                access_token = access_token.Remove(0, pos + 1);

                pos = access_token.IndexOf("&e");
                access_token = access_token.Remove(pos);
                webBrowserAuthorization.Visible = false;

                string request = "https://api.vk.com/method/users.get?&" + access_token + "&v=5.95";
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));
                UserGet user = JsonConvert.DeserializeObject<UserGet>(answer);
                user_id = user.response[0].id;
            }
        }

        private void buttonFriendsClean_Click(object sender, EventArgs e)
        {
         
        }

        private void buttonAddComments_Click(object sender, EventArgs e)
        {
            FormComments c = new FormComments();
            c.access_token = access_token;
            c.ShowDialog();
        }

        private void buttonUserID_Click(object sender, EventArgs e)
        {
            string request = "https://api.vk.com/method/messages.getConversations?" +
                    access_token + "&v=5.52";
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(request));
        }

        private void buttonSpam_Click(object sender, EventArgs e)
        {
            LikesForm Like = new LikesForm();
            Like.Access_token = access_token;
            Like.User_id = user_id;
            Like.Show();
        }

        private void buttonWordGame_Click(object sender, EventArgs e)
        {
            f.ParentTimer = timerGameWords;
            f.ShowDialog();
            //timer1.Enabled = true;
            //f.labelError.Text = "начинаю поиск слова";


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //string[] words=new string[100];
            // words=useless.Split('_') ;


            Random rnd2 = new Random();
            int value2 = rnd2.Next(20);

            Random rnd = new Random();

            //Получить очередное (в данном случае - первое) случайное число
            int value = rnd.Next();
            string request = "https://api.vk.com/method/messages.getConversations?filter=unread&access_token=ac0624e8fa2d28708590d46d03229f53cd539d227acdf82310295890b30b3c60e79d7db62181dd67f1876&v=5.80";
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(request));
            //FormWordGame f = new FormWordGame();
            ////f.textBox1.Text = access_token;
            ////f.textBoxDialog.Text = textMesssage;

            Messages data = JsonConvert.DeserializeObject<Messages>(answer);
            //if (data.response.count > 0)
            //{
            for (int i = 0; i < data.response.count; i++)
            {
                Application.DoEvents();
                string[] texts = new string[2];
                texts[0] = data.response.items[i].last_message.ToString();
                texts[1] = data.response.items[i].last_message.from_id.ToString();

                f.textBoxDialog.Text = f.textBoxDialog.Text + data.response.items[i].last_message.text.ToString() + "\r\n";
                //for (int s = 0; s < data.response.count; s++)
                //{
                //Application.DoEvents();

                //}
                if ((data.response.items[i].last_message.text.ToLower() == "играть") && (FirstMessage == true))
                {
                    string request2 = "https://api.vk.com/method/messages.send?random_id=" + value.ToString() + "&user_id=" + data.response.items[i].last_message.from_id.ToString() + "&message=" + "Арбуз" + "\r\n" + "Теперь придумай слово,которое начинается на букву" + " \"З\"" + "&access_token=ac0624e8fa2d28708590d46d03229f53cd539d227acdf82310295890b30b3c60e79d7db62181dd67f1876&v=5.90";
                    WebClient client2 = new WebClient();
                    string answer2 = Encoding.UTF8.GetString(client.DownloadData(request2));
                    SecondMessage = true;


                }
                if (SecondMessage == false)
                {

                    string request1 = "https://api.vk.com/method/messages.send?random_id=" + value.ToString() + "&user_id=" + data.response.items[i].last_message.from_id.ToString() + "&message=" + "отправь" + "\"Играть\"" + ",если хочешь сыграть в слова...  " + "&access_token=ac0624e8fa2d28708590d46d03229f53cd539d227acdf82310295890b30b3c60e79d7db62181dd67f1876&v=5.90";
                    WebClient client1 = new WebClient();
                    string answer1 = Encoding.UTF8.GetString(client.DownloadData(request1));
                    FirstMessage = true;

                }
                if (SecondMessage == true)
                {
                    char word = data.response.items[i].last_message.text[data.response.items[i].last_message.text.Length - 1];
                    //char last = aray[k].Length - 1;
                    string alphabet = "АаБбВвГгДдЕеЁёЖжЗзИиКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЭэЮюЯя";
                    if (word == 'ь')
                    {
                        word = data.response.items[i].last_message.text[data.response.items[i].last_message.text.Length - 2];
                        //last = aray[k].Length - 2;
                    }
                    if (word == 'й')
                    {
                        word = data.response.items[i].last_message.text[data.response.items[i].last_message.text.Length - 2];

                    }

                    AnotherTxt = data.response.items[i].last_message.text;
                    for (int l = 0; l < data.response.items[i].last_message.text.Length; l++)
                    {
                        if (alphabet.Contains(AnotherTxt[AnotherTxt.Length - 1]))
                        {
                            word = AnotherTxt[AnotherTxt.Length - 1];

                            break;
                        }
                        else
                        {
                            length = AnotherTxt.Length - 1;//lengthtext;
                            AnotherTxt = AnotherTxt.Remove(length);
                            //lengthtext = lengthtext + 1;
                        }
                    }



                    for (int k = 0; k < aray.Length; k++)
                    {

                        if (word == aray[k][0])
                        {

                            k = k + value2;

                        }

                        string request3 = "https://api.vk.com/method/messages.send?random_id=" + value.ToString() + "&user_id=";
                        request3 += data.response.items[i].last_message.from_id.ToString() + "&message=";
                        request3 += aray[k] + "\r\n" + "Теперь придумай слово,которое начинается на букву" + " ";
                        int ii = aray[k].Length - 1;
                        // request3 += aray[num][ii] + "&access_token=ac0624e8fa2d28708590d46d03229f53cd539d227acdf82310295890b30b3c60e79d7db62181dd67f1876&v=5.90";
                        string aaa = aray[k];
                        request3 += aray[k][ii] + "&access_token=ac0624e8fa2d28708590d46d03229f53cd539d227acdf82310295890b30b3c60e79d7db62181dd67f1876&v=5.90";
                        WebClient client3 = new WebClient();
                        string answer3 = Encoding.UTF8.GetString(client.DownloadData(request3));
                        aray[k] = "斯";
                        //useless = useless +"_" + aray[k];
                        f.labelError.Text = "Cлово найдено";

                        break;

                    }



                }
                //f.imageList1.Images.Add(pictureBox2.Image);
                ListViewItem lvi = new ListViewItem(texts[1]);//, imageList1.Images.Count - 1
                f.listViewPlayers.Items.Add(lvi);
                //Арбуз" + "\r\n" + "Теперь придумай слово,которое начинается на букву
            }
            //Messages data = JsonConvert.DeserializeObject<Messages>(answer);

        }

    }
}

          /*
                
                string request = "https://api.vk.com/method/friends.get?user_id=" + user_id + "&fields=name&count=&" + access_token + "&v=5.95";
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));
                FrendsList frendsList = JsonConvert.DeserializeObject<FrendsList>(answer);
                FrendsList frb = new FrendsList();
                if (answer.Contains("error"))
                {
                    MessageBox.Show("Неправильный ID пользователя");
                 
                }
                else
                {
                    for (int i = 0; i < frendsList.response.count; i++)
                    {
                        if (frendsList.response.items[i].deactivated != null)
                        {

                            if (frendsList.response.items[i].deactivated.Contains("deleted") || frendsList.response.items[i].deactivated.Contains("banned"))
                            {
                                friend_id = frendsList.response.items[i].id;
                                string request2 = "https://api.vk.com/method/friends.delete?user_id=" + friend_id + "&" + access_token + "&v=5.101";
                                WebClient client2 = new WebClient();
                                string answer2 = Encoding.UTF8.GetString(client.DownloadData(request2));
                                count = count + 1;
                            
                            }
                        }
                    }
                }

            }

        }
      
}
  */
