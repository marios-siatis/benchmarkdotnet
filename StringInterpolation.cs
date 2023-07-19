using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNet
{
    [MemoryDiagnoser]
    [RankColumn]
    [SimpleJob(Jobs.RuntimeMoniker.Net60)]
    [SimpleJob(Jobs.RuntimeMoniker.Net70)]
    public class StringInterpolation
    {
        private string msg = "This is normal write";
        private string interpolatedMsg = "interpolated string";
        private string concatenatedMsg = "concatenated string";

        [Benchmark(Baseline = true)]
        public string StringWriteBaseline()
        {
            return msg;
        }

        [Benchmark]
        public string StringConcatenationExample()
        {
            return "This is" + "a " + concatenatedMsg;
        }

        [Benchmark]
        public string StringInterpolationExample()
        {
            return $"This is an {interpolatedMsg}";
        }
    }
}
