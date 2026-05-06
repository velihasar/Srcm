
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

    public class CreateSoruWithSeceneklerFormValidator : AbstractValidator<CreateSoruWithSeceneklerFormCommand>
    {
        public CreateSoruWithSeceneklerFormValidator()
        {
            RuleFor(x => x.KonuId).GreaterThan(0);
            RuleFor(x => x.SoruMetin).NotEmpty();
            RuleFor(x => x.SecenekMetin1).NotEmpty();
            RuleFor(x => x.SecenekMetin2).NotEmpty();
            RuleFor(x => x.SecenekMetin3).NotEmpty();
            RuleFor(x => x.SecenekMetin4).NotEmpty();
            RuleFor(x => x.ErisimSeviyesi).GreaterThan(0);
            RuleFor(x => x).Must(cmd =>
            {
                var secenekSayisi = string.IsNullOrWhiteSpace(cmd.SecenekMetin5) ? 4 : 5;
                return cmd.DogruSecenekNo >= 1 && cmd.DogruSecenekNo <= secenekSayisi;
            }).WithMessage("DogruSecenekNo, dolu şık sayısına uygun olmalıdır (4 şıkta 1–4, 5 şıkta 1–5).");
        }
    }
}