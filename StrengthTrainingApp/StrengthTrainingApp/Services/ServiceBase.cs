using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrengthTrainingApp.Utility;

namespace StrengthTrainingApp.Services
{
    public abstract class ServiceBase : IServiceBase
    {
        protected HttpClient Client;

        private bool _isSetup = false;

        protected ServiceBase(HttpClient client)
        {
            HttpHelper.DefaultSetup(client);
            Client = client;
        }

        public virtual async Task Setup()
        {
            await HttpHelper.AuthTokenSetup(Client);
            _isSetup = true;
        }

        public void EnsureSetup()
        {
            if (!_isSetup)
            {
                throw new InvalidOperationException("This service has not been set up. Call Setup() before using it.");
            }
        }
    }
}
