using System.IO;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Order;
using MapperComparisons.Mappers;
using MapperComparisons.Models;

namespace MapperComparisons
{
    [SimpleJob(RunStrategy.Throughput)]
    [MemoryDiagnoser]
    [KeepBenchmarkFiles(false)]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByMethod)]
    [Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
    public class Benchmarks
    {
        private readonly VideosDto _videosDto;
        private readonly MapperlyMapper _mapperlyMapper;

        public Benchmarks()
        {
            // Base setup
            var json = File.ReadAllText("videos.json");
            _videosDto = VideosDto.FromJson(json);

            // Mapperly
            _mapperlyMapper = new MapperlyMapper();

            // Tiny Mapper
            Nelibur.ObjectMapper.TinyMapper.Bind<VideosDto, VideosMap>();
            Nelibur.ObjectMapper.TinyMapper.Bind<VideoDto, Video>();
            Nelibur.ObjectMapper.TinyMapper.Bind<UpdatedByDto, UpdatedBy>();
            Nelibur.ObjectMapper.TinyMapper.Bind<CustomFieldsDto, CustomFields>();
            Nelibur.ObjectMapper.TinyMapper.Bind<ImagesDto, Images>();
            Nelibur.ObjectMapper.TinyMapper.Bind<PosterDto, Poster>();
            Nelibur.ObjectMapper.TinyMapper.Bind<SourceDto, Source>();
        }

        [Benchmark]
        public void Manual_Mapping()
        {
            _videosDto.Map();
        }

        [Benchmark]
        public void Mapperly_Mapping()
        {
            _mapperlyMapper.Map(_videosDto);
        }

        [Benchmark]
        public void TinyMapper_Mapping()
        {
            Nelibur.ObjectMapper.TinyMapper.Map<VideosMap>(_videosDto);
        }
    }
}
