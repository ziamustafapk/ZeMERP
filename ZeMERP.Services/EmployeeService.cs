using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Internal;
using ZeMERP.Data.Infrastructure;
using ZeMERP.DTO;
using ZeMERP.Models;

namespace Erp.Service.Shared
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        //public EmployeesResponseModel AddEmployee(EmployeesRequestModel employeesRequestModel)
        //{
        //    try
        //    {
        //        using (var scope = new TransactionScope())
        //        {
        //            var employee = _mapper.Map<EmployeesRequestModel, Employees>
        //                (employeesRequestModel);
        //            employee.IsActive = true;
        //            using (_unitOfWork)
        //            {

        //                _unitOfWork.Employees.Add(employee);

        //                _unitOfWork.SaveChanges();
        //            }

        //            scope.Complete();
        //            return
        //            _mapper.Map<Employees, EmployeesResponseModel>
        //                (employee);
        //        }
        //    }
        //    catch
        //    {

        //        throw;
        //    }
        //}

        //public async Task<IEnumerable<EmployeesResponseModel>> GetAllEmployees(bool includeShows = false)
        //{
        //    try
        //    {
        //        if (includeShows)
        //        {
        //            return
        //                _mapper.Map<IEnumerable<Employees>, IEnumerable<EmployeesResponseModel>>
        //                    (await _unitOfWork.Employees.GetAllAsyn());

        //        }

        //        return
        //            _mapper.Map<IEnumerable<Employees>, IEnumerable<EmployeesResponseModel>>
        //                (await _unitOfWork.Employees.GetAllIncludeAsyn());


        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        //public async Task<EmployeesResponseModel> GetEmployeesById(int id)
        //{
        //    try
        //    {

        //        var result = await _unitOfWork.Employees.GetIncludeAsyn(id);
        //        if (result != null)
        //        {
        //            return
        //                _mapper.Map<Employees, EmployeesResponseModel>
        //                    (result);
        //        }
        //        return null;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        //public EmployeesResponseModel RemoveEmployee(int Id)
        //{
        //    try
        //    {
        //        using (var scope = new TransactionScope())
        //        {
        //            var employee = _unitOfWork.Employees.Single(e => e.Id == Id);
        //            if (employee == null)
        //                return null;
        //            employee.IsActive = false;
        //            _unitOfWork.Employees.Update(employee);
        //            _unitOfWork.SaveChanges();
        //            scope.Complete();
        //            return
        //                _mapper.Map<Employees, EmployeesResponseModel>
        //                    (employee);
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        //public EmployeesResponseModel Find(Expression<Func<Employees, bool>> predicate)
        //{
        //    var employee = _unitOfWork.Employees.Single(predicate);
        //    return _mapper.Map<Employees, EmployeesResponseModel>
        //             (employee);
        //}

        //public EmployeesResponseModel UpdateEmployee(int Id, EmployeesRequestModel employeesRequestModel)
        //{
        //    try
        //    {
        //        using (var scope = new TransactionScope())
        //        {
        //            var employee = _unitOfWork.Employees.Single(e => e.Id == Id);
        //            if (employee == null)
        //                return null;
        //            employee.BankAccountNo = employeesRequestModel.BankAccountNo;
        //            employee.Address1 = employeesRequestModel.Address1;
        //            employee.Address2 = employeesRequestModel.Address2;
        //            employee.Address3 = employeesRequestModel.Address3;
        //           employee.CityId = employeesRequestModel.CityId;
        //            employee.CNIC = employeesRequestModel.CNIC;
        //            employee.Code = employeesRequestModel.Code;
        //            employee.CountryId = employeesRequestModel.CountryId;
        //            employee.DateOfBirth = employeesRequestModel.DateOfBirth;
        //            employee.DateOfConfirmation = employeesRequestModel.DateOfConfirmation.Value;
        //            employee.DateOfJoining = employeesRequestModel.DateOfJoining;
        //            employee.DepartmentId = employeesRequestModel.DepartmentId;
        //            employee.Description = employeesRequestModel.Description;
        //            employee.DesignationId = employeesRequestModel.DesignationId;
        //            employee.Email = employeesRequestModel.Email;
        //            employee.EOBI = employeesRequestModel.EOBI;
        //            employee.FatherName = employeesRequestModel.FatherName;
        //            employee.Gender = employeesRequestModel.Gender;
        //            employee.IsActive = true;
        //            employee.IsForigner = employeesRequestModel.IsForigner;
        //            employee.JobStatus = employeesRequestModel.JobStatus;
        //            employee.LandLine = employeesRequestModel.LandLine;
        //            employee.MartailStatus = employeesRequestModel.MartailStatus;
        //            employee.MobileNumber = employeesRequestModel.MobileNumber;
        //            employee.Name = employeesRequestModel.Name;
        //            employee.NTN = employeesRequestModel.NTN;
        //            employee.PassportExpiryDate = employeesRequestModel.PassportExpiryDate;
        //            employee.PassportImage = employeesRequestModel.PassportImage;
        //            employee.PassportIssueDate = employeesRequestModel.PassportIssueDate;
        //            employee.PassportNo = employeesRequestModel.PassportNo;
        //            employee.PassportPlaceIssue = employeesRequestModel.PassportPlaceIssue;
        //            employee.Pay = employeesRequestModel.Pay.Value;
        //            employee.Picture = employeesRequestModel.Picture;
        //            employee.Reference = employeesRequestModel.Reference;
        //            employee.Reference1 = employeesRequestModel.Reference1;
        //            employee.Description = employeesRequestModel.Description;
        //            employee.SSN = employeesRequestModel.SSN;
        //            employee.TerritoryId = employeesRequestModel.TerritoryId;
        //            //employee.UpdatedBy = employeesRequestModel.UpdatedBy;
        //            //employee.UpdatedDate = employeesRequestModel.UpdatedDate;
        //            _unitOfWork.Employees.Update(employee);
        //            _unitOfWork.SaveChanges();
        //            scope.Complete();
        //            return
        //           _mapper.Map<Employees, EmployeesResponseModel>
        //               (employee);

        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        public async Task<IEnumerable<EmployeeResponseDTO>> GetAllEmployees()
        {
            try
            {
                return
                    _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeResponseDTO>>
                        (await _unitOfWork.Employee.GetAllEmployeesAsync());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public async Task<EmployeeResponseDTO> GetEmployeesById(int id)
        {
            try
            {
                return
                    _mapper.Map<Employee, EmployeeResponseDTO>
                        (await _unitOfWork.Employee.GetEmployeeByIdAsync(id));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public async Task<EmployeeResponseDTO> AddEmployee(EmployeeRequestDTO model)
        {
            try
            {
                using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var employee = new Employee()
                    {
                        Code = ((_unitOfWork.Employee.TotalEmployees() + 1).ToString()).PadLeft(4, '0'),
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        MiddleName = model.MiddleName,
                        DateOfBirth = model.DateOfBirth,
                        Description = model.Description,
                        FatherName = model.FatherName,
                        FaxNo = model.FaxNo,
                        MaritalStatus = model.MaritalStatus,
                        Gender = model.Gender,
                        Remarks = model.Remarks,
                        DepartmentId = model.DepartmentId,
                        IsActive = true,
                        Picture = model.Picture,
                        CreatedBy = Guid.NewGuid().ToString(),
                        CreatedDate = DateTime.Now
                    };
                  
                    using (_unitOfWork)
                    {
                        await _unitOfWork.Employee.AddAsync(employee);
                        await _unitOfWork.SaveChangesAsync();

                        var addressModel = model.Address.Select(address => new Address
                        {
                            StreetAddress = address.StreetAddress,
                            CityId = address.CityId,
                            CountryId = address.CountryId,
                            EmployeeId = employee.EmployeeId
                        }).ToList();
                        await _unitOfWork.Address.AddAsync(addressModel);
                        var emailModel = model.Email.Select(email => new Email
                        {
                            EmployeeId = employee.EmployeeId,
                            EmailAddress = email.EmailAddress,
                            Type = email.Type
                        }).ToList();
                        await _unitOfWork.Email.AddAsync(emailModel);
                       
                        var phoneModel = model.Phone.Select(phone => new Phone
                        {
                            EmployeeId = employee.EmployeeId,
                            Type = phone.Type,
                            PhoneNumber = phone.PhoneNumber
                        }).ToList();
                        await _unitOfWork.Phone.AddAsync(phoneModel);
                        await _unitOfWork.SaveChangesAsync();
                    }
                    scope.Complete();
                    return
                        _mapper.Map<Employee, EmployeeResponseDTO>
                            (employee);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }

}
 public interface IEmployeeService
    {
        #region CustomMethods
        Task<IEnumerable<EmployeeResponseDTO>> GetAllEmployees();
        Task<EmployeeResponseDTO> GetEmployeesById(int id);
        Task<EmployeeResponseDTO> AddEmployee(EmployeeRequestDTO model);
        //EmployeesResponseModel UpdateEmployee(int Id, EmployeesRequestModel employeesRequestModel);
        //EmployeesResponseModel RemoveEmployee(int Id);
        //EmployeesResponseModel Find(Expression<Func<Employees, bool>> predicate);

        #endregion CustomMethods
    }