using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Restaurant
{
    public class FoodItem
    {
        public string MaMonAn { get; set; } // Mã món ăn
        public string TenMonAn { get; set; } // Tên món ăn
        public string MaMuc { get; set; } // Mã mục
        public decimal GiaHienTai { get; set; } // Giá hiện tại
        public int TinhTrangPhucVu { get; set; } // Tình trạng phục vụ

        public static List<FoodItem> LoadFoodItemsFromProcedure(string branchID)
        {
            List<FoodItem> foodItems = new List<FoodItem>();
            string query = "CheckMonAnForChiNhanhByMaChiNhanh"; // Tên stored procedure

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
                        FoodItem foodItem = new FoodItem
                        {
                            MaMonAn = reader["MaMonAn"].ToString(),
                            TenMonAn = reader["TenMonAn"].ToString(),
                            MaMuc = reader["MaMuc"].ToString(), // Mã mục
                            GiaHienTai = Convert.ToDecimal(reader["GiaHienTai"]), // Giá hiện tại
                            TinhTrangPhucVu = Convert.ToInt32(reader["TinhTrangPhucVu"]) // Tình trạng phục vụ
                        };
                        foodItems.Add(foodItem);
                    }
                }
            }
            return foodItems;
        }

        public static List<FoodItem> SearchFoodItems(string searchTerm, string branchID)
        {
            List<FoodItem> foodItems = new List<FoodItem>();
            string query = "CheckMonAnForChiNhanhByMaChiNhanh"; // Tên stored procedure cho tìm kiếm món ăn

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
                        // Kiểm tra xem mã món ăn hoặc tên món ăn có chứa searchTerm không
                        if (reader["MaMonAn"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            reader["TenMonAn"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            FoodItem foodItem = new FoodItem
                            {
                                MaMonAn = reader["MaMonAn"].ToString(),
                                TenMonAn = reader["TenMonAn"].ToString(),
                                MaMuc = reader["MaMuc"].ToString(), // Mã mục
                                GiaHienTai = Convert.ToDecimal(reader["GiaHienTai"]), // Giá hiện tại
                                TinhTrangPhucVu = Convert.ToInt32(reader["TinhTrangPhucVu"]) // Tình trạng phục vụ
                            };
                            foodItems.Add(foodItem);
                        }
                    }
                }
            }
            return foodItems;
        }
    }
}
