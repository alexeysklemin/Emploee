using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Emploee
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source = LAPTOP-ALEX\SQLEXPRESS; Initial Catalog = emloees; Integrated Security = True";

        }

        private void sinupBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM loginTable";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if(userBox.Text.Equals(dr["account"].ToString()) && pswdBox.Text.Equals(dr["passsword"].ToString()))
                {
                    MessageBox.Show("OK", "Log in is succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You are mistaken", "Repeat one more time", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            con.CreateCommand();Close();

        }
    }
}
