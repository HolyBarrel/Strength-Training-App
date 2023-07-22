using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using StrengthTrainingApp.DataTransferObjects;
using JsonConvert = Newtonsoft.Json.JsonConvert;

namespace StrengthTrainingApp.Utility
{
    public static class JsonHelper
    {
        //TODO: make generic
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

        public static StringContent SerializeContent<T>(T obj)
        {
            var serializedObject = JsonConvert.SerializeObject(obj);
            return new StringContent(serializedObject, Encoding.UTF8, "application/json");
        }


        public static async Task<string> ExtractToken(HttpResponseMessage response)
        {
            var responseBody = await response.Content.ReadAsStringAsync();

            var responseJson = JObject.Parse(responseBody);

            return responseJson.TryGetValue("access_token", out var tokenValue) ? tokenValue.ToString() : "";
        }

        public static List<FullWorkoutRecord> DeserializeWorkoutRecords(string jsonString)
        {
            return JsonConvert.DeserializeObject<List<FullWorkoutRecord>>(jsonString);

        }
    }
}
