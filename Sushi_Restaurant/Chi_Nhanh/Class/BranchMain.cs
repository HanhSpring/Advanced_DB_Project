using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Sushi_Restaurant
{

    internal class Branch
    {
        // Chuỗi kết nối với cơ sở dữ liệu
        public static readonly string con_string = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=300;";
        public static SqlConnection con = new SqlConnection(con_string);

        // Thuộc tính tĩnh chung cho lớp (Mã chi nhánh)
        public static string MaChiNhanh { get; set; }

        // Kiểm tra đăng nhập và lấy mã chi nhánh
        public static string CheckLogin(string username, string hashedPassword)
        {
            string branchId = null;
            {
                string query = @"
                    SELECT MaChiNhanh 
                    FROM TaiKhoanChiNhanh 
                    WHERE TenDangNhap = @Username AND MatKhau = @Password";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", hashedPassword);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    branchId = reader["MaChiNhanh"].ToString();
                    MaChiNhanh = branchId; // Lưu mã chi nhánh vào thuộc tính chung
                }
                con.Close();
            }
            return branchId;
        }
    }


}

