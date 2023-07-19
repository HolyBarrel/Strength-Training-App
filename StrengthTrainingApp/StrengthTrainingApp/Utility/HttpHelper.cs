using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StrengthTrainingApp.Utility
{
    public static class HttpHelper
    {
        public static void DefaultSetup(HttpClient client)
        {
            client.BaseAddress = new Uri("https://xpyatpstjihpnjgujeae.supabase.co");
            client.DefaultRequestHeaders.Add("apikey",
                "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InhweWF0cHN0amlocG5qZ3VqZWFlIiwicm9sZSI6ImFub24iLCJpYXQiOjE2ODk0NTYzODksImV4cCI6MjAwNTAzMjM4OX0.myL9-ihnfoeXybqknHzloFTdTz8Trr72Jb1yDYUXElg");
        }

        public static async Task AuthTokenSetup(HttpClient client)
        {
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + await SecureStorage.GetAsync("access_token"));
        }
    }

}
