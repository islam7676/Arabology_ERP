using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;
using Arabology_ERP.DAL;

namespace Arabology_ERP.PL.Inventory
{
    public partial class F_Items : Form
    {
        private Arabology_ERPEntities db = new Arabology_ERPEntities();
        public F_Items()
        {
            InitializeComponent();
            PassDataToCombobox();
            FillDGVUOM();
        }
        private void PassDataToCombobox()
        {
            ForForms.SetDataToComboBox(db.Categories.Select(a=> new {ID=a.CategoryId,Name=a.CategoryNameA }).ToList(), ref cmbCategory);
            ForForms.SetDataToComboBox(db.ItemTypes.Select(a => new { ID = a.ItemTypeId, Name = a.ItemTypeNameA }).ToList(), ref cmbItemType);
            ForForms.SetDataToComboBox(db.Brands.Select(a => new { ID = a.BrandId, Name = a.BrandNameA }).ToList(), ref cmbBrand);
            ForForms.SetDataToComboBox(db.Countries.Select(a => new { ID = a.CountryId, Name = a.CountryNameA }).ToList(), ref cmbCountry);
            ForForms.SetDataToComboBox(db.ItemSubTypes.Select(a => new { ID = a.ItemSubTypeId, Name = a.ItemSubTypeNameA }).ToList(), ref cmbItemSubType);
            ForForms.SetDataToComboBox(db.UnitOfMeasures.Select(a => new { ID = a.UOM, Name = a.UOMNameA }).ToList(), ref cmbMainUnit);
            ForForms.SetDataToComboBox(db.UnitOfMeasures.Select(a => new { ID = a.UOM, Name = a.UOMNameA }).ToList(), ref cmbLargeUnit);
            ForForms.SetDataToComboBox(db.UnitOfMeasures.Select(a => new { ID = a.UOM, Name = a.UOMNameA }).ToList(), ref cmbSalesUnit);
            ForForms.SetDataToComboBox(db.UnitOfMeasures.Select(a => new { ID = a.UOM, Name = a.UOMNameA }).ToList(), ref cmbInventoryUnit);
            ForForms.SetDataToComboBox(db.UnitOfMeasures.Select(a => new { ID = a.UOM, Name = a.UOMNameA }).ToList(), ref cmbPurchaseUnit);
        }
        private void FillDGVUOM()
        {
            try
            {
                DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
                col.DataSource = db.UnitOfMeasures.ToList();
                col.DisplayMember = "UOMNameA";
                col.ValueMember = "UOM";
                col.Name = "ConvertTo";
                col.HeaderText = "إلى";
                dgvUOM.Columns.Insert(2,col);
                if (txtID.Text == string.Empty)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                _4Exception.GetException(ex);
                return;
            }
        }

        private void F_Items_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = string.Empty;
                txtNameA.Text = string.Empty;
                txtNameE.Text = string.Empty;
                ckInActive.Checked = false;
                PassDataToCombobox();
            }
            catch (Exception ex)
            {
                _4Exception.GetException(ex);
                return;
            }
        }

        private void dgvUOM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
