using System.ComponentModel.DataAnnotations;

namespace ZeMERP.DTO.Shared
{
    public class BaseRequestViewModel
    {

        [Required]
        [StringLength(15, MinimumLength = 1)]
        public string Code { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Description { get; set; }
        public string Remarks { get; set; }
    }
}
