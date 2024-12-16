using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Restaurant
{
    public class Invoice
    {
        public string MaHoaDon { get; set; }
        public string TenNhanVienLap { get; set; }
        public string MaKhachHang { get; set; }
        public string HoTenKhachHang { get; set; }
        public DateTime ThoiGianLap { get; set; }
        public decimal TongTien { get; set; } // Giả sử tổng tiền là kiểu decimal

        public static List<Invoice> LoadInvoicesFromProcedure(string branchID)
        {
            List<Invoice> invoices = new List<Invoice>();
            string query = "sp_LayThongTinHoaDon"; // Tên stored procedure

            using (SqlConnection con = new SqlConnection(Branch.con_string))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ChiNhanh", branchID);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Invoice invoice = new Invoice
                        {
                            MaHoaDon = reader["MaHoaDon"].ToString(),
                            TenNhanVienLap = reader["TenNhanVienLap"].ToString(),
                            MaKhachHang = reader["MaKhachHang"].ToString(),
                            HoTenKhachHang = reader["HoTen"].ToString(),
                            ThoiGianLap = Convert.ToDateTime(reader["NgayLapHoaDon"]), // Định dạng ngày
                            TongTien = Convert.ToDecimal(reader["TongTien"]) // Giả sử tổng tiền là kiểu decimal
                        };
                        invoices.Add(invoice);
                    }
                }
            }
            return invoices;

        }

        public static List<Invoice> SearchInvoicesItem(string searchTerm, string branchID)
        {
            List<Invoice> invoices = new List<Invoice>();
            string query = "sp_LayThongTinHoaDon"; // Tên stored procedure

            using (SqlConnection con = new SqlConnection(Branch.con_string))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ChiNhanh", branchID);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Kiểm tra xem tên khách hàng có chứa searchTerm không
                        if (reader["HoTen"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            Invoice invoice = new Invoice
                            {
                                MaHoaDon = reader["MaHoaDon"].ToString(),
                                TenNhanVienLap = reader["TenNhanVienLap"].ToString(),
                                MaKhachHang = reader["MaKhachHang"].ToString(),
                                HoTenKhachHang = reader["HoTen"].ToString(),
                                ThoiGianLap = Convert.ToDateTime(reader["NgayLapHoaDon"]), // Định dạng ngày
                                TongTien = Convert.ToDecimal(reader["TongTien"]) // Giả sử tổng tiền là kiểu decimal
                            };
                            invoices.Add(invoice);
                        }
                    }
                }
            }
            return invoices;
        }

        public static List<Invoice> SearchInvoicesDate(DateTime searchDate, string branchID)
        {
            List<Invoice> invoices = new List<Invoice>();
            string query = "EXEC sp_LayThongTinHoaDon @ChiNhanh, @NgayLapHoaDon";

            using (SqlConnection connection = new SqlConnection(Branch.con_string))
            {


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ChiNhanh", branchID);
                    command.Parameters.AddWithValue("@NgayLapHoaDon", searchDate);


                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Invoice invoice = new Invoice
                            {
                                MaHoaDon = reader["MaHoaDon"].ToString(),
                                TenNhanVienLap = reader["TenNhanVienLap"].ToString(),
                                MaKhachHang = reader["MaKhachHang"].ToString(),
                                HoTenKhachHang = reader["HoTen"].ToString(),
                                ThoiGianLap = Convert.ToDateTime(reader["NgayLapHoaDon"]), // Định dạng ngày
                                TongTien = Convert.ToDecimal(reader["TongTien"]) // Giả sử tổng tiền là kiểu decimal
                            };
                            invoices.Add(invoice);
                        }
                    }
                }
            }

            return invoices;
        }
    }
}
