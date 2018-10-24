using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareStation
{
    class PostRegister
    {
        PostHandler posthandler = new PostHandler();

        public async Task<RootObject> postRegister(String url, String name, String vorname, String email, String password)
        {
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
                {
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("email", email),
                new KeyValuePair<string, string>("name", name),
                new KeyValuePair<string, string>("vorname", vorname),
                };

            RootObject content = await posthandler.post(queries, url);

            return content;
        }
    }
}
