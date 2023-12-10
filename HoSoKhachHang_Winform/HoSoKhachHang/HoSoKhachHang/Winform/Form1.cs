using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoSoKhachHang
{
    public partial class Form1 : Form
    {
        private BinarySearchTree binaryTree;
        string filePath = @"C:\Users\Dell\Downloads\FILE DỮ LIỆU GỐC.tsv";
        public Form1()
        {
            InitializeComponent();
            InitializeBinaryTree();
            InitializeDataGridView();
            LoadDataIntoDataGridView();
        }

        private void InitializeBinaryTree()
        {
            binaryTree = new BinarySearchTree();
            string filePath = @"C:\Users\Dell\Downloads\FILE DỮ LIỆU GỐC.tsv";
            LoadDataFromFile(filePath);
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

                    // Attempt to parse date values, and handle errors
                    if (fields.Length >= 12 &&
                        DateTime.TryParseExact(fields[6], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaydatphong) &&
                        DateTime.TryParseExact(fields[7], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhanPhong) &&
                        DateTime.TryParseExact(fields[8], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayTraPhong))
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

                        binaryTree.Insert(hosokhachhang);
                    }
                    else
                    {
                        // Handle the case where the line does not have the expected format
                        Console.WriteLine($"Error parsing line {i + 1}: {line}");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine($"Error loading data from file: {ex.Message}");
            }
        }



        private void InitializeDataGridView()
        {
            dgv1.Columns.Add("Madatphong", "Mã đặt phòng");
            dgv1.Columns.Add("Tenkhachhang", "Tên khách hàng");
            dgv1.Columns.Add("GioiTinh", "Giới tính");
            dgv1.Columns.Add("Email", "Email");
            dgv1.Columns.Add("sodienthoai", "Số điện thoại");
            dgv1.Columns.Add("loaiphong", "Loại phòng");
            dgv1.Columns.Add("Ngaydatphong", "Ngày đặt phòng");
            dgv1.Columns.Add("NgayNhanPhong", "Ngày nhận phòng");   // New column
            dgv1.Columns.Add("NgayTraPhong", "Ngày trả phòng");     // New column
            dgv1.Columns.Add("luongphong", "Lượng phòng");
            dgv1.Columns.Add("luongnguoi", "Lượng người");
            dgv1.Columns.Add("trangthaiphong", "Trạng thái phòng");
        }

        private void LoadDataIntoDataGridView()
        {
            dgv1.Rows.Clear();
            List<Hosokhachhang> hosoList = new List<Hosokhachhang>();
            SaveDataToList(binaryTree.Root, hosoList);

            foreach (var hosokhachhang in hosoList)
            {
                dgv1.Rows.Add(hosokhachhang.Madatphong, hosokhachhang.Tenkhachhang, hosokhachhang.GioiTinh,
                    hosokhachhang.Email, hosokhachhang.sodienthoai, hosokhachhang.loaiphong,
                    hosokhachhang.Ngaydatphong.ToString("dd/MM/yyyy"),
                    hosokhachhang.NgayNhanPhong.ToString("dd/MM/yyyy"),   // New column
                    hosokhachhang.NgayTraPhong.ToString("dd/MM/yyyy"),    // New column
                    hosokhachhang.luongphong, hosokhachhang.luongnguoi, hosokhachhang.trangthaiphong);
            }
        }

        private void SaveDataToList(Node parent, List<Hosokhachhang> hosoList)
        {
            if (parent != null)
            {
                SaveDataToList(parent.LeftNode, hosoList);
                hosoList.Add(parent.Data);
                SaveDataToList(parent.RightNode, hosoList);
            }
        }
        private void SaveDataToFile(string filePath, List<Hosokhachhang> hosoList)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                CultureInfo viVn = new CultureInfo("vi-VN");

                foreach (Hosokhachhang hoso in hosoList)
                {
                    writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}",
                        hoso.Madatphong, hoso.Tenkhachhang, hoso.GioiTinh, hoso.Email,
                        hoso.sodienthoai, hoso.loaiphong,
                        hoso.Ngaydatphong.ToString("dd/MM/yyyy", viVn),
                        hoso.NgayNhanPhong.ToString("dd/MM/yyyy", viVn),
                        hoso.NgayTraPhong.ToString("dd/MM/yyyy", viVn),
                        hoso.luongphong, hoso.luongnguoi, hoso.trangthaiphong);
                }
            }
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            try
            {
                Hosokhachhang hosokhachhang = CreateHosokhachhangFromInputs();

                binaryTree.Insert(hosokhachhang);
                DisplayBookings();
                SaveBookingsToFile();

                txtMDP.Text = "";
                txtTKH.Text = "";
                cbGender.SelectedIndex = -1;
                txtEml.Text = "";
                txtSDT.Text = "";
                cbLP.SelectedIndex = -1;
                dtpDay.Value = DateTime.Now;
                dtpNhanPhong.Value = DateTime.Now;  // Assuming you have a DateTimePicker for NgayNhanPhong
                dtpTraPhong.Value = DateTime.Now;    // Assuming you have a DateTimePicker for NgayTraPhong
                txtNoR.Text = "";
                txtNoP.Text = "";
                cbTTP.SelectedIndex = -1;
                MessageBox.Show("Thêm khách hàng thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Hosokhachhang CreateHosokhachhangFromInputs()
        {
            return new Hosokhachhang
            {
                Madatphong = txtMDP.Text,
                Tenkhachhang = txtTKH.Text,
                GioiTinh = cbGender.Text,
                Email = txtEml.Text,
                sodienthoai = txtSDT.Text,
                loaiphong = cbLP.Text,
                Ngaydatphong = dtpDay.Value,
                NgayNhanPhong = dtpNhanPhong.Value,  // Assuming you have a DateTimePicker for NgayNhanPhong
                NgayTraPhong = dtpTraPhong.Value,    // Assuming you have a DateTimePicker for NgayTraPhong
                luongphong = int.Parse(txtNoR.Text),
                luongnguoi = int.Parse(txtNoP.Text),
                trangthaiphong = cbTTP.Text
            };
        }

        private void DisplayBookings()
        {
            LoadDataIntoDataGridView();
        }
        private void SaveBookingsToFile()
        {
            List<Hosokhachhang> hosoList = new List<Hosokhachhang>();
            SaveDataToList(binaryTree.Root, hosoList);
            SaveDataToFile(filePath, hosoList);
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f1 = new Home();
            f1.ShowDialog();
            this.Close();
        }

        private void dtpDay_ValueChanged(object sender, EventArgs e)
        {

        }
    }

    #region BST
    // Định nghĩa lớp BinarySearchTree để thực hiện các thao tác trên cây nhị phân
    public class BinarySearchTree
    {
            public Node Root { get; set; }

            // Phương thức Insert để chèn một giá trị vào cây nhị phân
            public void Insert(Hosokhachhang value)
            {
                Root = InsertRecursive(Root, value);
            }

            private Node InsertRecursive(Node node, Hosokhachhang value)
            {
                if (node == null)
                {
                    return new Node { Data = value };
                }

                if (value.Ngaydatphong <= node.Data.Ngaydatphong)
                {
                    node.LeftNode = InsertRecursive(node.LeftNode, value);
                }
                else if (value.Ngaydatphong > node.Data.Ngaydatphong)
                {
                    node.RightNode = InsertRecursive(node.RightNode, value);
                }

                return node;
            }

        // Phương thức TraverseInOrder để duyệt cây theo thứ tự trung tố và in ra thông tin
        public List<Hosokhachhang> TraverseInOrder()
        {
            List<Hosokhachhang> result = new List<Hosokhachhang>();
            TraverseInOrder(Root, result);
            return result;
        }

        private void TraverseInOrder(Node parent, List<Hosokhachhang> result)
        {
            CultureInfo viVn = new CultureInfo("vi-VN");
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode, result);
                result.Add(parent.Data);
                TraverseInOrder(parent.RightNode, result);
            }
        }

        // Phương thức findname để tìm kiếm khách hàng theo tên
        public List<Hosokhachhang> findName(string name)
        {
            List<Hosokhachhang> results = new List<Hosokhachhang>();
            findName(Root, name, results);
            return results;
        }

        private void findName(Node node, string name, List<Hosokhachhang> results)
        {
            if (node != null)
            {
                Hosokhachhang data = node.Data;

                if (data.Tenkhachhang.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    results.Add(data);
                }

                findName(node.LeftNode, name, results);
                findName(node.RightNode, name, results);
            }
        }
        public List<Hosokhachhang> findDate(DateTime startDate, DateTime endDate)
        {
            List<Hosokhachhang> results = new List<Hosokhachhang>();
            findDate(Root, startDate, endDate, results);
            return results;
        }

        private void findDate(Node node, DateTime startDate, DateTime endDate, List<Hosokhachhang> results)
        {
            if (node != null)
            {
                Hosokhachhang data = node.Data;

                if (data.NgayNhanPhong.Date >= startDate.Date && data.NgayNhanPhong.Date <= endDate.Date)
                {
                    results.Add(data);
                }

                if (data.NgayNhanPhong.Date > startDate.Date)
                {
                    findDate(node.LeftNode, startDate, endDate, results);
                }

                if (data.NgayNhanPhong.Date < endDate.Date)
                {
                    findDate(node.RightNode, startDate, endDate, results);
                }
            }
        }


        public Node GetRoot()
        {
            return Root;
        }
    }
    

}
    #endregion
    #region HoSo
    // Định nghĩa lớp Hosokhachhang để lưu trữ thông tin khách hàng
    public class Hosokhachhang
    {
        public string Madatphong { get; set; }
        public string Tenkhachhang { get; set; }
        public string Email { get; set; }
        public string GioiTinh { get; set; }
        public string sodienthoai { get; set; }
        public DateTime Ngaydatphong { get; set; }
        public DateTime NgayNhanPhong { get; set; }  // New field
        public DateTime NgayTraPhong { get; set; }   // New field
        public string loaiphong { get; set; }
        public int luongphong { get; set; }
        public int luongnguoi { get; set; }
        public string trangthaiphong { get; set; }
    }

    #endregion
    #region Node of Tree
    // Định nghĩa lớp Node để tạo nút trong cây nhị phân
    public class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public Hosokhachhang Data { get; set; }
    }
    #endregion
