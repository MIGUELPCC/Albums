using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace AlbumWeb.Utils
{
    public static class HttpUtil
    {
        public static T Get<T>(string url)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    using (var response = client.GetAsync(url).Result)
                    {
                        var stringResponse = response.Content.ReadAsStringAsync().Result;
                        if (response.IsSuccessStatusCode)
                            return JsonConvert.DeserializeObject<T>(stringResponse);
                        throw new Exception();
                    }
                }
            }catch(Exception e)
            {
                throw;
            }
           
        }
    }
}