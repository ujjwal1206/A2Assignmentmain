using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;

namespace A2DocWebApplication.Models
{
    public class RestServiceClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _serviceUrl = "http://localhost:50107/Service1.svc";

        public RestServiceClient()
        {
            _httpClient = new HttpClient();
        }
        public async Task<int> SecretNumberAsync(int x, int y)
        {
            var response = await _httpClient.GetStringAsync($"{_serviceUrl}/secretnumber?x={x}&y={y}");
            return int.Parse(response);
        }
        public async Task<string>CheckNumberAsync(int x,int y)
        {
            return await _httpClient.GetStringAsync($"{ _serviceUrl}/checknumber?x={x}&y={y}");
        }

    }
}