using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ZeMERP.DTO.Shared;
using ZeMERP.DTO.Validation;
using FluentValidation;

namespace ZeMERP.DTO
{
    class EmployeeDTO
    {
    }
    public class EmployeesResponse
    {
        public EmployeesResponse()
        {
            Messages = new BaseResponseViewModel();
            Result = new List<EmployeeResponseDTO>();
        }

        public BaseResponseViewModel Messages { get; set; }

        public List<EmployeeResponseDTO> Result { get; set; }
    }
    public class EmployeeResponse
    {
        public EmployeeResponse()
        {
            Messages = new BaseResponseViewModel();
            Result = new EmployeeResponseDTO();
        }

        public BaseResponseViewModel Messages { get; set; }

        public EmployeeResponseDTO Result { get; set; }
    }
    public class EmployeeResponseDTO
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
        public DepartmentResponseDTO Department { get; set; }

        public ICollection<AddressResponseDTO> Address { get; set; }
        public ICollection<EmailResponseDTO> Email { get; set; }
        public ICollection<PhoneResponseDTO> Phone { get; set; }
    }

    //[Validator(typeof(EmployeeValidator))]
    //[Validator]
    public class EmployeeRequestDTO
    {
        
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
        public DepartmentResponseDTO Department { get; set; }

        public ICollection<AddressResponseDTO> Address { get; set; }
        public ICollection<EmailResponseDTO> Email { get; set; }
        public ICollection<PhoneResponseDTO> Phone { get; set; }
    }



}
