using Microsoft.AspNetCore.Mvc;
using Repository.Model;
using Service.Service;

namespace ThatTodo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeControllor : ControllerBase
    {
        [HttpPost]
        public List<EmployeeEntity> GetAllEmlpoyeeData()
        {
            EmployeeService 毛毛蟲 = new EmployeeService();

            List<EmployeeEntity> employeeData = 毛毛蟲.取得全部員工資料();

            return employeeData;
        }

        [HttpPost]
        public int CreateEmployee(EmployeeEntity employee)
        {
            EmployeeService 毛毛蟲 = new EmployeeService();

            int CreateData = 毛毛蟲.CreateData(employee);

            return CreateData;
        }

        [HttpPost]
        public int UpdateAddress(EmployeeEntity employee)
        {
            EmployeeService 毛毛蟲 = new EmployeeService();

            int UpdateData = 毛毛蟲.UpdateData(employee);

            return UpdateData;
        }

        [HttpPost]
        public int DeleteCity(EmployeeEntity employee)
        {
            EmployeeService 毛毛蟲 = new EmployeeService();

            int DeleteData = 毛毛蟲.DeleteData(employee);

            return DeleteData;
        }
    }
}
