using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Window_Form_Exam.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Window_Form_Exam.Forms.Products
{
    public partial class Product_FRM : Form
    {
        public Product_FRM()
        {
            InitializeComponent();
            clsDatabase.AddDataToComboBox(cbo_category_name);
        }
        clsProduct objProduct;
        DataGridViewRow dgv;

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (clsFunction.CheckEmptyTextbox(txt_productname,txt_barcode,txt_uniprice,txt_sellprice,txt_qty)== true) { return; }
            if (clsFunction.CheckEmptyComboBox(cbo_category_name)== true) { return; }
            objProduct = new clsProduct
            {
                Productname = txt_productname.Text.Trim(),
                Barcode = Convert.ToInt64(txt_barcode.Text.Trim()),
                Uniprice = Convert.ToDouble(txt_uniprice.Text.Trim()),
                Sellprice = Convert.ToDouble(txt_sellprice.Text.Trim()),
                Categoryid = clsDatabase.GetIDFromComboBox(cbo_category_name),
                Qtyinstock = Convert.ToInt64(txt_qty.Text.Trim())
            };
            objProduct.Save();
            clsDatabase.AddDataToDataGridView(dg_product, "select * from view_product");
            clsFunction.ClearTextBoxes(this);
            //objProduct.PrintMessage();
            //objProduct.AddDataGridView(dg_product);
            //clsDatabase.AutomaticID("tblproduct", "ProductID");

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            objProduct = new clsProduct();
            dgv = new DataGridViewRow();
            dgv = dg_product.SelectedRows[0];
            objProduct.Productid = Convert.ToInt64(dgv.Cells[0].Value.ToString());
            objProduct.Productname = txt_productname.Text;
            objProduct.Barcode = Convert.ToInt64(txt_barcode.Text);
            objProduct.Uniprice = Convert.ToDouble(txt_uniprice.Text);
            objProduct.Sellprice = Convert.ToDouble(txt_sellprice.Text);
            objProduct.Categoryid= clsDatabase.GetIDFromComboBox(cbo_category_name);
            objProduct.Qtyinstock = Convert.ToInt64(txt_qty.Text);
            objProduct.Update();
            clsDatabase.AddDataToDataGridView(dg_product, "select * from view_product");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dg_product.Rows.Count == 0)
            {
                return;
            }
            dgv = new DataGridViewRow();
            dgv = dg_product.SelectedRows[0];
            objProduct = new clsProduct();
            if(MessageBox.Show("Do you want to delete record?","POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objProduct.Productid = Convert.ToInt64(dgv.Cells[0].Value.ToString());
                objProduct.Delete();
                dg_product.Rows.Remove(dgv);
            }
            clsDatabase.AddDataToDataGridView(dg_product, "select * from view_product");
        }

        private void dg_product_DoubleClick(object sender, EventArgs e)
        {
            objProduct = new clsProduct();
            objProduct.TransferDataToTextbox(dg_product, txt_productname, txt_barcode, txt_uniprice, txt_sellprice, txt_qty, cbo_category_name);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            var f = new Login_Form();
            f.Show();
            this.Hide();
        }

        private void cbo_category_name_TextChanged(object sender, EventArgs e)
        {
            //clsDatabase.GetIDFromComboBox(cbo_category_name);
        }

        private void Product_FRM_Load(object sender, EventArgs e)
        {
            clsDatabase.AddDataToDataGridView(dg_product,"select * from view_product");
        }

        private void dg_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = new DataGridViewRow();
            dgv = dg_product.SelectedRows[0];
            txt_productname.Text = dgv.Cells[1].Value.ToString();
            txt_barcode.Text = dgv.Cells[2].Value.ToString();
            txt_uniprice.Text = dgv.Cells[3].Value.ToString();
            txt_sellprice.Text = dgv.Cells[4].Value.ToString();
            cbo_category_name.Text = dgv.Cells[5].Value.ToString();
            txt_qty.Text = dgv.Cells[6].Value.ToString();
            
        }

        private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDatabase.AddDataToDataGridView(dg_product,"select * from view_product");
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                clsDatabase.SearchRecord(dg_product, "select * from view_product where ProductName like '%'+@name+'%' or Barcode like '%'+@name+'%'", txt_search);
            }
        }
    }
}
