using System;
using System.Collections.Generic;
using System.Text;

namespace ZeMERP.DTO
{
    class DepartmentDTO
    {
    }

    public class DepartmentRequestDTO
    {
        public int DepartmentId { get; set; }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
       
    }

   public class DepartmentResponseDTO
    {
        

        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       
        
    }
}
