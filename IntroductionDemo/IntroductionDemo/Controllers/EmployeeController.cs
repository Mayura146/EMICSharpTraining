using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntroductionDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        [HttpGet]
        [Route("Details/All")]
        [Route("AllDetails")]
        [Route("Details/GetAll")]
        public string GetTrainerDetails()
        {
            return "Trainer Details Recieved!!";
        }
        [HttpGet]
        [Route("Trainer/{id}")]

        public string GetTrainerDetails(int id)
        {
            return $"Trainer id is {id}";
        }

        [HttpGet]
        [Route("Trainer/Skill/{skill}/exp/{exp}")]

        public string GetTrainerDetails(string skill,int exp)
        {
            return $"Trainer Skill is {skill} and experience is {exp}";
        }

        [HttpGet]
        [Route("Trainer/Dept")]
        public string getDept(string dept)
        {
            return $" Department is {dept}";
        }
    }
}

// api/Employee/Details/All