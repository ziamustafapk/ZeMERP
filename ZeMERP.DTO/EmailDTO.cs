using System;
using System.Collections.Generic;
using System.Text;

namespace ZeMERP.DTO
{
    class EmailDTO
    {
    }
public class EmailResponseDTO
    {
        public int EmailId { get; set; }
        public string Type { get; set; }
        public string EmailAddress { get; set; }
        public int? EmployeeId { get; set; }
       
    }
public class EmailRequestDTO
    {
        
        public string Type { get; set; }
        public string EmailAddress { get; set; }
        public int? EmployeeId { get; set; }
       
    }



}
