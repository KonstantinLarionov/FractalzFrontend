using Newtonsoft.Json;

namespace FractalzWPF.Application.Domains.Entities.Websocket
{
    public class BasicWsEntities
    {
        [JsonProperty("Type")]
        public WsMessageType Type { get; set; }

        [JsonProperty("Data")]
        public object? Data { get; set; }
    }
}