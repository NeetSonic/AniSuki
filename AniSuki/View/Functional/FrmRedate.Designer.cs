namespace AniSuki.View.Functional
{
    partial class FrmRedate
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(12, 12);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(210, 26);
            this.date.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(54, 44);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(126, 41);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // FrmRedate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 93);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.date);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "FrmRedate";
            this.Text = "更新发售时间";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button btnOK;
    }
}