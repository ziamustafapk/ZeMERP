namespace ZeMERP.Models
{
    public class Email
    {
        public int EmailId { get; set; }
        public string Type { get; set; }
        public string EmailAddress { get; set; }
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
        
        
    }
}