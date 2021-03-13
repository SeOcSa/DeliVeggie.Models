using DeliVeggie.Models.Enums;

namespace DeliVeggie.Models.Requests
{
    public class RequestMessage<T> : IRequestMessages
    {
        public T Payload { get; set; }
        public RequestType RequestType { get; set; }
    }
}