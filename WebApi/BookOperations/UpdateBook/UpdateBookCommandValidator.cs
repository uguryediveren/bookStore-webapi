using FluentValidation;

namespace WebApi
{
    public class UpdateBookCommandValidator : AbstractValidator<UpdateBookCommand>
    {
        public UpdateBookCommandValidator()
        {
            // buradaki command nesnesi 'UpdateBookCommand' sınıfındaki tüm propsları içeriyor commandın book id'si ya da commandın modelinin genreId'si gibi okunabilir 
            RuleFor(command => command.BookId).GreaterThan(0);
            RuleFor(command => command.Model.GenreId).GreaterThan(0);
            RuleFor(command => command.Model.Title).NotEmpty().MinimumLength(4);
        }
    }

}
