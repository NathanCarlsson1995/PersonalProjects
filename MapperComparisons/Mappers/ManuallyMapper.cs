using MapperComparisons.Models;

namespace MapperComparisons.Mappers
{
    public static class ManuallyMapper
    {
        public static VideosMap Map(this VideosDto videosDto)
        {
            return new VideosMap()
            {
                Videos = videosDto.Videos.Select(x => new Video()
                {
                    Id = x.Id,
                    AccountId = x.AccountId,
                    AdKeys = x.AdKeys,
                    ClipSourceVideoId = x.ClipSourceVideoId,
                    Complete = x.Complete,
                    CreatedAt = x.CreatedAt,
                    CreatedBy = new UpdatedBy() 
                    {
                        Id = x.CreatedBy?.Id,
                        Email = x.CreatedBy?.Email,
                        Type = x.CreatedBy?.Type,
                    },
                    CuePoints = x.CuePoints,
                    DeliveryType = x.DeliveryType,
                    Description = x.Description,
                    DigitalMasterId = x.DigitalMasterId,
                    Duration = x.Duration,
                    Economics = x.Economics,
                    FolderId = x.FolderId,
                    Geo = x.Geo,
                    HasDigitalMaster = x.HasDigitalMaster,
                    Images = new Images()
                    {
                        Thumbnail = new Poster()
                        {
                            Src = x.Images?.Thumbnail?.Src,
                            Sources = x.Images?.Thumbnail?.Sources?.Select(y => new Source()
                            {
                                Height = y.Height,
                                Width = y.Width,
                                Src = x.Images?.Thumbnail?.Src,
                            }).ToArray()
                        },
                        Poster = new Poster()
                        {
                            Src = x.Images?.Thumbnail?.Src,
                            Sources = x.Images?.Thumbnail?.Sources?.Select(y => new Source()
                            {
                                Height = y.Height,
                                Width = y.Width,
                                Src = x.Images?.Thumbnail?.Src,
                            }).ToArray()
                        },
                    },
                    IngestionProfileId = x.IngestionProfileId,
                    Link = x.Link,
                    LongDescription = x.LongDescription,
                    Name = x.Name,
                    OriginalFilename = x.OriginalFilename,
                    PlaybackRightsId = x.PlaybackRightsId,
                    Projection = x.Projection,
                    PublishedAt = x.PublishedAt,
                    ReferenceId = x.ReferenceId,
                    Schedule = x.Schedule,
                    Sharing = x.Sharing,
                    State = x.State,
                    Tags = x.Tags,
                    TextTracks = x.TextTracks,
                    Transcripts = x.Transcripts,
                    UpdatedAt = x.UpdatedAt,
                    UpdatedBy = new UpdatedBy()
                    {
                        Id = x.CreatedBy?.Id,
                        Email = x.CreatedBy?.Email,
                        Type = x.CreatedBy?.Type,
                    },
                }).ToArray()
            };  
        }
    }
}
