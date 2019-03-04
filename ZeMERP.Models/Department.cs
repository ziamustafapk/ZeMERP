using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ZeMERP.Models
{
    public class Department 
    {

        public int DepartmentId { get; set; }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Department()
        {
            Employee = new Collection<Employee>();
            
        }

        public ICollection<Employee> Employee { get; set; }
         
    }
}