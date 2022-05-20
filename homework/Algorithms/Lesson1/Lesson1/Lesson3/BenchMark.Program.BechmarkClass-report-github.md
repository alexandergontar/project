``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4510.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8 (4.8.4510.0), X86 LegacyJIT


```
|                   Method |      Mean |     Error |    StdDev |    Median |
|------------------------- |----------:|----------:|----------:|----------:|
|             TestDistance | 4.9691 ns | 0.1490 ns | 0.2230 ns | 4.9017 ns |
|       TestDistanceStruct | 6.3548 ns | 0.1042 ns | 0.0974 ns | 6.3410 ns |
| TestDistanceStructDouble | 0.0143 ns | 0.0200 ns | 0.0214 ns | 0.0000 ns |
| TestDistanceStructSimple | 4.1508 ns | 0.1217 ns | 0.1402 ns | 4.1147 ns |
