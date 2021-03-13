namespace DeliVeggie.Models.Responses
{
    public class ResponseMessage <T> : IResponseMessage
    {
        public T Payload { get; set; }
    }
}