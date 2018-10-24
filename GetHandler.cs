using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareStation
{
    class GetHandler
    {
        public async Task<RootObjectGet> get(String url)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            String content = await response.Content.ReadAsStringAsync();

            var serializer = new DataContractJsonSerializer(typeof(RootObjectGet));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(content));
            var data = (RootObjectGet)serializer.ReadObject(ms);

            return data;
        }
    }

    [DataContract]
    public class RootObjectGet
    {
        [DataMember]
        public string _id { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string vorname { get; set; }
        [DataMember]
        public string birthday { get; set; }
        [DataMember]
        public string height { get; set; }
        [DataMember]
        public string sex { get; set; }
        [DataMember]
        public string weight { get; set; }
    }
}
