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
using QuanLySieuThi.Forms;

namespace QuanLySieuThi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (textbox_ID.Text != "")
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.str))
                {
                    con.Open();
                    string query = "SELECT * FROM TaiKhoan " +
                        "WHERE MaNV = '" + (textbox_ID.Text) +
                        "' and MatKhau = '" + (textbox_Password.Text) + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();                   
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int id = Int32.Parse(textbox_ID.Text);
                        string pass = textbox_Password.Text;
                        this.Hide();
                        var fmain = new MainForm(id, pass);
                        fmain.Closed += (s, args) => this.Close();
                        fmain.Show();
                    }
                    else label_Message.Visible = true;
                }
            }
            else label_Message.Visible = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label_Message.Visible = false;
            label_Message.ForeColor = System.Drawing.Color.DarkRed;
            controlbox.MinimizeNormalForeColor = Color.Black;
            controlbox.MinimizeHoverForeColor = Color.White;
            controlbox.MinimizeHoverBackColor = Color.Gray;
        }
    }
}
