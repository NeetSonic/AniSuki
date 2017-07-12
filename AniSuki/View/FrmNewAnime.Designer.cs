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
            this.dgvAnimeFile = new AniSuki.View.Control.AnimeFileDataGridView();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.tabTag = new System.Windows.Forms.TabPage();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tabCast = new System.Windows.Forms.TabPage();
            this.txtName = new Neetsonic.Control.TextBox();
            this.cmbResolution = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimeFile)).BeginInit();
            this.tabBase.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvAnimeFile.Size = new System.Drawing.Size(760, 222);
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
            this.tabTag.Location = new System.Drawing.Point(4, 29);
            this.tabTag.Name = "tabTag";
            this.tabTag.Padding = new System.Windows.Forms.Padding(3);
            this.tabTag.Size = new System.Drawing.Size(752, 185);
            this.tabTag.TabIndex = 1;
            this.tabTag.Text = "标签";
            this.tabTag.UseVisualStyleBackColor = true;
            // 
            // tabBase
            // 
            this.tabBase.Controls.Add(this.cmbResolution);
            this.tabBase.Controls.Add(label2);
            this.tabBase.Controls.Add(this.txtName);
            this.tabBase.Controls.Add(label1);
            this.tabBase.Location = new System.Drawing.Point(4, 29);
            this.tabBase.Name = "tabBase";
            this.tabBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabBase.Size = new System.Drawing.Size(752, 185);
            this.tabBase.TabIndex = 0;
            this.tabBase.Text = "基本";
            this.tabBase.UseVisualStyleBackColor = true;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.tabBase);
            this.tabInfo.Controls.Add(this.tabTag);
            this.tabInfo.Controls.Add(this.tabCast);
            this.tabInfo.Location = new System.Drawing.Point(12, 282);
            this.tabInfo.Multiline = true;
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedIndex = 0;
            this.tabInfo.Size = new System.Drawing.Size(760, 218);
            this.tabInfo.TabIndex = 2;
            // 
            // tabCast
            // 
            this.tabCast.Location = new System.Drawing.Point(4, 29);
            this.tabCast.Name = "tabCast";
            this.tabCast.Size = new System.Drawing.Size(752, 185);
            this.tabCast.TabIndex = 2;
            this.tabCast.Text = "配音";
            this.tabCast.UseVisualStyleBackColor = true;
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(669, 26);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 53);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 20);
            label2.TabIndex = 2;
            label2.Text = "分辨率";
            // 
            // cmbResolution
            // 
            this.cmbResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResolution.FormattingEnabled = true;
            this.cmbResolution.Location = new System.Drawing.Point(77, 50);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(121, 28);
            this.cmbResolution.TabIndex = 3;
            // 
            // FrmNewAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabInfo);
            this.Controls.Add(this.btnNewFile);
            this.Controls.Add(this.dgvAnimeFile);
            this.Name = "FrmNewAnime";
            this.Text = "添加动画";
            this.Load += new System.EventHandler(this.FrmNewAnime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimeFile)).EndInit();
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}