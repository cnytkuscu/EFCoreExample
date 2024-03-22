using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TyeBank.Core.DTOs;
using TyeBank.Core.Entities;
using TyeBank.Core.Services;

namespace TyeBank.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Employee> _employeeService;

        public EmployeesController(IService<Employee> employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var employees = await _employeeService.GetAllAsync();

            var employeesDto = _mapper.Map<List<EmployeeDTO>>(employees.ToList());

            //return Ok(CustomResponseDTO<List<EmployeeDTO>>.Success(200, employeesDto));

            return CreateActionResult<List<EmployeeDTO>>(CustomResponseDTO<List<EmployeeDTO>>.Success(200, employeesDto));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var employee =  await _employeeService.GetByIdAsync(id);
            var employeeDto = _mapper.Map<EmployeeDTO>(employee);
            return CreateActionResult(CustomResponseDTO<EmployeeDTO>.Success(200, employeeDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(EmployeeDTO employeeDTO)
        {
            var employee =  await _employeeService.AddAsync(_mapper.Map<Employee>(employeeDTO));
            var employeeMappedDTO = _mapper.Map<EmployeeDTO>(employee);
            return CreateActionResult(CustomResponseDTO<EmployeeDTO>.Success(201, employeeMappedDTO)); // 201 Created Demek...
        }

        [HttpPut]
        public async Task<IActionResult> Update(EmployeeUpdateDTO employeeUpdateDTO)
        {
            await _employeeService.UpdateAsync(_mapper.Map<Employee>(employeeUpdateDTO));            
            return CreateActionResult(CustomResponseDTO<NoContentDTO>.Success(204)); // 204 NoContent Demek...
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(Guid id)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            await _employeeService.RemoveAsync(employee); 
            return CreateActionResult(CustomResponseDTO<NoContentDTO>.Success(204)); // 204 NoContent Demek...
        }

    }
}
