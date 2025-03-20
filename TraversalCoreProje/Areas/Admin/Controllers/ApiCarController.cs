using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    public class ApiCarController : Controller
    {
        [Area("Admin")]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            List<ApiCarsViewModel> apiCarsViewModels = new List<ApiCarsViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://car-data.p.rapidapi.com/cars?limit=50&page=0"),
                Headers =
    {
        { "x-rapidapi-key", "cf05966583msh69ecb44c628c682p16635fjsnf89bda7ff348" },
        { "x-rapidapi-host", "car-data.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apiCarsViewModels = JsonConvert.DeserializeObject<List<ApiCarsViewModel>>(body);
                return View(apiCarsViewModels);
            }
        }
    }
}
