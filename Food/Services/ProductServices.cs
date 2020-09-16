using Food.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Food.Services
{
    class ProductServices
    {
        public async Task<ProductList> TodaySpecial()
        {
            string stringUrl = String.Format("https://foodgroup.herokuapp.com/api/today-special");
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(stringUrl);
            if(response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ProductList>(stringContent);
            }
            return null;
        }
    }
}
