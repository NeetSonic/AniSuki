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
            this.checkedDateTimePicker1 = new Neetsonic.Control.CheckedDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnime)).BeginInit();
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
            // checkedDateTimePicker1
            // 
            this.checkedDateTimePicker1.CheckText = "";
            this.checkedDateTimePicker1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkedDateTimePicker1.Location = new System.Drawing.Point(12, 128);
            this.checkedDateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedDateTimePicker1.MaximumSize = new System.Drawing.Size(2000, 26);
            this.checkedDateTimePicker1.MinimumSize = new System.Drawing.Size(30, 26);
            this.checkedDateTimePicker1.Name = "checkedDateTimePicker1";
            this.checkedDateTimePicker1.Size = new System.Drawing.Size(225, 26);
            this.checkedDateTimePicker1.TabIndex = 4;
            // 
            // FrmBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 328);
            this.Controls.Add(this.checkedDateTimePicker1);
            this.Controls.Add(this.cmbFilterResolution);
            this.Controls.Add(this.cmbFilterProducer);
            this.Controls.Add(this.txtFilterName);
            this.Controls.Add(this.dgvAnime);
            this.Name = "FrmBrowse";
            this.Text = "浏览动画";
            this.Load += new System.EventHandler(this.FrmBrowse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.AnimeDataGridView dgvAnime;
        private Neetsonic.Control.TextBox txtFilterName;
        private System.Windows.Forms.ComboBox cmbFilterProducer;
        private System.Windows.Forms.ComboBox cmbFilterResolution;
        private Neetsonic.Control.CheckedDateTimePicker checkedDateTimePicker1;
    }
}