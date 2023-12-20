using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz...");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik açıklama girin!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Maksimim 1500 karakter girilebilir.");
        }
    }
}
