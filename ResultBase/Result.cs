using System;
using ResultBase.Interfaces;

namespace ResultBase
{
    public class Result<T, TS> : IResult<T, TS>
        where TS : Enum
    {
        public TS Status { get; set; }
    }
}
