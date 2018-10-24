using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareStation
{
    class PostResult
    {
        PostHandler posthandler = new PostHandler();

        public async Task<RootObject> postResult(String url, String email, String result)
        {
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
                {
                new KeyValuePair<string, string>("email", email),
                new KeyValuePair<string, string>("result", result),
                };

            RootObject content = await posthandler.post(queries, url);

            return content;
        }
    }
}
