using AppLab.Models;
using System.Net.Http.Json;

namespace AppLab.Services
{
    public class TipoTrabajadorService
    {
        private readonly HttpClient _httpClient;

        public TipoTrabajadorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TipoTrabajador>> GetTipoTrabajadoresAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<TipoTrabajador>>("http://apiservicios.ecuasolmovsa.com:3009/api/Varios/TipoTrabajador");
        }
    }
}
