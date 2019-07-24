using System.Net;

namespace ResponseBase.Interfaces
{
    public interface IResponse<T>
    {
        HttpStatusCode StatusCode { get; set; }
    }
}
