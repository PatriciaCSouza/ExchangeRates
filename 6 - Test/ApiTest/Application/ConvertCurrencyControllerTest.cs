using ConvertCurrency.API.ViewModel;
using ConvertCurrency.Controllers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Xunit;

namespace ApiTest
{
    public class ConvertCurrencyControllerTest
    {

        [Fact]
        public void ConvertCurrencyController()
        {
            string accessKey = "94674d34f72d8f40d39b88b68d8cbdd9";
            string from = "USD";
            string to = "GBP";
            string amount = "10";

            using (var client = new HttpClient())
            {

                ConvertValuesController convertValuesController = new ConvertValuesController();

                QueryViewModel query = new QueryViewModel(from, to, amount);

                JObject json = JObject.FromObject(query);

                var result = convertValuesController.Get(from, to, amount);

                Assert.IsType<OkObjectResult>(result);

                //if (result.Result != null && result.Result.IsSuccessStatusCode)
                //{
                //    Assert.True((int)result.Result.StatusCode == 200);
                //}

                //var resultCurrency = client.PostAsJsonAsync(string.Format("https://apilayer.net/api/convert?access_key={0}&from={1}&to={2}&amount={3}", accessKey, query.From, query.To, query.Amount), string.Empty);


            }
        }
    }
}

