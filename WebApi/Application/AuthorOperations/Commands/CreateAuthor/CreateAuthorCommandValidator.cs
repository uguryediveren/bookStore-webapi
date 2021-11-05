using System;
using System.Data;
using FluentValidation;

namespace WebApi
{
    public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommand>
    {
        public CreateAuthorCommandValidator()
        {
            RuleFor(x => x.Model.Name).NotEmpty().WithMessage("Name boş bırakılamaz!");
            RuleFor(x => x.Model.Surname).NotEmpty().WithMessage("Surname boş bırakılamaz!");
            RuleFor(x => x.Model.birthDate).NotEmpty().WithMessage("BirthDate boş bırakılamaz!");
        }
    }
}