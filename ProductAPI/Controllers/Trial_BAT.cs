using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models.Contact;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http;


namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Trial_BAT : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public Trial_BAT(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpPost]
        [Route("send-data")]
        public async Task<IActionResult> SendData([FromBody] ContactModel model)
        {
            // Azure Function URL
            string functionUrl = "http://localhost:7080/api/ValidateAndProcess";

            // Create HttpClient instance
            var client = _httpClientFactory.CreateClient();

            // Serialize model to JSON
            var jsonData = JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            try
            {
                // Send POST request to Azure Function
                var response = await client.PostAsync(functionUrl, content);

                // Read the response
                var responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return Ok(new { Message = "Data sent successfully", Response = responseBody });
                }
                else
                {
                    return BadRequest(new { Message = "Error sending data", Details = responseBody });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred", Error = ex.Message });
            }
        }
    }
}
