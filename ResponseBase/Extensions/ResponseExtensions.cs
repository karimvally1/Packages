using ResponseBase.Interfaces;

namespace ResponseBase.Extensions
{
    public static class ResponseExtensions
    {
        public static IErrorResponse<T> ToErrorResponse<T>(this IResponse<T> response)
        {
            return response as IErrorResponse<T>;
        }

        public static IItemResponse<T> ToItemResponse<T>(this IResponse<T> response)
        {
            return response as IItemResponse<T>;
        }

        public static IPagedResponse<T> ToPagedResponse<T>(this IResponse<T> response)
        {
            return response as IPagedResponse<T>;
        }

    }
}
