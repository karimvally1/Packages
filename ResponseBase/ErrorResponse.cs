using System.Collections.Generic;
using System.Net;
using ResponseBase.Interfaces;
using ResponseBase.Models;

namespace ResponseBase
{
    public class ErrorResponse<T> : IErrorResponse<T>
    {
        public IList<Error> Errors { get; set; } = new List<Error>();
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
