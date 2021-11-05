namespace WebApi
{

    using FluentValidation;

    namespace WebApi
    {
        public class GetAuthorDetailQueryValidator : AbstractValidator<GetAuthorDetailQuery>
        {
            public GetAuthorDetailQueryValidator()
            {
                RuleFor(query => query.AuthorId).GreaterThan(0);
            }
        }

    }

}