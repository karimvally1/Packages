using System;
using ResultBase.Interfaces;

namespace ResultBase
{
    public class ItemResult<T, TS> : IItemResult<T, TS>
        where TS : Enum
    {
        public T Data { get; set; }
        public TS Status { get; set; }
    }
}
