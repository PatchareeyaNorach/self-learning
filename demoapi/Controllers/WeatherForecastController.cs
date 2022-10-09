using Microsoft.AspNetCore.Mvc;

namespace demoapi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public Product Get() {
        return new Product(){
            Id = 1,
            ProductName = "AAA",
            Price = 25.5
        };
    }

    [HttpGet("{name}")]
    public string Get(string name){
        return "Hello " + name;
    }

    [HttpPost]
    public string CreateNewProduct([FromBody]Product product){
        //Save to database
        return "Product " + product.ProductName + " has been created!!!";
    }

    [HttpPut("{productName}")]
    public string ChangeProductName(string productName){
        //Update product name in the database
        return "Product name has been changed!!!";
    }

    //[HttpGet(Name = "GetWeatherForecast")]
    //public IEnumerable<WeatherForecast> Get()
    //{
    //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //        Date = DateTime.Now.AddDays(index),
    //        TemperatureC = Random.Shared.Next(-20, 55),
    //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //    })
    //    .ToArray();
    //}
}
