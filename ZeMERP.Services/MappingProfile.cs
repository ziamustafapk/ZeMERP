using AutoMapper;
using ZeMERP.DTO;
using ZeMERP.Models;

namespace ZeMERP.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
            : this("MyProfile")
        {
        }
        protected MappingProfile(string profileName)
            : base(profileName)
        {
            CreateMap<Employee, EmployeeResponseDTO>();
            CreateMap<Address, AddressResponseDTO>();
            CreateMap<Email, EmailResponseDTO>();
            CreateMap<Phone, PhoneResponseDTO>();
        }
    }

}
