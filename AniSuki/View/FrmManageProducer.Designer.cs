namespace AniSuki.View
{
    partial class FrmManageProducer
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
            this.dgvProducer = new AniSuki.View.Control.ProducerDataGridView();
            this.txtName = new Neetsonic.Control.TextBox();
            this.txtWebsite = new Neetsonic.Control.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducer)).BeginInit();
            this.SuspendLayout();
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
            this.dgvProducer.DataList = null;
            this.dgvProducer.Location = new System.Drawing.Point(164, 87);
            this.dgvProducer.MultiSelect = false;
            this.dgvProducer.Name = "dgvProducer";
            this.dgvProducer.OpenLinkInBrowser = true;
            this.dgvProducer.ReadOnly = true;
            this.dgvProducer.RowHeadersVisible = false;
            this.dgvProducer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProducer.RowTemplate.Height = 23;
            this.dgvProducer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducer.Size = new System.Drawing.Size(519, 312);
            this.dgvProducer.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(358, 39);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(150, 26);
            this.txtWebsite.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(527, 37);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 31);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "添加";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(608, 37);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(689, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmManageProducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 511);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvProducer);
            this.Name = "FrmManageProducer";
            this.Text = "FrmManageProducer";
            this.Load += new System.EventHandler(this.FrmManageProducer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.ProducerDataGridView dgvProducer;
        private Neetsonic.Control.TextBox txtName;
        private Neetsonic.Control.TextBox txtWebsite;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}