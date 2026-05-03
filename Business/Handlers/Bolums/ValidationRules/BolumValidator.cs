
using Business.Handlers.Bolums.Commands;
using FluentValidation;

namespace Business.Handlers.Bolums.ValidationRules
{

    public class CreateBolumValidator : AbstractValidator<CreateBolumCommand>
    {
        public CreateBolumValidator()
        {
            RuleFor(x => x.SinavId).NotEmpty();
            RuleFor(x => x.Ad).NotEmpty();
            RuleFor(x => x.SiraNo).NotEmpty();

        }
    }
    public class UpdateBolumValidator : AbstractValidator<UpdateBolumCommand>
    {
        public UpdateBolumValidator()
        {
            RuleFor(x => x.SinavId).NotEmpty();
            RuleFor(x => x.Ad).NotEmpty();
            RuleFor(x => x.SiraNo).NotEmpty();

        }
    }
}