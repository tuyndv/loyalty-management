﻿using FluentValidation;
namespace Application.Services.Commands.Account.Validators
{
    public class CollectPointCommandValidator : AbstractValidator<CollectPointCommand>
    {
        public CollectPointCommandValidator()
        {
            RuleFor(t => t.MemberAccountId).NotNull().GreaterThan(0);
            RuleFor(t => t.Point).NotNull().GreaterThanOrEqualTo(0);
        }
    }
}
