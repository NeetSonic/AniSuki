namespace AniSuki.View
{
    partial class FrmNewAnime
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.dgvAnimeFile = new AniSuki.View.Control.AnimeFileDataGridView();
            this.menuDgvAnimeFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDeleteAnimeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.tabTag = new System.Windows.Forms.TabPage();
            this.btnReverseCheckTag = new System.Windows.Forms.Button();
            this.btnUncheckAllTag = new System.Windows.Forms.Button();
            this.btnCheckAllTag = new System.Windows.Forms.Button();
            this.btnManageTag = new System.Windows.Forms.Button();
            this.clstTag = new AniSuki.View.Control.TagCheckedListBox();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.txtComment = new Neetsonic.Control.TextBox();
            this.btnManageProducer = new System.Windows.Forms.Button();
            this.cmbProducer = new System.Windows.Forms.ComboBox();
            this.dateSale = new System.Windows.Forms.DateTimePicker();
            this.cmbResolution = new System.Windows.Forms.ComboBox();
            this.txtName = new Neetsonic.Control.TextBox();
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tabCast = new System.Windows.Forms.TabPage();
            this.btnNewCast = new System.Windows.Forms.Button();
            this.btnManageVoiceActor = new System.Windows.Forms.Button();
            this.cmbVoiceActor = new System.Windows.Forms.ComboBox();
            this.txtCharaName = new Neetsonic.Control.TextBox();
            this.dgvCast = new AniSuki.View.Control.CastDataGridView();
            this.menuDgvCast = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDeleteCast = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLog = new Neetsonic.Control.LogTextBox();
            this.btnNewAnime = new System.Windows.Forms.Button();
            this.chkDeleteWhenSucceed = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimeFile)).BeginInit();
            this.menuDgvAnimeFile.SuspendLayout();
            this.tabTag.SuspendLayout();
            this.tabBase.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabCast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCast)).BeginInit();
            this.menuDgvCast.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "动画名称";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 20);
            label2.TabIndex = 2;
            label2.Text = "分辨率";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(253, 54);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 20);
            label3.TabIndex = 4;
            label3.Text = "发售时间";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 99);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 20);
            label4.TabIndex = 6;
            label4.Text = "出版公司";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 144);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(65, 20);
            label5.TabIndex = 9;
            label5.Text = "动画简介";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(4, 53);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(37, 20);
            label6.TabIndex = 2;
            label6.Text = "角色";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(4, 14);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(37, 20);
            label7.TabIndex = 3;
            label7.Text = "声优";
            // 
            // dgvAnimeFile
            // 
            this.dgvAnimeFile.AllowUserToAddRows = false;
            this.dgvAnimeFile.AllowUserToDeleteRows = false;
            this.dgvAnimeFile.AllowUserToResizeColumns = false;
            this.dgvAnimeFile.AllowUserToResizeRows = false;
            this.dgvAnimeFile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnimeFile.BackgroundColor = System.Drawing.Color.White;
            this.dgvAnimeFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimeFile.ContextMenuStrip = this.menuDgvAnimeFile;
            this.dgvAnimeFile.DataList = null;
            this.dgvAnimeFile.Location = new System.Drawing.Point(12, 54);
            this.dgvAnimeFile.MultiSelect = false;
            this.dgvAnimeFile.Name = "dgvAnimeFile";
            this.dgvAnimeFile.OpenLinkInBrowser = false;
            this.dgvAnimeFile.ReadOnly = true;
            this.dgvAnimeFile.RowHeadersVisible = false;
            this.dgvAnimeFile.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAnimeFile.RowTemplate.Height = 23;
            this.dgvAnimeFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimeFile.Size = new System.Drawing.Size(513, 222);
            this.dgvAnimeFile.TabIndex = 0;
            this.dgvAnimeFile.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAnimeFile_CellDoubleClick);
            // 
            // menuDgvAnimeFile
            // 
            this.menuDgvAnimeFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDeleteAnimeFile});
            this.menuDgvAnimeFile.Name = "menuDgvAnimeFile";
            this.menuDgvAnimeFile.Size = new System.Drawing.Size(101, 26);
            this.menuDgvAnimeFile.Opening += new System.ComponentModel.CancelEventHandler(this.MenuDgvAnimeFile_Opening);
            // 
            // menuDeleteAnimeFile
            // 
            this.menuDeleteAnimeFile.Name = "menuDeleteAnimeFile";
            this.menuDeleteAnimeFile.Size = new System.Drawing.Size(100, 22);
            this.menuDeleteAnimeFile.Text = "删除";
            this.menuDeleteAnimeFile.Click += new System.EventHandler(this.MenuDeleteAnimeFile_Click);
            // 
            // btnNewFile
            // 
            this.btnNewFile.Location = new System.Drawing.Point(12, 12);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(86, 36);
            this.btnNewFile.TabIndex = 1;
            this.btnNewFile.Text = "添加文件";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.BtnNewFile_Click);
            // 
            // tabTag
            // 
            this.tabTag.BackColor = System.Drawing.SystemColors.Window;
            this.tabTag.Controls.Add(this.btnReverseCheckTag);
            this.tabTag.Controls.Add(this.btnUncheckAllTag);
            this.tabTag.Controls.Add(this.btnCheckAllTag);
            this.tabTag.Controls.Add(this.btnManageTag);
            this.tabTag.Controls.Add(this.clstTag);
            this.tabTag.Location = new System.Drawing.Point(4, 29);
            this.tabTag.Name = "tabTag";
            this.tabTag.Padding = new System.Windows.Forms.Padding(3);
            this.tabTag.Size = new System.Drawing.Size(505, 500);
            this.tabTag.TabIndex = 1;
            this.tabTag.Text = "标签";
            // 
            // btnReverseCheckTag
            // 
            this.btnReverseCheckTag.Location = new System.Drawing.Point(404, 49);
            this.btnReverseCheckTag.Name = "btnReverseCheckTag";
            this.btnReverseCheckTag.Size = new System.Drawing.Size(95, 37);
            this.btnReverseCheckTag.TabIndex = 4;
            this.btnReverseCheckTag.Text = "反选";
            this.btnReverseCheckTag.UseVisualStyleBackColor = true;
            this.btnReverseCheckTag.Click += new System.EventHandler(this.BtnReverseCheckTag_Click);
            // 
            // btnUncheckAllTag
            // 
            this.btnUncheckAllTag.Location = new System.Drawing.Point(404, 92);
            this.btnUncheckAllTag.Name = "btnUncheckAllTag";
            this.btnUncheckAllTag.Size = new System.Drawing.Size(95, 37);
            this.btnUncheckAllTag.TabIndex = 3;
            this.btnUncheckAllTag.Text = "全不选";
            this.btnUncheckAllTag.UseVisualStyleBackColor = true;
            this.btnUncheckAllTag.Click += new System.EventHandler(this.BtnUncheckAllTag_Click);
            // 
            // btnCheckAllTag
            // 
            this.btnCheckAllTag.Location = new System.Drawing.Point(404, 6);
            this.btnCheckAllTag.Name = "btnCheckAllTag";
            this.btnCheckAllTag.Size = new System.Drawing.Size(95, 37);
            this.btnCheckAllTag.TabIndex = 2;
            this.btnCheckAllTag.Text = "全选";
            this.btnCheckAllTag.UseVisualStyleBackColor = true;
            this.btnCheckAllTag.Click += new System.EventHandler(this.BtnCheckAllTag_Click);
            // 
            // btnManageTag
            // 
            this.btnManageTag.Location = new System.Drawing.Point(404, 456);
            this.btnManageTag.Name = "btnManageTag";
            this.btnManageTag.Size = new System.Drawing.Size(95, 37);
            this.btnManageTag.TabIndex = 1;
            this.btnManageTag.Text = "管理标签";
            this.btnManageTag.UseVisualStyleBackColor = true;
            this.btnManageTag.Click += new System.EventHandler(this.BtnManageTag_Click);
            // 
            // clstTag
            // 
            this.clstTag.CheckOnClick = true;
            this.clstTag.DataList = null;
            this.clstTag.FormattingEnabled = true;
            this.clstTag.HorizontalScrollbar = true;
            this.clstTag.Location = new System.Drawing.Point(6, 6);
            this.clstTag.Name = "clstTag";
            this.clstTag.Size = new System.Drawing.Size(392, 487);
            this.clstTag.TabIndex = 0;
            // 
            // tabBase
            // 
            this.tabBase.BackColor = System.Drawing.SystemColors.Window;
            this.tabBase.Controls.Add(this.txtComment);
            this.tabBase.Controls.Add(label5);
            this.tabBase.Controls.Add(this.btnManageProducer);
            this.tabBase.Controls.Add(this.cmbProducer);
            this.tabBase.Controls.Add(label4);
            this.tabBase.Controls.Add(this.dateSale);
            this.tabBase.Controls.Add(label3);
            this.tabBase.Controls.Add(this.cmbResolution);
            this.tabBase.Controls.Add(label2);
            this.tabBase.Controls.Add(this.txtName);
            this.tabBase.Controls.Add(label1);
            this.tabBase.Location = new System.Drawing.Point(4, 29);
            this.tabBase.Name = "tabBase";
            this.tabBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabBase.Size = new System.Drawing.Size(505, 500);
            this.tabBase.TabIndex = 0;
            this.tabBase.Text = "基本";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(77, 144);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(415, 350);
            this.txtComment.TabIndex = 10;
            // 
            // btnManageProducer
            // 
            this.btnManageProducer.Location = new System.Drawing.Point(439, 95);
            this.btnManageProducer.Name = "btnManageProducer";
            this.btnManageProducer.Size = new System.Drawing.Size(53, 30);
            this.btnManageProducer.TabIndex = 8;
            this.btnManageProducer.Text = "管理";
            this.btnManageProducer.UseVisualStyleBackColor = true;
            this.btnManageProducer.Click += new System.EventHandler(this.BtnManageProducer_Click);
            // 
            // cmbProducer
            // 
            this.cmbProducer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducer.FormattingEnabled = true;
            this.cmbProducer.Location = new System.Drawing.Point(77, 96);
            this.cmbProducer.Name = "cmbProducer";
            this.cmbProducer.Size = new System.Drawing.Size(356, 28);
            this.cmbProducer.TabIndex = 7;
            // 
            // dateSale
            // 
            this.dateSale.Location = new System.Drawing.Point(324, 51);
            this.dateSale.Name = "dateSale";
            this.dateSale.Size = new System.Drawing.Size(168, 26);
            this.dateSale.TabIndex = 5;
            // 
            // cmbResolution
            // 
            this.cmbResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResolution.FormattingEnabled = true;
            this.cmbResolution.Location = new System.Drawing.Point(77, 50);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(170, 28);
            this.cmbResolution.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(415, 26);
            this.txtName.TabIndex = 1;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.tabBase);
            this.tabInfo.Controls.Add(this.tabTag);
            this.tabInfo.Controls.Add(this.tabCast);
            this.tabInfo.Location = new System.Drawing.Point(531, 12);
            this.tabInfo.Multiline = true;
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedIndex = 0;
            this.tabInfo.Size = new System.Drawing.Size(513, 533);
            this.tabInfo.TabIndex = 2;
            // 
            // tabCast
            // 
            this.tabCast.BackColor = System.Drawing.SystemColors.Window;
            this.tabCast.Controls.Add(this.btnNewCast);
            this.tabCast.Controls.Add(this.btnManageVoiceActor);
            this.tabCast.Controls.Add(this.cmbVoiceActor);
            this.tabCast.Controls.Add(label7);
            this.tabCast.Controls.Add(label6);
            this.tabCast.Controls.Add(this.txtCharaName);
            this.tabCast.Controls.Add(this.dgvCast);
            this.tabCast.Location = new System.Drawing.Point(4, 29);
            this.tabCast.Name = "tabCast";
            this.tabCast.Size = new System.Drawing.Size(505, 500);
            this.tabCast.TabIndex = 2;
            this.tabCast.Text = "配音";
            // 
            // btnNewCast
            // 
            this.btnNewCast.Location = new System.Drawing.Point(203, 83);
            this.btnNewCast.Name = "btnNewCast";
            this.btnNewCast.Size = new System.Drawing.Size(99, 40);
            this.btnNewCast.TabIndex = 7;
            this.btnNewCast.Text = "添加";
            this.btnNewCast.UseVisualStyleBackColor = true;
            this.btnNewCast.Click += new System.EventHandler(this.BtnNewCast_Click);
            // 
            // btnManageVoiceActor
            // 
            this.btnManageVoiceActor.Location = new System.Drawing.Point(398, 9);
            this.btnManageVoiceActor.Name = "btnManageVoiceActor";
            this.btnManageVoiceActor.Size = new System.Drawing.Size(99, 31);
            this.btnManageVoiceActor.TabIndex = 6;
            this.btnManageVoiceActor.Text = "管理声优";
            this.btnManageVoiceActor.UseVisualStyleBackColor = true;
            this.btnManageVoiceActor.Click += new System.EventHandler(this.BtnManageVoiceActor_Click);
            // 
            // cmbVoiceActor
            // 
            this.cmbVoiceActor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoiceActor.FormattingEnabled = true;
            this.cmbVoiceActor.Location = new System.Drawing.Point(47, 11);
            this.cmbVoiceActor.Name = "cmbVoiceActor";
            this.cmbVoiceActor.Size = new System.Drawing.Size(333, 28);
            this.cmbVoiceActor.TabIndex = 4;
            // 
            // txtCharaName
            // 
            this.txtCharaName.Location = new System.Drawing.Point(47, 50);
            this.txtCharaName.Name = "txtCharaName";
            this.txtCharaName.Size = new System.Drawing.Size(450, 26);
            this.txtCharaName.TabIndex = 1;
            // 
            // dgvCast
            // 
            this.dgvCast.AllowUserToAddRows = false;
            this.dgvCast.AllowUserToDeleteRows = false;
            this.dgvCast.AllowUserToResizeColumns = false;
            this.dgvCast.AllowUserToResizeRows = false;
            this.dgvCast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCast.BackgroundColor = System.Drawing.Color.White;
            this.dgvCast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCast.ContextMenuStrip = this.menuDgvCast;
            this.dgvCast.DataList = null;
            this.dgvCast.Location = new System.Drawing.Point(7, 131);
            this.dgvCast.MultiSelect = false;
            this.dgvCast.Name = "dgvCast";
            this.dgvCast.OpenLinkInBrowser = false;
            this.dgvCast.ReadOnly = true;
            this.dgvCast.RowHeadersVisible = false;
            this.dgvCast.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCast.RowTemplate.Height = 23;
            this.dgvCast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCast.Size = new System.Drawing.Size(490, 362);
            this.dgvCast.TabIndex = 0;
            // 
            // menuDgvCast
            // 
            this.menuDgvCast.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDeleteCast});
            this.menuDgvCast.Name = "menuDgvCast";
            this.menuDgvCast.Size = new System.Drawing.Size(101, 26);
            this.menuDgvCast.Opening += new System.ComponentModel.CancelEventHandler(this.MenuDgvCast_Opening);
            // 
            // menuDeleteCast
            // 
            this.menuDeleteCast.Name = "menuDeleteCast";
            this.menuDeleteCast.Size = new System.Drawing.Size(100, 22);
            this.menuDeleteCast.Text = "删除";
            this.menuDeleteCast.Click += new System.EventHandler(this.MenuDeleteCast_Click);
            // 
            // txtLog
            // 
            this.txtLog.AcceptsReturn = true;
            this.txtLog.AcceptsTab = true;
            this.txtLog.Location = new System.Drawing.Point(12, 342);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(513, 199);
            this.txtLog.TabIndex = 3;
            // 
            // btnNewAnime
            // 
            this.btnNewAnime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNewAnime.Location = new System.Drawing.Point(12, 282);
            this.btnNewAnime.Name = "btnNewAnime";
            this.btnNewAnime.Size = new System.Drawing.Size(513, 54);
            this.btnNewAnime.TabIndex = 4;
            this.btnNewAnime.Text = "添加动画";
            this.btnNewAnime.UseVisualStyleBackColor = true;
            this.btnNewAnime.Click += new System.EventHandler(this.BtnNewAnime_Click);
            // 
            // chkDeleteWhenSucceed
            // 
            this.chkDeleteWhenSucceed.AutoSize = true;
            this.chkDeleteWhenSucceed.Location = new System.Drawing.Point(357, 19);
            this.chkDeleteWhenSucceed.Name = "chkDeleteWhenSucceed";
            this.chkDeleteWhenSucceed.Size = new System.Drawing.Size(168, 24);
            this.chkDeleteWhenSucceed.TabIndex = 5;
            this.chkDeleteWhenSucceed.Text = "添加完成后删除原文件";
            this.chkDeleteWhenSucceed.UseVisualStyleBackColor = true;
            // 
            // FrmNewAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 557);
            this.Controls.Add(this.chkDeleteWhenSucceed);
            this.Controls.Add(this.btnNewAnime);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.tabInfo);
            this.Controls.Add(this.btnNewFile);
            this.Controls.Add(this.dgvAnimeFile);
            this.Name = "FrmNewAnime";
            this.Text = "添加动画";
            this.Load += new System.EventHandler(this.FrmNewAnime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimeFile)).EndInit();
            this.menuDgvAnimeFile.ResumeLayout(false);
            this.tabTag.ResumeLayout(false);
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            this.tabCast.ResumeLayout(false);
            this.tabCast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCast)).EndInit();
            this.menuDgvCast.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.AnimeFileDataGridView dgvAnimeFile;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.TabPage tabTag;
        private System.Windows.Forms.TabPage tabBase;
        private System.Windows.Forms.TabControl tabInfo;
        private System.Windows.Forms.TabPage tabCast;
        private Neetsonic.Control.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbResolution;
        private System.Windows.Forms.ComboBox cmbProducer;
        private System.Windows.Forms.DateTimePicker dateSale;
        private System.Windows.Forms.Button btnManageProducer;
        private Neetsonic.Control.TextBox txtComment;
        private Control.TagCheckedListBox clstTag;
        private System.Windows.Forms.Button btnManageTag;
        private System.Windows.Forms.Button btnReverseCheckTag;
        private System.Windows.Forms.Button btnUncheckAllTag;
        private System.Windows.Forms.Button btnCheckAllTag;
        private Neetsonic.Control.LogTextBox txtLog;
        private Control.CastDataGridView dgvCast;
        private Neetsonic.Control.TextBox txtCharaName;
        private System.Windows.Forms.ComboBox cmbVoiceActor;
        private System.Windows.Forms.Button btnNewCast;
        private System.Windows.Forms.Button btnManageVoiceActor;
        private System.Windows.Forms.ContextMenuStrip menuDgvCast;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteCast;
        private System.Windows.Forms.Button btnNewAnime;
        private System.Windows.Forms.ContextMenuStrip menuDgvAnimeFile;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteAnimeFile;
        private System.Windows.Forms.CheckBox chkDeleteWhenSucceed;
    }
}