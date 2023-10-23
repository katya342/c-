using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class UserInfo
    {
        public async Task<string> Reader()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage message = await client.GetAsync("https://randomuser.me/api/");
                var responseContent = await message.Content.ReadAsStringAsync();

                // Deserialize the JSON response into the appropriate class
                var result = JsonConvert.DeserializeObject<UserResponse>(responseContent);

                // Access the URL of the user's photo
                string photoUrl = result.Results[0].Picture.Large;
                return photoUrl;
                // Now you have the URL of the photo in the 'photoUrl' variable
            }
        }
    }
    
}
