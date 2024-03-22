using AutoMapper;
using TyeBank.Core.DTOs;
using TyeBank.Core.Entities;

namespace TyeBank.Service.Mappers
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Employee, EmployeeDTO>().ReverseMap();  //ReverseMap ile tam tersi yönde de mapleme yapılabilmektedir.
            CreateMap<EmployeeUpdateDTO, Employee>();

            CreateMap<Address, AddressDTO>().ReverseMap();
            CreateMap<Department, DepartmentDTO>().ReverseMap();
            CreateMap<Position, PositionDTO>().ReverseMap();
            CreateMap<Salary, SalaryDTO>().ReverseMap();
        }
    }
}
