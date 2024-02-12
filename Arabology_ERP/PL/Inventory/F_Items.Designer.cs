
namespace Arabology_ERP.PL.Inventory
{
    partial class F_Items
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
            this.components = new System.ComponentModel.Container();
            this.btnNew = new System.Windows.Forms.Button();
            this.ckInActive = new System.Windows.Forms.CheckBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNameA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbItemSubType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPurchaseUnit = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbInventoryUnit = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSalesUnit = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbLargeUnit = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbMainUnit = new System.Windows.Forms.ComboBox();
            this.dgvUOM = new System.Windows.Forms.DataGridView();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.unitOfMeasureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(50, 86);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 50);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ckInActive
            // 
            this.ckInActive.AutoSize = true;
            this.ckInActive.Location = new System.Drawing.Point(60, 313);
            this.ckInActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckInActive.Name = "ckInActive";
            this.ckInActive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckInActive.Size = new System.Drawing.Size(101, 28);
            this.ckInActive.TabIndex = 1;
            this.ckInActive.Text = "  غير فعال";
            this.ckInActive.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(142, 349);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(369, 32);
            this.cmbCategory.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "الكود";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(142, 179);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(369, 32);
            this.txtID.TabIndex = 4;
            // 
            // txtNameA
            // 
            this.txtNameA.Location = new System.Drawing.Point(142, 221);
            this.txtNameA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameA.Name = "txtNameA";
            this.txtNameA.Size = new System.Drawing.Size(369, 32);
            this.txtNameA.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "الاسم بالعربية";
            // 
            // txtNameE
            // 
            this.txtNameE.Location = new System.Drawing.Point(142, 263);
            this.txtNameE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameE.Name = "txtNameE";
            this.txtNameE.Size = new System.Drawing.Size(369, 32);
            this.txtNameE.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "الاسم بالانجليزية";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(174, 86);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 50);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(298, 86);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 50);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(419, 86);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 50);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "القطاع";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(914, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "الأصناف";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 392);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "النوع";
            // 
            // cmbItemType
            // 
            this.cmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Location = new System.Drawing.Point(142, 389);
            this.cmbItemType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(369, 32);
            this.cmbItemType.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 432);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "الشركة المنتجة";
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(144, 429);
            this.cmbBrand.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(369, 32);
            this.cmbBrand.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 472);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "الدولة المنتجة";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(142, 469);
            this.cmbCountry.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(369, 32);
            this.cmbCountry.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 512);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "التصنيف";
            // 
            // cmbItemSubType
            // 
            this.cmbItemSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemSubType.FormattingEnabled = true;
            this.cmbItemSubType.Location = new System.Drawing.Point(142, 509);
            this.cmbItemSubType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbItemSubType.Name = "cmbItemSubType";
            this.cmbItemSubType.Size = new System.Drawing.Size(369, 32);
            this.cmbItemSubType.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-1, 712);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 24);
            this.label10.TabIndex = 31;
            this.label10.Text = "الوحدة للمشتريات";
            // 
            // cmbPurchaseUnit
            // 
            this.cmbPurchaseUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPurchaseUnit.FormattingEnabled = true;
            this.cmbPurchaseUnit.Location = new System.Drawing.Point(142, 709);
            this.cmbPurchaseUnit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPurchaseUnit.Name = "cmbPurchaseUnit";
            this.cmbPurchaseUnit.Size = new System.Drawing.Size(369, 32);
            this.cmbPurchaseUnit.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-1, 672);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 24);
            this.label11.TabIndex = 29;
            this.label11.Text = "الوحدة للتحويلات";
            // 
            // cmbInventoryUnit
            // 
            this.cmbInventoryUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInventoryUnit.FormattingEnabled = true;
            this.cmbInventoryUnit.Location = new System.Drawing.Point(142, 669);
            this.cmbInventoryUnit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbInventoryUnit.Name = "cmbInventoryUnit";
            this.cmbInventoryUnit.Size = new System.Drawing.Size(369, 32);
            this.cmbInventoryUnit.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 632);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "الوحدة للمبيعات";
            // 
            // cmbSalesUnit
            // 
            this.cmbSalesUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesUnit.FormattingEnabled = true;
            this.cmbSalesUnit.Location = new System.Drawing.Point(144, 629);
            this.cmbSalesUnit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSalesUnit.Name = "cmbSalesUnit";
            this.cmbSalesUnit.Size = new System.Drawing.Size(369, 32);
            this.cmbSalesUnit.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 592);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "الوحدة الكبرى";
            // 
            // cmbLargeUnit
            // 
            this.cmbLargeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLargeUnit.FormattingEnabled = true;
            this.cmbLargeUnit.Location = new System.Drawing.Point(142, 589);
            this.cmbLargeUnit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLargeUnit.Name = "cmbLargeUnit";
            this.cmbLargeUnit.Size = new System.Drawing.Size(369, 32);
            this.cmbLargeUnit.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 552);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 24);
            this.label14.TabIndex = 23;
            this.label14.Text = "الوحدة الرئيسية";
            // 
            // cmbMainUnit
            // 
            this.cmbMainUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainUnit.FormattingEnabled = true;
            this.cmbMainUnit.Location = new System.Drawing.Point(142, 549);
            this.cmbMainUnit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMainUnit.Name = "cmbMainUnit";
            this.cmbMainUnit.Size = new System.Drawing.Size(369, 32);
            this.cmbMainUnit.TabIndex = 22;
            // 
            // dgvUOM
            // 
            this.dgvUOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.MainUnit,
            this.Factory});
            this.dgvUOM.Location = new System.Drawing.Point(12, 800);
            this.dgvUOM.Name = "dgvUOM";
            this.dgvUOM.RowHeadersWidth = 51;
            this.dgvUOM.RowTemplate.Height = 24;
            this.dgvUOM.Size = new System.Drawing.Size(499, 191);
            this.dgvUOM.TabIndex = 32;
            this.dgvUOM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUOM_CellContentClick);
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(566, 86);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(785, 905);
            this.dgvItems.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(170, 763);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 24);
            this.label15.TabIndex = 34;
            this.label15.Text = "حساب وحدات الصنف";
            // 
            // unitOfMeasureBindingSource
            // 
            this.unitOfMeasureBindingSource.DataSource = typeof(Arabology_ERP.DAL.UnitOfMeasure);
            // 
            // ItemId
            // 
            this.ItemId.HeaderText = "كود الصنف";
            this.ItemId.MinimumWidth = 6;
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.Width = 125;
            // 
            // MainUnit
            // 
            this.MainUnit.HeaderText = "الوحدة الرئيسية";
            this.MainUnit.MinimumWidth = 6;
            this.MainUnit.Name = "MainUnit";
            this.MainUnit.ReadOnly = true;
            this.MainUnit.Width = 125;
            // 
            // Factory
            // 
            this.Factory.HeaderText = "المعامل";
            this.Factory.MinimumWidth = 6;
            this.Factory.Name = "Factory";
            this.Factory.Width = 125;
            // 
            // F_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1376, 1055);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.dgvUOM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbPurchaseUnit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbInventoryUnit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbSalesUnit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbLargeUnit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbMainUnit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbItemSubType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbItemType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNameE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.ckInActive);
            this.Controls.Add(this.btnNew);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F_Items";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الاصناف";
            this.Load += new System.EventHandler(this.F_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.CheckBox ckInActive;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNameA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbItemSubType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPurchaseUnit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbInventoryUnit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSalesUnit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbLargeUnit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbMainUnit;
        private System.Windows.Forms.DataGridView dgvUOM;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource unitOfMeasureBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factory;
    }
}