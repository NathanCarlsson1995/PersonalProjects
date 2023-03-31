# EFCore_vs_Dapper

This project shows the difference in time execution and memory usage between Entity Framework and Dapper.

**Results**
|         Method |         Mean |       Error |      StdDev |       Median | Allocated |
|--------------- |-------------:|------------:|------------:|-------------:|----------:|
|        EF_Find |     117.4 ns |     2.79 ns |     8.09 ns |     116.0 ns |     160 B |
|      EF_Single | 110,308.7 ns | 2,197.60 ns | 6,410.50 ns | 107,185.9 ns |   10465 B |
|       EF_First | 109,301.8 ns | 2,166.26 ns | 4,977.35 ns | 107,497.5 ns |   10816 B |
| Dapper_GetById |  59,000.5 ns | 1,596.03 ns | 4,655.70 ns |  57,778.1 ns |    1920 B |


# MapperComparisons

This project compares 3 mapping packages (Manual, Mapperly & TinyMapper) and displays the difference in time execution and memory usage.

**Results**
|             Method |      Mean |     Error |    StdDev |    Median |   Gen0 |   Gen1 | Allocated |
|------------------- |----------:|----------:|----------:|----------:|-------:|-------:|----------:|
|     Manual_Mapping |  4.488 us | 0.1179 us | 0.3475 us |  4.362 us | 3.0746 | 0.1526 |  18.84 KB |
|   Mapperly_Mapping |  2.663 us | 0.0721 us | 0.2115 us |  2.583 us | 2.3537 | 0.1221 |  14.42 KB |
| TinyMapper_Mapping | 38.701 us | 0.8673 us | 2.5436 us | 37.998 us | 3.9673 | 0.2441 |  24.57 KB |


# IterationComparison

**Results**
|           Method |    Size |            Mean |         Error |        StdDev |          Median | Allocated |
|----------------- |-------- |----------------:|--------------:|--------------:|----------------:|----------:|
|              For |     100 |        55.54 ns |      1.352 ns |      3.965 ns |        53.38 ns |         - |
|          Foreach |     100 |       102.97 ns |      2.055 ns |      5.194 ns |       101.63 ns |         - |
|            While |     100 |        52.48 ns |      1.038 ns |      0.867 ns |        52.73 ns |         - |
| Foreach_Parallel |     100 |     3,783.85 ns |     75.685 ns |    143.999 ns |     3,755.79 ns |    2688 B |
|     ForEach_Span |     100 |        32.96 ns |      0.739 ns |      2.179 ns |        32.25 ns |         - |
|         For_Span |     100 |        31.82 ns |      0.652 ns |      1.670 ns |        31.24 ns |         - |
|              For |   10000 |     4,889.22 ns |    108.643 ns |    318.632 ns |     4,796.50 ns |         - |
|          Foreach |   10000 |    11,172.44 ns |    190.200 ns |    226.420 ns |    11,149.84 ns |         - |
|            While |   10000 |     4,738.42 ns |     52.672 ns |     43.983 ns |     4,753.79 ns |         - |
| Foreach_Parallel |   10000 |    20,234.57 ns |    400.112 ns |    751.507 ns |    20,341.74 ns |    3897 B |
|     ForEach_Span |   10000 |     2,309.23 ns |     44.161 ns |     85.084 ns |     2,271.98 ns |         - |
|         For_Span |   10000 |     2,292.46 ns |     43.840 ns |     55.444 ns |     2,267.14 ns |         - |
|              For | 1000000 |   473,837.99 ns |  9,289.996 ns | 16,270.678 ns |   472,942.92 ns |         - |
|          Foreach | 1000000 | 1,085,092.15 ns | 21,512.890 ns | 48,995.737 ns | 1,086,901.76 ns |       1 B |
|            While | 1000000 |   474,362.14 ns |  8,938.725 ns | 21,069.626 ns |   471,662.40 ns |         - |
| Foreach_Parallel | 1000000 |   956,781.10 ns | 18,498.513 ns | 33,825.577 ns |   954,431.54 ns |    4040 B |
|     ForEach_Span | 1000000 |   228,165.44 ns |  4,385.656 ns |  4,503.746 ns |   227,496.39 ns |         - |
|         For_Span | 1000000 |   226,892.06 ns |  4,339.033 ns |  4,642.716 ns |   224,985.27 ns |         - |
