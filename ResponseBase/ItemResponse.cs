using System.Net;
using ResponseBase.Interfaces;

namespace ResponseBase
{
    public class ItemResponse<T> : IItemResponse<T>
    {
        public T Data { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
