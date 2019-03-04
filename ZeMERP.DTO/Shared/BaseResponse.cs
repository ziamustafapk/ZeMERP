using System.Collections.Generic;

namespace ZeMERP.DTO.Shared
{
    public class BaseResponse<T> where T : class, new()
    {
        public BaseResponse()
        {
            Messages = new BaseResponseViewModel();
            Result = new List<T>();
        }
        public BaseResponseViewModel Messages { get; set; }
        public IEnumerable<T> Result { get; set; }
    }
}
