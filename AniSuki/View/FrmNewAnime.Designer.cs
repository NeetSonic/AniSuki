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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.dgvAnimeFile = new AniSuki.View.Control.AnimeFileDataGridView();
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
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.cmbResolution = new System.Windows.Forms.ComboBox();
            this.txtName = new Neetsonic.Control.TextBox();
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tabCast = new System.Windows.Forms.TabPage();
            this.logTextBox1 = new Neetsonic.Control.LogTextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimeFile)).BeginInit();
            this.tabTag.SuspendLayout();
            this.tabBase.SuspendLayout();
            this.tabInfo.SuspendLayout();
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
            // dgvAnimeFile
            // 
            this.dgvAnimeFile.AllowUserToAddRows = false;
            this.dgvAnimeFile.AllowUserToDeleteRows = false;
            this.dgvAnimeFile.AllowUserToResizeColumns = false;
            this.dgvAnimeFile.AllowUserToResizeRows = false;
            this.dgvAnimeFile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnimeFile.BackgroundColor = System.Drawing.Color.White;
            this.dgvAnimeFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.tabBase.Controls.Add(this.dateTime);
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
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(324, 51);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(168, 26);
            this.dateTime.TabIndex = 5;
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
            this.tabCast.Location = new System.Drawing.Point(4, 29);
            this.tabCast.Name = "tabCast";
            this.tabCast.Size = new System.Drawing.Size(505, 500);
            this.tabCast.TabIndex = 2;
            this.tabCast.Text = "配音";
            // 
            // logTextBox1
            // 
            this.logTextBox1.AcceptsReturn = true;
            this.logTextBox1.AcceptsTab = true;
            this.logTextBox1.Location = new System.Drawing.Point(12, 301);
            this.logTextBox1.Multiline = true;
            this.logTextBox1.Name = "logTextBox1";
            this.logTextBox1.ReadOnly = true;
            this.logTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox1.Size = new System.Drawing.Size(513, 240);
            this.logTextBox1.TabIndex = 3;
            // 
            // FrmNewAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 557);
            this.Controls.Add(this.logTextBox1);
            this.Controls.Add(this.tabInfo);
            this.Controls.Add(this.btnNewFile);
            this.Controls.Add(this.dgvAnimeFile);
            this.Name = "FrmNewAnime";
            this.Text = "添加动画";
            this.Load += new System.EventHandler(this.FrmNewAnime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimeFile)).EndInit();
            this.tabTag.ResumeLayout(false);
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            this.tabInfo.ResumeLayout(false);
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
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button btnManageProducer;
        private Neetsonic.Control.TextBox txtComment;
        private Control.TagCheckedListBox clstTag;
        private System.Windows.Forms.Button btnManageTag;
        private System.Windows.Forms.Button btnReverseCheckTag;
        private System.Windows.Forms.Button btnUncheckAllTag;
        private System.Windows.Forms.Button btnCheckAllTag;
        private Neetsonic.Control.LogTextBox logTextBox1;
    }
}