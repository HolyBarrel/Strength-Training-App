using StrengthTrainingApp.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthTrainingApp.Services
{
    public interface IFullWorkoutService
    {
        Task Setup();
        Task<List<FullWorkoutRecord>> GetAllFullWorkoutRecords();
    }
}
