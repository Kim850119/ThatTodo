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
    }
}
