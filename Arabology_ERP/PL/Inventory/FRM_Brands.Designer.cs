
namespace Arabology_ERP.PL.Inventory
{
    partial class FRM_Brands
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BrandId = new TestNew.BrID();
            this.searchBrand = new TestNew.UsCo.Search();
            this.BrandNameA = new TestNew.BrNameA();
            this.BrandNameE = new TestNew.UsCo.BrNameE();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InActiveBrand = new TestNew.UsCo.BrInAc();
            this.butBrandNew = new System.Windows.Forms.Button();
            this.butBrandEdit = new System.Windows.Forms.Button();
            this.butBrandAdd = new System.Windows.Forms.Button();
            this.butBrandEx = new System.Windows.Forms.Button();
            this.butBrandRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BrandId
            // 
            this.BrandId.Location = new System.Drawing.Point(700, 173);
            this.BrandId.Name = "BrandId";
            this.BrandId.Size = new System.Drawing.Size(185, 41);
            this.BrandId.TabIndex = 1;
            // 
            // searchBrand
            // 
            this.searchBrand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchBrand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchBrand.Location = new System.Drawing.Point(461, 60);
            this.searchBrand.Margin = new System.Windows.Forms.Padding(5);
            this.searchBrand.Name = "searchBrand";
            this.searchBrand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchBrand.searchText = "";
            this.searchBrand.Size = new System.Drawing.Size(450, 91);
            this.searchBrand.TabIndex = 2;
            // 
            // BrandNameA
            // 
            this.BrandNameA.Location = new System.Drawing.Point(461, 234);
            this.BrandNameA.Name = "BrandNameA";
            this.BrandNameA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BrandNameA.Size = new System.Drawing.Size(449, 43);
            this.BrandNameA.TabIndex = 3;
            this.BrandNameA.Load += new System.EventHandler(this.brNameA1_Load);
            // 
            // BrandNameE
            // 
            this.BrandNameE.Location = new System.Drawing.Point(461, 286);
            this.BrandNameE.Name = "BrandNameE";
            this.BrandNameE.Size = new System.Drawing.Size(455, 44);
            this.BrandNameE.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "الشــــــركات المنتــجه";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Size = new System.Drawing.Size(443, 454);
            this.dataGridView1.TabIndex = 6;
            // 
            // InActiveBrand
            // 
            this.InActiveBrand.Location = new System.Drawing.Point(789, 336);
            this.InActiveBrand.Name = "InActiveBrand";
            this.InActiveBrand.Size = new System.Drawing.Size(105, 32);
            this.InActiveBrand.TabIndex = 7;
            // 
            // butBrandNew
            // 
            this.butBrandNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butBrandNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butBrandNew.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBrandNew.Location = new System.Drawing.Point(707, 374);
            this.butBrandNew.Name = "butBrandNew";
            this.butBrandNew.Size = new System.Drawing.Size(187, 39);
            this.butBrandNew.TabIndex = 21;
            this.butBrandNew.Text = "جـــــديد";
            this.butBrandNew.UseVisualStyleBackColor = true;
            // 
            // butBrandEdit
            // 
            this.butBrandEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butBrandEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butBrandEdit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBrandEdit.Location = new System.Drawing.Point(707, 425);
            this.butBrandEdit.Name = "butBrandEdit";
            this.butBrandEdit.Size = new System.Drawing.Size(187, 39);
            this.butBrandEdit.TabIndex = 20;
            this.butBrandEdit.Text = "تعــديل";
            this.butBrandEdit.UseVisualStyleBackColor = true;
            // 
            // butBrandAdd
            // 
            this.butBrandAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butBrandAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butBrandAdd.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBrandAdd.Location = new System.Drawing.Point(523, 373);
            this.butBrandAdd.Name = "butBrandAdd";
            this.butBrandAdd.Size = new System.Drawing.Size(178, 39);
            this.butBrandAdd.TabIndex = 19;
            this.butBrandAdd.Text = "اضـــــافه";
            this.butBrandAdd.UseVisualStyleBackColor = true;
            // 
            // butBrandEx
            // 
            this.butBrandEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butBrandEx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butBrandEx.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBrandEx.Location = new System.Drawing.Point(523, 473);
            this.butBrandEx.Name = "butBrandEx";
            this.butBrandEx.Size = new System.Drawing.Size(371, 39);
            this.butBrandEx.TabIndex = 18;
            this.butBrandEx.Text = "خــروج";
            this.butBrandEx.UseVisualStyleBackColor = true;
            // 
            // butBrandRemove
            // 
            this.butBrandRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butBrandRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butBrandRemove.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBrandRemove.Location = new System.Drawing.Point(523, 425);
            this.butBrandRemove.Name = "butBrandRemove";
            this.butBrandRemove.Size = new System.Drawing.Size(178, 39);
            this.butBrandRemove.TabIndex = 17;
            this.butBrandRemove.Text = "حـــذف";
            this.butBrandRemove.UseVisualStyleBackColor = true;
            // 
            // FRM_Brands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 520);
            this.Controls.Add(this.butBrandNew);
            this.Controls.Add(this.butBrandEdit);
            this.Controls.Add(this.butBrandAdd);
            this.Controls.Add(this.butBrandEx);
            this.Controls.Add(this.butBrandRemove);
            this.Controls.Add(this.InActiveBrand);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrandNameE);
            this.Controls.Add(this.BrandNameA);
            this.Controls.Add(this.searchBrand);
            this.Controls.Add(this.BrandId);
            this.Name = "FRM_Brands";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TestNew.BrID BrandId;
        private TestNew.UsCo.Search searchBrand;
        private TestNew.BrNameA BrandNameA;
        private TestNew.UsCo.BrNameE BrandNameE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TestNew.UsCo.BrInAc InActiveBrand;
        private System.Windows.Forms.Button butBrandNew;
        private System.Windows.Forms.Button butBrandEdit;
        private System.Windows.Forms.Button butBrandAdd;
        private System.Windows.Forms.Button butBrandEx;
        private System.Windows.Forms.Button butBrandRemove;
    }
}