using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using ConvertCurrency.API.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ConvertCurrency.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConvertValuesController : Controller
    {
        private IConfiguration _config;

        public ConvertValuesController()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();
        }
        // GET from/to/amount
        [HttpGet("{from}/{to}/{amount}")]
        public ActionResult<IEnumerable<CurrencyConversionViewModel>> Get(string from, string to, string amount)
        {
            using (var client = new HttpClient())
            {
                var resultConvert = client.GetAsync(string.Format(_config[("ApiCurrencyLayer:ConvertValues")], from, to, amount));

                if (resultConvert.Result != null && resultConvert.Result.IsSuccessStatusCode)
                {
                    return Ok(JsonConvert.SerializeObject(resultConvert.Result.Content.ReadAsStringAsync().Result));
                }

                return null;
            }
        }
    }
}
