using FluentValidation;
using FluentValidation.AspNetCore;
using OrganiZa.Web.Models;

namespace OrganiZa.Web.Validacion
{
    public class LoginValidator : AbstractValidator<LoginModel>
    {
        public LoginValidator()
        {
            RuleFor(login => login.Usuario)
                .NotNull().WithMessage("Este campo no puede ser null")
                .NotEmpty().WithMessage("Este campo no puede ser vacio");
            RuleFor(login => login.Contraseña)
                .NotNull().WithMessage("Este campo no puede ser null")
                .NotEmpty().WithMessage("Este campo no puede ser vacio")
                .Length(2, 15);
            RuleFor(login => login.status).NotEqual(true).WithMessage("Correo y contraseña no validos");
        }
    }
}
