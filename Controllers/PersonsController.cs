using Microsoft.AspNetCore.Mvc;

namespace SampleApi.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var persons = new string[]{
                "Mohamad",
                "Donald Duck",
                "Mikey",
                "Batman",
                "Thor",
                "Tony Stark"
            };
            return Ok(persons);
        }

    }
}