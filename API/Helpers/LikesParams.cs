namespace API.Helpers
{
    public class LikesParams : PaginationParams
    {
        public int UserId { get; set; } = 18;
        public string Predicate { get; set; }
    }
}