using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;

namespace eTickets.Controllers
{
    public class AdsController : Controller
    {
        private readonly HttpClient _httpClient;

        public AdsController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient(nameof(AdsController));
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("/Ads");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var ads = JsonSerializer.Deserialize<List<Advertisement>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return View(ads);
            }

            return NotFound();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpClient.GetAsync($"/Ads/{id}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var ad = JsonSerializer.Deserialize<Advertisement>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return View(ad);
            }

            return NotFound();
        }
    }
}
