using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Window_Form_Exam.Classes
{
    class clsFunction
    {
        public static void Banner(WebBrowser webBrowser)
        {
            string path = @"\banner.swf";
            webBrowser.Navigate(Application.StartupPath + path);

        }
        //if (Classes.clsFunctions.CheckEmptyTextbox(txt_name, txt_password)==true) { return; }
        public static bool CheckEmptyTextbox(params TextBox[] txt)
        {
            foreach (TextBox t in txt)
            {
                if (t.Text.Equals(""))
                {
                    //t.BackColor = Color.Red;
                    MessageBox.Show("Please input value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t.Select();
                    return true;
                }

            }
            return false;
        }
        public static void ClearTextBoxes(Form form)
        {
            foreach (Control control in form.Controls)
            {

                if (control.GetType() == typeof(TextBox))
                {
                    
                    control.Text = "";

                }

            }
        }
        public static bool CheckEmptyComboBox(params ComboBox[] cbo)
        {
            foreach (ComboBox t in cbo)
            {
                if (t.Equals(""))
                {

                    t.BackColor = Color.Red;
                    MessageBox.Show("Please select item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t.Select();
                    return true;
                }
            }
            return false;
        }
        public static void SetImage(PictureBox picture)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.png)|*.BMP;*.JPG;*.GIF;*.jpeg,*.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                picture.ImageLocation = f.FileName;
            }

        }
        public static void RemoveImage(PictureBox picture)
        {

            picture.ImageLocation = null;
            picture.Image = null;
        }
        public static bool DataGridViewItemEmpty(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Not record", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;

            }
            return false;
        }
        public static bool RemoveItemFromDataGridView(DataGridView dataGridView)
        {
            if (DataGridViewItemEmpty(dataGridView) == true) { return true; }
            DataGridViewRow _dgv = new DataGridViewRow();
            _dgv = dataGridView.SelectedRows[0];
            if (MessageBox.Show("Do you want to delete record?", "POS", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView.Rows.Remove(_dgv);

            }

            return false;
        }
        public static void InputNumber(TextBox textBox, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //if (char.IsDigit(e.KeyChar))
            //{
            //    e.Handled =;
            //}

        }
        public static void InputNumber(TextBox textBox, KeyPressEventArgs e, int len)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }
        public static void InputString(TextBox textBox, KeyPressEventArgs e)
        {
            //if (e.KeyChar==48 || e.KeyChar==49 || e.KeyChar == 50 || e.KeyChar == 51 || e.KeyChar == 52 || e.KeyChar == 53 || e.KeyChar == 54 || e.KeyChar == 55 || e.KeyChar == 56 || e.KeyChar == 57)
            //{

            e.Handled = char.IsDigit(e.KeyChar);
            //}
        }
        public static void InputFloat(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        public static void WriteImage(DataGridView dataGridView, int index, PictureBox pictureBox)
        {
            DataGridViewRow dgv = new DataGridViewRow();
            dgv = dataGridView.SelectedRows[0];
            if (dgv.Cells[index].Value.ToString().Equals("") || dgv.Cells[index].Value.ToString().Equals(DBNull.Value))
            {
                pictureBox.ImageLocation = null;
            }
            else
            {
                string file = @"\noimage.png";
                string pathonimage = Application.StartupPath + file;
                byte[] byte1;
                byte1 = (byte[])dgv.Cells[index].Value;
                File.WriteAllBytes(pathonimage, byte1);
                pictureBox.ImageLocation = pathonimage;

            }
        }
        public static byte[] ReadImage(PictureBox pictureBox)
        {
            byte[] photo = File.ReadAllBytes(pictureBox.ImageLocation);
            return photo;
        }

        
    }
}
