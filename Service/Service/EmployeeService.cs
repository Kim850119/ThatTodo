using Repository.Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class EmployeeService
    {
        public List<EmployeeEntity> 取得全部員工資料()
        {

            EmployeeRepository 毛蟲 = new EmployeeRepository();

            List<EmployeeEntity> 全部員工資料 = 毛蟲.取得Employee全部();

            return 全部員工資料;
        }
        public List<EmployeeEntity> 取得指定ID的毛毛毛蟲(EmployeeEntity employee)
        {
            EmployeeRepository 毛蟲 = new EmployeeRepository();

            List<EmployeeEntity> 全部員工資料 = 毛蟲.取得Employee全部();

            List<EmployeeEntity> 取得指定ID的資料方法一 = new List<CustomersEntity>();

            foreach (EmployeeEntity 單一筆員工資料 in 全部員工資料)
            {
                if (單一筆員工資料.CustomerID?.Trim() == employee.CustomerID)
                {
                    //單一筆客戶資料.City = "台北";
                    取得指定ID的資料方法一.Add(單一筆員工資料);
                }
            }
            return 取得指定ID的資料方法一;
        }
    }
}
