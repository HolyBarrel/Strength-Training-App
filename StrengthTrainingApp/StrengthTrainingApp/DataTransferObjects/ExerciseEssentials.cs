using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthTrainingApp.DataTransferObjects
{
    public class ExerciseEssentials
    {
        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("exercise_type_id")]
        public long ExerciseTypeId { get; set; }

        [JsonProperty("workout_id")]
        public long WorkoutId { get; set; }
    }
}
