using System;
using System.Collections.Generic;
using System.Text;

namespace ZeMERP.DTO
{
    class PhoneDTO
    {
    }

public class PhoneResponseDTO
    {
        public int PhoneNumberId { get; set; }
        public string Type { get; set; }
        public string PhoneNumber { get; set; }
        public int? EmployeeId { get; set; }
        
    }

public class PhoneRequestDTO
    {
        
        public string Type { get; set; }
        public string PhoneNumber { get; set; }
        public int? EmployeeId { get; set; }
        
    }



}
