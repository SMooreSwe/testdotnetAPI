using Microsoft.AspNetCore.Mvc;

namespace test.Controllers;

[ApiController]
[Route("[controller]")]
public class StephenController : ControllerBase
{

    public StephenController()
    {

    }

    [HttpGet("Test")]
    public string Get()
    {
        return "Hi, I am Stephen";
    }
}
