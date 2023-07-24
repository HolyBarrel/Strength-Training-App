using StrengthTrainingApp.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthTrainingApp.Services.Interfaces
{
    internal interface IExerciseTypeService
    {
        Task Setup();
        Task<List<ExerciseType>> GetAllExerciseTypes();
    }
}
