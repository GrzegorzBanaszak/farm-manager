using FluentValidation;

namespace farm_manager.Application.Features.Fields.Commands.CreateField
{
    public class CreateFieldCommandValidator : AbstractValidator<CreateFieldCommand>
    {
        public CreateFieldCommandValidator()
        {
            RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Nazwa pola jest wymagana.")
            .MaximumLength(100);

            RuleFor(x => x.AreaHa)
                .GreaterThan(0).WithMessage("Powierzchnia musi być większa niż 0.");
        }
    }
}
