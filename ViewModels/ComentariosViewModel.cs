using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AlbumWeb.ViewModels
{
    public class ComentariosViewModel
    {
        [JsonProperty("postId")]
        public int PostId { get; set; }
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }

    }
}