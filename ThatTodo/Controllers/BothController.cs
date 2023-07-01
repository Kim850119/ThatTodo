using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Model;
using Repository.Model.ViewModel;
using Service.Service;

namespace ThatTodo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BothController : ControllerBase
    {
        [HttpPost]
        public List<BothEntity> GetAllBothData()
        {
            BothService service = new BothService();
            List<BothEntity> bothEntities = service.取得全部資料();
            return bothEntities;
        }

        [HttpPost]
        public string CreateBoths(List<BothEntity> both)
        {
            BothService service = new BothService();

            string CreateData = service.新增指定ID(both);
            
            return CreateData;
        }

        [HttpPost]
        public string UpdateBoths(List<BothEntity> both)
        {
            BothService service = new BothService();

            string UpdateData = service.更新指定ID(both);

            return UpdateData;
        }

        [HttpPost]
        public string DeleteBoths(List<BothEntity> both)
        {
            BothService service = new BothService();

            string DeleteData = service.刪除指定ID(both);

            return DeleteData;
        }
    }
}
