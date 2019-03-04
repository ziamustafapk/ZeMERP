namespace ZeMERP.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string StreetAddress { get; set; }
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
        
    }
}