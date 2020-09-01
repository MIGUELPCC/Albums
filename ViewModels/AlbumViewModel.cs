using Newtonsoft.Json;

namespace AlbumWeb.ViewModels
{
    public class AlbumViewModel
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}