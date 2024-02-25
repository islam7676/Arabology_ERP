
namespace TestNew.UsCo
{
    partial class BrNameE
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
            this.txtBrNamee = new System.Windows.Forms.TextBox();
            this.lblBrNamee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBrNamee
            // 
            this.txtBrNamee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrNamee.Location = new System.Drawing.Point(3, 5);
            this.txtBrNamee.Name = "txtBrNamee";
            this.txtBrNamee.Size = new System.Drawing.Size(212, 29);
            this.txtBrNamee.TabIndex = 7;
            // 
            // lblBrNamee
            // 
            this.lblBrNamee.AutoSize = true;
            this.lblBrNamee.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBrNamee.Location = new System.Drawing.Point(217, 8);
            this.lblBrNamee.Name = "lblBrNamee";
            this.lblBrNamee.Size = new System.Drawing.Size(104, 22);
            this.lblBrNamee.TabIndex = 6;
            this.lblBrNamee.Text = "الاسم الانجليزى";
            // 
            // BrNameE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBrNamee);
            this.Controls.Add(this.lblBrNamee);
            this.Name = "BrNameE";
            this.Size = new System.Drawing.Size(322, 44);
            this.Resize += new System.EventHandler(this.BrNameE_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrNamee;
        private System.Windows.Forms.Label lblBrNamee;
    }
}
