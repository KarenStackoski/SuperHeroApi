using System.Dynamic;
using System.Net;

namespace SuperHeroApi.DTO
{
    public class ResponseGeneric<T> where T : class
    {
        public HttpStatusCode HttpCode { get; set; }
        public T? ReturnData { get; set; }
        public ExpandoObject? ReturnError { get; set; }
    }
}
