using System;

using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNet
{
    [MemoryDiagnoser]
    [RankColumn]
    public class LoopVariables
    {
        [Benchmark(Baseline = true)]
        public void NoVariableInLoop()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Hello World");
            }
        }

        [Benchmark]
        public void VariablesInsideLoop()
        {
            for (int i = 0; i < 100; i++)
            {
                Random rnd = new Random();
                var num = rnd.Next();
                Console.WriteLine($"Number {i} is {num}");
            }
        }

        [Benchmark]
        public void VariablesOutsideLoop()
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Number {i} is {rnd.Next()}");
            }
        }
    }
}
