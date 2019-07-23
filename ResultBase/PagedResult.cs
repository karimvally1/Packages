using System;
using ResultBase.Interfaces;

namespace ResultBase
{
    public class PagedResult<T, TS> : IPagedResult<T, TS>
        where TS : Enum
    {
        public int TotalResults { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public T Data { get; set; }
        public TS Status { get; set; }
    }
}
