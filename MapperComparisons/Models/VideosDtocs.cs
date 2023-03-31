using Newtonsoft.Json;

namespace MapperComparisons.Models
{
    public partial class VideosDto
    {
        [JsonProperty("videos")]
        public VideoDto[] Videos { get; set; }
    }

    public partial class VideoDto
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("account_id")]
        public string? AccountId { get; set; }

        [JsonProperty("ad_keys")]
        public object? AdKeys { get; set; }

        [JsonProperty("clip_source_video_id")]
        public string? ClipSourceVideoId { get; set; }

        [JsonProperty("complete")]
        public bool? Complete { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public UpdatedByDto? CreatedBy { get; set; }

        [JsonProperty("cue_points")]
        public object[]? CuePoints { get; set; }

        [JsonProperty("custom_fields")]
        public CustomFieldsDto? CustomFields { get; set; }

        [JsonProperty("delivery_type")]
        public string? DeliveryType { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("digital_master_id")]
        public object? DigitalMasterId { get; set; }

        [JsonProperty("duration")]
        public long? Duration { get; set; }

        [JsonProperty("economics")]
        public string? Economics { get; set; }

        [JsonProperty("folder_id")]
        public string? FolderId { get; set; }

        [JsonProperty("geo")]
        public object? Geo { get; set; }

        [JsonProperty("has_digital_master")]
        public bool? HasDigitalMaster { get; set; }

        [JsonProperty("images")]
        public ImagesDto? Images { get; set; }

        [JsonProperty("link")]
        public object? Link { get; set; }

        [JsonProperty("long_description")]
        public string? LongDescription { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("original_filename")]
        public string? OriginalFilename { get; set; }

        [JsonProperty("projection")]
        public object? Projection { get; set; }

        [JsonProperty("published_at")]
        public DateTimeOffset? PublishedAt { get; set; }

        [JsonProperty("reference_id")]
        public string? ReferenceId { get; set; }

        [JsonProperty("schedule")]
        public object? Schedule { get; set; }

        [JsonProperty("sharing")]
        public object? Sharing { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("tags")]
        public string[]? Tags { get; set; }

        [JsonProperty("text_tracks")]
        public object[]? TextTracks { get; set; }

        [JsonProperty("transcripts")]
        public object[]? Transcripts { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("updated_by")]
        public UpdatedByDto? UpdatedBy { get; set; }

        [JsonProperty("playback_rights_id")]
        public string? PlaybackRightsId { get; set; }

        [JsonProperty("ingestion_profile_id")]
        public string? IngestionProfileId { get; set; }
    }

    public partial class UpdatedByDto
    {
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string? Email { get; set; }
    }

    public partial class CustomFieldsDto
    {
    }

    public partial class ImagesDto
    {
        [JsonProperty("poster")]
        public PosterDto? Poster { get; set; }

        [JsonProperty("thumbnail")]
        public PosterDto? Thumbnail { get; set; }
    }

    public partial class PosterDto
    {
        [JsonProperty("src")]
        public Uri? Src { get; set; }

        [JsonProperty("sources")]
        public SourceDto[]? Sources { get; set; }
    }

    public partial class SourceDto
    {
        [JsonProperty("src")]
        public Uri? Src { get; set; }

        [JsonProperty("height")]
        public long? Height { get; set; }

        [JsonProperty("width")]
        public long? Width { get; set; }
    }

    public partial class VideosDto
    {
        public static VideosDto FromJson(string json)
        {
            return JsonConvert.DeserializeObject<VideosDto>(json, Converter.Settings);
        }
    }

    public static class Serialize
    {
        public static string ToJson(this VideosDto self)
        {
            return JsonConvert.SerializeObject(self, Converter.Settings);
        }
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None
        };
    }
}
