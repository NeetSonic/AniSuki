namespace AniSuki.View
{
    partial class FrmVoiceActor
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtName = new Neetsonic.Control.TextBox();
            this.dgvVoiceActor = new AniSuki.View.Control.VoiceActorDataGridView();
            this.cmsDgvVoiceActor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoiceActor)).BeginInit();
            this.cmsDgvVoiceActor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 295);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 20);
            label1.TabIndex = 16;
            label1.Text = "标签名称";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(142, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "更  新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNew.Location = new System.Drawing.Point(12, 333);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 40);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "添  加";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 292);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 26);
            this.txtName.TabIndex = 13;
            // 
            // dgvVoiceActor
            // 
            this.dgvVoiceActor.AllowUserToAddRows = false;
            this.dgvVoiceActor.AllowUserToDeleteRows = false;
            this.dgvVoiceActor.AllowUserToResizeColumns = false;
            this.dgvVoiceActor.AllowUserToResizeRows = false;
            this.dgvVoiceActor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVoiceActor.BackgroundColor = System.Drawing.Color.White;
            this.dgvVoiceActor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoiceActor.ContextMenuStrip = this.cmsDgvVoiceActor;
            this.dgvVoiceActor.DataList = null;
            this.dgvVoiceActor.Location = new System.Drawing.Point(12, 12);
            this.dgvVoiceActor.MultiSelect = false;
            this.dgvVoiceActor.Name = "dgvVoiceActor";
            this.dgvVoiceActor.OpenLinkInBrowser = false;
            this.dgvVoiceActor.ReadOnly = true;
            this.dgvVoiceActor.RowHeadersVisible = false;
            this.dgvVoiceActor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVoiceActor.RowTemplate.Height = 23;
            this.dgvVoiceActor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVoiceActor.Size = new System.Drawing.Size(230, 270);
            this.dgvVoiceActor.TabIndex = 17;
            // 
            // cmsDgvVoiceActor
            // 
            this.cmsDgvVoiceActor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDelete});
            this.cmsDgvVoiceActor.Name = "cmsDgvVoiceActor";
            this.cmsDgvVoiceActor.Size = new System.Drawing.Size(101, 26);
            this.cmsDgvVoiceActor.Opening += new System.ComponentModel.CancelEventHandler(this.CmsDgvVoiceActor_Opening);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(100, 22);
            this.menuDelete.Text = "删除";
            this.menuDelete.Click += new System.EventHandler(this.MenuDelete_Click);
            // 
            // FrmVoiceActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 384);
            this.Controls.Add(this.dgvVoiceActor);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtName);
            this.Name = "FrmVoiceActor";
            this.Text = "管理声优";
            this.Load += new System.EventHandler(this.FrmVoiceActor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoiceActor)).EndInit();
            this.cmsDgvVoiceActor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private Neetsonic.Control.TextBox txtName;
        private Control.VoiceActorDataGridView dgvVoiceActor;
        private System.Windows.Forms.ContextMenuStrip cmsDgvVoiceActor;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
    }
}