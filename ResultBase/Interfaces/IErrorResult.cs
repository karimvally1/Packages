using System;
using System.Collections.Generic;

namespace ResultBase.Interfaces
{
    public interface IErrorResult<T, TS> : IResult<T, TS>
        where TS : Enum
    {
        Dictionary<string, string> ErrorCollection { get; set; }
    }
}
