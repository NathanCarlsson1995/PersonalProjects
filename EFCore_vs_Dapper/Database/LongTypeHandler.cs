using Dapper;
using System.Data;

namespace EFCore_vs_Dapper.Database
{
    public class LongTypeHandler : SqlMapper.TypeHandler<long>
    {
        public override long Parse(object value)
        {
            return long.Parse((string)value);
        }

        public override void SetValue(IDbDataParameter parameter, long value)
        {
            parameter.Value = value;
        }
    }
}
