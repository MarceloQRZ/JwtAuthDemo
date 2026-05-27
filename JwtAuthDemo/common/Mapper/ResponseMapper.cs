namespace JwtAuthDemo.Common.Mapper
{
    public class ResponseMapper
    {
        public static Response Map(bool success, dynamic data = null, string errorMessage = null)
        {
            return new Response
            {
                Success = success,
                Data = data,
                ErrorMessage = errorMessage
            };
        }
    }
}