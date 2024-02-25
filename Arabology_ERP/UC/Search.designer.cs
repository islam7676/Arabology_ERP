
namespace TestNew.UsCo
{
    partial class Search
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
            this.txtSeach = new System.Windows.Forms.TextBox();
            this.rbStratWith = new System.Windows.Forms.RadioButton();
            this.rbEqual = new System.Windows.Forms.RadioButton();
            this.rbContains = new System.Windows.Forms.RadioButton();
            this.groBoxseach = new System.Windows.Forms.GroupBox();
            this.groBoxseach.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSeach
            // 
            this.txtSeach.Location = new System.Drawing.Point(5, 5);
            this.txtSeach.Margin = new System.Windows.Forms.Padding(5);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(440, 26);
            this.txtSeach.TabIndex = 1;
            this.txtSeach.TextChanged += new System.EventHandler(this.txtSeach_TextChanged);
            // 
            // rbStratWith
            // 
            this.rbStratWith.AutoSize = true;
            this.rbStratWith.Checked = true;
            this.rbStratWith.Location = new System.Drawing.Point(303, 16);
            this.rbStratWith.Name = "rbStratWith";
            this.rbStratWith.Size = new System.Drawing.Size(89, 23);
            this.rbStratWith.TabIndex = 2;
            this.rbStratWith.TabStop = true;
            this.rbStratWith.Text = "بحــث تلقائى";
            this.rbStratWith.UseVisualStyleBackColor = true;
            this.rbStratWith.CheckedChanged += new System.EventHandler(this.rbStratWith_CheckedChanged);
            // 
            // rbEqual
            // 
            this.rbEqual.AutoSize = true;
            this.rbEqual.Location = new System.Drawing.Point(28, 16);
            this.rbEqual.Name = "rbEqual";
            this.rbEqual.Size = new System.Drawing.Size(92, 23);
            this.rbEqual.TabIndex = 3;
            this.rbEqual.TabStop = true;
            this.rbEqual.Text = "بحــث مطابق";
            this.rbEqual.UseVisualStyleBackColor = true;
            this.rbEqual.CheckedChanged += new System.EventHandler(this.rbEqual_CheckedChanged);
            // 
            // rbContains
            // 
            this.rbContains.AutoSize = true;
            this.rbContains.Location = new System.Drawing.Point(154, 16);
            this.rbContains.Name = "rbContains";
            this.rbContains.Size = new System.Drawing.Size(115, 23);
            this.rbContains.TabIndex = 4;
            this.rbContains.TabStop = true;
            this.rbContains.Text = "جــزء من النــص";
            this.rbContains.UseVisualStyleBackColor = true;
            this.rbContains.CheckedChanged += new System.EventHandler(this.rbContains_CheckedChanged);
            // 
            // groBoxseach
            // 
            this.groBoxseach.Controls.Add(this.rbStratWith);
            this.groBoxseach.Controls.Add(this.rbEqual);
            this.groBoxseach.Controls.Add(this.rbContains);
            this.groBoxseach.Location = new System.Drawing.Point(8, 39);
            this.groBoxseach.Name = "groBoxseach";
            this.groBoxseach.Size = new System.Drawing.Size(436, 47);
            this.groBoxseach.TabIndex = 5;
            this.groBoxseach.TabStop = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groBoxseach);
            this.Controls.Add(this.txtSeach);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Search";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(450, 91);
            this.Load += new System.EventHandler(this.Search_Load);
            this.Resize += new System.EventHandler(this.Search_Resize);
            this.groBoxseach.ResumeLayout(false);
            this.groBoxseach.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSeach;
        private System.Windows.Forms.RadioButton rbStratWith;
        private System.Windows.Forms.RadioButton rbEqual;
        private System.Windows.Forms.RadioButton rbContains;
        private System.Windows.Forms.GroupBox groBoxseach;
    }
}
