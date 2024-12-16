using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Restaurant
{
    // Phương thức để lấy danh sách nhân viên từ stored procedure
    public class Employee
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string NgayVaoLam { get; set; } // Ngày vào làm
        public string TenBoPhan { get; set; } // Tên bộ phận
        public int MucLuong { get; set; } // Mức lương
        public int DiemPhucVu { get; set; } // Điểm phục vụ

        // Phương thức để lấy danh sách nhân viên từ stored procedure
        public static List<Employee> LoadEmployeeFromProcedure(string branchID)
        {
            List<Employee> employees = new List<Employee>();
            string query = "LayNhanVienCuaChiNhanhTheoLichSu"; // Tên stored procedure

            using (SqlConnection con = new SqlConnection(Branch.con_string))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaChiNhanh", branchID);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee emp = new Employee
                        {
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString(),
                            NgaySinh = Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy"), // Định dạng ngày sinh
                            DiaChi = reader["DiaChi"].ToString(),
                            SDT = reader["SoDienThoai"].ToString(),
                            NgayVaoLam = Convert.ToDateTime(reader["NgayGanNhat"]).ToString("dd/MM/yyyy"), // Định dạng ngày vào làm
                            TenBoPhan = reader["TenBoPhan"].ToString(),
                            MucLuong = Convert.ToInt32(reader["MucLuong"]),
                            DiemPhucVu = Convert.ToInt32(reader["DiemPhucVu"])
                        };
                        employees.Add(emp);
                    }
                }
            }
            return employees;
        }
        // Phương thức tìm kiếm nhân viên
        public static List<Employee> SearchEmployees(string searchTerm, string branchID)
        {
            List<Employee> employees = new List<Employee>();
            string query = "LayNhanVienCuaChiNhanhTheoLichSu"; // Tên stored procedure

            using (SqlConnection con = new SqlConnection(Branch.con_string))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaChiNhanh", branchID);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Kiểm tra xem tên nhân viên hoặc mã nhân viên có chứa searchTerm không
                        if (reader["MaNhanVien"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            reader["HoTen"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            reader["TenBoPhan"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            Employee emp = new Employee
                            {
                                MaNhanVien = reader["MaNhanVien"].ToString(),
                                HoTen = reader["HoTen"].ToString(),
                                GioiTinh = reader["GioiTinh"].ToString(),
                                NgaySinh = Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy"),
                                DiaChi = reader["DiaChi"].ToString(),
                                SDT = reader["SoDienThoai"].ToString(),
                                NgayVaoLam = Convert.ToDateTime(reader["NgayGanNhat"]).ToString("dd/MM/yyyy"),
                                TenBoPhan = reader["TenBoPhan"].ToString(),
                                MucLuong = Convert.ToInt32(reader["MucLuong"]),
                                DiemPhucVu = Convert.ToInt32(reader["DiemPhucVu"])
                            };
                            employees.Add(emp);
                        }
                    }
                }
            }
            return employees;
        }

    }
}
