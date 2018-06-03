namespace AniSuki.View
{
    partial class FrmMain
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
            if(disposing && (components != null))
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProducer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResolution = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTag = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVoiceActor = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewAnime = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManage,
            this.设置ToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(303, 25);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuManage
            // 
            this.menuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProducer,
            this.menuResolution,
            this.menuTag,
            this.menuVoiceActor});
            this.menuManage.Name = "menuManage";
            this.menuManage.Size = new System.Drawing.Size(44, 21);
            this.menuManage.Text = "管理";
            // 
            // menuProducer
            // 
            this.menuProducer.Name = "menuProducer";
            this.menuProducer.Size = new System.Drawing.Size(124, 22);
            this.menuProducer.Text = "出版公司";
            this.menuProducer.Click += new System.EventHandler(this.MenuProducer_Click);
            // 
            // menuResolution
            // 
            this.menuResolution.Name = "menuResolution";
            this.menuResolution.Size = new System.Drawing.Size(124, 22);
            this.menuResolution.Text = "分辨率";
            this.menuResolution.Click += new System.EventHandler(this.MenuResolution_Click);
            // 
            // menuTag
            // 
            this.menuTag.Name = "menuTag";
            this.menuTag.Size = new System.Drawing.Size(124, 22);
            this.menuTag.Text = "标签";
            this.menuTag.Click += new System.EventHandler(this.MenuTag_Click);
            // 
            // menuVoiceActor
            // 
            this.menuVoiceActor.Name = "menuVoiceActor";
            this.menuVoiceActor.Size = new System.Drawing.Size(124, 22);
            this.menuVoiceActor.Text = "声优";
            this.menuVoiceActor.Click += new System.EventHandler(this.MenuVoiceActor_Click);
            // 
            // btnNewAnime
            // 
            this.btnNewAnime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNewAnime.Location = new System.Drawing.Point(12, 45);
            this.btnNewAnime.Name = "btnNewAnime";
            this.btnNewAnime.Size = new System.Drawing.Size(106, 49);
            this.btnNewAnime.TabIndex = 1;
            this.btnNewAnime.Text = "添加";
            this.btnNewAnime.UseVisualStyleBackColor = true;
            this.btnNewAnime.Click += new System.EventHandler(this.BtnNewAnime_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrowse.Location = new System.Drawing.Point(185, 45);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(106, 49);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改配置ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 修改配置ToolStripMenuItem
            // 
            this.修改配置ToolStripMenuItem.Name = "修改配置ToolStripMenuItem";
            this.修改配置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改配置ToolStripMenuItem.Text = "修改配置";
            this.修改配置ToolStripMenuItem.Click += new System.EventHandler(this.修改配置ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 103);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnNewAnime);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "FrmMain";
            this.Text = "Anisuki";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuManage;
        private System.Windows.Forms.ToolStripMenuItem menuProducer;
        private System.Windows.Forms.ToolStripMenuItem menuResolution;
        private System.Windows.Forms.ToolStripMenuItem menuTag;
        private System.Windows.Forms.ToolStripMenuItem menuVoiceActor;
        private System.Windows.Forms.Button btnNewAnime;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改配置ToolStripMenuItem;
    }
}