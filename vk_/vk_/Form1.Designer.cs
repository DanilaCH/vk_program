namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.buttonWordGame = new System.Windows.Forms.Button();
            this.buttonLike = new System.Windows.Forms.Button();
            this.buttonRepost = new System.Windows.Forms.Button();
            this.timerGameWords = new System.Windows.Forms.Timer(this.components);
            this.buttonAddComments = new System.Windows.Forms.Button();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelHelp = new System.Windows.Forms.Label();
            this.buttonUserID = new System.Windows.Forms.Button();
            this.buttonSpam = new System.Windows.Forms.Button();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.webBrowserAuthorization = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWordGame
            // 
            this.buttonWordGame.Location = new System.Drawing.Point(10, 53);
            this.buttonWordGame.Name = "buttonWordGame";
            this.buttonWordGame.Size = new System.Drawing.Size(113, 36);
            this.buttonWordGame.TabIndex = 4;
            this.buttonWordGame.Text = "Играть в слова";
            this.buttonWordGame.UseVisualStyleBackColor = true;
            this.buttonWordGame.Click += new System.EventHandler(this.buttonWordGame_Click);
            // 
            // buttonLike
            // 
            this.buttonLike.Location = new System.Drawing.Point(160, 64);
            this.buttonLike.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(108, 19);
            this.buttonLike.TabIndex = 5;
            this.buttonLike.Text = "Ставить лайки";
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.buttonSpam_Click);
            // 
            // buttonRepost
            // 
            this.buttonRepost.Location = new System.Drawing.Point(10, 95);
            this.buttonRepost.Name = "buttonRepost";
            this.buttonRepost.Size = new System.Drawing.Size(113, 36);
            this.buttonRepost.TabIndex = 6;
            this.buttonRepost.Text = "Репосты";
            this.buttonRepost.UseVisualStyleBackColor = true;
            this.buttonRepost.Click += new System.EventHandler(this.buttonRepost_Click);
            // 
            // timerGameWords
            // 
            this.timerGameWords.Interval = 3000;
            this.timerGameWords.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonAddComments
            // 
            this.buttonAddComments.Location = new System.Drawing.Point(10, 136);
            this.buttonAddComments.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddComments.Name = "buttonAddComments";
            this.buttonAddComments.Size = new System.Drawing.Size(113, 36);
            this.buttonAddComments.TabIndex = 9;
            this.buttonAddComments.Text = "Добавление комментариев";
            this.buttonAddComments.UseVisualStyleBackColor = true;
            this.buttonAddComments.Click += new System.EventHandler(this.buttonAddComments_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(12, 127);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(46, 17);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "label1";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(12, 168);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(35, 13);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "label2";
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.BackColor = System.Drawing.Color.White;
            this.labelHelp.Location = new System.Drawing.Point(181, 107);
            this.labelHelp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(282, 39);
            this.labelHelp.TabIndex = 12;
            this.labelHelp.Text = "                                             ↑\r\nОчистить список друзей от удаленн" +
                "ых пользователей\r\n                   ";
            // 
            // buttonUserID
            // 
            this.buttonUserID.Location = new System.Drawing.Point(283, 51);
            this.buttonUserID.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUserID.Name = "buttonUserID";
            this.buttonUserID.Size = new System.Drawing.Size(83, 41);
            this.buttonUserID.TabIndex = 10;
            this.buttonUserID.Text = "Очистить";
            this.buttonUserID.UseVisualStyleBackColor = true;
            this.buttonUserID.Click += new System.EventHandler(this.buttonUserID_Click);
            // 
            // buttonSpam
            // 
            this.buttonSpam.Location = new System.Drawing.Point(13, 13);
            this.buttonSpam.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSpam.Name = "buttonSpam";
            this.buttonSpam.Size = new System.Drawing.Size(151, 44);
            this.buttonSpam.TabIndex = 5;
            this.buttonSpam.Text = "Рассылка";
            this.buttonSpam.UseVisualStyleBackColor = true;
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(103, 103);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar.TabIndex = 3;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // webBrowserAuthorization
            // 
            this.webBrowserAuthorization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserAuthorization.Location = new System.Drawing.Point(0, 0);
            this.webBrowserAuthorization.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserAuthorization.Name = "webBrowserAuthorization";
            this.webBrowserAuthorization.Size = new System.Drawing.Size(724, 461);
            this.webBrowserAuthorization.TabIndex = 13;
            this.webBrowserAuthorization.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 461);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.buttonUserID);
            this.Controls.Add(this.buttonAddComments);
            this.Controls.Add(this.buttonRepost);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.buttonWordGame);
            this.Controls.Add(this.webBrowserAuthorization);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWordGame;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.Button buttonRepost;
        private System.Windows.Forms.Button buttonSpam;
        public System.Windows.Forms.Timer timerGameWords;
        private System.Windows.Forms.Button buttonAddComments;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button buttonUserID;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.WebBrowser webBrowserAuthorization;
    }
}

