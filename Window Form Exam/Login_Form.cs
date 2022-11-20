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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Window_Form_Exam.Forms.Products;
using Window_Form_Exam.Classes;

namespace Window_Form_Exam
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {

            //clsDatabase.CheckConnection();
            clsDatabase.Login(txt_username.Text.Trim(), txt_password.Text.Trim());
            //this.Hide();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
