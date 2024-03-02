
namespace TestNew
{
    partial class BrID
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
            this.lblBrId = new System.Windows.Forms.Label();
            this.txtBrId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBrId
            // 
            this.lblBrId.AutoSize = true;
            this.lblBrId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBrId.Location = new System.Drawing.Point(120, 8);
            this.lblBrId.Name = "lblBrId";
            this.lblBrId.Size = new System.Drawing.Size(57, 22);
            this.lblBrId.TabIndex = 0;
            this.lblBrId.Text = "الكــــود";
            this.lblBrId.Click += new System.EventHandler(this.lblBrId_Click);
            // 
            // txtBrId
            // 
            this.txtBrId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrId.Location = new System.Drawing.Point(6, 3);
            this.txtBrId.Name = "txtBrId";
            this.txtBrId.Size = new System.Drawing.Size(111, 29);
            this.txtBrId.TabIndex = 1;
            this.txtBrId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BrID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBrId);
            this.Controls.Add(this.lblBrId);
            this.Name = "BrID";
            this.Size = new System.Drawing.Size(221, 41);
            this.Resize += new System.EventHandler(this.Branches_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrId;
        private System.Windows.Forms.TextBox txtBrId;
    }
}
