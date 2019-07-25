using System.Collections.Generic;

namespace ResponseBase.Interfaces
{
    public interface IErrorResponse<T> : IResponse<T>
    {
        Dictionary<string, string> Errors { get; set; }
        string Message { get; set; }
    }
}
