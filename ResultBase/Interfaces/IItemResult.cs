using System;

namespace ResultBase.Interfaces
{
    public interface IItemResult<T, TS> : IResult<T, TS>
        where TS : Enum
    {
        T Data { get; set; }
    }
}
