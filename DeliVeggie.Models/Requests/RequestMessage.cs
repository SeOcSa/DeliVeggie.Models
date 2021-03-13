using DeliVeggie.Models.Enums;

namespace DeliVeggie.Models.Requests
{
    public class RequestMessage<T> : IRequestMessages
    {
        public RequestType RequestType { get; set; }
        public T Payload { get; set; }
    }
}