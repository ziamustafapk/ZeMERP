using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZeMERP.Models.Shared
{
    public abstract class BaseModel : IBaseModel
    {
        [Column(Order = 5)]
        public string CreatedBy { get; set; }
        [Column(Order = 6)]
        public string UpdatedBy { get; set; }
        [Column(Order = 7)]
        public DateTime? CreatedDate { get; set; }
        [Column(Order = 8)]
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; }
    }


    public interface IBaseModel
    {

        string CreatedBy { get; set; }
        string UpdatedBy { get; set; }
        DateTime? CreatedDate { get; set; }
        DateTime? UpdatedDate { get; set; }
        bool IsActive { get; set; }
    }
}
