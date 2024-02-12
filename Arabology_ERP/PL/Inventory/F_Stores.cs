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
    public partial class F_Stores : Form
    {
        private Arabology_ERPEntities db = new Arabology_ERPEntities();
        public F_Stores()
        {
            InitializeComponent();
            dgv.DataSource = db.Stores.Select(s => new { الكود = s.StoreId, الاسم_بالعربي = s.StoreNameA, الاسم_بالانجليزي = s.StoreNameE }).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Store store = db.Stores.Find(int.Parse(txtId.Text));
                store.StoreNameA = txtNameA.Text;
                store.StoreNameE = txtNameE.Text;
                store.InActive = ckInActive.Checked;
                
                db.SaveChanges();
                _4Data.msgAlert("تم الحفظ بنجاح");
                dgv.DataSource = db.Stores.Select(s => new { الكود = s.StoreId, الاسم_بالعربي = s.StoreNameA, الاسم_بالانجليزي = s.StoreNameE }).ToList();
            }
            catch (Exception ex)
            {
                _4Exception.GetException(ex);
                return;
            }
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtId.Text = dgv.CurrentRow.Cells[0].FormattedValue.ToString();
                txtNameA.Text = dgv.CurrentRow.Cells[1].FormattedValue.ToString();
                txtNameE.Text = dgv.CurrentRow.Cells[2].FormattedValue.ToString();
                ckInActive.Checked =(bool) db.Stores.Find(int.Parse(txtId.Text)).InActive;
            }
            catch (Exception ex)
            {
                _4Exception.GetException(ex);
                return;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtId.Text = string.Empty;
                txtNameA.Text = string.Empty;
                txtNameE.Text = string.Empty;
                ckInActive.Checked = false;

            }
            catch (Exception ex)
            {
                _4Exception.GetException(ex);
                return;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != string.Empty)
                {
                    throw new Exception("هذا المخزن موجود بالفعل");
                }
                Store store = new Store()
                {
                    StoreNameA = txtNameA.Text,
                    StoreNameE = txtNameE.Text,
                    InActive = ckInActive.Checked
                };
                int i = store.StoreId;
                db.Stores.Add(store);

                db.SaveChanges();
                if (store.StoreId != i)
                {
                    _4Data.msgAlert("تم الإضافة بنجاح");
                }
                else
                {
                    _4Data.msgError("حدث خطأ أثناء الحفظ برجاء المحاولة مرة اخرى");
                }
                dgv.DataSource = db.Stores.Select(s => new { الكود = s.StoreId, الاسم_بالعربي = s.StoreNameA, الاسم_بالانجليزي = s.StoreNameE }).ToList();
            }
            catch (Exception ex)
            {
                _4Exception.GetException(ex);
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_4Data.msgQuestion("هل تريد بالفعل الحذف؟") == DialogResult.Yes)
                {
                    Store store = db.Stores.Find(int.Parse(txtId.Text));
                    db.Stores.Remove(store);
                    db.SaveChanges();
                    _4Data.msgAlert("تم حذف البيانات بنجاح");
                }
                dgv.DataSource = db.Stores.Select(s => new { الكود = s.StoreId, الاسم_بالعربي = s.StoreNameA, الاسم_بالانجليزي = s.StoreNameE }).ToList();
            }
            catch (Exception ex)
            {
                _4Exception.GetException(ex);
                return;
            }
        }
    }
}
