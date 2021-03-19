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

namespace QuanLySieuThi
{
    public partial class FormDoanhThuBan : Form
    {
        private string connectString = @"Data Source=localhost;Initial Catalog=QLSieuThi;Integrated Security=True";
        public FormDoanhThuBan()
        {
            InitializeComponent();
            load();
        }

        #region tools
        void load()
        {
            textBoxNgayBD.Text = DateTime.Now.ToString("MM/dd/yyyy");
            textBoxNgayKT.Text = DateTime.Now.ToString("MM/dd/yyyy");
            
            //select *
            //from dbo.thongKeTheoNgay('01/01/2020', '01/01/2022')
        }

        #endregion
        #region Excute Query
        public DataTable InstallQuery(string query)
        {
            DataTable data = new DataTable();
            try
            {
                using (SqlConnection con=new SqlConnection(connectString))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);

                    con.Close();

                }    
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return data;
        }
        public int InstallNonQuery(string query)
        {
            int data = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(connectString))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    data=command.ExecuteNonQuery();
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return data;
        }
        #endregion
        #region Event
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBoxNgayBD.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBoxNgayKT.Text = dateTimePicker2.Value.ToString("MM/dd/yyyy");
        }
        #endregion

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = InstallQuery("Select * from dbo.thongKeTheoNgay('"+textBoxNgayBD.Text+"','"+textBoxNgayKT.Text+"')");         
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ngayBan = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //DateTime date = new DateTime(ngayBan);
            MessageBox.Show(ngayBan);
        }
    }
}
