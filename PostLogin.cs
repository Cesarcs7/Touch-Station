using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareStation
{
    class PostLogin
    {
        PostHandler posthandler = new PostHandler();

        public async Task<RootObject> postLogin(String url, String email, String password)
        {
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
                {
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("email", email),
                };

            RootObject content = await posthandler.post(queries, url);

            return content;
        }
    }
}
