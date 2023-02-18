using Dapper;
using Repository.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class EmployeeRepository
    {
        private string 連線字串 = @"Server=LAPTOP-A1U05AHA\SQLEXPRESS;Database=教學資料庫;Trusted_Connection=True;TrustServerCertificate=true;User ID=sa;Password=humx841229";

        public List<EmployeeEntity> 取得Employee全部()
        {
            string sql = @"SELECT * FROM Employee";

            //SqlConnection=>型別
            using (SqlConnection conn = new SqlConnection(連線字串))
            {
                conn.Open();

                List<EmployeeEntity> 全部員工資料 = conn.Query<EmployeeEntity>(sql).ToList();

                return 全部員工資料;
            }
        }
    }
}
