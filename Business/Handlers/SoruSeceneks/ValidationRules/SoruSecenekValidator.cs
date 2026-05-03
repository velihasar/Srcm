
using Business.Handlers.SoruSeceneks.Commands;
using FluentValidation;

namespace Business.Handlers.SoruSeceneks.ValidationRules
{

    public class CreateSoruSecenekValidator : AbstractValidator<CreateSoruSecenekCommand>
    {
        public CreateSoruSecenekValidator()
        {
            RuleFor(x => x.SoruId).NotEmpty();
            RuleFor(x => x.Anahtar).NotEmpty();
            RuleFor(x => x.metin).NotEmpty();
            RuleFor(x => x.GorselUrl).NotEmpty();
            RuleFor(x => x.DogruMu).NotEmpty();

        }
    }
    public class UpdateSoruSecenekValidator : AbstractValidator<UpdateSoruSecenekCommand>
    {
        public UpdateSoruSecenekValidator()
        {
            RuleFor(x => x.SoruId).NotEmpty();
            RuleFor(x => x.Anahtar).NotEmpty();
            RuleFor(x => x.metin).NotEmpty();
            RuleFor(x => x.GorselUrl).NotEmpty();
            RuleFor(x => x.DogruMu).NotEmpty();

        }
    }
}