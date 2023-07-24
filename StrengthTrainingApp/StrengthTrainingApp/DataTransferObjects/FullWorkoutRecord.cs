using Newtonsoft.Json;

namespace StrengthTrainingApp.DataTransferObjects
{
    //Credz:https://app.quicktype.io/
    public class FullWorkoutRecord
    {
        [JsonProperty("workout_id")]
        public long WorkoutId { get; set; }

        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("total_load")]
        public double? TotalLoad { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("muscle_group")]
        public string MuscleGroup { get; set; }

        [JsonProperty("primary_muscle")]
        public string PrimaryMuscle { get; set; }

        [JsonProperty("reps")]
        public long Reps { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }
    }
}