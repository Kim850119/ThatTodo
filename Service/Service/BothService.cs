using Repository.Model;
using Repository.Model.ViewModel;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public string 新增指定ID(List<BothEntity> 新增資料)
        {

            CustomersEntity customersdata = new CustomersEntity();

            List<CustomersEntity> customerlist = new List<CustomersEntity>();

            EmployeeEntity employeedata = new EmployeeEntity();

            List<EmployeeEntity> employeelist = new List<EmployeeEntity>();

            
            foreach (BothEntity 單一資料 in 新增資料)
            {
                
                customersdata.CustomerID = 單一資料.CustomerID;
                customersdata.CompenyName= 單一資料.CompenyName;
                customersdata.Address = 單一資料.Address;
                customersdata.City = 單一資料.City;
                customersdata.Phone = 單一資料.Phone;
                customerlist.Add(customersdata);

                employeedata.CustomerID = 單一資料.CustomerID;
                employeedata.FirstName= 單一資料.FirstName;
                employeedata.LastName = 單一資料.LastName;
                employeedata.Address = 單一資料.Address;
                employeedata.HomePhone = 單一資料.HomePhone;
                employeedata.CellPhone = 單一資料.CellPhone;
                employeelist.Add(employeedata);

            }

            CustomersRepository customersRepository = new CustomersRepository();

            foreach(CustomersEntity customersiteam in customerlist)
            {
                int 新增客戶 = customersRepository.Create(customersiteam);
            }
            
            EmployeeRepository employeeRepository = new EmployeeRepository();

            foreach (EmployeeEntity employeeiteam in employeelist)
            {
                int 新增員工 = employeeRepository.Create(employeeiteam);
            }
            return "新增成功";
        }
        public string 更新指定ID(List<BothEntity> 更新資料)
        {

            CustomersEntity customersdata = new CustomersEntity();

            List<CustomersEntity> customerlist = new List<CustomersEntity>();

            EmployeeEntity employeedata = new EmployeeEntity();

            List<EmployeeEntity> employeelist = new List<EmployeeEntity>();


            foreach (BothEntity 單一資料 in 更新資料)
            {

                customersdata.CustomerID = 單一資料.CustomerID;
                customersdata.CompenyName = 單一資料.CompenyName;
                customersdata.Address = 單一資料.Address;
                customersdata.City = 單一資料.City;
                customersdata.Phone = 單一資料.Phone;
                customerlist.Add(customersdata);

                employeedata.CustomerID = 單一資料.CustomerID;
                employeedata.FirstName = 單一資料.FirstName;
                employeedata.LastName = 單一資料.LastName;
                employeedata.Address = 單一資料.Address;
                employeedata.HomePhone = 單一資料.HomePhone;
                employeedata.CellPhone = 單一資料.CellPhone;
                employeelist.Add(employeedata);

            }

            CustomersRepository customersRepository = new CustomersRepository();

            foreach (CustomersEntity customersiteam in customerlist)
            {
                int 新增客戶 = customersRepository.Update(customersiteam);
            }

            EmployeeRepository employeeRepository = new EmployeeRepository();

            foreach (EmployeeEntity employeeiteam in employeelist)
            {
                int 新增員工 = employeeRepository.Update(employeeiteam);
            }
            return "更新成功";

        }
        public string 刪除指定ID(List<BothEntity> 刪除資料)
        {

            CustomersEntity customersdata = new CustomersEntity();

            List<CustomersEntity> customerlist = new List<CustomersEntity>();

            EmployeeEntity employeedata = new EmployeeEntity();

            List<EmployeeEntity> employeelist = new List<EmployeeEntity>();


            foreach (BothEntity 單一資料 in 刪除資料)
            {

                customersdata.Address = 單一資料.Address;
                customerlist.Add(customersdata);

                employeedata.Address = 單一資料.Address;
                employeelist.Add(employeedata);

            }

            CustomersRepository customersRepository = new CustomersRepository();

            foreach (CustomersEntity customersiteam in customerlist)
            {
                int 新增客戶 = customersRepository.Delete(customersiteam);
            }
            EmployeeRepository employeeRepository = new EmployeeRepository();

            foreach (EmployeeEntity employeeiteam in employeelist)
            {
                int 新增員工 = employeeRepository.Delete(employeeiteam);
            }
            return "刪除成功";

        }
    }
}
