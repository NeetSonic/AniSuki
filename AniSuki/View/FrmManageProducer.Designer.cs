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
            this.producerDataGridView1 = new AniSuki.View.Control.ProducerDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.producerDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // producerDataGridView1
            // 
            this.producerDataGridView1.AllowUserToAddRows = false;
            this.producerDataGridView1.AllowUserToDeleteRows = false;
            this.producerDataGridView1.AllowUserToResizeColumns = false;
            this.producerDataGridView1.AllowUserToResizeRows = false;
            this.producerDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.producerDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.producerDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.producerDataGridView1.DataList = null;
            this.producerDataGridView1.Location = new System.Drawing.Point(73, 84);
            this.producerDataGridView1.MultiSelect = false;
            this.producerDataGridView1.Name = "producerDataGridView1";
            this.producerDataGridView1.OpenLinkInBrowser = true;
            this.producerDataGridView1.ReadOnly = true;
            this.producerDataGridView1.RowHeadersVisible = false;
            this.producerDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.producerDataGridView1.RowTemplate.Height = 23;
            this.producerDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.producerDataGridView1.Size = new System.Drawing.Size(787, 352);
            this.producerDataGridView1.TabIndex = 0;
            // 
            // FrmManageProducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 511);
            this.Controls.Add(this.producerDataGridView1);
            this.Name = "FrmManageProducer";
            this.Text = "FrmManageProducer";
            this.Load += new System.EventHandler(this.FrmManageProducer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.producerDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Control.ProducerDataGridView producerDataGridView1;
    }
}