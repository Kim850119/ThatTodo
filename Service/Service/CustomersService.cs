using Repository.Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class CustomersService
    {
        public List<CustomersEntity> 取得全部客戶資料()
        {
            //CustomersRepository=>類型
            //毛蟲=>名子
            //賽入new CustomersRepository()
            CustomersRepository 毛蟲 = new CustomersRepository();

            List<CustomersEntity> 全部客戶資料 = 毛蟲.取得Customers全部();

            return 全部客戶資料;
        }

        public List<CustomersEntity> 取得指定ID的毛毛毛毛毛蟲(CustomersEntity customers)
        {
            CustomersRepository 毛蟲 = new CustomersRepository();

            List<CustomersEntity> 全部客戶資料 = 毛蟲.取得Customers全部();

            List<CustomersEntity> 取得指定ID的資料方法一 = new List<CustomersEntity>();

            List<CustomersEntity> 取得指定ID的資料方法二 = new List<CustomersEntity>();

            List<CustomersEntity> 取得指定ID的資料方法三 = new List<CustomersEntity>();

            //方法1 foreach
            foreach (CustomersEntity 單一筆客戶資料 in 全部客戶資料)
            {
                if (單一筆客戶資料.CustomerID?.Trim() == customers.CustomerID)
                {
                    //單一筆客戶資料.City = "台北";
                    取得指定ID的資料方法一.Add(單一筆客戶資料);
                }
            }

            //方法2 for
            for (int i = 0; i < 全部客戶資料.Count(); i++)
            {
                if (全部客戶資料[i].CustomerID?.Trim() == customers.CustomerID)
                {
                    取得指定ID的資料方法二.Add(全部客戶資料[i]);
                }
            }

            //方法3 linq
            //item=>每一筆
            取得指定ID的資料方法三 = 全部客戶資料.Where(item => item.CustomerID?.Trim() == customers.CustomerID).ToList();


            return 取得指定ID的資料方法三;
        }

        public int CreateData(CustomersEntity customers)
        {
            CustomersRepository 毛蟲 = new CustomersRepository();

            int 新增客戶資料 = 毛蟲.Create(customers);

            return 新增客戶資料;
        }

        public int UpdateData(CustomersEntity customers)
        {
            CustomersRepository 毛蟲 = new CustomersRepository();

            int 更新客戶住址 = 毛蟲.Update(customers);

            return 更新客戶住址;
        }
        public int DeleteData(CustomersEntity customers)
        {
            CustomersRepository 毛蟲 = new CustomersRepository();

            int 刪除客戶城市 = 毛蟲.Delete(customers);

            return 刪除客戶城市;
        }
    }
}
