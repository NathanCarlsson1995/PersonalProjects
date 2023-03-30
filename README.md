This project shows the difference in time execution and memory usage between Entity Framework and Dapper.

# Results
|         Method |         Mean |       Error |      StdDev |       Median | Allocated |
|--------------- |-------------:|------------:|------------:|-------------:|----------:|
|        EF_Find |     117.4 ns |     2.79 ns |     8.09 ns |     116.0 ns |     160 B |
|      EF_Single | 110,308.7 ns | 2,197.60 ns | 6,410.50 ns | 107,185.9 ns |   10465 B |
|       EF_First | 109,301.8 ns | 2,166.26 ns | 4,977.35 ns | 107,497.5 ns |   10816 B |
| Dapper_GetById |  59,000.5 ns | 1,596.03 ns | 4,655.70 ns |  57,778.1 ns |    1920 B |
