using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using StrengthTrainingApp.Utility;

namespace StrengthTrainingApp.Services
{
    public class AuthService : ServiceBase, IAuthService
    {
        public AuthService(HttpClient httpClient) : base(httpClient) { }
        public async Task<string> Authenticate(string email, string password)
        {
            var response = await Client.PostAsync("/auth/v1/token?grant_type=password",
                JsonHelper.CreateSerializedCredentials(email, password));

                if (response.IsSuccessStatusCode)
                {
                    return await JsonHelper.ExtractToken(response);
                }

            throw new Exception("The login was rejected due to invalid credentials");
        }
    }
}
