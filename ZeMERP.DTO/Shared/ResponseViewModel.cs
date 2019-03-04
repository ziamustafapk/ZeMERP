using System.Collections.Generic;

namespace ZeMERP.DTO.Shared
{
   public class ResponseViewModel<T> where T : class
    {
        public List<T> Response { get; set; }
        public BaseResponseViewModel BaseResponseViewModel { get; set; }
    }
}
