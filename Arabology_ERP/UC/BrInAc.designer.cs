
namespace TestNew.UsCo
{
    partial class BrInAc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chInActive = new System.Windows.Forms.CheckBox();
            this.lblInActive = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chInActive
            // 
            this.chInActive.AutoSize = true;
            this.chInActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chInActive.Location = new System.Drawing.Point(7, 9);
            this.chInActive.Name = "chInActive";
            this.chInActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chInActive.Size = new System.Drawing.Size(15, 14);
            this.chInActive.TabIndex = 10;
            this.chInActive.UseVisualStyleBackColor = true;
            // 
            // lblInActive
            // 
            this.lblInActive.AutoSize = true;
            this.lblInActive.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblInActive.Location = new System.Drawing.Point(38, 5);
            this.lblInActive.Name = "lblInActive";
            this.lblInActive.Size = new System.Drawing.Size(64, 22);
            this.lblInActive.TabIndex = 9;
            this.lblInActive.Text = "غير فعال";
            this.lblInActive.Click += new System.EventHandler(this.lblInActive_Click);
            // 
            // BrInAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chInActive);
            this.Controls.Add(this.lblInActive);
            this.Name = "BrInAc";
            this.Size = new System.Drawing.Size(105, 32);
            this.Resize += new System.EventHandler(this.BrInAc_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chInActive;
        private System.Windows.Forms.Label lblInActive;
    }
}
