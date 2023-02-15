using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API_Project
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://smart.cpc.vn/CISP_API/api/CISP/LoadLISTKHUVUC");
            var content = new StringContent("{\r\n    \"TOKEN\":\"\"\r\n}", null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }
    }
}
