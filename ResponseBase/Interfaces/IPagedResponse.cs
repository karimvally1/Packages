namespace ResponseBase.Interfaces
{
    public interface IPagedResponse<T> : IItemResponse<T>
    {
        int TotalResults { get; set; }
        int Page { get; set; }
        int Size { get; set; }
    }
}
