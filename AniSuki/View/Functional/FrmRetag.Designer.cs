namespace AniSuki.View.Functional
{
    partial class FrmRetag
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
            this.clstTag = new AniSuki.View.Control.TagCheckedListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnManageTag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clstTag
            // 
            this.clstTag.CheckOnClick = true;
            this.clstTag.DataList = null;
            this.clstTag.FormattingEnabled = true;
            this.clstTag.HorizontalScrollbar = true;
            this.clstTag.Location = new System.Drawing.Point(12, 12);
            this.clstTag.Name = "clstTag";
            this.clstTag.Size = new System.Drawing.Size(255, 361);
            this.clstTag.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(76, 422);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(126, 41);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnManageTag
            // 
            this.btnManageTag.Location = new System.Drawing.Point(92, 379);
            this.btnManageTag.Name = "btnManageTag";
            this.btnManageTag.Size = new System.Drawing.Size(95, 37);
            this.btnManageTag.TabIndex = 3;
            this.btnManageTag.Text = "管理标签";
            this.btnManageTag.UseVisualStyleBackColor = true;
            this.btnManageTag.Click += new System.EventHandler(this.BtnManageTag_Click);
            // 
            // FrmRetag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 472);
            this.Controls.Add(this.btnManageTag);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.clstTag);
            this.Name = "FrmRetag";
            this.Text = "更新标签";
            this.Load += new System.EventHandler(this.FrmRetag_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.TagCheckedListBox clstTag;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnManageTag;
    }
}