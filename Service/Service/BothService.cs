using Repository.Model;
using Repository.Model.ViewModel;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class BothService
    {
        public List<BothEntity> 取得全部資料()
        {
            //CustomersRepository=>類型
            //毛蟲=>名子
            //賽入new CustomersRepository()
            CustomersRepository 毛蟲 = new CustomersRepository();

            List<CustomersEntity> 全部客戶資料 = 毛蟲.取得Customers全部();

            EmployeeRepository 毛毛蟲 = new EmployeeRepository();

            List<EmployeeEntity> 全部員工資料 = 毛毛蟲.取得Employee全部();

            BothEntity bothEntity = new BothEntity();
            List<BothEntity> boths = new List<BothEntity>();
            foreach(CustomersEntity 單一客戶資料 in 全部客戶資料)
            {

                //取得指定ID的資料方法三 = 全部客戶資料.Where(item => item.CustomerID?.Trim() == customers.CustomerID).ToList();
                EmployeeEntity? 指定ID的資料方法 = 全部員工資料.FirstOrDefault(item => item.CustomerID?.Trim() == 單一客戶資料.CustomerID?.Trim());

                bothEntity.CustomerID = 單一客戶資料.CustomerID;
                bothEntity.Address = "2";
                boths.Add(bothEntity);

                boths.Add(new BothEntity() { 
                CustomerID = 單一客戶資料.CustomerID,
                Address=""
                });
            }
            return boths;
        }
        public List<BothEntity> 新增指定ID(List<BothEntity> 新增資料)
        {

            CustomersEntity customersdata = new CustomersEntity();

            List<CustomersEntity> customers = new List<CustomersEntity>();

            EmployeeEntity employeedata = new EmployeeEntity();

            List<EmployeeEntity> employees = new List<EmployeeEntity>();

            
            foreach (BothEntity 單一資料 in 新增資料)
            {
                
                customersdata.CustomerID = 單一資料.CustomerID;


                //CreateData.Add(customers);

            }
            

        }
    }
}
