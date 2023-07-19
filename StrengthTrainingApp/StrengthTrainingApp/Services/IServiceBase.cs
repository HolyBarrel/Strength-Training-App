using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthTrainingApp.Services
{
    internal interface IServiceBase
    {
        Task Setup();

        void EnsureSetup();
    }
}
