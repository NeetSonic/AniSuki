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
            this.dgvAnime = new AniSuki.View.Control.AnimeDataGridView();
            this.txtFilterName = new Neetsonic.Control.TextBox();
            this.cmbFilterProducer = new System.Windows.Forms.ComboBox();
            this.cmbFilterResolution = new System.Windows.Forms.ComboBox();
            this.dateFilterSaleDateAfter = new Neetsonic.Control.CheckedDateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateFilterSaleDateBefore = new Neetsonic.Control.CheckedDateTimePicker();
            this.clstFilterTagAnd = new AniSuki.View.Control.TagCheckedListBox();
            this.clstFilterTagOr = new AniSuki.View.Control.TagCheckedListBox();
            this.clstFilterVoiceActorAnd = new AniSuki.View.Control.VoiceActorCheckedListBox();
            this.clstFilterVoiceActorOr = new AniSuki.View.Control.VoiceActorCheckedListBox();
            this.dgvTag = new AniSuki.View.Control.TagDataGridView();
            this.dgvCast = new AniSuki.View.Control.CastDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCast)).BeginInit();
            this.SuspendLayout();
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
            this.dgvAnime.Location = new System.Drawing.Point(12, 194);
            this.dgvAnime.MultiSelect = false;
            this.dgvAnime.Name = "dgvAnime";
            this.dgvAnime.OpenLinkInBrowser = false;
            this.dgvAnime.ReadOnly = true;
            this.dgvAnime.RowHeadersVisible = false;
            this.dgvAnime.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAnime.RowTemplate.Height = 23;
            this.dgvAnime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnime.Size = new System.Drawing.Size(681, 122);
            this.dgvAnime.TabIndex = 0;
            // 
            // txtFilterName
            // 
            this.txtFilterName.Location = new System.Drawing.Point(12, 12);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(100, 26);
            this.txtFilterName.TabIndex = 1;
            // 
            // cmbFilterProducer
            // 
            this.cmbFilterProducer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterProducer.FormattingEnabled = true;
            this.cmbFilterProducer.Location = new System.Drawing.Point(12, 44);
            this.cmbFilterProducer.Name = "cmbFilterProducer";
            this.cmbFilterProducer.Size = new System.Drawing.Size(121, 28);
            this.cmbFilterProducer.TabIndex = 2;
            // 
            // cmbFilterResolution
            // 
            this.cmbFilterResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterResolution.FormattingEnabled = true;
            this.cmbFilterResolution.Location = new System.Drawing.Point(12, 78);
            this.cmbFilterResolution.Name = "cmbFilterResolution";
            this.cmbFilterResolution.Size = new System.Drawing.Size(121, 28);
            this.cmbFilterResolution.TabIndex = 3;
            // 
            // dateFilterSaleDateAfter
            // 
            this.dateFilterSaleDateAfter.CheckText = "";
            this.dateFilterSaleDateAfter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateFilterSaleDateAfter.Location = new System.Drawing.Point(12, 114);
            this.dateFilterSaleDateAfter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateFilterSaleDateAfter.MaximumSize = new System.Drawing.Size(2000, 26);
            this.dateFilterSaleDateAfter.MinimumSize = new System.Drawing.Size(30, 26);
            this.dateFilterSaleDateAfter.Name = "dateFilterSaleDateAfter";
            this.dateFilterSaleDateAfter.Size = new System.Drawing.Size(225, 26);
            this.dateFilterSaleDateAfter.TabIndex = 4;
            this.dateFilterSaleDateAfter.Value = null;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 148);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 40);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "button1";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dateFilterSaleDateBefore
            // 
            this.dateFilterSaleDateBefore.CheckText = "";
            this.dateFilterSaleDateBefore.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateFilterSaleDateBefore.Location = new System.Drawing.Point(256, 114);
            this.dateFilterSaleDateBefore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateFilterSaleDateBefore.MaximumSize = new System.Drawing.Size(2000, 26);
            this.dateFilterSaleDateBefore.MinimumSize = new System.Drawing.Size(30, 26);
            this.dateFilterSaleDateBefore.Name = "dateFilterSaleDateBefore";
            this.dateFilterSaleDateBefore.Size = new System.Drawing.Size(174, 26);
            this.dateFilterSaleDateBefore.TabIndex = 6;
            this.dateFilterSaleDateBefore.Value = null;
            // 
            // clstFilterTagAnd
            // 
            this.clstFilterTagAnd.CheckOnClick = true;
            this.clstFilterTagAnd.DataList = null;
            this.clstFilterTagAnd.FormattingEnabled = true;
            this.clstFilterTagAnd.HorizontalScrollbar = true;
            this.clstFilterTagAnd.Location = new System.Drawing.Point(161, 12);
            this.clstFilterTagAnd.Name = "clstFilterTagAnd";
            this.clstFilterTagAnd.Size = new System.Drawing.Size(120, 88);
            this.clstFilterTagAnd.TabIndex = 7;
            // 
            // clstFilterTagOr
            // 
            this.clstFilterTagOr.CheckOnClick = true;
            this.clstFilterTagOr.DataList = null;
            this.clstFilterTagOr.FormattingEnabled = true;
            this.clstFilterTagOr.HorizontalScrollbar = true;
            this.clstFilterTagOr.Location = new System.Drawing.Point(296, 12);
            this.clstFilterTagOr.Name = "clstFilterTagOr";
            this.clstFilterTagOr.Size = new System.Drawing.Size(120, 88);
            this.clstFilterTagOr.TabIndex = 8;
            // 
            // clstFilterVoiceActorAnd
            // 
            this.clstFilterVoiceActorAnd.CheckOnClick = true;
            this.clstFilterVoiceActorAnd.DataList = null;
            this.clstFilterVoiceActorAnd.FormattingEnabled = true;
            this.clstFilterVoiceActorAnd.HorizontalScrollbar = true;
            this.clstFilterVoiceActorAnd.Location = new System.Drawing.Point(440, 12);
            this.clstFilterVoiceActorAnd.Name = "clstFilterVoiceActorAnd";
            this.clstFilterVoiceActorAnd.Size = new System.Drawing.Size(120, 88);
            this.clstFilterVoiceActorAnd.TabIndex = 9;
            // 
            // clstFilterVoiceActorOr
            // 
            this.clstFilterVoiceActorOr.CheckOnClick = true;
            this.clstFilterVoiceActorOr.DataList = null;
            this.clstFilterVoiceActorOr.FormattingEnabled = true;
            this.clstFilterVoiceActorOr.HorizontalScrollbar = true;
            this.clstFilterVoiceActorOr.Location = new System.Drawing.Point(573, 12);
            this.clstFilterVoiceActorOr.Name = "clstFilterVoiceActorOr";
            this.clstFilterVoiceActorOr.Size = new System.Drawing.Size(120, 88);
            this.clstFilterVoiceActorOr.TabIndex = 10;
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
            this.dgvTag.Location = new System.Drawing.Point(732, 12);
            this.dgvTag.MultiSelect = false;
            this.dgvTag.Name = "dgvTag";
            this.dgvTag.OpenLinkInBrowser = false;
            this.dgvTag.ReadOnly = true;
            this.dgvTag.RowHeadersVisible = false;
            this.dgvTag.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTag.RowTemplate.Height = 23;
            this.dgvTag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTag.Size = new System.Drawing.Size(176, 101);
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
            this.dgvCast.Location = new System.Drawing.Point(732, 166);
            this.dgvCast.MultiSelect = false;
            this.dgvCast.Name = "dgvCast";
            this.dgvCast.OpenLinkInBrowser = false;
            this.dgvCast.ReadOnly = true;
            this.dgvCast.RowHeadersVisible = false;
            this.dgvCast.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCast.RowTemplate.Height = 23;
            this.dgvCast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCast.Size = new System.Drawing.Size(265, 150);
            this.dgvCast.TabIndex = 12;
            // 
            // FrmBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 328);
            this.Controls.Add(this.dgvCast);
            this.Controls.Add(this.dgvTag);
            this.Controls.Add(this.clstFilterVoiceActorOr);
            this.Controls.Add(this.clstFilterVoiceActorAnd);
            this.Controls.Add(this.clstFilterTagOr);
            this.Controls.Add(this.clstFilterTagAnd);
            this.Controls.Add(this.dateFilterSaleDateBefore);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateFilterSaleDateAfter);
            this.Controls.Add(this.cmbFilterResolution);
            this.Controls.Add(this.cmbFilterProducer);
            this.Controls.Add(this.txtFilterName);
            this.Controls.Add(this.dgvAnime);
            this.Name = "FrmBrowse";
            this.Text = "浏览动画";
            this.Load += new System.EventHandler(this.FrmBrowse_Load);
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
    }
}