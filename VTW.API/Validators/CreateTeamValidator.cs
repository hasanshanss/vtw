using FluentValidation;
using VTW.API.Services.Contracts.V1.TeamContracts.Requests;

namespace VTW.API.Validators
{
    public class CreateTeamValidator : AbstractValidator<CreateTeamRequest>
    {
        public CreateTeamValidator()
        {
            RuleFor(t => t.TeamName)
                .NotEmpty()
                .WithMessage("The TeamName shouldn't be empty")
                .Length(1, 5)
                .WithMessage("Length is not correct");

            RuleFor(t => t.TeamCategoryId)
                .NotEmpty();
        }
    }
}
