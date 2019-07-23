using System;

namespace ResultBase.Interfaces
{
    public interface IResult<T, TS>
        where TS : Enum
    {
        TS Status { get; set; }
    }
}
