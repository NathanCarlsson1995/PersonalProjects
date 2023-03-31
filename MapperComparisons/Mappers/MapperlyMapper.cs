using MapperComparisons.Models;
using Riok.Mapperly.Abstractions;

namespace MapperComparisons.Mappers
{
    [Mapper]
    public partial class MapperlyMapper
    {
        public partial VideosMap Map(VideosDto videosDto);
    }
}
