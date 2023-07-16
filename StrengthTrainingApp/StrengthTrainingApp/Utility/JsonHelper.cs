using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StrengthTrainingApp.Utility
{
    public static class JsonHelper
    {
        public static StringContent CreateSerializedCredentials(string email, string password)
        {
            var credentials = new Dictionary<string, string>
            {
                { "email", email },
                { "password", password }
            };

            var serializedCredentials = JsonConvert.SerializeObject(credentials);

            return new StringContent(serializedCredentials, Encoding.UTF8, "application/json");
        }

        public static async Task<string> ExtractToken(HttpResponseMessage response)
        {
            var responseBody = await response.Content.ReadAsStringAsync();

            var responseJson = JObject.Parse(responseBody);

            if (responseJson.TryGetValue("token", out var tokenValue))
            {
                return tokenValue.ToString();

            }
            else
            {
                return "";
            }
        }
    }
}
