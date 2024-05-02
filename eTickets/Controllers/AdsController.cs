using eTickets.Models;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace eTickets.Controllers
{
    public class AdsController : Controller
    {
        private readonly HttpClient _httpClient;
        private string _jwtToken;

        public AdsController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient(nameof(AdsController));
        }

        private async Task Login()
        {
            var loginModel = new LoginModel { Username = "AdsAdmin", Password = "AdsAdminPassword123!" };
            var loginJson = JsonSerializer.Serialize(loginModel);
            var loginData = new StringContent(loginJson, Encoding.UTF8, "application/json");
            var loginResponse = await _httpClient.PostAsync("https://advertisementapi.azurewebsites.net/Login", loginData);
            var loginResultJson = await loginResponse.Content.ReadAsStringAsync();
            var loginResult = JsonSerializer.Deserialize<LoginResult>(loginResultJson);
            _jwtToken = loginResult.Token;
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _jwtToken);
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

        [HttpPost]
        public async Task<IActionResult> Update(Advertisement ad)
        {
            var json = JsonSerializer.Serialize(ad);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"/Ads/{ad.Id}", data);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(ad);
        }
    }
}
