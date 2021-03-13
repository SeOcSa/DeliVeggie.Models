using DeliVeggie.Models.Enums;

namespace DeliVeggie.Models.Requests
{
    public class RequestMessageFactory
    {
        public IRequestMessages GetRequestMessages(RequestType requestType)
        {
            switch (requestType)
            {
                case RequestType.ProductsRequest:
                    return new RequestMessage<string> {RequestType = RequestType.ProductsRequest, Payload = string.Empty};
                case RequestType.ProductDetailsRequest:
                    return new RequestMessage<string>{ RequestType = RequestType.ProductDetailsRequest, Payload = string.Empty};
                default:
                    return new RequestMessage<string> { RequestType = RequestType.Na};
            }
        }
    }
}