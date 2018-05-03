namespace AniSuki.View
{
    partial class FrmConfig
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
            this.prop = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // prop
            // 
            this.prop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prop.Location = new System.Drawing.Point(0, 0);
            this.prop.Name = "prop";
            this.prop.Size = new System.Drawing.Size(384, 361);
            this.prop.TabIndex = 0;
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.prop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "FrmConfig";
            this.Text = "修改配置";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid prop;
    }
}