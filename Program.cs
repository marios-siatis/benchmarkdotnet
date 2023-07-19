using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace BenchmarkDotNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = DefaultConfig.Instance;
            //BenchmarkRunner.Run<Benchmarks>(config, args);
            // BenchmarkRunner.Run<LoopVariables>(config, args);
            BenchmarkRunner.Run<StringInterpolation>(config, args);
        }
    }
}
