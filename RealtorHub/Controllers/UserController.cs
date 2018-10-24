using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RealtorHub.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        // Ex: https://localhost:5001/User/Register/1114?name=Frodo&age=111
        public string Register(string name = "default_name", int id = -1, int age = -1)
        {
            //Call UserModel objects
            return System.Text.Encodings.Web.HtmlEncoder.Default.Encode($"Testing Action: Hello {name}, ID is: {id}, age is : {age}");
        }

        public string Get(string id)
        {
            //call UserModel to get User information
            return "UserModel";
        }
    }
}
