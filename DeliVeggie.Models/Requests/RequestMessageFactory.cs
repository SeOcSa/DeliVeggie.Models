using DeliVeggie.Models.Enums;

namespace DeliVeggie.Models.Requests
{
    public class RequestMessageFactory
    {
        public RequestMessage GetRequestMessages(RequestType requestType, string id = null)
        {
            switch (requestType)
            {
                case RequestType.ProductsRequest:
                    return new RequestMessage {RequestType = RequestType.ProductsRequest};
                case RequestType.ProductDetailsRequest:
                    return new RequestMessage { RequestType = RequestType.ProductDetailsRequest, Id = id};
                default:
                    return new RequestMessage { RequestType = RequestType.Na};
            }
        }
    }
}