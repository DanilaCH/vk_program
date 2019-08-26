namespace WindowsFormsApplication1
{
    partial class FormComments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewGroups = new System.Windows.Forms.ListView();
            this.textBoxGroups = new System.Windows.Forms.TextBox();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.buttonDistribution = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // listViewGroups
            // 
            this.listViewGroups.HideSelection = false;
            this.listViewGroups.Location = new System.Drawing.Point(12, 34);
            this.listViewGroups.Name = "listViewGroups";
            this.listViewGroups.Size = new System.Drawing.Size(197, 289);
            this.listViewGroups.TabIndex = 0;
            this.toolTipHelp.SetToolTip(this.listViewGroups, "Список ваших групп");
            this.listViewGroups.UseCompatibleStateImageBehavior = false;
            this.listViewGroups.View = System.Windows.Forms.View.Tile;
            this.listViewGroups.SelectedIndexChanged += new System.EventHandler(this.listViewGroups_SelectedIndexChanged);
            // 
            // textBoxGroups
            // 
            this.textBoxGroups.Location = new System.Drawing.Point(12, 329);
            this.textBoxGroups.Name = "textBoxGroups";
            this.textBoxGroups.Size = new System.Drawing.Size(197, 22);
            this.textBoxGroups.TabIndex = 1;
            this.toolTipHelp.SetToolTip(this.textBoxGroups, "Введите ссылку на группу");
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Location = new System.Drawing.Point(215, 326);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(87, 29);
            this.buttonAddGroup.TabIndex = 2;
            this.buttonAddGroup.Text = "Добавить";
            this.toolTipHelp.SetToolTip(this.buttonAddGroup, "Добавляет группу в список");
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // buttonDistribution
            // 
            this.buttonDistribution.Location = new System.Drawing.Point(346, 312);
            this.buttonDistribution.Name = "buttonDistribution";
            this.buttonDistribution.Size = new System.Drawing.Size(150, 39);
            this.buttonDistribution.TabIndex = 3;
            this.buttonDistribution.Text = "Комментировать";
            this.toolTipHelp.SetToolTip(this.buttonDistribution, "Прокомментировать записи");
            this.buttonDistribution.UseVisualStyleBackColor = true;
            this.buttonDistribution.Click += new System.EventHandler(this.buttonDistribution_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(286, 27);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(259, 279);
            this.textBoxMessage.TabIndex = 4;
            this.toolTipHelp.SetToolTip(this.textBoxMessage, "Введите ваше сообщение");
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(624, 450);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(12, 366);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(42, 22);
            this.textBoxCount.TabIndex = 6;
            this.textBoxCount.Text = "1";
            this.toolTipHelp.SetToolTip(this.textBoxCount, "Кол-во комментируемых постов");
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCount_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Группы:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(283, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Сообщение:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 28);
            this.button3.TabIndex = 13;
            this.button3.Text = "Удалить";
            this.toolTipHelp.SetToolTip(this.button3, "Удаляет группу из списка");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolTipHelp
            // 
            this.toolTipHelp.AutoPopDelay = 5000;
            this.toolTipHelp.InitialDelay = 100;
            this.toolTipHelp.ReshowDelay = 100;
            // 
            // FormComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonDistribution);
            this.Controls.Add(this.buttonAddGroup);
            this.Controls.Add(this.textBoxGroups);
            this.Controls.Add(this.listViewGroups);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormComments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormComments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormComments_FormClosed);
            this.Load += new System.EventHandler(this.FormComments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewGroups;
        private System.Windows.Forms.TextBox textBoxGroups;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Button buttonDistribution;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTipHelp;
    }
}