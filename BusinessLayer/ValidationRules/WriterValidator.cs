using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı boş geçilemez.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail boş geçilemez.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez.");
            RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Resim boş geçilemez.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar adı minimum 2 karakter olmalıdır.");
            RuleFor(x => x.WriterName).MaximumLength(30).WithMessage("Yazar adı maximum 30 karakter olmalıdır.");
        }
    }
}
