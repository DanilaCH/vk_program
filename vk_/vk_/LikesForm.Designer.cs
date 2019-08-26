namespace WindowsFormsApplication1
{
    partial class LikesForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.SearchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LikeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SearchFriends = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Back = new System.Windows.Forms.Button();
            this.UsersSearchB = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(359, 107);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(119, 53);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Поиск альбомов";
            this.toolTip1.SetToolTip(this.SearchButton, "Введите ID или NickName пользователя в поле слева, чтобы найти его альбомы");
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.LikeButtom_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 53);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Данила Чернышёв";
            this.toolTip1.SetToolTip(this.textBox1, "Введите ID пользователя, которого хотите найти");
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(554, 31);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(266, 53);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Поиск фотографий";
            this.toolTip1.SetToolTip(this.button1, "Выберете альбом из списка и нажмите на кнопку, чтобы отобразить фотографии из аль" +
                    "бома");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LikeButton
            // 
            this.LikeButton.Location = new System.Drawing.Point(294, 107);
            this.LikeButton.Name = "LikeButton";
            this.LikeButton.Size = new System.Drawing.Size(119, 53);
            this.LikeButton.TabIndex = 4;
            this.LikeButton.Text = "Лайкнуть!";
            this.toolTip1.SetToolTip(this.LikeButton, "Выберете фоторафии, а затем нажмите, чтобы поставить лайк");
            this.LikeButton.UseVisualStyleBackColor = true;
            this.LikeButton.Visible = false;
            this.LikeButton.Click += new System.EventHandler(this.LikeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите ID или NickName пользователя";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(162, 166);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(568, 247);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Изобр.";
            this.columnHeader3.Width = 49;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 77;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 53);
            this.button2.TabIndex = 7;
            this.button2.Text = "Лайкнуть Все!";
            this.toolTip1.SetToolTip(this.button2, "Нажмите, чтобы лайкнуть все найенный фотографии");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchFriends
            // 
            this.SearchFriends.Location = new System.Drawing.Point(294, 31);
            this.SearchFriends.Name = "SearchFriends";
            this.SearchFriends.Size = new System.Drawing.Size(119, 53);
            this.SearchFriends.TabIndex = 8;
            this.SearchFriends.Text = "Поиск друзей";
            this.toolTip1.SetToolTip(this.SearchFriends, "Нажмите, чтобы отобразить список ваших друзей");
            this.SearchFriends.UseVisualStyleBackColor = true;
            this.SearchFriends.Click += new System.EventHandler(this.SearchFriends_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(701, 369);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(119, 53);
            this.Back.TabIndex = 11;
            this.Back.Text = "Назад";
            this.toolTip1.SetToolTip(this.Back, "Вернуться к началу");
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // UsersSearchB
            // 
            this.UsersSearchB.Location = new System.Drawing.Point(419, 31);
            this.UsersSearchB.Name = "UsersSearchB";
            this.UsersSearchB.Size = new System.Drawing.Size(119, 53);
            this.UsersSearchB.TabIndex = 12;
            this.UsersSearchB.Text = "Поиск пользователя";
            this.toolTip1.SetToolTip(this.UsersSearchB, "Введите NickName пользователя в поле слева и нажмите на кнопку, чтобы найти польз" +
                    "ователя");
            this.UsersSearchB.UseVisualStyleBackColor = true;
            this.UsersSearchB.Click += new System.EventHandler(this.UsersSearch_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 107);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 53);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "Пенза";
            this.toolTip1.SetToolTip(this.textBox3, "Введите ID пользователя, которого хотите найти");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(65, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Введите город в котором живет пользователь";
            // 
            // LikesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsersSearchB);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.SearchFriends);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LikeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SearchButton);
            this.Name = "LikesForm";
            this.Text = "LikesForm";
            this.Load += new System.EventHandler(this.LikesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LikeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SearchFriends;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button UsersSearchB;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;

    }
}