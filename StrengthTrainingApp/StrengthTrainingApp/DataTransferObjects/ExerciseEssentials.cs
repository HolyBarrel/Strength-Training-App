using Newtonsoft.Json;

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
