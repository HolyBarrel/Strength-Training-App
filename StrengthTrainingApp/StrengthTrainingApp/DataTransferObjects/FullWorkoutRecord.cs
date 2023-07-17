using Newtonsoft.Json;

namespace StrengthTrainingApp.DataTransferObjects
{
    public class FullWorkoutRecord
    {
        [JsonProperty("workout_id")]
        public long WorkoutId { get; set; }

        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("total_load")]
        public object TotalLoad { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("muscle_group")]
        public string MuscleGroup { get; set; }

        [JsonProperty("notes")]
        public object Notes { get; set; }

        [JsonProperty("reps")]
        public long Reps { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }

    }
}
