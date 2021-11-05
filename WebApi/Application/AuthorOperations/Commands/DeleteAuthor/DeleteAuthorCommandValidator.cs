namespace WebApi
{

    using FluentValidation;

    namespace WebApi
    {
        public class DeleteAuthorCommandValidator : AbstractValidator<DeleteAuthorCommand>
        {
            public DeleteAuthorCommandValidator()
            {
                RuleFor(command => command.AuthorId).GreaterThan(0);
            }
        }

    }

}