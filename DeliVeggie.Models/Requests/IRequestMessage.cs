using DeliVeggie.Models.Enums;

namespace DeliVeggie.Models.Requests
{
    public interface IRequestMessages
    {
        public RequestType RequestType { get; set; }
    }
}