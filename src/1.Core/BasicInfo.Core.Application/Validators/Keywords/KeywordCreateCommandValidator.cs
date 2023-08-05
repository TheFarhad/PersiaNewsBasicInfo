namespace BasicInfo.Core.Application.Validators.Keywords;

using FluentValidation;
using Contract.Service.Command.Keywords;

public class KeywordCreateCommandValidator : AbstractValidator<KeywordCreateCommand>
{
    public KeywordCreateCommandValidator()
    {

    }
}
