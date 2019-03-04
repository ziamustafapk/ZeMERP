namespace ZeMERP.Models
{
    public class Phone
    {
        public int PhoneNumberId { get; set; }
        public string Type { get; set; }
        public string PhoneNumber { get; set; }
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
        
    }
}