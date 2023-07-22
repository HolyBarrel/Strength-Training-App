using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
