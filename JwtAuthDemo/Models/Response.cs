namespace JwtAuthDemo.Common.Mapper
{
    public class Response
    {
        public bool Success { get; set; }
        public dynamic? Data { get; set; }
        public string? ErrorMessage { get; set; }
    }
}