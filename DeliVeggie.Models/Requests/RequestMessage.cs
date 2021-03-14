using DeliVeggie.Models.Enums;

namespace DeliVeggie.Models.Requests
{
    public class RequestMessage
    {
        public RequestType RequestType { get; set; }
        public string Id { get; set; }
    }
}