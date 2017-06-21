namespace AniSuki.View
{
    partial class FrmResolution
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
            this.dgvResolution = new AniSuki.View.Control.ResolutionDataGridView();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmsDgvResolution = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.cmsDgvResolution.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResolution
            // 
            this.dgvResolution.AllowUserToAddRows = false;
            this.dgvResolution.AllowUserToDeleteRows = false;
            this.dgvResolution.AllowUserToResizeColumns = false;
            this.dgvResolution.AllowUserToResizeRows = false;
            this.dgvResolution.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResolution.BackgroundColor = System.Drawing.Color.White;
            this.dgvResolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResolution.ContextMenuStrip = this.cmsDgvResolution;
            this.dgvResolution.DataList = null;
            this.dgvResolution.Location = new System.Drawing.Point(12, 12);
            this.dgvResolution.MultiSelect = false;
            this.dgvResolution.Name = "dgvResolution";
            this.dgvResolution.OpenLinkInBrowser = false;
            this.dgvResolution.ReadOnly = true;
            this.dgvResolution.RowHeadersVisible = false;
            this.dgvResolution.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResolution.RowTemplate.Height = 23;
            this.dgvResolution.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResolution.Size = new System.Drawing.Size(260, 156);
            this.dgvResolution.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 181);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 20);
            label1.TabIndex = 1;
            label1.Text = "宽度";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(149, 181);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 20);
            label2.TabIndex = 2;
            label2.Text = "高度";
            // 
            // numWidth
            // 
            this.numWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWidth.Location = new System.Drawing.Point(51, 178);
            this.numWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(80, 26);
            this.numWidth.TabIndex = 3;
            // 
            // numHeight
            // 
            this.numHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHeight.Location = new System.Drawing.Point(192, 178);
            this.numHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(80, 26);
            this.numHeight.TabIndex = 4;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNew.Location = new System.Drawing.Point(12, 215);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 40);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "添  加";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(172, 215);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "更  新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // cmsDgvResolution
            // 
            this.cmsDgvResolution.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDelete});
            this.cmsDgvResolution.Name = "cmsDgvResolution";
            this.cmsDgvResolution.Size = new System.Drawing.Size(153, 50);
            this.cmsDgvResolution.Opening += new System.ComponentModel.CancelEventHandler(this.CmsDgvResolution_Opening);
            // 
            // menuDelete
            // 
            this.menuDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(152, 24);
            this.menuDelete.Text = "删除";
            this.menuDelete.Click += new System.EventHandler(this.MenuDelete_Click);
            // 
            // FrmResolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.dgvResolution);
            this.Name = "FrmResolution";
            this.Text = "管理分辨率";
            this.Load += new System.EventHandler(this.FrmResolution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.cmsDgvResolution.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.ResolutionDataGridView dgvResolution;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ContextMenuStrip cmsDgvResolution;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
    }
}