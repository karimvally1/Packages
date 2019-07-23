using System;

namespace ResultBase.Interfaces
{
    public interface IPagedResult<T, TS> : IItemResult<T, TS>
        where TS : Enum
    {
        int TotalResults { get; set; }
        int Page { get; set; }
        int Size { get; set; }
    }
}
