using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QuanLySieuThi
{
    public partial class Form_Khachhang : Form
    {
        public Form_Khachhang()
        {
            InitializeComponent();
        }

        void load()
        {
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString.str))
            {
                sqlcon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("Select makh as N'Mã khách hàng', tenkh as N'Tên khách hàng', diachi as N'Địa chỉ', sodt as N'Số điện thoại' from KhachHang", sqlcon);
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);
                //dataGridView_khachhang.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
                dataGridView_khachhang.DataSource = dataTable;
                dataGridView_khachhang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView_khachhang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
                dataGridView_khachhang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView_khachhang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
                for (int i = 0; i <= dataGridView_khachhang.Columns.Count - 1; i++)
                {
                    // Store Auto Sized Widths:
                    int colw = dataGridView_khachhang.Columns[i].Width;

                    // Remove AutoSizing:
                    dataGridView_khachhang.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                    // Set Width to calculated AutoSize value:
                    dataGridView_khachhang.Columns[i].Width = colw;
                }


                // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
                for (int i = 0; i <= dataGridView_khachhang.Columns.Count - 1; i++)
                {
                    // Store Auto Sized Widths:
                    int colw = dataGridView_khachhang.Columns[i].Width;

                    // Remove AutoSizing:
                    dataGridView_khachhang.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                    // Set Width to calculated AutoSize value:
                    dataGridView_khachhang.Columns[i].Width = colw;
                }
            }
        }
        string ten, ma, sdt, dc;
        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void Form_Khachhang_Load(object sender, EventArgs e)
        {
            load();


        }

        private void dataGridView_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_khachhang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataGridViewRow row = this.dataGridView_khachhang.Rows[e.RowIndex];
                textBox_makh.Text = row.Cells[0].Value.ToString();
                ma = row.Cells[0].Value.ToString();
                textBox_tenkh.Text = row.Cells[1].Value.ToString();
                ten = row.Cells[1].Value.ToString();
                textBox_diachi.Text = row.Cells[2].Value.ToString();
                dc = row.Cells[2].Value.ToString();
                textBox_sdt.Text = row.Cells[3].Value.ToString();
                sdt= row.Cells[3].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox_makh.Text == "" || textBox_tenkh.Text == "")
                MessageBox.Show("Bạn chưa nhập đầy đủ các thông tin bắt buộc của khách hàng", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Regex.IsMatch(textBox_makh.Text, "\\d") == false || textBox_sdt.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại dường như chưa chính xác", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //string ri = "\\d";
                if (Regex.IsMatch(textBox_makh.Text, "\\d") == false || int.Parse(textBox_makh.Text) < 0 || int.Parse(textBox_makh.Text) > 32000)
                    MessageBox.Show("Mã khách hàng phải là số nhỏ hơn 32000 và lớn hơn 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {

                    using (SqlConnection sqlcon = new SqlConnection(ConnectionString.str))
                    {
                        sqlcon.Open();
                        SqlCommand command = new SqlCommand("execute kiemtrakh N'" + textBox_tenkh.Text + "', '" + textBox_sdt.Text + "', '" + textBox_makh.Text + "', N'" + textBox_diachi.Text + "'", sqlcon);
                        sqlcon.InfoMessage += new SqlInfoMessageEventHandler(InfoMessageHandler);
                        command.ExecuteNonQuery();
                    }
                    load();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_timkiemkh Form_timkiemkh = new Form_timkiemkh();
            Form_timkiemkh.Show();
        }

        public static void InfoMessageHandler(object mySender, SqlInfoMessageEventArgs myEvent)
        {
            MessageBox.Show(myEvent.Message);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_makh.Text == "" || textBox_tenkh.Text == "" || textBox_sdt.Text == "")
                MessageBox.Show("Bạn chưa nhập đầy đủ các thông tin bắt buộc của khách hàng", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Regex.IsMatch(textBox_makh.Text, "\\d") == false || textBox_sdt.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại dường như chưa chính xác", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //string ri = "\\d";
                if (Regex.IsMatch(textBox_makh.Text, "\\d") == false || int.Parse(textBox_makh.Text) < 0 || int.Parse(textBox_makh.Text) > 32000)
                    MessageBox.Show("Mã khách hàng phải là số nhỏ hơn 32000 và lớn hơn 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa thông tin khách hàng:\n" + textBox_makh.Text + "| " + textBox_tenkh.Text + "| " + textBox_sdt.Text + "| " + textBox_diachi.Text, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result== DialogResult.Yes)
                    { 
                        using (SqlConnection sqlcon = new SqlConnection(ConnectionString.str))
                        {
                            sqlcon.Open();
                            SqlCommand command = new SqlCommand("execute xoa_thongtin_kh N'" + textBox_makh.Text + "', N'" + textBox_tenkh.Text + "', '" + textBox_sdt.Text + "', N'" + textBox_diachi.Text + "'", sqlcon);
                            sqlcon.InfoMessage += new SqlInfoMessageEventHandler(InfoMessageHandler);
                            command.ExecuteNonQuery();
                        }
                        load();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox_makh.Text == "" || textBox_tenkh.Text == "" || textBox_sdt.Text == "")
                MessageBox.Show("Bạn chưa nhập đầy đủ các thông tin bắt buộc của khách hàng", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Regex.IsMatch(textBox_makh.Text, "\\d") == false || textBox_sdt.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại dường như chưa chính xác", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //string ri = "\\d";
                if (Regex.IsMatch(textBox_makh.Text, "\\d") == false || int.Parse(textBox_makh.Text) < 0 || int.Parse(textBox_makh.Text) > 32000)
                    MessageBox.Show("Mã khách hàng phải là số nhỏ hơn 32000 và lớn hơn 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn đổi thông tin khách hàng:\n" + ma + "| " + ten + "| " + sdt + "| " + dc+"\nThành: " + textBox_makh.Text + "| " + textBox_tenkh.Text + "| " + textBox_sdt.Text + "| " + textBox_diachi.Text, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(result== DialogResult.Yes)
                    {
                        using (SqlConnection sqlcon = new SqlConnection(ConnectionString.str))
                        {
                            sqlcon.Open();
                            SqlCommand command = new SqlCommand("execute sua_thongtin_kh N'" + textBox_makh.Text  + "', N'" + textBox_tenkh.Text  + "', '" + textBox_sdt.Text + "', N'" + textBox_diachi.Text + "','"+ma+"'", sqlcon);
                            sqlcon.InfoMessage += new SqlInfoMessageEventHandler(InfoMessageHandler);
                            command.ExecuteNonQuery();
                        }
                        load();
                    }    
                }
            }

        }

        protected void timkiem(object sender, EventArgs e)
        {
            if(Form_timkiemkh.)
        }
    }
}