using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Refit_SampleApp.Models
{
    public class FreeToPlayGameModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("thumbnail")]
        public Uri Thumbnail { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("game_url")]
        public Uri GameUrl { get; set; }

        [JsonProperty("genre")]
        public string Genre { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("developer")]
        public string Developer { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("freetogame_profile_url")]
        public Uri FreetogameProfileUrl { get; set; }
    }
}
