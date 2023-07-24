using Newtonsoft.Json;

namespace StrengthTrainingApp.DataTransferObjects
{
    //Credz:https://app.quicktype.io/
    public class SetEssentials
    {
        [JsonProperty("exercise_id")]
        public long ExerciseId { get; set; }

        [JsonProperty("reps")]
        public long Reps { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }
    }
}
