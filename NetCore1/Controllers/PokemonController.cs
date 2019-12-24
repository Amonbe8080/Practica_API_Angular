using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace NetCore1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        // GET: api/Pokemon/pikachu
        [HttpGet("{name}")]
        public async Task<IActionResult> Buscar([FromForm]string name)
        {
            try
            {
                // Intancia de un objeto HttpClient y consulta a un pokemon pasado como parametro
                var httpClient = new HttpClient();
                var response = httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/" + name);

                string apiResponse = await response.Result.Content.ReadAsStringAsync();
                // Convierte la respuesta de la API en un objeto de tipo Pokemon
                Pokemon pok = JsonConvert.DeserializeObject<Pokemon>(apiResponse);

                // El string se convierte a Json, luego el Json se asigna a un objeto (fetch_object[PHP])
                dynamic pokemon = JsonConvert.DeserializeObject(apiResponse);
                // Forma de acceder a un valor dentro de un objeto
                string pathImg = pokemon.sprites.front_default;

                return Ok(pok);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }
    }
}
