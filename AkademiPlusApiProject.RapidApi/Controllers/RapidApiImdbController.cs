using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using AkademiPlusApiProject.RapidApi.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace AkademiPlusApiProject.RapidApi.Controllers
{
    public class RapidApiIMDBController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<RapidApiImdbViewModel> rapidApiViewModels = new List<RapidApiImdbViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "X-RapidAPI-Key", "7cc0c9e075msh77323eaa6d868e4p1810e6jsncd16774577d4" },
        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
               rapidApiViewModels=JsonConvert.DeserializeObject<List<RapidApiImdbViewModel>>(body);
                return View(rapidApiViewModels);
            }
        }
    }
}
