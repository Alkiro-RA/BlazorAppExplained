using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace BlazorServerApp.Data
{
    [Route("api/forecast")]
    [ApiController]
    public class ForecastController : ControllerBase
    {
        public async Task<ActionResult<IEnumerable<WeatherForecast>>> GetForecast()
        {
            var service = new WeatherForecastService();

            return new OkObjectResult(await service.GetForecastAsync(DateTime.Now));
        }
    }
}
