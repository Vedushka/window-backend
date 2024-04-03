using System.Text.Json.Serialization;

namespace window_backend.Data
{
    public class Window
    {
        [JsonPropertyName("width")]
        public int Width { get; set; }
        [JsonPropertyName("height")]
        public int Height { get; set; }
    }
}
