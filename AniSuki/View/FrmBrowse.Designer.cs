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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
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
            this.txtComment = new Neetsonic.Control.TextBox();
            this.btnClearResolution = new System.Windows.Forms.Button();
            this.btnClearProducer = new System.Windows.Forms.Button();
            this.btnClearTagAnd = new System.Windows.Forms.Button();
            this.btnClearName = new System.Windows.Forms.Button();
            this.btnClearTagOr = new System.Windows.Forms.Button();
            this.btnClearVoiceActorAnd = new System.Windows.Forms.Button();
            this.btnClearVoiceActorOr = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            grpFilter = new Neetsonic.Control.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCast)).BeginInit();
            grpFilter.SuspendLayout();
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
            this.dgvAnime.Location = new System.Drawing.Point(12, 323);
            this.dgvAnime.MultiSelect = false;
            this.dgvAnime.Name = "dgvAnime";
            this.dgvAnime.OpenLinkInBrowser = false;
            this.dgvAnime.ReadOnly = true;
            this.dgvAnime.RowHeadersVisible = false;
            this.dgvAnime.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAnime.RowTemplate.Height = 23;
            this.dgvAnime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnime.Size = new System.Drawing.Size(681, 262);
            this.dgvAnime.TabIndex = 0;
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
            // clstFilterTagAnd
            // 
            this.clstFilterTagAnd.CheckOnClick = true;
            this.clstFilterTagAnd.DataList = null;
            this.clstFilterTagAnd.FormattingEnabled = true;
            this.clstFilterTagAnd.HorizontalScrollbar = true;
            this.clstFilterTagAnd.Location = new System.Drawing.Point(352, 58);
            this.clstFilterTagAnd.Name = "clstFilterTagAnd";
            this.clstFilterTagAnd.Size = new System.Drawing.Size(220, 193);
            this.clstFilterTagAnd.TabIndex = 7;
            // 
            // clstFilterTagOr
            // 
            this.clstFilterTagOr.CheckOnClick = true;
            this.clstFilterTagOr.DataList = null;
            this.clstFilterTagOr.FormattingEnabled = true;
            this.clstFilterTagOr.HorizontalScrollbar = true;
            this.clstFilterTagOr.Location = new System.Drawing.Point(578, 58);
            this.clstFilterTagOr.Name = "clstFilterTagOr";
            this.clstFilterTagOr.Size = new System.Drawing.Size(220, 193);
            this.clstFilterTagOr.TabIndex = 8;
            // 
            // clstFilterVoiceActorAnd
            // 
            this.clstFilterVoiceActorAnd.CheckOnClick = true;
            this.clstFilterVoiceActorAnd.DataList = null;
            this.clstFilterVoiceActorAnd.FormattingEnabled = true;
            this.clstFilterVoiceActorAnd.HorizontalScrollbar = true;
            this.clstFilterVoiceActorAnd.Location = new System.Drawing.Point(804, 58);
            this.clstFilterVoiceActorAnd.Name = "clstFilterVoiceActorAnd";
            this.clstFilterVoiceActorAnd.Size = new System.Drawing.Size(220, 193);
            this.clstFilterVoiceActorAnd.TabIndex = 9;
            // 
            // clstFilterVoiceActorOr
            // 
            this.clstFilterVoiceActorOr.CheckOnClick = true;
            this.clstFilterVoiceActorOr.DataList = null;
            this.clstFilterVoiceActorOr.FormattingEnabled = true;
            this.clstFilterVoiceActorOr.HorizontalScrollbar = true;
            this.clstFilterVoiceActorOr.Location = new System.Drawing.Point(1030, 58);
            this.clstFilterVoiceActorOr.Name = "clstFilterVoiceActorOr";
            this.clstFilterVoiceActorOr.Size = new System.Drawing.Size(220, 193);
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
            this.dgvTag.Location = new System.Drawing.Point(1183, 333);
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
            this.dgvCast.Location = new System.Drawing.Point(772, 323);
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
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(935, 489);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(265, 91);
            this.txtComment.TabIndex = 13;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(this.btnClearAll);
            grpFilter.Controls.Add(this.btnClearVoiceActorOr);
            grpFilter.Controls.Add(this.btnClearVoiceActorAnd);
            grpFilter.Controls.Add(this.btnClearTagOr);
            grpFilter.Controls.Add(this.btnClearName);
            grpFilter.Controls.Add(this.btnClearTagAnd);
            grpFilter.Controls.Add(label7);
            grpFilter.Controls.Add(label6);
            grpFilter.Controls.Add(label5);
            grpFilter.Controls.Add(label4);
            grpFilter.Controls.Add(this.btnSearch);
            grpFilter.Controls.Add(this.btnClearProducer);
            grpFilter.Controls.Add(this.clstFilterVoiceActorOr);
            grpFilter.Controls.Add(this.btnClearResolution);
            grpFilter.Controls.Add(label3);
            grpFilter.Controls.Add(this.clstFilterVoiceActorAnd);
            grpFilter.Controls.Add(label2);
            grpFilter.Controls.Add(label1);
            grpFilter.Controls.Add(this.txtFilterName);
            grpFilter.Controls.Add(this.clstFilterTagOr);
            grpFilter.Controls.Add(this.cmbFilterProducer);
            grpFilter.Controls.Add(this.clstFilterTagAnd);
            grpFilter.Controls.Add(this.cmbFilterResolution);
            grpFilter.Controls.Add(this.dateFilterSaleDateBefore);
            grpFilter.Controls.Add(this.dateFilterSaleDateAfter);
            grpFilter.Location = new System.Drawing.Point(12, 12);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new System.Drawing.Size(1263, 292);
            grpFilter.TabIndex = 14;
            grpFilter.TabStop = false;
            grpFilter.Text = "过滤条件";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 20);
            label2.TabIndex = 4;
            label2.Text = "出版公司";
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
            // btnClearResolution
            // 
            this.btnClearResolution.Location = new System.Drawing.Point(276, 96);
            this.btnClearResolution.Name = "btnClearResolution";
            this.btnClearResolution.Size = new System.Drawing.Size(59, 31);
            this.btnClearResolution.TabIndex = 15;
            this.btnClearResolution.Text = "清除";
            this.btnClearResolution.UseVisualStyleBackColor = true;
            // 
            // btnClearProducer
            // 
            this.btnClearProducer.Location = new System.Drawing.Point(276, 59);
            this.btnClearProducer.Name = "btnClearProducer";
            this.btnClearProducer.Size = new System.Drawing.Size(59, 31);
            this.btnClearProducer.TabIndex = 16;
            this.btnClearProducer.Text = "清除";
            this.btnClearProducer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Aquamarine;
            label4.Location = new System.Drawing.Point(352, 24);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(220, 26);
            label4.TabIndex = 17;
            label4.Text = "包含以下所有标签";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = System.Drawing.Color.Aquamarine;
            label5.Location = new System.Drawing.Point(578, 24);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(220, 26);
            label5.TabIndex = 18;
            label5.Text = "包含以下任一标签";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Aquamarine;
            label6.Location = new System.Drawing.Point(804, 24);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(220, 26);
            label6.TabIndex = 19;
            label6.Text = "包含以下所有声优";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.Color.Aquamarine;
            label7.Location = new System.Drawing.Point(1030, 24);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(220, 26);
            label7.TabIndex = 20;
            label7.Text = "包含以下任一声优";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClearTagAnd
            // 
            this.btnClearTagAnd.Location = new System.Drawing.Point(351, 255);
            this.btnClearTagAnd.Name = "btnClearTagAnd";
            this.btnClearTagAnd.Size = new System.Drawing.Size(222, 31);
            this.btnClearTagAnd.TabIndex = 21;
            this.btnClearTagAnd.Text = "清除";
            this.btnClearTagAnd.UseVisualStyleBackColor = true;
            // 
            // btnClearName
            // 
            this.btnClearName.Location = new System.Drawing.Point(276, 22);
            this.btnClearName.Name = "btnClearName";
            this.btnClearName.Size = new System.Drawing.Size(59, 31);
            this.btnClearName.TabIndex = 22;
            this.btnClearName.Text = "清除";
            this.btnClearName.UseVisualStyleBackColor = true;
            // 
            // btnClearTagOr
            // 
            this.btnClearTagOr.Location = new System.Drawing.Point(577, 255);
            this.btnClearTagOr.Name = "btnClearTagOr";
            this.btnClearTagOr.Size = new System.Drawing.Size(222, 31);
            this.btnClearTagOr.TabIndex = 23;
            this.btnClearTagOr.Text = "清除";
            this.btnClearTagOr.UseVisualStyleBackColor = true;
            // 
            // btnClearVoiceActorAnd
            // 
            this.btnClearVoiceActorAnd.Location = new System.Drawing.Point(803, 255);
            this.btnClearVoiceActorAnd.Name = "btnClearVoiceActorAnd";
            this.btnClearVoiceActorAnd.Size = new System.Drawing.Size(222, 31);
            this.btnClearVoiceActorAnd.TabIndex = 24;
            this.btnClearVoiceActorAnd.Text = "清除";
            this.btnClearVoiceActorAnd.UseVisualStyleBackColor = true;
            // 
            // btnClearVoiceActorOr
            // 
            this.btnClearVoiceActorOr.Location = new System.Drawing.Point(1029, 255);
            this.btnClearVoiceActorOr.Name = "btnClearVoiceActorOr";
            this.btnClearVoiceActorOr.Size = new System.Drawing.Size(222, 31);
            this.btnClearVoiceActorOr.TabIndex = 25;
            this.btnClearVoiceActorOr.Text = "清除";
            this.btnClearVoiceActorOr.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(253, 230);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(82, 37);
            this.btnClearAll.TabIndex = 26;
            this.btnClearAll.Text = "清除所有";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // FrmBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 597);
            this.Controls.Add(grpFilter);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.dgvCast);
            this.Controls.Add(this.dgvTag);
            this.Controls.Add(this.dgvAnime);
            this.Name = "FrmBrowse";
            this.Text = "浏览";
            this.Load += new System.EventHandler(this.FrmBrowse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCast)).EndInit();
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
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
    }
}