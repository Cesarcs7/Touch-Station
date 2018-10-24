using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareStation
{
    class PostData
    {
        PostHandler posthandler = new PostHandler();

        public async Task<RootObject> postData(String url, String email, String weight, String height)
        {
            Console.WriteLine(url);
            Console.WriteLine(email);
            Console.WriteLine(weight);
            Console.WriteLine(height);
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
                {
                new KeyValuePair<string, string>("weight", weight),
                new KeyValuePair<string, string>("height", height),
                new KeyValuePair<string, string>("email", email),
                };

            RootObject content = await posthandler.post(queries, url);

            return content;
        }
    }
}
