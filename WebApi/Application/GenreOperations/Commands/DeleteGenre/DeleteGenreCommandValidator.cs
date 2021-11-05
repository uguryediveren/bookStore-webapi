namespace WebApi
{

    using FluentValidation;

    namespace WebApi
    {
        public class DeleteGenreCommandValidator : AbstractValidator<DeleteGenreCommand>
        {
            public DeleteGenreCommandValidator()
            {
                RuleFor(command => command.GenreId).GreaterThan(0);
            }
        }

    }

}