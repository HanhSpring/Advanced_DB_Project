using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Restaurant
{
    public class CustomerCard
    {
        public string MaSoThe { get; set; } // Mã số thẻ
        public string LoaiThe { get; set; } // Loại thẻ
        public int TongDiemTichLuy { get; set; } // Tổng điểm tích lũy
        public DateTime NgayLap { get; set; } // Ngày lập thẻ
        public string HoTenKhachHang { get; set; } // Họ tên khách hàng
        public string HoTenNhanVien { get; set; } // Họ tên nhân viên lập thẻ

        public static List<CustomerCard> LoadCustomerCardsFromProcedure(string branchID)
        {
            List<CustomerCard> customerCards = new List<CustomerCard>();
            string query = "sp_LayThongTinTheThanhVien"; // Tên stored procedure

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
                        CustomerCard customerCard = new CustomerCard
                        {
                            MaSoThe = reader["MaSoThe"].ToString(),
                            LoaiThe = reader["LoaiThe"].ToString(),
                            TongDiemTichLuy = Convert.ToInt32(reader["TongDiemTichLuy"]), // Tổng điểm tích lũy  
                            NgayLap = Convert.ToDateTime(reader["NgayLap"]), // Ngày lập thẻ                         
                            HoTenKhachHang = reader["HoTenKhachHang"].ToString(),
                            HoTenNhanVien = reader["TenNhanVienLap"].ToString() // Họ tên nhân viên lập thẻ
                        };
                        customerCards.Add(customerCard);
                    }
                }
            }
            return customerCards;
        }

        public static List<CustomerCard> SearchCustomerCards(string searchTerm, string branchID)
        {
            List<CustomerCard> customerCards = new List<CustomerCard>();
            string query = "sp_LayThongTinTheThanhVien"; // Tên stored procedure cho tìm kiếm

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
                        // Kiểm tra xem mã số thẻ hoặc họ tên khách hàng có chứa searchTerm không
                        if (reader["MaSoThe"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            reader["HoTenKhachHang"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            CustomerCard customerCard = new CustomerCard
                            {
                                MaSoThe = reader["MaSoThe"].ToString(),
                                LoaiThe = reader["LoaiThe"].ToString(),
                                TongDiemTichLuy = Convert.ToInt32(reader["TongDiemTichLuy"]), // Tổng điểm tích lũy  
                                NgayLap = Convert.ToDateTime(reader["NgayLap"]), // Ngày lập thẻ                         
                                HoTenKhachHang = reader["HoTenKhachHang"].ToString(),
                                HoTenNhanVien = reader["TenNhanVienLap"].ToString() // Họ tên nhân viên lập thẻ
                            };
                            customerCards.Add(customerCard);
                        }
                    }
                }
            }
            return customerCards;
        }
    }
}
