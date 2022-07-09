using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izolabella.KawaiiRed.NET
{
    public class GenericResponse
    {
        public GenericResponse(string Response)
        {
            this.Response = Response;
        }

        [JsonProperty("Response")]
        private string Response { get; }

        [JsonIgnore]
        public Uri ResponseUrl => new(this.Response);
    }
}
