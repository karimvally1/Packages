using System;
using AutoMapper;
using ResultBase.Interfaces;

namespace ResultBase.Extensions
{
    public static class ResultExtensions
    {
        public static IErrorResult<T, TS> AddError<T, TS>(this IErrorResult<T, TS> errorResult, string key, string value)
            where TS : Enum
        {
            errorResult.ErrorCollection.Add(key, value);
            return errorResult;
        }

        public static IResult<TT, TS> ToMappedResult<TF, TT, TS>(this IResult<TF, TS> result)
            where TS : Enum
        {
            return new Result<TT, TS>
            {
                Status = result.Status
            };
        }

        public static IErrorResult<T, TS> ToErrorResult<T, TS>(this IResult<T, TS> result)
            where TS : Enum
        {
            return result as IErrorResult<T, TS>;
        }

        public static IErrorResult<TT, TS> ToMappedErrorResult<TF, TT, TS>(this IResult<TF, TS> result)
            where TS : Enum
        {
            var errorResult = result.ToErrorResult();
            return new ErrorResult<TT, TS>
            {
                Status = errorResult.Status,
                ErrorCollection = errorResult.ErrorCollection
            };
        }

        public static IItemResult<T, TS> ToItemResult<T, TS>(this IResult<T, TS> result)
            where TS : Enum
        {
            return result as IItemResult<T, TS>;
        }

        public static IItemResult<TT, TS> ToMappedItemResult<TF, TT, TS>(this IResult<TF, TS> result, IMapper mapper)
            where TS : Enum
        {
            var itemResult = result.ToItemResult();
            return new ItemResult<TT, TS>
            {
                Status = itemResult.Status,
                Data = mapper.Map<TT>(itemResult.Data)
            };
        }

        public static IPagedResult<T, TS> ToPagedResult<T, TS>(this IResult<T, TS> result)
            where TS : Enum
        {
            return result as IPagedResult<T, TS>;
        }

        public static IPagedResult<TT, TS> ToMappedPagedResult<TF, TT, TS>(this IResult<TF, TS> result, IMapper mapper)
            where TS : Enum
        {
            var pagedResult = result.ToPagedResult();
            return new PagedResult<TT, TS>
            {
                Status = pagedResult.Status,
                TotalResults = pagedResult.TotalResults,
                Page = pagedResult.Page,
                Size = pagedResult.Size,
                Data = mapper.Map<TT>(pagedResult.Data)
            };
        }
    }
}
