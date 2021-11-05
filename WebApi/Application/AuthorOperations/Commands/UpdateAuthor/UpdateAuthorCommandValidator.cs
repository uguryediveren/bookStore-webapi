namespace WebApi
{
    using System.Security.Cryptography.X509Certificates;
    using FluentValidation;

    namespace WebApi
    {
        public class UpdateAuthorCommandValidator : AbstractValidator<UpdateAuthorCommand>
        {
            public UpdateAuthorCommandValidator()
            {
                RuleFor(command => command.Model.AuthorName).MinimumLength(4).When(x => x.Model.AuthorName.Trim() != string.Empty);
                RuleFor(command => command.Model.AuthorSurname).MinimumLength(4).When(x => x.Model.AuthorSurname.Trim() != string.Empty);
                RuleFor(command => command.Model.birthDate).NotNull().When(x => x.Model.birthDate.ToString() != string.Empty);
            }
        }

    }

}