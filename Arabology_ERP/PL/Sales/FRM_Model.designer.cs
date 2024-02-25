
namespace TestNew
{
    partial class FRM_Model
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
            this.label1 = new System.Windows.Forms.Label();
            this.butRemove = new System.Windows.Forms.Button();
            this.butEx = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.brID1 = new TestNew.BrID();
            this.brInAc1 = new TestNew.UsCo.BrInAc();
            this.brNameE1 = new TestNew.UsCo.BrNameE();
            this.brNameA1 = new TestNew.BrNameA();
            this.search2 = new TestNew.UsCo.Search();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "الفــــــــــــــــــــــــروع";
            // 
            // butRemove
            // 
            this.butRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butRemove.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRemove.Location = new System.Drawing.Point(530, 431);
            this.butRemove.Name = "butRemove";
            this.butRemove.Size = new System.Drawing.Size(178, 39);
            this.butRemove.TabIndex = 8;
            this.butRemove.Text = "حـــذف";
            this.butRemove.UseVisualStyleBackColor = true;
            // 
            // butEx
            // 
            this.butEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butEx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butEx.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEx.Location = new System.Drawing.Point(530, 479);
            this.butEx.Name = "butEx";
            this.butEx.Size = new System.Drawing.Size(371, 39);
            this.butEx.TabIndex = 9;
            this.butEx.Text = "خــروج";
            this.butEx.UseVisualStyleBackColor = true;
            this.butEx.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 454);
            this.dataGridView1.TabIndex = 10;
            // 
            // butAdd
            // 
            this.butAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butAdd.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.Location = new System.Drawing.Point(530, 379);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(178, 39);
            this.butAdd.TabIndex = 12;
            this.butAdd.Text = "اضـــــافه";
            this.butAdd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(714, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "تعــديل";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(714, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 39);
            this.button2.TabIndex = 16;
            this.button2.Text = "جـــــديد";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // brID1
            // 
            this.brID1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brID1.Location = new System.Drawing.Point(695, 169);
            this.brID1.Name = "brID1";
            this.brID1.Size = new System.Drawing.Size(196, 41);
            this.brID1.TabIndex = 5;
            // 
            // brInAc1
            // 
            this.brInAc1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brInAc1.Location = new System.Drawing.Point(798, 321);
            this.brInAc1.Name = "brInAc1";
            this.brInAc1.Size = new System.Drawing.Size(77, 32);
            this.brInAc1.TabIndex = 4;
            // 
            // brNameE1
            // 
            this.brNameE1.Location = new System.Drawing.Point(457, 276);
            this.brNameE1.Name = "brNameE1";
            this.brNameE1.Size = new System.Drawing.Size(457, 41);
            this.brNameE1.TabIndex = 3;
            // 
            // brNameA1
            // 
            this.brNameA1.Location = new System.Drawing.Point(457, 227);
            this.brNameA1.Name = "brNameA1";
            this.brNameA1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.brNameA1.Size = new System.Drawing.Size(449, 43);
            this.brNameA1.TabIndex = 2;
            // 
            // search2
            // 
            this.search2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.search2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.search2.Location = new System.Drawing.Point(464, 54);
            this.search2.Margin = new System.Windows.Forms.Padding(5);
            this.search2.Name = "search2";
            this.search2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.search2.searchText = "";
            this.search2.Size = new System.Drawing.Size(450, 91);
            this.search2.TabIndex = 18;
            this.search2.SearchTextChanged += new System.EventHandler(this.search2_SearchTextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 276);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 520);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.search2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butEx);
            this.Controls.Add(this.butRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brID1);
            this.Controls.Add(this.brInAc1);
            this.Controls.Add(this.brNameE1);
            this.Controls.Add(this.brNameA1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BrNameA brNameA1;
        private UsCo.BrNameE brNameE1;
        private UsCo.BrInAc brInAc1;
        private BrID brID1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butRemove;
        private System.Windows.Forms.Button butEx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UsCo.Search search2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

