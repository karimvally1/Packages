using ResponseBase.Models;
using System.Collections.Generic;

namespace ResponseBase.Interfaces
{
    public interface IErrorResponse<T> : IResponse<T>
    {
        IList<Error> Errors { get; set; }
        string Message { get; set; }
    }
}
