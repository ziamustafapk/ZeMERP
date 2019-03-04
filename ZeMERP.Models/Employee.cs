using System;
using System.Collections.Generic;
using ZeMERP.Models.Shared;

namespace ZeMERP.Models
{
    public class Employee : BaseModel
    {

        public int EmployeeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MaritalStatus { get; set; }

        public string FaxNo { get; set; }
        public string Picture { get; set; }
        public string Remarks { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
       
        public ICollection<Address> Address { get; set; }
        public ICollection<Email> Email { get; set; }
        public ICollection<Phone> Phone { get; set; }
      

    }


}