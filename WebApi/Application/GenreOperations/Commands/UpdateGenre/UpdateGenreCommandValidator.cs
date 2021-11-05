namespace WebApi
{
    using System.Security.Cryptography.X509Certificates;
    using FluentValidation;

    namespace WebApi
    {
        public class UpdateGenreCommandValidator : AbstractValidator<UpdateGenreCommand>
        {
            public UpdateGenreCommandValidator()
            {
                RuleFor(command => command.Model.Name).MinimumLength(4).When(x => x.Model.Name.Trim() != string.Empty);
            }
        }

    }

}