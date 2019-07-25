using System.Net;
using ResponseBase.Interfaces;

namespace ResponseBase
{
    public class Response<T> : IResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; }
    }
}
