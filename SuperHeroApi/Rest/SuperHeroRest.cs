using SuperHeroApi.DTO;
using SuperHeroApi.Interfaces;
using SuperHeroApi.Models;
using System.Dynamic;
using System.Text.Json;

namespace SuperHeroApi.Rest
{
    public class SuperHeroRest : ISuperHero
    {
        public async Task<ResponseGeneric<SuperHeroModel>> GetSuperHero(string id, string token)
        {
            //request made by the user by id
            //what's going to appear in swagger, the fields
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://superheroapi.com/api/{token}/{id}");

            //response that the swagger will show, response structure
            var response = new ResponseGeneric<SuperHeroModel>();
            using (var client = new HttpClient())
            {
                var responseSuperHero = await client.SendAsync(request); //wait and get the response of the user
                var contentResponse = await responseSuperHero.Content.ReadAsStringAsync(); //read the content of the response
                var objectResponse = JsonSerializer.Deserialize<SuperHeroModel>(contentResponse); //deserialize the content of teh response to json

                if (responseSuperHero.IsSuccessStatusCode)
                {
                    response.HttpCode = responseSuperHero.StatusCode;
                    response.ReturnData = objectResponse;
                }
                else
                {
                    response.HttpCode = responseSuperHero.StatusCode;
                    response.ReturnError = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
                return response;
            }
        }
    }
}
