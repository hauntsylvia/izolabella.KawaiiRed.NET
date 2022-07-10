using izolabella.KawaiiRed.NET.Enums;
using Newtonsoft.Json;
using System.Globalization;

namespace izolabella.KawaiiRed.NET
{
    public class KawaiiRedClient
    {
        public KawaiiRedClient()
        {
            this.Client = new();
        }

        public HttpClient Client { get; }

        public static Uri BaseAddres => new("https://kawaii.red/api/");

        public async Task<GenericResponse?> GetGifAsync(GenericEndpointType Type)
        {
            HttpResponseMessage Message = await this.Client.GetAsync(BaseAddres + $"gif/{Type.Singular.ToLower(CultureInfo.InvariantCulture)}/token%3Danonymous/");
            string A = await Message.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<GenericResponse>(A);
        }
    }
}