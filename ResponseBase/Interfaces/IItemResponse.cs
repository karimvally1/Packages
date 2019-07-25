namespace ResponseBase.Interfaces
{
    public interface IItemResponse<T> : IResponse<T>
    {
        T Data { get; set; }
    }
}
