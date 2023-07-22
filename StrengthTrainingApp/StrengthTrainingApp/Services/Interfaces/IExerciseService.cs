using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrengthTrainingApp.DataTransferObjects;

namespace StrengthTrainingApp.Services.Interfaces
{
    internal interface IExerciseService
    {
        Task CreateExercise(ExerciseEssentials exercise);
    }
}
