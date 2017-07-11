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
            this.dgvAnimeFile = new AniSuki.View.Control.AnimeFileDataGridView();
            this.btnNewFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimeFile)).BeginInit();
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
            // FrmNewAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnNewFile);
            this.Controls.Add(this.dgvAnimeFile);
            this.Name = "FrmNewAnime";
            this.Text = "添加动画";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimeFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Control.AnimeFileDataGridView dgvAnimeFile;
        private System.Windows.Forms.Button btnNewFile;
    }
}