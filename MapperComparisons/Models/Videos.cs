using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperComparisons.Models
{
    public class VideosMap
    {
        public Video[] Videos { get; set; }
    }
    public class Video
    {
        public string? Id { get; set; }
        public string? AccountId { get; set; }
        public object? AdKeys { get; set; }
        public string? ClipSourceVideoId { get; set; }
        public bool? Complete { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public UpdatedBy? CreatedBy { get; set; }
        public object[]? CuePoints { get; set; }
        public CustomFields? CustomFields { get; set; }
        public string? DeliveryType { get; set; }
        public string? Description { get; set; }
        public object? DigitalMasterId { get; set; }
        public long? Duration { get; set; }
        public string? Economics { get; set; }
        public string? FolderId { get; set; }
        public object? Geo { get; set; }
        public bool? HasDigitalMaster { get; set; }
        public Images? Images { get; set; }
        public object? Link { get; set; }
        public string? LongDescription { get; set; }
        public string? Name { get; set; }
        public string? OriginalFilename { get; set; }
        public object? Projection { get; set; }
        public DateTimeOffset? PublishedAt { get; set; }
        public string? ReferenceId { get; set; }
        public object? Schedule { get; set; }
        public object? Sharing { get; set; }
        public string? State { get; set; }
        public string[]? Tags { get; set; }
        public object[]? TextTracks { get; set; }
        public object[]? Transcripts { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public UpdatedBy? UpdatedBy { get; set; }
        public string? PlaybackRightsId { get; set; }
        public string? IngestionProfileId { get; set; }
    }

    public partial class UpdatedBy
    {
        public string? Type { get; set; }
        public string? Id { get; set; }
        public string? Email { get; set; }
    }

    public partial class CustomFields
    {
    }

    public partial class Images
    {
        public Poster? Poster { get; set; }
        public Poster? Thumbnail { get; set; }
    }

    public partial class Poster
    {
        public Uri? Src { get; set; }
        public Source[]? Sources { get; set; }
    }

    public partial class Source
    {
        public Uri? Src { get; set; }
        public long? Height { get; set; }
        public long? Width { get; set; }
    }
}
