using HoSoKhachHang;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace HoSoKhachHang
{
    public partial class SearchCus : Form
    {
        private BinarySearchTree bst;
        private Node Root; // Add this field
        string filePath = @"C:\Users\Dell\Downloads\FILE DỮ LIỆU GỐC.tsv";
        
        public SearchCus()
        {
            InitializeComponent();
            bst = new BinarySearchTree();
            LoadDataFromFile(filePath);           
            Root = bst.GetRoot(); // Set the Root field
        }

        private void LoadDataFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] fields = line.Split('\t');

                    Hosokhachhang hosokhachhang = new Hosokhachhang();

                    // Parse date fields
                    DateTime ngaydatphong;
                    DateTime ngayNhanPhong;
                    DateTime ngayTraPhong;
                    if (fields.Length >= 12 &&
                        DateTime.TryParseExact(fields[6], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaydatphong) &&
                        DateTime.TryParseExact(fields[7], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayNhanPhong) &&
                        DateTime.TryParseExact(fields[8], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayTraPhong))
                    {
                        hosokhachhang.Madatphong = fields[0];
                        hosokhachhang.Tenkhachhang = fields[1];
                        hosokhachhang.GioiTinh = fields[2];
                        hosokhachhang.Email = fields[3];
                        hosokhachhang.sodienthoai = fields[4];
                        hosokhachhang.loaiphong = fields[5];
                        hosokhachhang.Ngaydatphong = ngaydatphong;
                        hosokhachhang.NgayNhanPhong = ngayNhanPhong;
                        hosokhachhang.NgayTraPhong = ngayTraPhong;
                        hosokhachhang.luongphong = int.Parse(fields[9]);
                        hosokhachhang.luongnguoi = int.Parse(fields[10]);
                        hosokhachhang.trangthaiphong = fields[11];

                        bst.Insert(hosokhachhang);
                    }
                    else
                    {
                        // Handle the case where the line does not have the expected format
                        Console.WriteLine($"Error parsing line {i + 1}: {line}");
                    }
                }

                // Display data in the DataGridView
                dgvSCus.DataSource = bst.TraverseInOrder();
                dgvSCus.Refresh();
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine($"Error loading data from file: {ex.Message}");
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f1 = new Home();
            f1.ShowDialog();
            this.Close();
        }

        private void btnSearchByName_Click_1(object sender, EventArgs e)
        {
            string tenKhachHang = txtTenKhachHang.Text;

            List<Hosokhachhang> searchResults = bst.findName(tenKhachHang);

            if (searchResults.Count > 0)
            {
                dgvSCus.DataSource = searchResults;
                dgvSCus.Refresh();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng với tên đã nhập.");
            }
        }

        private void btnSearchByDate_Click_1(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;
            List<Hosokhachhang> searchResults = bst.findDate(startDate, endDate);


            if (searchResults.Count > 0)
            {
                dgvSCus.DataSource = searchResults;
                dgvSCus.Refresh();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng trong khoảng thời gian đã nhập.");
            }
        }
    }
}
