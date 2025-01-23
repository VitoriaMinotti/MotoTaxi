namespace MotoTaxi.API.Application.Models.Requests
{
    public record PaginatedItemRequest(int PageIndex, int PageSize)
    {
    }
}
