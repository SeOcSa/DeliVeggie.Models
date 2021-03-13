using System.Collections.Generic;
using DeliVeggie.Models.Enums;

namespace DeliVeggie.Models.Responses
{
    public class ResponseMessageFactory
    {
        public IResponseMessage GetRequestMessages(ResponseTypes requestType)
        {
            switch (requestType)
            {
                case ResponseTypes.ProductsResponse:
                    return new ResponseMessage<IEnumerable<ProductsResponse>>{ Payload = new List<ProductsResponse>()};
                case ResponseTypes.ProductDetailsResponse:
                    return new ResponseMessage<ProductDetailsResponse> {Payload = new ProductDetailsResponse()};
                default:
                    return new ResponseMessage<object> {Payload = null};
            }
        }
    }
}