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
            this.webBrowserAutorization = new System.Windows.Forms.WebBrowser();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonWordGame = new System.Windows.Forms.Button();
            this.buttonLike = new System.Windows.Forms.Button();
            this.buttonRepost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowserAutorization
            // 
            this.webBrowserAutorization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserAutorization.Location = new System.Drawing.Point(0, 0);
            this.webBrowserAutorization.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserAutorization.Name = "webBrowserAutorization";
            this.webBrowserAutorization.Size = new System.Drawing.Size(691, 483);
            this.webBrowserAutorization.TabIndex = 0;
            this.webBrowserAutorization.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowserAutorization.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
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
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(103, 103);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar.TabIndex = 3;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(50, 50);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonWordGame
            // 
            this.buttonWordGame.Location = new System.Drawing.Point(214, 31);
            this.buttonWordGame.Name = "buttonWordGame";
            this.buttonWordGame.Size = new System.Drawing.Size(144, 23);
            this.buttonWordGame.TabIndex = 4;
            this.buttonWordGame.Text = "Играть в слова";
            this.buttonWordGame.UseVisualStyleBackColor = true;
            // 
            // buttonLike
            // 
            this.buttonLike.Location = new System.Drawing.Point(214, 79);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(144, 23);
            this.buttonLike.TabIndex = 5;
            this.buttonLike.Text = "Ставить лайки";
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.buttonSpam_Click);
            // 
            // buttonRepost
            // 
            this.buttonRepost.Location = new System.Drawing.Point(214, 127);
            this.buttonRepost.Name = "buttonRepost";
            this.buttonRepost.Size = new System.Drawing.Size(144, 23);
            this.buttonRepost.TabIndex = 6;
            this.buttonRepost.Text = "Репосты";
            this.buttonRepost.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(556, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRepost);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.buttonWordGame);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.webBrowserAutorization);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserAutorization;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonWordGame;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.Button buttonRepost;
        private System.Windows.Forms.Label label1;
    }
}

