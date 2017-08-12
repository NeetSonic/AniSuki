namespace AniSuki.View
{
    partial class FrmBrowse
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
            Neetsonic.Control.GroupBox grpFilter;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.tabFilter = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clstFilterTagAnd = new AniSuki.View.Control.TagCheckedListBox();
            this.btnClearTagAnd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clstFilterTagOr = new AniSuki.View.Control.TagCheckedListBox();
            this.btnClearTagOr = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clstFilterVoiceActorAnd = new AniSuki.View.Control.VoiceActorCheckedListBox();
            this.btnClearVoiceActorAnd = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.clstFilterVoiceActorOr = new AniSuki.View.Control.VoiceActorCheckedListBox();
            this.btnClearVoiceActorOr = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearName = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearProducer = new System.Windows.Forms.Button();
            this.btnClearResolution = new System.Windows.Forms.Button();
            this.txtFilterName = new Neetsonic.Control.TextBox();
            this.cmbFilterProducer = new System.Windows.Forms.ComboBox();
            this.cmbFilterResolution = new System.Windows.Forms.ComboBox();
            this.dateFilterSaleDateBefore = new Neetsonic.Control.CheckedDateTimePicker();
            this.dateFilterSaleDateAfter = new Neetsonic.Control.CheckedDateTimePicker();
            this.dgvAnime = new AniSuki.View.Control.AnimeDataGridView();
            this.dgvTag = new AniSuki.View.Control.TagDataGridView();
            this.dgvCast = new AniSuki.View.Control.CastDataGridView();
            this.txtComment = new Neetsonic.Control.TextBox();
            this.btnExplorer = new System.Windows.Forms.Button();
            this.btnFreshResolution = new System.Windows.Forms.Button();
            this.picCover = new Neetsonic.Control.PictureViewer();
            this.btnUpdateComment = new System.Windows.Forms.Button();
            this.btnUpdateTag = new System.Windows.Forms.Button();
            this.btnUpdateCast = new System.Windows.Forms.Button();
            grpFilter = new Neetsonic.Control.GroupBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            grpFilter.SuspendLayout();
            this.tabFilter.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCast)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(this.tabFilter);
            grpFilter.Controls.Add(this.btnClearAll);
            grpFilter.Controls.Add(this.btnClearName);
            grpFilter.Controls.Add(this.btnSearch);
            grpFilter.Controls.Add(this.btnClearProducer);
            grpFilter.Controls.Add(this.btnClearResolution);
            grpFilter.Controls.Add(label3);
            grpFilter.Controls.Add(label2);
            grpFilter.Controls.Add(label1);
            grpFilter.Controls.Add(this.txtFilterName);
            grpFilter.Controls.Add(this.cmbFilterProducer);
            grpFilter.Controls.Add(this.cmbFilterResolution);
            grpFilter.Controls.Add(this.dateFilterSaleDateBefore);
            grpFilter.Controls.Add(this.dateFilterSaleDateAfter);
            grpFilter.Location = new System.Drawing.Point(12, 12);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new System.Drawing.Size(681, 292);
            grpFilter.TabIndex = 14;
            grpFilter.TabStop = false;
            grpFilter.Text = "过滤条件";
            // 
            // tabFilter
            // 
            this.tabFilter.Controls.Add(this.tabPage1);
            this.tabFilter.Controls.Add(this.tabPage2);
            this.tabFilter.Controls.Add(this.tabPage3);
            this.tabFilter.Controls.Add(this.tabPage4);
            this.tabFilter.Location = new System.Drawing.Point(342, 14);
            this.tabFilter.Name = "tabFilter";
            this.tabFilter.SelectedIndex = 0;
            this.tabFilter.Size = new System.Drawing.Size(333, 272);
            this.tabFilter.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clstFilterTagAnd);
            this.tabPage1.Controls.Add(this.btnClearTagAnd);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(325, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "所有标签";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // clstFilterTagAnd
            // 
            this.clstFilterTagAnd.CheckOnClick = true;
            this.clstFilterTagAnd.DataList = null;
            this.clstFilterTagAnd.FormattingEnabled = true;
            this.clstFilterTagAnd.HorizontalScrollbar = true;
            this.clstFilterTagAnd.Location = new System.Drawing.Point(6, 6);
            this.clstFilterTagAnd.Name = "clstFilterTagAnd";
            this.clstFilterTagAnd.Size = new System.Drawing.Size(313, 193);
            this.clstFilterTagAnd.TabIndex = 7;
            // 
            // btnClearTagAnd
            // 
            this.btnClearTagAnd.Location = new System.Drawing.Point(5, 203);
            this.btnClearTagAnd.Name = "btnClearTagAnd";
            this.btnClearTagAnd.Size = new System.Drawing.Size(314, 31);
            this.btnClearTagAnd.TabIndex = 21;
            this.btnClearTagAnd.Text = "清除";
            this.btnClearTagAnd.UseVisualStyleBackColor = true;
            this.btnClearTagAnd.Click += new System.EventHandler(this.BtnClearTagAnd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clstFilterTagOr);
            this.tabPage2.Controls.Add(this.btnClearTagOr);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(325, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "任一标签";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clstFilterTagOr
            // 
            this.clstFilterTagOr.CheckOnClick = true;
            this.clstFilterTagOr.DataList = null;
            this.clstFilterTagOr.FormattingEnabled = true;
            this.clstFilterTagOr.HorizontalScrollbar = true;
            this.clstFilterTagOr.Location = new System.Drawing.Point(6, 6);
            this.clstFilterTagOr.Name = "clstFilterTagOr";
            this.clstFilterTagOr.Size = new System.Drawing.Size(313, 193);
            this.clstFilterTagOr.TabIndex = 8;
            // 
            // btnClearTagOr
            // 
            this.btnClearTagOr.Location = new System.Drawing.Point(5, 203);
            this.btnClearTagOr.Name = "btnClearTagOr";
            this.btnClearTagOr.Size = new System.Drawing.Size(314, 31);
            this.btnClearTagOr.TabIndex = 23;
            this.btnClearTagOr.Text = "清除";
            this.btnClearTagOr.UseVisualStyleBackColor = true;
            this.btnClearTagOr.Click += new System.EventHandler(this.BtnClearTagOr_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.clstFilterVoiceActorAnd);
            this.tabPage3.Controls.Add(this.btnClearVoiceActorAnd);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(325, 239);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "所有声优";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // clstFilterVoiceActorAnd
            // 
            this.clstFilterVoiceActorAnd.CheckOnClick = true;
            this.clstFilterVoiceActorAnd.DataList = null;
            this.clstFilterVoiceActorAnd.FormattingEnabled = true;
            this.clstFilterVoiceActorAnd.HorizontalScrollbar = true;
            this.clstFilterVoiceActorAnd.Location = new System.Drawing.Point(6, 6);
            this.clstFilterVoiceActorAnd.Name = "clstFilterVoiceActorAnd";
            this.clstFilterVoiceActorAnd.Size = new System.Drawing.Size(313, 193);
            this.clstFilterVoiceActorAnd.TabIndex = 9;
            // 
            // btnClearVoiceActorAnd
            // 
            this.btnClearVoiceActorAnd.Location = new System.Drawing.Point(5, 203);
            this.btnClearVoiceActorAnd.Name = "btnClearVoiceActorAnd";
            this.btnClearVoiceActorAnd.Size = new System.Drawing.Size(314, 31);
            this.btnClearVoiceActorAnd.TabIndex = 24;
            this.btnClearVoiceActorAnd.Text = "清除";
            this.btnClearVoiceActorAnd.UseVisualStyleBackColor = true;
            this.btnClearVoiceActorAnd.Click += new System.EventHandler(this.BtnClearVoiceActorAnd_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.clstFilterVoiceActorOr);
            this.tabPage4.Controls.Add(this.btnClearVoiceActorOr);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(325, 239);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "任一声优";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // clstFilterVoiceActorOr
            // 
            this.clstFilterVoiceActorOr.CheckOnClick = true;
            this.clstFilterVoiceActorOr.DataList = null;
            this.clstFilterVoiceActorOr.FormattingEnabled = true;
            this.clstFilterVoiceActorOr.HorizontalScrollbar = true;
            this.clstFilterVoiceActorOr.Location = new System.Drawing.Point(6, 6);
            this.clstFilterVoiceActorOr.Name = "clstFilterVoiceActorOr";
            this.clstFilterVoiceActorOr.Size = new System.Drawing.Size(313, 193);
            this.clstFilterVoiceActorOr.TabIndex = 10;
            // 
            // btnClearVoiceActorOr
            // 
            this.btnClearVoiceActorOr.Location = new System.Drawing.Point(5, 203);
            this.btnClearVoiceActorOr.Name = "btnClearVoiceActorOr";
            this.btnClearVoiceActorOr.Size = new System.Drawing.Size(314, 31);
            this.btnClearVoiceActorOr.TabIndex = 25;
            this.btnClearVoiceActorOr.Text = "清除";
            this.btnClearVoiceActorOr.UseVisualStyleBackColor = true;
            this.btnClearVoiceActorOr.Click += new System.EventHandler(this.BtnClearVoiceActorOr_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(253, 230);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(82, 37);
            this.btnClearAll.TabIndex = 26;
            this.btnClearAll.Text = "清除所有";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // btnClearName
            // 
            this.btnClearName.Location = new System.Drawing.Point(276, 22);
            this.btnClearName.Name = "btnClearName";
            this.btnClearName.Size = new System.Drawing.Size(59, 31);
            this.btnClearName.TabIndex = 22;
            this.btnClearName.Text = "清除";
            this.btnClearName.UseVisualStyleBackColor = true;
            this.btnClearName.Click += new System.EventHandler(this.BtnClearName_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(10, 221);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(212, 55);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnClearProducer
            // 
            this.btnClearProducer.Location = new System.Drawing.Point(276, 59);
            this.btnClearProducer.Name = "btnClearProducer";
            this.btnClearProducer.Size = new System.Drawing.Size(59, 31);
            this.btnClearProducer.TabIndex = 16;
            this.btnClearProducer.Text = "清除";
            this.btnClearProducer.UseVisualStyleBackColor = true;
            this.btnClearProducer.Click += new System.EventHandler(this.BtnClearProducer_Click);
            // 
            // btnClearResolution
            // 
            this.btnClearResolution.Location = new System.Drawing.Point(276, 96);
            this.btnClearResolution.Name = "btnClearResolution";
            this.btnClearResolution.Size = new System.Drawing.Size(59, 31);
            this.btnClearResolution.TabIndex = 15;
            this.btnClearResolution.Text = "清除";
            this.btnClearResolution.UseVisualStyleBackColor = true;
            this.btnClearResolution.Click += new System.EventHandler(this.BtnClearResolution_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(20, 101);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 20);
            label3.TabIndex = 5;
            label3.Text = "分辨率";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 20);
            label2.TabIndex = 4;
            label2.Text = "出版公司";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "名称名称";
            // 
            // txtFilterName
            // 
            this.txtFilterName.Location = new System.Drawing.Point(77, 24);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(193, 26);
            this.txtFilterName.TabIndex = 1;
            // 
            // cmbFilterProducer
            // 
            this.cmbFilterProducer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterProducer.FormattingEnabled = true;
            this.cmbFilterProducer.Location = new System.Drawing.Point(77, 60);
            this.cmbFilterProducer.Name = "cmbFilterProducer";
            this.cmbFilterProducer.Size = new System.Drawing.Size(193, 28);
            this.cmbFilterProducer.TabIndex = 2;
            // 
            // cmbFilterResolution
            // 
            this.cmbFilterResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterResolution.FormattingEnabled = true;
            this.cmbFilterResolution.Location = new System.Drawing.Point(77, 97);
            this.cmbFilterResolution.Name = "cmbFilterResolution";
            this.cmbFilterResolution.Size = new System.Drawing.Size(193, 28);
            this.cmbFilterResolution.TabIndex = 3;
            // 
            // dateFilterSaleDateBefore
            // 
            this.dateFilterSaleDateBefore.CheckText = "发售时间早于";
            this.dateFilterSaleDateBefore.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateFilterSaleDateBefore.Location = new System.Drawing.Point(10, 177);
            this.dateFilterSaleDateBefore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateFilterSaleDateBefore.MaximumSize = new System.Drawing.Size(2000, 26);
            this.dateFilterSaleDateBefore.MinimumSize = new System.Drawing.Size(30, 26);
            this.dateFilterSaleDateBefore.Name = "dateFilterSaleDateBefore";
            this.dateFilterSaleDateBefore.Size = new System.Drawing.Size(325, 26);
            this.dateFilterSaleDateBefore.TabIndex = 6;
            this.dateFilterSaleDateBefore.Value = null;
            // 
            // dateFilterSaleDateAfter
            // 
            this.dateFilterSaleDateAfter.CheckText = "发售时间晚于";
            this.dateFilterSaleDateAfter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateFilterSaleDateAfter.Location = new System.Drawing.Point(10, 141);
            this.dateFilterSaleDateAfter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateFilterSaleDateAfter.MaximumSize = new System.Drawing.Size(2000, 26);
            this.dateFilterSaleDateAfter.MinimumSize = new System.Drawing.Size(30, 26);
            this.dateFilterSaleDateAfter.Name = "dateFilterSaleDateAfter";
            this.dateFilterSaleDateAfter.Size = new System.Drawing.Size(325, 26);
            this.dateFilterSaleDateAfter.TabIndex = 4;
            this.dateFilterSaleDateAfter.Value = null;
            // 
            // dgvAnime
            // 
            this.dgvAnime.AllowUserToAddRows = false;
            this.dgvAnime.AllowUserToDeleteRows = false;
            this.dgvAnime.AllowUserToResizeColumns = false;
            this.dgvAnime.AllowUserToResizeRows = false;
            this.dgvAnime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnime.BackgroundColor = System.Drawing.Color.White;
            this.dgvAnime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnime.DataList = null;
            this.dgvAnime.Location = new System.Drawing.Point(12, 310);
            this.dgvAnime.MultiSelect = false;
            this.dgvAnime.Name = "dgvAnime";
            this.dgvAnime.OpenLinkInBrowser = false;
            this.dgvAnime.ReadOnly = true;
            this.dgvAnime.RowHeadersVisible = false;
            this.dgvAnime.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAnime.RowTemplate.Height = 23;
            this.dgvAnime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnime.Size = new System.Drawing.Size(681, 384);
            this.dgvAnime.TabIndex = 0;
            // 
            // dgvTag
            // 
            this.dgvTag.AllowUserToAddRows = false;
            this.dgvTag.AllowUserToDeleteRows = false;
            this.dgvTag.AllowUserToResizeColumns = false;
            this.dgvTag.AllowUserToResizeRows = false;
            this.dgvTag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTag.BackgroundColor = System.Drawing.Color.White;
            this.dgvTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTag.DataList = null;
            this.dgvTag.Location = new System.Drawing.Point(1239, 310);
            this.dgvTag.MultiSelect = false;
            this.dgvTag.Name = "dgvTag";
            this.dgvTag.OpenLinkInBrowser = false;
            this.dgvTag.ReadOnly = true;
            this.dgvTag.RowHeadersVisible = false;
            this.dgvTag.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTag.RowTemplate.Height = 23;
            this.dgvTag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTag.Size = new System.Drawing.Size(260, 498);
            this.dgvTag.TabIndex = 11;
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
            this.dgvCast.DataList = null;
            this.dgvCast.Location = new System.Drawing.Point(1239, 22);
            this.dgvCast.MultiSelect = false;
            this.dgvCast.Name = "dgvCast";
            this.dgvCast.OpenLinkInBrowser = false;
            this.dgvCast.ReadOnly = true;
            this.dgvCast.RowHeadersVisible = false;
            this.dgvCast.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCast.RowTemplate.Height = 23;
            this.dgvCast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCast.Size = new System.Drawing.Size(260, 282);
            this.dgvCast.TabIndex = 12;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(12, 700);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ReadOnly = true;
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(681, 149);
            this.txtComment.TabIndex = 13;
            // 
            // btnExplorer
            // 
            this.btnExplorer.Location = new System.Drawing.Point(859, 816);
            this.btnExplorer.Name = "btnExplorer";
            this.btnExplorer.Size = new System.Drawing.Size(154, 33);
            this.btnExplorer.TabIndex = 15;
            this.btnExplorer.Text = "打开文件目录";
            this.btnExplorer.UseVisualStyleBackColor = true;
            this.btnExplorer.Click += new System.EventHandler(this.BtnExplorer_Click);
            // 
            // btnFreshResolution
            // 
            this.btnFreshResolution.Location = new System.Drawing.Point(1019, 816);
            this.btnFreshResolution.Name = "btnFreshResolution";
            this.btnFreshResolution.Size = new System.Drawing.Size(154, 33);
            this.btnFreshResolution.TabIndex = 16;
            this.btnFreshResolution.Text = "刷新分辨率";
            this.btnFreshResolution.UseVisualStyleBackColor = true;
            this.btnFreshResolution.Click += new System.EventHandler(this.BtnFreshResolution_Click);
            // 
            // picCover
            // 
            this.picCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCover.CacheSize = 10;
            this.picCover.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.picCover.Location = new System.Drawing.Point(701, 22);
            this.picCover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(531, 786);
            this.picCover.TabIndex = 17;
            // 
            // btnUpdateComment
            // 
            this.btnUpdateComment.Location = new System.Drawing.Point(699, 816);
            this.btnUpdateComment.Name = "btnUpdateComment";
            this.btnUpdateComment.Size = new System.Drawing.Size(154, 33);
            this.btnUpdateComment.TabIndex = 18;
            this.btnUpdateComment.Text = "更新动画简介";
            this.btnUpdateComment.UseVisualStyleBackColor = true;
            this.btnUpdateComment.Click += new System.EventHandler(this.BtnUpdateComment_Click);
            // 
            // btnUpdateTag
            // 
            this.btnUpdateTag.Location = new System.Drawing.Point(1179, 816);
            this.btnUpdateTag.Name = "btnUpdateTag";
            this.btnUpdateTag.Size = new System.Drawing.Size(154, 33);
            this.btnUpdateTag.TabIndex = 19;
            this.btnUpdateTag.Text = "更新动画标签";
            this.btnUpdateTag.UseVisualStyleBackColor = true;
            this.btnUpdateTag.Click += new System.EventHandler(this.BtnUpdateTag_Click);
            // 
            // btnUpdateCast
            // 
            this.btnUpdateCast.Location = new System.Drawing.Point(1339, 816);
            this.btnUpdateCast.Name = "btnUpdateCast";
            this.btnUpdateCast.Size = new System.Drawing.Size(154, 33);
            this.btnUpdateCast.TabIndex = 20;
            this.btnUpdateCast.Text = "更新动画配音";
            this.btnUpdateCast.UseVisualStyleBackColor = true;
            this.btnUpdateCast.Click += new System.EventHandler(this.BtnUpdateCast_Click);
            // 
            // FrmBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 861);
            this.Controls.Add(this.btnUpdateCast);
            this.Controls.Add(this.btnUpdateTag);
            this.Controls.Add(this.btnUpdateComment);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.btnFreshResolution);
            this.Controls.Add(this.btnExplorer);
            this.Controls.Add(grpFilter);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.dgvCast);
            this.Controls.Add(this.dgvTag);
            this.Controls.Add(this.dgvAnime);
            this.Name = "FrmBrowse";
            this.Text = "浏览";
            this.Load += new System.EventHandler(this.FrmBrowse_Load);
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            this.tabFilter.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.AnimeDataGridView dgvAnime;
        private Neetsonic.Control.TextBox txtFilterName;
        private System.Windows.Forms.ComboBox cmbFilterProducer;
        private System.Windows.Forms.ComboBox cmbFilterResolution;
        private Neetsonic.Control.CheckedDateTimePicker dateFilterSaleDateAfter;
        private System.Windows.Forms.Button btnSearch;
        private Neetsonic.Control.CheckedDateTimePicker dateFilterSaleDateBefore;
        private Control.TagCheckedListBox clstFilterTagAnd;
        private Control.TagCheckedListBox clstFilterTagOr;
        private Control.VoiceActorCheckedListBox clstFilterVoiceActorAnd;
        private Control.VoiceActorCheckedListBox clstFilterVoiceActorOr;
        private Control.TagDataGridView dgvTag;
        private Control.CastDataGridView dgvCast;
        private Neetsonic.Control.TextBox txtComment;
        private System.Windows.Forms.Button btnClearProducer;
        private System.Windows.Forms.Button btnClearResolution;
        private System.Windows.Forms.Button btnClearName;
        private System.Windows.Forms.Button btnClearTagAnd;
        private System.Windows.Forms.Button btnClearVoiceActorOr;
        private System.Windows.Forms.Button btnClearVoiceActorAnd;
        private System.Windows.Forms.Button btnClearTagOr;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TabControl tabFilter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnExplorer;
        private System.Windows.Forms.Button btnFreshResolution;
        private Neetsonic.Control.PictureViewer picCover;
        private System.Windows.Forms.Button btnUpdateComment;
        private System.Windows.Forms.Button btnUpdateTag;
        private System.Windows.Forms.Button btnUpdateCast;
    }
}