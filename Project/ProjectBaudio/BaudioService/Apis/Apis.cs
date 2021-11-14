using BaudioService.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BaudioService.Apis
{
    public class Apis
    {
        public async Task<ZaloResponse> GetAudioFromText(string content)
        {
            using var httpClient = new HttpClient();
            using var request = new HttpRequestMessage(new HttpMethod("POST"), "https://api.zalo.ai/v1/tts/synthesize");
            request.Headers.TryAddWithoutValidation("apikey", "X8DEEy2VxgisgSxJa9xHcIoec4n5M3gi");

            var contentList = new List<string>
                    {
                        $"input={Uri.EscapeDataString(content)}",
                        "speaker_id=1",
                        "encode_type=0"
                    };
            request.Content = new StringContent(string.Join("&", contentList));
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");

            var response = await httpClient.SendAsync(request);
            var res = response.Content.ReadAsStringAsync().Result;

            var zaloResponse = JsonConvert.DeserializeObject<ZaloResponse>(res);

            return zaloResponse;
        }
    }
}
