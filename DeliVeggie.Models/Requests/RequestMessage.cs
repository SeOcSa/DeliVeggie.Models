using DeliVeggie.Models.Enums;

namespace DeliVeggie.Models.Requests
{
    public class RequestMessage <T>
    {
        private RequestType RequestType { get; set; }
        private T Payload { get; set; }
    }
}