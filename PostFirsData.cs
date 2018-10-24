using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareStation
{
    class PostFirsData
    {
        PostHandler posthandler = new PostHandler();

        public async Task<RootObject> postFirstData(String url, String email, String birthday, String weight, String sex,String height)
        {
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
                {
                new KeyValuePair<string, string>("weight", weight),
                new KeyValuePair<string, string>("height", height),
                new KeyValuePair<string, string>("email", email),
                new KeyValuePair<string, string>("birthday", birthday),
                new KeyValuePair<string, string>("sex", sex),
                };

            RootObject content = await posthandler.post(queries, url);

            return content;
        }
    }
}
