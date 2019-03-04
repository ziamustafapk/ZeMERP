using System.Collections.Generic;

namespace ZeMERP.DTO.Shared
{
    public class BaseResponseViewModel
    {
        public string ResultCode { get; set; }
        public string ResultDescription { get; set; }
        public string StatusCode { get; set; }
        public string HasErrors { get; set; }
        public string HasWarnings { get; set; }
        public string ReferenceNumber { get; set; }
        public string Trace { get; set; }
        public List<ErrorViewModel> Error { get; set; }
    }
}
