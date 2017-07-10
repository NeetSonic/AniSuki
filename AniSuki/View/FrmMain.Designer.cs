﻿namespace AniSuki.View
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
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManage});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(384, 25);
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
            this.menuProducer.Size = new System.Drawing.Size(152, 22);
            this.menuProducer.Text = "出版公司";
            this.menuProducer.Click += new System.EventHandler(this.MenuProducer_Click);
            // 
            // menuResolution
            // 
            this.menuResolution.Name = "menuResolution";
            this.menuResolution.Size = new System.Drawing.Size(152, 22);
            this.menuResolution.Text = "分辨率";
            this.menuResolution.Click += new System.EventHandler(this.MenuResolution_Click);
            // 
            // menuTag
            // 
            this.menuTag.Name = "menuTag";
            this.menuTag.Size = new System.Drawing.Size(152, 22);
            this.menuTag.Text = "标签";
            this.menuTag.Click += new System.EventHandler(this.MenuTag_Click);
            // 
            // menuVoiceActor
            // 
            this.menuVoiceActor.Name = "menuVoiceActor";
            this.menuVoiceActor.Size = new System.Drawing.Size(152, 22);
            this.menuVoiceActor.Text = "声优";
            this.menuVoiceActor.Click += new System.EventHandler(this.MenuVoiceActor_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
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
    }
}