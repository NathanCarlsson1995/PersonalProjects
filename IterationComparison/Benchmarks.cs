using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IterationComparison
{
    [MemoryDiagnoser(false)]
    public class Benchmarks
    {
        private static readonly Random Rng = new(80085);

        [Params(100, 100_00, 1_000_000)]
        public int Size { get; set; }

        private List<int> _items;

        [GlobalSetup]
        public void Setup()
        {
            _items = Enumerable.Range(1, Size).Select(x => Rng.Next()).ToList();
        }

        [Benchmark]
        public void For()
        {
            for(var i = 0; i < _items.Count; i++)
            {
                var item = _items[i];
            }
        }

        [Benchmark]
        public void Foreach()
        {
            foreach(var item in _items)
            {

            }
        }

        [Benchmark]
        public void While()
        {
            var num = 0;
            while(num < _items.Count)
            {
                var item = _items[num];
                num++;
            }
        }

        [Benchmark]
        public void Foreach_Parallel()
        {
            Parallel.ForEach(_items, x => { });
        }

        [Benchmark]
        public void ForEach_Span()
        {
            // gives us access to the items directly but we can NOT add/remove items whilst using this method.
            foreach(var item in CollectionsMarshal.AsSpan(_items))
            {

            }
        }

        [Benchmark]
        public void For_Span()
        {
            // gives us access to the items directly but we can NOT add/remove items whilst using this method.
            var items = CollectionsMarshal.AsSpan(_items);
            for (var i = 0; i < items.Length; i++)
            {
                var item = items[i];
            }
        }
    }
}
