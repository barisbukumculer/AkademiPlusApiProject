using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using AkademiPlusApiProject.RapidApi.Models;
using System.Linq;

namespace AkademiPlusApiProject.RapidApi.Controllers
{
    public class RapidApiExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        { 
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=TRY&locale=en-gb"),
                Headers =
    {
        { "X-RapidAPI-Key", "7cc0c9e075msh77323eaa6d868e4p1810e6jsncd16774577d4" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<RapidApiExchangeViewModel>(body);
                return View(values.exchange_rates.ToList());
            }
           
        }
    }
}
