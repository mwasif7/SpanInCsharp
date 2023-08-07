```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2070/22H2/2022Update/SunValley2)
Intel Core i5-10210U CPU 1.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.302
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|    Method | Size |       Mean |     Error |    StdDev | Ratio |   Gen0 | Allocated | Alloc Ratio |
|---------- |----- |-----------:|----------:|----------:|------:|-------:|----------:|------------:|
|  Original |   10 | 66.8959 ns | 0.4383 ns | 0.3660 ns |  1.00 | 0.0459 |     144 B |        1.00 |
| CopyArray |   10 | 75.9478 ns | 0.4882 ns | 0.4566 ns |  1.14 | 0.0560 |     176 B |        1.22 |
|      Span |   10 |  0.6796 ns | 0.0123 ns | 0.0103 ns |  0.01 |      - |         - |        0.00 |
