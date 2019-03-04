using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace ZeMERP.DTO.Validation
{
    public class EmployeeValidator : AbstractValidator<EmployeeRequestDTO>
    {
        public EmployeeValidator()
        {
            RuleFor(emp => emp.FirstName)
                .NotNull()
                .NotEmpty()
                .WithMessage("FirstName is mandatory.");
             RuleFor(emp => emp.LastName)
                .NotNull()
                .NotEmpty()
                .WithMessage("LastName is mandatory.");
           
            
        }
    }
}
