using Microsoft.AspNetCore.Mvc;
using UserForm.Models;

namespace UserForm.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UserFormController : Controller
    {
        
        [HttpGet]
        public string Get()
        {
            return "Welcome to my application";
        }
        [HttpGet ("UserName")]
        public string GetUserName()
        {
            string userName = "Nishchhal";
            return userName;
        }
        [HttpPost]
        public string Post([FromBody]UserModel userModel)
        {
            if(userModel.FirstName != null && userModel.FirstName != string.Empty)
            {
                return "success";
            }
            return "Failed";
        }
    }
}
