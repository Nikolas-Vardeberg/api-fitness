
using FastEndpoints;
using FluentValidation;

public class MyValidator : Validator<MyRequest>
{
    public MyValidator()
    {
        RuleFor(x => x.Username)
            .NotEmpty()
            .WithMessage("Your username cannot be empty")
            .MinimumLength(5)
            .WithMessage("Your username is to short")
            .MaximumLength(50)
            .WithMessage("Your username is to long!");
        RuleFor(x => x.Email)
            .EmailAddress();
        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage("Your password cannot be empty")
            .MinimumLength(5)
            .WithMessage("Your password is to short")
            .MaximumLength(50)
            .WithMessage("Your password is to long");
    }
}