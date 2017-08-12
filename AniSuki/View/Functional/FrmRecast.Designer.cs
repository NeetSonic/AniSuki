namespace AniSuki.View.Functional
{
    partial class FrmRecast
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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            this.btnNewCast = new System.Windows.Forms.Button();
            this.btnManageVoiceActor = new System.Windows.Forms.Button();
            this.cmbVoiceActor = new System.Windows.Forms.ComboBox();
            this.txtCharaName = new Neetsonic.Control.TextBox();
            this.dgvCast = new AniSuki.View.Control.CastDataGridView();
            this.menuDgvCast = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDeleteCast = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOK = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCast)).BeginInit();
            this.menuDgvCast.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(9, 12);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(37, 20);
            label7.TabIndex = 11;
            label7.Text = "声优";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(9, 51);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(37, 20);
            label6.TabIndex = 10;
            label6.Text = "角色";
            // 
            // btnNewCast
            // 
            this.btnNewCast.Location = new System.Drawing.Point(208, 81);
            this.btnNewCast.Name = "btnNewCast";
            this.btnNewCast.Size = new System.Drawing.Size(99, 40);
            this.btnNewCast.TabIndex = 14;
            this.btnNewCast.Text = "添加";
            this.btnNewCast.UseVisualStyleBackColor = true;
            this.btnNewCast.Click += new System.EventHandler(this.BtnNewCast_Click);
            // 
            // btnManageVoiceActor
            // 
            this.btnManageVoiceActor.Location = new System.Drawing.Point(403, 7);
            this.btnManageVoiceActor.Name = "btnManageVoiceActor";
            this.btnManageVoiceActor.Size = new System.Drawing.Size(99, 31);
            this.btnManageVoiceActor.TabIndex = 13;
            this.btnManageVoiceActor.Text = "管理声优";
            this.btnManageVoiceActor.UseVisualStyleBackColor = true;
            this.btnManageVoiceActor.Click += new System.EventHandler(this.BtnManageVoiceActor_Click);
            // 
            // cmbVoiceActor
            // 
            this.cmbVoiceActor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoiceActor.FormattingEnabled = true;
            this.cmbVoiceActor.Location = new System.Drawing.Point(52, 9);
            this.cmbVoiceActor.Name = "cmbVoiceActor";
            this.cmbVoiceActor.Size = new System.Drawing.Size(333, 28);
            this.cmbVoiceActor.TabIndex = 12;
            // 
            // txtCharaName
            // 
            this.txtCharaName.Location = new System.Drawing.Point(52, 48);
            this.txtCharaName.Name = "txtCharaName";
            this.txtCharaName.Size = new System.Drawing.Size(450, 26);
            this.txtCharaName.TabIndex = 9;
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
            this.dgvCast.Location = new System.Drawing.Point(12, 129);
            this.dgvCast.MultiSelect = false;
            this.dgvCast.Name = "dgvCast";
            this.dgvCast.OpenLinkInBrowser = false;
            this.dgvCast.ReadOnly = true;
            this.dgvCast.RowHeadersVisible = false;
            this.dgvCast.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCast.RowTemplate.Height = 23;
            this.dgvCast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCast.Size = new System.Drawing.Size(490, 362);
            this.dgvCast.TabIndex = 8;
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
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(194, 497);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(126, 41);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // FrmRecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 545);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnNewCast);
            this.Controls.Add(this.btnManageVoiceActor);
            this.Controls.Add(this.cmbVoiceActor);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(this.txtCharaName);
            this.Controls.Add(this.dgvCast);
            this.Name = "FrmRecast";
            this.Text = "更新配音";
            this.Load += new System.EventHandler(this.FrmRecast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCast)).EndInit();
            this.menuDgvCast.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewCast;
        private System.Windows.Forms.Button btnManageVoiceActor;
        private System.Windows.Forms.ComboBox cmbVoiceActor;
        private Neetsonic.Control.TextBox txtCharaName;
        private Control.CastDataGridView dgvCast;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ContextMenuStrip menuDgvCast;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteCast;
    }
}