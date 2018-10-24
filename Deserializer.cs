using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;


namespace SoftwareStation
{
    class Deserializer
    {
        public RootObject serialize(String response)
        {
            var serializer = new DataContractJsonSerializer(typeof(RootObject));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(response));
            var data = (RootObject)serializer.ReadObject(ms);

            return data;
        }
    }

}

