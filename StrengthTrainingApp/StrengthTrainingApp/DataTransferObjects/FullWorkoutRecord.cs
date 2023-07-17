using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StrengthTrainingApp.DataTransferObjects
{
    public class FullWorkoutRecord
    {
        [JsonPropertyName("workout_id")]
        public long WorkoutId { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonPropertyName("total_load")]
        public object TotalLoad { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("muscle_group")]
        public string MuscleGroup { get; set; }

        [JsonPropertyName("notes")]
        public object Notes { get; set; }

        [JsonPropertyName("reps")]
        public long Reps { get; set; }

        [JsonPropertyName("weight")]
        public long Weight { get; set; }

    }
}
