using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using StrengthTrainingApp.DataTransferObjects;
using StrengthTrainingApp.Services.Interfaces;
using StrengthTrainingApp.Utility;

namespace StrengthTrainingApp.Services.Implementations
{
    public class SetService : ServiceBase, ISetService
    {
        public SetService(HttpClient client) : base(client) { }

        /**
         * curl -X POST 'https://xpyatpstjihpnjgujeae.supabase.co/rest/v1/sets' \
-H "apikey: SUPABASE_KEY" \
-H "Authorization: Bearer SUPABASE_KEY" \
-H "Content-Type: application/json" \
-d '[{ "some_column": "someValue" }, { "other_column": "otherValue" }]'
        */
        public async Task CreateSets(List<SetEssentials> sets)
        {
            EnsureSetup();

            /*
             *
             * EXAMPLE BODY:
            [
                {
                    "exercise_id": 3,
                    "reps": 12,
                    "weight": 60
                },
                {
                    "exercise_id": 3,
                    "reps": 8,
                    "weight": 85
                }
            ]
             */
            var response = await Client.PostAsync("/rest/v1/sets", JsonHelper.SerializeContent(sets));

            if (!response.IsSuccessStatusCode)
            {

                throw new Exception("Failed to create sets.");

            }
        }
    }
}
