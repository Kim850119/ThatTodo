using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Model;
using Service.Service;

namespace ThatTodo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpPost]
        public List<CustomersEntity> GetAllCustomersData()
        {
            CustomersService 毛毛蟲 = new CustomersService();

            List<CustomersEntity> customerData = 毛毛蟲.取得全部客戶資料();

            return customerData;
        }

        [HttpPost]
        public List<CustomersEntity> GetCustomersDataByCustomersID(CustomersEntity customers)
        {
            CustomersService 毛毛蟲 = new CustomersService();

            List<CustomersEntity> customerData = 毛毛蟲.取得指定ID的毛毛毛毛毛蟲(customers);

            return customerData;
        }

        [HttpPost]
        public int CreateCustomers(CustomersEntity customers)
        {
            CustomersService 毛毛蟲 = new CustomersService();

            int CreateData = 毛毛蟲.CreateData(customers);

            return CreateData;
        }

    }
}
