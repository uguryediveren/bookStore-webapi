using FluentValidation;

namespace WebApi
{
    public class GetGenreDetailQueryValidator : AbstractValidator<GetGenreDetailQuery>
    {
        public GetGenreDetailQueryValidator()
        {
            RuleFor(query => query.GenreID).GreaterThan(0);
        }
    }

}
