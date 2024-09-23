namespace Repaso
{
    partial class FormVer
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
            if (disposing && (components != null))
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
            this.lbxVer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxVer
            // 
            this.lbxVer.FormattingEnabled = true;
            this.lbxVer.Location = new System.Drawing.Point(30, 30);
            this.lbxVer.Name = "lbxVer";
            this.lbxVer.Size = new System.Drawing.Size(240, 95);
            this.lbxVer.TabIndex = 0;
            // 
            // FormVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 205);
            this.Controls.Add(this.lbxVer);
            this.Name = "FormVer";
            this.Text = "FormVer";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbxVer;
    }
}