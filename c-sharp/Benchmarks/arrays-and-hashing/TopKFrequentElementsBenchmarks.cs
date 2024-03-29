﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

using Problems;

namespace Benchmarks;

[MemoryDiagnoser]
[Orderer( SummaryOrderPolicy.FastestToSlowest )]
[RankColumn]
public class TopKFrequentElementsBenchmarks
{
    private static readonly TopKFrequentElements _topKFrequentElements = new();

    private static readonly int[] _testNums = new int[]
    {
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 654, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 3, 5, 6, 7, 8, 3, 3, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 12, 9, 10, 12, 11, 12, 54, 654, 654, 1, 2, 12, 12, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 12, 12,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 5, 7, 5, 8, 5, 5, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 1, 1, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654,
        1, 2, 3, 4, 1, 5, 1, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654, 654, 654, 654, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 54, 654, 654
    };

    [Benchmark]
    public void TopKFrequent() => _topKFrequentElements.TopKFrequent( _testNums, 5 );

    [Benchmark]
    public void TopKFrequentBucketSort() => _topKFrequentElements.TopKFrequentBucketSort( _testNums, 5 );
}
