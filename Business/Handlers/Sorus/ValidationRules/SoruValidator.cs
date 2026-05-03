
using Business.Handlers.Sorus.Commands;
using FluentValidation;

namespace Business.Handlers.Sorus.ValidationRules
{

    public class CreateSoruValidator : AbstractValidator<CreateSoruCommand>
    {
        public CreateSoruValidator()
        {
            RuleFor(x => x.KonuId).NotEmpty();
            RuleFor(x => x.Metin).NotEmpty();
            RuleFor(x => x.GorselUrl).NotEmpty();
            RuleFor(x => x.SiraNo).NotEmpty();
            RuleFor(x => x.ErisimSeviyesi).NotEmpty();

        }
    }
    public class UpdateSoruValidator : AbstractValidator<UpdateSoruCommand>
    {
        public UpdateSoruValidator()
        {
            RuleFor(x => x.KonuId).NotEmpty();
            RuleFor(x => x.Metin).NotEmpty();
            RuleFor(x => x.GorselUrl).NotEmpty();
            RuleFor(x => x.SiraNo).NotEmpty();
            RuleFor(x => x.ErisimSeviyesi).NotEmpty();

        }
    }
}