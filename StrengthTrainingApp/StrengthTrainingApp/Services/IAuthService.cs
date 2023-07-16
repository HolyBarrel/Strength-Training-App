using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthTrainingApp.Services
{
    public interface IAuthService
    {

        Task<string> Authenticate(string email, string password);
    }
}
