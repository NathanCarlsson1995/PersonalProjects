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
