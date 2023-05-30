using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SaraJack.Controllers
{
    //[Route("api/[controller]")]
    //[Route("[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        //[Route("api/Get-list/{id}")]
        //public string GetList(int id)
        //{
        //    return "Get all list with api " + id;
        //}

        //[Route("[controller]/{id}")]
        //public string GetMyList(int id)
        //{
        //    return "Get all my list " + id;
        //}

        //[Route("[controller]/[action]")]
        //[Route("~/GetNewList")]
        //[Route("~/GetList")]
        //[Route("api/GetList")]
        //public string GetMyList()
        //{
        //    return "Get all my list ";
        //}

        [Route("api/GetList/{id}")]
        public string GetList(int id)
        {
            return "Get all list " + id;
        }

        [Route("api/GetListString")]
        public string GetListString(string name, int userId, int userCode, string? userClass)
        {
            return "Get all string list";
        }
    }
}
