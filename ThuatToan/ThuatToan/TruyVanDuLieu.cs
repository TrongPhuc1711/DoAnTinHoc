using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel; // Thư viện đọc file Excel
using System.IO; // Thư viện xử lý file
namespace ThuatToan
{
    internal class TruyVanDuLieu
    {
        public static List<float> readFormExcel(string filePath)
        {
            List<float> danhSachSo = new List<float>();

            // Mở file Excel
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheets.First(); // Lấy sheet đầu tiên

                // Kiểm tra nếu sheet không có dữ liệu
                if (worksheet == null || worksheet.RangeUsed() == null)
                {
                    return danhSachSo; // Trả về danh sách rỗng
                }
                var dong = worksheet.RangeUsed().RowsUsed(); // Lấy các hàng có dữ liệu

                foreach (var d in dong)
                {
                    foreach (var gt in d.Cells()) // Duyệt qua từng ô trong hàng
                    {
                        string giaTri = gt.GetValue<string>();
                        if (!float.TryParse(giaTri, out float so))
                        {
                            throw new Exception($"Giá trị '{giaTri}' trong file Excel không hợp lệ!");
                            return danhSachSo; // Ngừng xử lý nếu gặp dữ liệu không hợp lệ
                        }
                        danhSachSo.Add(so);
                    }
                }
            }
            return danhSachSo;
        }

        public static List<float> readFormTxt(string filePath)
        {
            List<float> danhSachSo= new List<float>();
            try
            {
                string[] dong = File.ReadAllLines(filePath);
                foreach(string d in dong)
                {
                    string[] danhSach = d.Split('|');

                    foreach(string so in danhSach)
                    {
                        if(float.TryParse(so.Trim(),out float soThuc))
                        {
                            danhSachSo.Add(soThuc);
                        }
                        else
                        {
                            throw new Exception($"Giá trị '{so}' không hợp lệ trong file txt!");

                        }
                    }
                }
            }catch (Exception ex)
            {
                throw new Exception($"Loi khi doc file txt: {ex.Message}");
            }
            return danhSachSo;
        }
    }
}
