using Dapper;
using Repository.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class CustomersRepository
    {
        private string 連線字串 = @"Server=LAPTOP-A1U05AHA\SQLEXPRESS;Database=教學資料庫;Trusted_Connection=True;TrustServerCertificate=true;User ID=sa;Password=humx841229";

        public List<CustomersEntity> 取得Customers全部()
        {
            string sql = @"SELECT * FROM Customers";

            //SqlConnection=>型別
            using (SqlConnection conn = new SqlConnection(連線字串))
            {
                conn.Open();

                List<CustomersEntity> 全部客戶資料 = conn.Query<CustomersEntity>(sql).ToList();

                return 全部客戶資料;
            }
        }

        public int Create(CustomersEntity parameter)
        {
            var sql =
    @"
                Insert into Customers 
                (
                   [Phone],[CustomerID],[Address],[CompenyName],[City]
                ) 
                values 
                (
                   @Phone,@CustomerID,@Address,@CompenyName,@City
                );
            ";
            using (var conn = new SqlConnection(連線字串))
            {
                conn.Open();

                int Customer = conn.Execute(sql, parameter);
                return Customer;
            }

        }
        public int Update(CustomersEntity Address)
        {
            using (var conn = new SqlConnection(連線字串))
            {
                conn.Open();

                var sql = @"Update Customers Set Address = @Address WHERE Phone = @Phone";

                int z = conn.Execute(sql, Address);
                return z;
            }
        }
        public int Delete(CustomersEntity City)
        {
            using (var conn = new SqlConnection(連線字串))
            {
                conn.Open();
                var sql = @"Delete From Customers WHERE City = @City";

                int a = conn.Execute(sql, City);
                return a;
            }

        }

    }
}
