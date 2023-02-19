using Repository.Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

            List<EmployeeEntity> 取得指定ID的資料方法一 = new List<EmployeeEntity>();

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
        public int CreateData(EmployeeEntity customers)
        {
            EmployeeRepository 毛蟲 = new EmployeeRepository();

            int 新增員工資料 = 毛蟲.Create(customers);

            return 新增員工資料;
        }
        public int UpdateData(EmployeeEntity Address)
        {
            EmployeeRepository 毛蟲 = new EmployeeRepository();

            int 更新員工住址 = 毛蟲.Update(Address);

            return 更新員工住址;
        }
        public int DeleteData(EmployeeEntity FirstName)
        {
            EmployeeRepository 毛蟲 = new EmployeeRepository();

            int 刪除員工手機 = 毛蟲.Delete(FirstName);

            return 刪除員工手機;
        }
    }
}
