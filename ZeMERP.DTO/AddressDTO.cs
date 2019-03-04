using System;
using System.Collections.Generic;
using System.Text;

namespace ZeMERP.DTO
{
    class AddressDTO
    {
    }
    public class AddressResponseDTO
    {
        public int AddressId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string StreetAddress { get; set; }
        public int? EmployeeId { get; set; }
        
    }

    public class AddressRequestDTO
    {
        
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string StreetAddress { get; set; }
        public int? EmployeeId { get; set; }
        
    }




}
