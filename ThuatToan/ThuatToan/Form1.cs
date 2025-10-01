using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace ThuatToan
{
    public partial class Form1 : Form
    {
        private DanhMucSapXep dmSapXep = new DanhMucSapXep(new DanhSachLienKetKep());
        private DanhMucBST dmTim = new DanhMucBST(new BinarySearchTree());
        private DanhSachLienKetKep dsLKKep = new DanhSachLienKetKep();
        public Form1()
        {
            InitializeComponent();
            dmSapXep = new DanhMucSapXep();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtNhapSo.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập 1 số!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    float so;
                    if (!float.TryParse(txtNhapSo.Text, out so))
                    {
                        MessageBox.Show("Vui lòng nhập 1 số hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    bool ketqua = dsLKKep.ThemCuoi(so);
                    if (ketqua)
                    {
                        MessageBox.Show($"Đã thêm {so} vào danh sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Thêm {so} không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Cập nhật danh sách liên kết trong dmSapXep
                    dmSapXep.DSLKKep = dsLKKep;
                    lstDanhSach.Items.Add(so);
                    ChuyenDuLieuTuStrCollection(lstDanhSach.Items.Cast<object>());
                    txtNhapSo.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show("Bạn có chắc chắn muốn thoát không!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ketQua == DialogResult.Yes)
                this.Close();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            string selectedMethod = cmbThuatToan.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedMethod))
            {
                MessageBox.Show("Vui lòng chọn phương pháp sắp xếp!!!!");
                return;
            }
            //Chuyển dữ liệu từ listbox sang dslk trc khi sắp xếp
            ChuyenDuLieuTuStrCollection(lstDanhSach.Items.Cast<object>());
            if (selectedMethod == "Selection Sort")
            {
                dmSapXep.SelectionSort();
                MessageBox.Show("Đã sắp xếp thành công dãy số bằng Selection Sort!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (selectedMethod == "Quick Sort")
            {
                dmSapXep.QuickSort();
                MessageBox.Show("Đã sắp xếp thành công dãy số bằng Quick Sort!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Hien thi danh sach lien ket
            CapNhatList(dmSapXep.DSLKKep.head);
        }

        private void CapNhatList(Node head)
        {
            //Xoa tat ca cac muc trong listbox
            lstDSSauKhiSapXep.Items.Clear();

            Node currNode = head;
            while (currNode != null)
            {
                lstDSSauKhiSapXep.Items.Add(currNode.Data);
                currNode = currNode.Next;
            }
        }

        private void ChuyenDuLieuTuStrCollection(IEnumerable<object> strCollection)
        {
            // Xóa danh sách liên kết cũ
            dsLKKep = new DanhSachLienKetKep();
            foreach (var ds in strCollection)
            {
                if (float.TryParse(ds.ToString(), out float so))
                {
                    dsLKKep.ThemCuoi(so);
                }
            }
            // Đồng bộ với DanhMucSapXep
            dmSapXep.DSLKKep = dsLKKep;
        }
        private int? highlightValue = null;
        private void btnTimBST_Click(object sender, EventArgs e)
        {
            try
            {
                if (dmTim.BST == null || dmTim.BST.root == null)
                {
                    MessageBox.Show("Cây BST hiện đang rỗng!! Vui lòng thêm dữ liệu trước khi tìm kiếm!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Kiểm tra nếu người dùng nhập số cần tìm
                else if (txtNhapSoDeTimBST.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số để tìm kiếm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(txtNhapSoDeTimBST.Text, out int so))
                {
                    MessageBox.Show("Vui lòng nhập một số hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Tạo Stopwatch để đo thời gian
                Stopwatch sw = new Stopwatch();
                sw.Start(); // Bắt đầu đo thời gian
                // Tìm kiếm trong cây
                var ketQua = dmTim.TimCoTG(so); // dmTim là đối tượng BinarySearchTree
                sw.Stop(); // Dừng đo thời gian
                // Hiển thị kết quả tìm kiếm và thời gian tìm kiếm
                if (ketQua.found)
                {
                    highlightValue = so;
                    MessageBox.Show($"Số {so} đã được tìm thấy trong cây! Thời gian tìm kiếm: {ketQua.time} ms",
                        "Kết quả", MessageBoxButtons.OK);
                    CapNhatPanel(so);//Tô màu node nếu được tìm thấy
                }
                else
                {
                    highlightValue = null;
                    MessageBox.Show($"Số {so} không tìm thấy trong cây! Thời gian tìm kiếm: {ketQua.time} ms",
                        "Kết quả", MessageBoxButtons.OK);
                    CapNhatPanel();//Không tô màu
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void pnlCayBST_Paint(object sender, PaintEventArgs e)
        {
            if (dmTim == null || dmTim.BST == null || dmTim.BST.root == null)
            {
                return; // Không vẽ nếu cây BST chưa được khởi tạo hoặc chưa có dữ liệu
            }
            Graphics g = e.Graphics;
            VeCayBST(dmTim.BST.root, g, pnlCayBST.Width / 2, 20, pnlCayBST.Width / 4, 50);

        }

        private void VeCayBST(BinarySearchTree.NodeBST root, Graphics g, int x, int y, int delX, int delY, int? highlightValue = null)//int? cho phép nhận thêm giá trị null(hightlightVlue đang null)
        {
            if (root == null)
            {
                return;
            }
            //Đổi màu nếu node là node cần tìm
            Brush nodeBrush;
            if (highlightValue != null && root.Data == highlightValue)
            {
                nodeBrush = Brushes.IndianRed;// Nếu highlightValue không null và trùng với root.Data, tô màu đỏ
            }
            else { nodeBrush = Brushes.LightBlue; }
            //Ve nut hien tai
            int size = 30;
            g.FillRectangle(nodeBrush, x - size / 2, y - size / 2, size, size);
            g.DrawRectangle(Pens.Black, x - size / 2, y - size / 2, size, size);
            g.DrawString(root.Data.ToString(), this.Font, Brushes.Black, x - size / 3, y - size / 3);

            //Ve nhanh trai
            if (root.Left != null)
            {
                int childX = x - delX;
                int childY = y + delY;
                g.DrawLine(Pens.Black, x, y, childX, childY);//Vẽ đường nối
                VeCayBST(root.Left, g, childX, childY, delX / 2, delY, highlightValue);//vẽ nhánh
            }
            //Ve nhanh phai
            if (root.Right != null)
            {
                int childX = x + delX;
                int childY = y + delY;
                g.DrawLine(Pens.Black, x, y, childX, childY);
                VeCayBST(root.Right, g, childX, childY, delX / 2, delY, highlightValue);

            }
        }

        //Cập nhật panel
        private void CapNhatPanel(int? highlightValue = null)
        {
            pnlCayBST.Invalidate();//yêu cầu vẽ lại panel
            pnlCayBST.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                VeCayBST(dmTim.BST.root, g, pnlCayBST.Width / 2, 20, pnlCayBST.Width / 4, 50, highlightValue);
            };
        }

        private void btnThemCay_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtNhapSoBST.Text, out int so))
            {

                dmTim.Insert(so);
                CapNhatPanel(highlightValue);
                txtNhapSoBST.Clear();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtNhapSoDeXoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (int.TryParse(txtNhapSoDeXoa.Text, out int so))
            {
                if (dmTim.BST.SearchRec(dmTim.BST.root, so))
                {
                    dmTim.Delete(so);
                    CapNhatPanel(highlightValue);
                    txtNhapSoDeXoa.Clear();
                    MessageBox.Show($"Đã xóa số {so} ra khỏi cây và cập nhật lại cây!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Số không tồn tại trong cây!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ để xóa!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                Title = "Chọn file Excel"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Đọc dữ liệu từ Excel
                    List<float> danhSachSo = TruyVanDuLieu.readFormExcel(filePath);

                    // Kiểm tra nếu danh sách rỗng hoặc file không hợp lệ
                    if (danhSachSo == null)
                    {
                        MessageBox.Show("File không hợp lệ hoặc không đọc được dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (danhSachSo.Count == 0)
                    {
                        MessageBox.Show("File Excel không chứa dữ liệu hợp lệ (danh sách rỗng)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Hiển thị danh sách lên ListBox và thêm vào dsLKKep
                    lstDanhSach.Items.Clear();
                    dmSapXep.DSLKKep = new DanhSachLienKetKep();//// Tạo lại danh sách liên kết kép

                    // Thêm dữ liệu vào ListBox và DanhSachLienKetKep
                    foreach (float so in danhSachSo)
                    {
                        lstDanhSach.Items.Add(so);  // Hiển thị trên ListBox
                        dmSapXep.DSLKKep.ThemCuoi(so);   // Thêm vào danh sách liên kết kép
                    }

                    MessageBox.Show("Đã tải dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoadExcelBST_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                Title = "Chọn tệp Excel"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    // Đọc dữ liệu từ Excel
                    List<float> danhSachSo = TruyVanDuLieu.readFormExcel(filePath);
                    // Kiểm tra nếu danh sách rỗng hoặc file không hợp lệ
                    if (danhSachSo == null || danhSachSo.Count == 0)
                    {
                        MessageBox.Show("File Excel không chứa dữ liệu hợp lệ (danh sách rỗng)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // Khởi tạo lại cây nhị phân tìm kiếm
                    dmTim.BST = new BinarySearchTree();
                    // Thêm dữ liệu từ Excel vào cây BST
                    foreach (int so in danhSachSo)
                    {
                        dmTim.BST.Insert(so); // Thêm vào cây BST
                    }
                    // Hiển thị thông báo thành công và cập nhật giao diện
                    MessageBox.Show("Đã tải dữ liệu thành công vào cây BST!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CapNhatPanel(); // Cập nhật panel để vẽ lại cây
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoadTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files|*.txt",
                Title = "Chon file TXT"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    List<float> danhSachSo = TruyVanDuLieu.readFormTxt(filePath);
                    if (danhSachSo == null && danhSachSo.Count == 0)
                    {
                        MessageBox.Show("File TXT không chứa dữ liệu hợp lệ (danh sách rỗng)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    dmTim.BST = new BinarySearchTree();
                    foreach (int so in danhSachSo)
                    {
                        dmTim.BST.Insert(so);
                    }
                    MessageBox.Show("Đã tải dữ liệu thành công vào cây BST!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CapNhatPanel();
                }
                catch (Exception ex) { MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
    

