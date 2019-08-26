namespace WindowsFormsApplication1
{
    partial class FormRepost
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
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.buttonResost = new System.Windows.Forms.Button();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.listViewGroups = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteGroup = new System.Windows.Forms.Button();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(21, 292);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(182, 22);
            this.textBoxGroup.TabIndex = 1;
            this.toolTipHelp.SetToolTip(this.textBoxGroup, "Введите ссылку на группу");
            // 
            // buttonResost
            // 
            this.buttonResost.Location = new System.Drawing.Point(193, 360);
            this.buttonResost.Name = "buttonResost";
            this.buttonResost.Size = new System.Drawing.Size(108, 42);
            this.buttonResost.TabIndex = 4;
            this.buttonResost.Text = "Репост";
            this.toolTipHelp.SetToolTip(this.buttonResost, "Сделать репост записи с выбранной группы");
            this.buttonResost.UseVisualStyleBackColor = true;
            this.buttonResost.Click += new System.EventHandler(this.buttonResost_Click);
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Location = new System.Drawing.Point(209, 292);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(92, 26);
            this.buttonAddGroup.TabIndex = 5;
            this.buttonAddGroup.Text = "Добавить";
            this.toolTipHelp.SetToolTip(this.buttonAddGroup, "Добавить группу в список");
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listViewGroups
            // 
            this.listViewGroups.HideSelection = false;
            this.listViewGroups.Location = new System.Drawing.Point(21, 50);
            this.listViewGroups.Name = "listViewGroups";
            this.listViewGroups.Size = new System.Drawing.Size(280, 237);
            this.listViewGroups.TabIndex = 10;
            this.toolTipHelp.SetToolTip(this.listViewGroups, "Список ваших групп");
            this.listViewGroups.UseCompatibleStateImageBehavior = false;
            this.listViewGroups.View = System.Windows.Forms.View.Tile;
            this.listViewGroups.SelectedIndexChanged += new System.EventHandler(this.listViewGroups_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(200, 200);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Группы:";
            // 
            // buttonDeleteGroup
            // 
            this.buttonDeleteGroup.Location = new System.Drawing.Point(209, 324);
            this.buttonDeleteGroup.Name = "buttonDeleteGroup";
            this.buttonDeleteGroup.Size = new System.Drawing.Size(92, 30);
            this.buttonDeleteGroup.TabIndex = 15;
            this.buttonDeleteGroup.Text = "Удалить";
            this.toolTipHelp.SetToolTip(this.buttonDeleteGroup, "Удалить группу из списка");
            this.buttonDeleteGroup.UseVisualStyleBackColor = true;
            this.buttonDeleteGroup.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTipHelp
            // 
            this.toolTipHelp.AutomaticDelay = 100;
            this.toolTipHelp.AutoPopDelay = 5000;
            this.toolTipHelp.InitialDelay = 100;
            this.toolTipHelp.ReshowDelay = 20;
            // 
            // FormRepost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 547);
            this.Controls.Add(this.buttonDeleteGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewGroups);
            this.Controls.Add(this.buttonAddGroup);
            this.Controls.Add(this.buttonResost);
            this.Controls.Add(this.textBoxGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FormRepost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRepost";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRepost_FormClosed);
            this.Load += new System.EventHandler(this.FormRepost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Button buttonResost;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.ListView listViewGroups;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteGroup;
        private System.Windows.Forms.ToolTip toolTipHelp;
    }
}