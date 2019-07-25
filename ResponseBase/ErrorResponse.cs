using System.Collections.Generic;
using System.Net;
using ResponseBase.Interfaces;

namespace ResponseBase
{
    public class ErrorResponse<T> : IErrorResponse<T>
    {
        public Dictionary<string, string> Errors { get; set; }
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
