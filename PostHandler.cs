using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace SoftwareStation
{
    class PostHandler
    {
        public async Task<RootObject> post(IEnumerable<KeyValuePair<string, string>> queries, String url)
        {

            HttpContent keys = new FormUrlEncodedContent(queries);
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await request(client, url, keys);
            String content = await response.Content.ReadAsStringAsync();

            var serializer = new DataContractJsonSerializer(typeof(RootObject));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(content));
            var data = (RootObject)serializer.ReadObject(ms);

            return data;
        }

        public async Task<HttpResponseMessage> request(HttpClient client, String url, HttpContent keys)
        {
            HttpResponseMessage response = await client.PostAsync(url, keys);
            return response;
        }
    }

    [DataContract]
    public class RootObject
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string error { get; set; }
        [DataMember]
        public string vorname { get; set; }
    }
}

