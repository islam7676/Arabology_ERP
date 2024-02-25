
namespace TestNew
{
    partial class BrNameA
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
            this.txtBrNameA = new System.Windows.Forms.TextBox();
            this.lblBrNameA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBrNameA
            // 
            this.txtBrNameA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrNameA.Location = new System.Drawing.Point(9, 4);
            this.txtBrNameA.Name = "txtBrNameA";
            this.txtBrNameA.Size = new System.Drawing.Size(212, 29);
            this.txtBrNameA.TabIndex = 15;
            // 
            // lblBrNameA
            // 
            this.lblBrNameA.AutoSize = true;
            this.lblBrNameA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBrNameA.Location = new System.Drawing.Point(224, 8);
            this.lblBrNameA.Name = "lblBrNameA";
            this.lblBrNameA.Size = new System.Drawing.Size(98, 22);
            this.lblBrNameA.TabIndex = 14;
            this.lblBrNameA.Text = "الاســـم العربى";
            this.lblBrNameA.Click += new System.EventHandler(this.lblBranchNameA_Click);
            // 
            // BrNameA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBrNameA);
            this.Controls.Add(this.lblBrNameA);
            this.Name = "BrNameA";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(332, 43);
            this.Resize += new System.EventHandler(this.Branches2_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBrNameA;
        private System.Windows.Forms.Label lblBrNameA;
    }
}
