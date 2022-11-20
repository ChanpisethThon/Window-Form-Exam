using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Window_Form_Exam.Classes
{
    public class clsProduct : infAction
    {
        //member variable or field, properties
        private long _productid;
        private string _productname;
        private long _barcode;
        private double _uniprice;
        private double _sellprice;
        private long _categoryid;
        private long _qtyinstock;
        public string sql = null;
        private DateTime dateTimeVariable = DateTime.Now;


        public long Productid { get => _productid; set => _productid = value; }
        public string Productname { get => _productname; set => _productname = value; }
        public long Barcode { get => _barcode; set => _barcode = value; }
        public double Uniprice { get => _uniprice; set => _uniprice = value; }
        public double Sellprice { get => _sellprice; set => _sellprice = value; }
        public long Categoryid { get => _categoryid; set => _categoryid = value; }
        public long Qtyinstock { get => _qtyinstock; set => _qtyinstock = value; }

        public void PrintMessage()
        {
            //MessageBox.Show("Name :" + this.Productname + "\nBarcode :" + this.Barcode + "\nUnit Price :" + this.Uniprice + "\nSell Price :" + this.Sellprice + "\nCategory :" + this._categoryname + "\nQtyInstock :" + this.Qtyinstock);
        }

        public void AddDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Add(1, this.Productname, this.Barcode, this.Uniprice, this.Sellprice, this.Qtyinstock, this._categoryid);
        }

        //change datagridview SelectionMode to Fullrowselect
        public void TransferDataToTextbox(DataGridView dataGridView, TextBox txt_name, TextBox txt_barcode, TextBox txt_uniprice, TextBox txt_sellprice, TextBox txt_qty, ComboBox cbo_category_name)
        {
            if (clsFunction.DataGridViewItemEmpty(dataGridView) == true) { return; }
            DataGridViewRow dgv = new DataGridViewRow();
            dgv = dataGridView.SelectedRows[0];
            txt_name.Text = dgv.Cells[1].Value.ToString();
            txt_barcode.Text = dgv.Cells[2].Value.ToString();
            txt_uniprice.Text = dgv.Cells[3].Value.ToString();
            txt_sellprice.Text = dgv.Cells[4].Value.ToString();
            txt_qty.Text = dgv.Cells[5].Value.ToString();
            cbo_category_name.Text = dgv.Cells[6].Value.ToString();
        }

        public void Save()
        {
            try
            {
                Productid = clsDatabase.AutomaticID("tblproduct", "productid");
                //sql = "insert into TblProduct values(@productid,@productname,@barcode,@uniprice,@sellprice,@categoryid,@qtyinstock)";
                sql = "insert into TblProduct " + "(ProductID, ProductName, Barcode, UnitPrice, SellPrice, CategoryID, QtyInStock) values " + "(@productid,@productname,@barcode,@uniprice,@sellprice,@categoryid,@qtyinstock);";
                clsDatabase.CMD = new SqlCommand(sql, clsDatabase.CON);
                clsDatabase.CMD.Parameters.AddWithValue("@productid",_productid);
                clsDatabase.CMD.Parameters.AddWithValue("@productname", _productname);
                clsDatabase.CMD.Parameters.AddWithValue("@barcode", _barcode);
                clsDatabase.CMD.Parameters.AddWithValue("@uniprice", _uniprice);
                clsDatabase.CMD.Parameters.AddWithValue("@sellprice", _sellprice);
                clsDatabase.CMD.Parameters.AddWithValue("@categoryid", _categoryid);
                clsDatabase.CMD.Parameters.AddWithValue("@qtyinstock", _qtyinstock);
                if (clsDatabase.CON.State == ConnectionState.Closed)
                {
                    clsDatabase.CON.Open();
                }
                clsDatabase.CMD.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully!");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ex.Message);
            }
        }

        public void Update()
        {
            try
            {
                //clsDatabase.sql = "update TblProduct set ProductName=@ProductName,Barcode=@barcode,UnitPrice=@unitprice,SellPrice=@sellprice,CategoryID=@categoryid,QtyInStock=@qty where ProductID=@ProductID";
                clsDatabase.sql = "update TblProduct set ProductName=@ProductName,Barcode=@barcode,UnitPrice=@unitprice,SellPrice=@sellprice,CategoryID=@categoryid,QtyInStock=@qty,UpdatedDate=@updateddate where ProductID=@ProductID";
                clsDatabase.CMD = new SqlCommand(clsDatabase.sql, clsDatabase.CON);
                clsDatabase.CMD.Parameters.AddWithValue("@ProductID", _productid);
                clsDatabase.CMD.Parameters.AddWithValue("@ProductName", _productname);
                clsDatabase.CMD.Parameters.AddWithValue("@barcode", _barcode);
                clsDatabase.CMD.Parameters.AddWithValue("@unitprice", _uniprice);
                clsDatabase.CMD.Parameters.AddWithValue("@sellprice", _sellprice);
                clsDatabase.CMD.Parameters.AddWithValue("@categoryid", _categoryid);
                clsDatabase.CMD.Parameters.AddWithValue("@qty", _qtyinstock);
                clsDatabase.CMD.Parameters.AddWithValue("@updateddate", dateTimeVariable);
                if (clsDatabase.CON.State == ConnectionState.Closed)
                {
                    clsDatabase.CON.Open();
                }
                clsDatabase.CMD.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error :\n" + ex.Message);
            }
        }

        public void Search()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            try
            {
                clsDatabase.sql = "delete from TblProduct where ProductID=@ProductID";
                clsDatabase.CMD = new SqlCommand(clsDatabase.sql, clsDatabase.CON);
                clsDatabase.CMD.Parameters.AddWithValue("@ProductID", _productid);
                if (clsDatabase.CON.State == ConnectionState.Closed)
                {
                    clsDatabase.CON.Open();
                }
                clsDatabase.CMD.ExecuteNonQuery ();
                MessageBox.Show("Deteled Successfully!");
            }catch(SqlException ex)
            {
                MessageBox.Show("Error :\n"+ex.Message);
            }
        }

        public static void AddDataToDataGridView(DataGridView dataGridView)
        {
            try
            {
                dataGridView.Rows.Clear();
                clsDatabase.sql = "select * from TblProduct join TblCategory on TblProduct.CategoryID=TblCategory.CategoryID";
                clsDatabase.CMD = new SqlCommand(clsDatabase.sql, clsDatabase.CON);
                clsDatabase.da = new SqlDataAdapter(clsDatabase.CMD);
                clsDatabase.tbl = new DataTable();
                clsDatabase.da.Fill(clsDatabase.tbl);
                foreach (DataRow r in clsDatabase.tbl.Rows)
                {
                    object[] row = { r["ProductID"], r["ProductName"], r["Barcode"], r["UnitPrice"], r["SellPrice"], r["CategoryName"], r["QtyInStock"] };
                    dataGridView.Rows.Add(row);
                }
            }catch(SqlException ex)
            {
                MessageBox.Show("Error :\n"+ex.Message);
            }
            
        }

        
    }
}
