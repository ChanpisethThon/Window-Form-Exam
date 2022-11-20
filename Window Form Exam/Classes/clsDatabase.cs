using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Runtime.CompilerServices;
using Window_Form_Exam.Forms.Products;

namespace Window_Form_Exam.Classes
{
    public class clsDatabase
    {
        public static SqlConnection CON = new SqlConnection("Data Source=WIN-ON87F60K50N;Initial Catalog=window_form;Persist Security Info=True;User ID=sa;Password=P@ssw0rd");
        public static SqlCommand CMD;
        public static SqlDataAdapter da;
        public static DataTable tbl;
        public static string sql=null;
        public static string username;
        public static long userid;
        public static void CheckConnection()
        {
            try
            {
                if(CON.State == ConnectionState.Closed)
                {
                    CON.Open();
                    MessageBox.Show("Connected");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Can not connect to database"+ex.Message);
            }
        }

        public static void AddDataToComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            sql = "select * from TblCategory";
            da = new SqlDataAdapter(sql, CON);
            tbl = new DataTable();
            da.Fill(tbl);
            foreach(DataRow r in tbl.Rows)
            {
                comboBox.Items.Add(r[1].ToString());
            }
        }

        public static long GetIDFromComboBox(ComboBox comboBox)
        {
            long id = 0;
            sql = "select * from TblCategory where CategoryName=@CategoryName";
            CMD = new SqlCommand(sql, CON);
            CMD.Parameters.AddWithValue("@CategoryName",comboBox.SelectedItem.ToString());
            da = new SqlDataAdapter(CMD);
            tbl = new DataTable();
            da.Fill(tbl);
            if(tbl.Rows.Count > 0)
            {
                id=Convert.ToInt64(tbl.Rows[0]["CategoryID"]);
            }
            return id;
        }

        public static void Login(string username, string password)
        {
            sql = "select * from [user] where UserName=@UserName";
            CMD = new SqlCommand(sql,CON);
            CMD.Parameters.AddWithValue("@Username", username);
            da = new SqlDataAdapter(CMD);
            tbl = new DataTable();
            da.Fill(tbl);
            if (tbl.Rows.Count == 0)
            {
                MessageBox.Show("Username is invalid","POS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            sql = "select * from [user] where UserName=@UserName and password=@password";
            CMD = new SqlCommand(sql, CON);
            CMD.Parameters.AddWithValue("@UserName", username);
            CMD.Parameters.AddWithValue("@password", password);
            da = new SqlDataAdapter(CMD);
            tbl = new DataTable();
            da.Fill(tbl);
            if (tbl.Rows.Count == 0)
            {
                MessageBox.Show("Password is invalid", "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            username = tbl.Rows[0][0].ToString();
            Forms.Products.Product_FRM f = new Forms.Products.Product_FRM();
            f.lbl_username.Text = username;
            f.Show();
        }

        public static long AutomaticID(string tablename, string columnname)
        {
            long id = 0;
            string sql = "select * from "+tablename+" order by "+columnname+" desc";
            da = new SqlDataAdapter(sql,CON);
            tbl = new DataTable();
            da.Fill(tbl);
            if (tbl.Rows.Count > 0)
            {
                id = long.Parse(tbl.Rows[0][0].ToString())+1;
            }
            else
            {
                id = 1;
            }
            return id;
        }

        public static void AddDataToDataGridView(DataGridView dataGridView, String sql)
        {
            dataGridView.Rows.Clear();
            try
            {
                CMD = new SqlCommand(sql, CON);
                if (CON.State == ConnectionState.Closed)
                {
                    CON.Open();
                }
                CMD.ExecuteNonQuery();
                SqlDataReader dr = CMD.ExecuteReader();
                while (dr.Read())
                {
                    int i = dataGridView.Rows.Add(dr[0].ToString());
                    for (int c = 1; c < dr.FieldCount; c++)
                    {
                        dataGridView.Rows[i].Cells[c].Value = dr[c];
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                if (ex is SqlException)
                {
                    MessageBox.Show("Error Sql Server" + ex.Message.ToString());
                }
                else
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        public static void SearchRecord(DataGridView dataGridView, String sql, TextBox txt_search)
        {
            dataGridView.Rows.Clear();
            try
            {
                CMD = new SqlCommand(sql, CON);
                CMD.Parameters.AddWithValue("@name", txt_search.Text);
                if (CON.State == ConnectionState.Closed)
                {
                    CON.Open();
                }
                CMD.ExecuteNonQuery();
                SqlDataReader dr = CMD.ExecuteReader();
                while (dr.Read())
                {
                    int i = dataGridView.Rows.Add(dr[0].ToString());
                    for (int c = 1; c < dr.FieldCount; c++)
                    {
                        dataGridView.Rows[i].Cells[c].Value = dr[c];
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                if (ex is SqlException)
                {
                    MessageBox.Show("Error Sql Server" + ex.Message.ToString());
                }
                else
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
