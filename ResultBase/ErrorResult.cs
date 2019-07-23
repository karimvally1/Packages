using System;
using System.Collections.Generic;
using ResultBase.Interfaces;

namespace ResultBase
{
    public class ErrorResult<T, TS> : IErrorResult<T, TS>
        where TS : Enum
    {
        public Dictionary<string, string> ErrorCollection { get; set; } = new Dictionary<string, string>();
        public TS Status { get; set; }
    }
}
