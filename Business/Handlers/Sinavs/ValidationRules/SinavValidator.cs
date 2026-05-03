
using Business.Handlers.Sinavs.Commands;
using FluentValidation;

namespace Business.Handlers.Sinavs.ValidationRules
{

    public class CreateSinavValidator : AbstractValidator<CreateSinavCommand>
    {
        public CreateSinavValidator()
        {
            RuleFor(x => x.KisaAd).NotEmpty();
            RuleFor(x => x.Ad).NotEmpty();
            RuleFor(x => x.SiraNo).NotEmpty();

        }
    }
    public class UpdateSinavValidator : AbstractValidator<UpdateSinavCommand>
    {
        public UpdateSinavValidator()
        {
            RuleFor(x => x.KisaAd).NotEmpty();
            RuleFor(x => x.Ad).NotEmpty();
            RuleFor(x => x.SiraNo).NotEmpty();

        }
    }
}