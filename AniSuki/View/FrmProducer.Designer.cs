namespace AniSuki.View
{
    partial class FrmProducer
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
            this.dgvProducer = new AniSuki.View.Control.ProducerDataGridView();
            this.cmsDgvProducer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.txtName = new Neetsonic.Control.TextBox();
            this.txtWebsite = new Neetsonic.Control.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducer)).BeginInit();
            this.cmsDgvProducer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 407);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 20);
            label1.TabIndex = 5;
            label1.Text = "公司名称";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 445);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 20);
            label2.TabIndex = 6;
            label2.Text = "官方网站";
            // 
            // dgvProducer
            // 
            this.dgvProducer.AllowUserToAddRows = false;
            this.dgvProducer.AllowUserToDeleteRows = false;
            this.dgvProducer.AllowUserToResizeColumns = false;
            this.dgvProducer.AllowUserToResizeRows = false;
            this.dgvProducer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducer.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducer.ContextMenuStrip = this.cmsDgvProducer;
            this.dgvProducer.DataList = null;
            this.dgvProducer.Location = new System.Drawing.Point(12, 12);
            this.dgvProducer.MultiSelect = false;
            this.dgvProducer.Name = "dgvProducer";
            this.dgvProducer.OpenLinkInBrowser = true;
            this.dgvProducer.ReadOnly = true;
            this.dgvProducer.RowHeadersVisible = false;
            this.dgvProducer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProducer.RowTemplate.Height = 23;
            this.dgvProducer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducer.Size = new System.Drawing.Size(600, 380);
            this.dgvProducer.TabIndex = 0;
            // 
            // cmsDgvProducer
            // 
            this.cmsDgvProducer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmsDgvProducer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDelete});
            this.cmsDgvProducer.Name = "cmsDgvProducer";
            this.cmsDgvProducer.Size = new System.Drawing.Size(153, 50);
            this.cmsDgvProducer.Opening += new System.ComponentModel.CancelEventHandler(this.CmsDgvProducer_Opening);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(152, 24);
            this.menuDelete.Text = "删除";
            this.menuDelete.Click += new System.EventHandler(this.MenuDelete_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 404);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(522, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(90, 442);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(522, 26);
            this.txtWebsite.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNew.Location = new System.Drawing.Point(12, 485);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(200, 50);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "添  加";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(412, 484);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 50);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "更  新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // FrmProducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 546);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvProducer);
            this.Name = "FrmProducer";
            this.Text = "管理出版公司";
            this.Load += new System.EventHandler(this.FrmProducer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducer)).EndInit();
            this.cmsDgvProducer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.ProducerDataGridView dgvProducer;
        private Neetsonic.Control.TextBox txtName;
        private Neetsonic.Control.TextBox txtWebsite;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ContextMenuStrip cmsDgvProducer;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
    }
}