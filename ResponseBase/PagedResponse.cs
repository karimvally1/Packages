using System.Net;
using ResponseBase.Interfaces;

namespace ResponseBase
{
    public class PagedResponse<T> : IPagedResponse<T>
    {
        public int TotalResults { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public T Data { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
